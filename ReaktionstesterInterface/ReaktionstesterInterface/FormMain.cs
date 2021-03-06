using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_RS232;
using HighscoreFileHandling;
using ErrorLogger;

namespace ReaktionstesterInterface
{
    public partial class FormMain : Form
    {
        delegate void oDataReceivedDeleg(char cReceived);
        IExceptionLogger ILogger = new ExceptionLogger();
        string sBuffer;
        FormRS232 oSetupRS232;
        readonly SerialPort serialPortToPsoC;
        bool bAnswerReceived;
        string sName;
        Dictionary<string, int> oResults;
        Dictionary<string, int> oHighscores;
        
        public FormMain()
        {
            InitializeComponent();
            // initialize fields
            oResults = new Dictionary<string, int>();
            serialPortToPsoC = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            oSetupRS232 = new FormRS232(serialPortToPsoC);
            // subscribe SerialPort DataReceived method to corresponding event handler
            serialPortToPsoC.DataReceived += new SerialDataReceivedEventHandler(SerialPortToPsoC_DataReceived);

            // disable RS232 options until a port connection has successfully been opened
            toolStripMenuItemClose.Enabled = false;
            toolStripMenuItemOpen.Enabled = false;

            // dynamically assign control properties upon instance creation. could also be done in designer.
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            labelStatus.Text = "Statusanzeige";


            // ---------------------------------------------- test -----------------------------------      
            ImportHighscores();
        }

        #region //StripMenu------------------------------------------------------------------//
        private void ToolStripMenuItemSetup_Click(object sender, EventArgs e)
        {
            // Check whether the object instance still exists or if its reference has already been disposed from memory
            // Prevents "ObjectDisposedException"
            if (oSetupRS232 == null || oSetupRS232.IsDisposed)
            {
                // If previous instance has been closed, create new one and add it as listener to FormClosed event
                oSetupRS232 = new FormRS232(serialPortToPsoC);
                oSetupRS232.FormClosed += new FormClosedEventHandler(FormRS232_Closed);
            }

            // Show setup form as dialog and enable/disable stripmenu options according to the result
            oSetupRS232.ShowDialog();
            if (oSetupRS232.DialogResult == DialogResult.OK)
            {
                toolStripMenuItemClose.Enabled = false;
                toolStripMenuItemOpen.Enabled = true;
            }
            else
            {
                toolStripMenuItemClose.Enabled = false;
                toolStripMenuItemOpen.Enabled = false;
            }
        }

        private void FormRS232_Closed(object sender, FormClosedEventArgs e)
        {
            oSetupRS232.Dispose();
            oSetupRS232 = null;
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortToPsoC.IsOpen)
                {
                    serialPortToPsoC.Open();
                    serialPortToPsoC.DiscardInBuffer();
                }

                toolStripMenuItemClose.Enabled = true;
                toolStripMenuItemOpen.Enabled = false;
                sBuffer = string.Empty;
            }
            catch (Exception oEx)
            {
                ILogger.LogError(oEx.ToString());
                MessageBox.Show("Fehler beim Öffnen des Serialports: " + oEx.Message, "Error!");
            }
        }

        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPortToPsoC.IsOpen)
                {
                    serialPortToPsoC.Close();
                }

                toolStripMenuItemClose.Enabled = false;
                toolStripMenuItemOpen.Enabled = true;
            }
            catch (Exception oEx)
            {
                ILogger.LogError(oEx.ToString());
                MessageBox.Show("Fehler beim Öffnen des Serialports: " + oEx.Message, "Error!");
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Application.Exit();
        #endregion

        #region //receive serialport data----------------------------------------------------------//
        private void SerialPortToPsoC_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPortToPsoC.IsOpen)
            {
                char cChar;
                while (serialPortToPsoC.BytesToRead != 0)
                {
                    cChar = (char)serialPortToPsoC.ReadChar();

                    // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.control.begininvoke?view=net-5.0
                    // synchronous(Invoke) / asynchronous(BeginInvoke)
                    try
                    {
                        BeginInvoke(new oDataReceivedDeleg(SerialDataReceived), new object[] { cChar });
                    }
                    catch(Exception oEx)
                    {
                        ILogger.LogError(oEx.ToString());
                    }
                }
            }
        }

        private void SerialDataReceived(char cChar)
        {
            if (sBuffer.Length > 100)
            {
                sBuffer = string.Empty;
            }

            sBuffer += cChar;

            DisplayResult();
        }

        #endregion

        #region //reaction test--------------------------------------------------------------//
        /// <summary>
        /// Starts the reaction test.
        /// </summary>
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            bAnswerReceived = false;

            try
            {
                if (!serialPortToPsoC.IsOpen)
                {
                    labelStatus.Text = "Port nicht geöffnet.";
                    buttonStart.Enabled = true;
                    return;
                }

                serialPortToPsoC.Write("s");

                await Task.Run(async () =>
                {
                    await ReactionTestCountdown();
                });                
            }
            catch (Exception oEx)
            {
                ILogger.LogError(oEx.ToString());
            };            
        }

        /// <summary>
        /// Checks if data received from PSoC is valid/fits the required protocol format and updates the result display in the GUI.
        /// </summary>
        private void DisplayResult()
        {
            try
            {
                if ((sBuffer.Length > 2) && (sBuffer.Substring(0, 2) == "R:") && (sBuffer.Substring(sBuffer.Length - 1) == "|"))
                {
                    bAnswerReceived = true;

                    string sMessage = sBuffer.Substring(2, sBuffer.Length - 3);
                    sBuffer = string.Empty;

                    switch (sMessage)
                    {
                        // button was pressed early
                        case "-2":
                            labelStatus.Text = "Knopf gedrückt halten gilt nicht :)";
                            break;

                        // button wasn't pressed
                        case "-1":
                            labelStatus.Text = "Knopf nicht gedrückt.";
                            break;

                        // valid measurement
                        default:
                            labelStatus.Text = $"Reaktionszeit: {sMessage} ms.";
                            UpdateResults(Convert.ToInt32(sMessage));
                            break;
                    }
                }
            }
            catch (Exception oEx)
            {
                ILogger.LogError(oEx.ToString());
            }
        }

        /// <summary>
        /// Updates the session scoreboard and displays the top 5 in listbox.
        /// </summary>
        /// <param name="iTime">Reactiontime in milliseconds</param>
        private void UpdateResults(int iTime)
        {
            string sName = textBoxName.Text;
            List<string> oSessionDataSource = new List<string>();
            List<string> oAllTimeDataSource = new List<string>();

            if (sName.Contains('|'))
            {
                MessageBox.Show("Name enthält reserviertes Zeichen '|'. Bitte ändern Sie den Namen im Textfeld.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (sName == string.Empty)
            {
                sName = "Unknown";
            }

            oResults = oResults.UpdateHighscores(sName, iTime);
            oHighscores = oHighscores.UpdateHighscores(sName, iTime);

            foreach (KeyValuePair<string, int> oPair in oResults)
            {
                oSessionDataSource.Add($"{oPair.Key}\t\t|\t{oPair.Value} ms");
            }

            foreach (KeyValuePair<string, int> oPair in oHighscores)
            {
                oAllTimeDataSource.Add($"{oPair.Key}\t\t|\t{oPair.Value} ms");
            }

            if (oSessionDataSource.Count > 5)
            {
                oSessionDataSource = oSessionDataSource.Take(5).ToList();
            }

            listBoxResults.DataSource = oSessionDataSource;
            listBoxHighscores.DataSource = oAllTimeDataSource;
        }

        /// <summary>
        /// Import highscores from file
        /// </summary>
        private void ImportHighscores()
        {
            List<string> oDataSource = new List<string>();

            // File is parsed with custom extension methods.
            oHighscores = Highscores.ReadFile().ParseHighscores();

            // Highscores should already be in order, as they are sorted whenever a new KeyValuePair is added, this is just to be safe.
            // Dictionary is ordered ascendingly by value. Parameter type of lambda expressions is detected automatically ("Type inference feature"). Returns IOrderedEnumerable,
            // which does not have a .ToDictionary extension, so it is first cast to a List<KeyValuePair<string,int>> which can then be cast to a dictionary.
            oHighscores = oHighscores.OrderBy(oKVPair => oKVPair.Value).ToList().ToDictionary(sKey => sKey.Key, iValue => iValue.Value);

            foreach (KeyValuePair<string,int> oItem in oHighscores)
            {
                oDataSource.Add($"{oItem.Key}\t|\t{oItem.Value} ms");
            }

            listBoxHighscores.DataSource = oDataSource;
        }

        /// <summary>
        /// This method implements the countdown.
        /// It handles sending commands to the PSoC and updating GUI elements. 
        /// </summary>
        private async Task ReactionTestCountdown()
        {
            foreach (PictureBox oBox in flowLayoutPanel.Controls.OfType<PictureBox>())
            {
                oBox.Invoke(new Action(() =>
                {
                    oBox.BackColor = Color.Red;
                }));
            }
            
            for (int iCountdown = 3; iCountdown >= 0; iCountdown--)
            {
                try
                {
                    serialPortToPsoC.Write(iCountdown.ToString());
                }
                catch(Exception oEx)
                {
                    ILogger.LogError(oEx.ToString());
                }
                labelStatus.Invoke(new Action(() =>
                {
                    if (iCountdown > 0)
                    {
                        labelStatus.Text = $"{iCountdown}";
                    }
                    else
                    {
                        labelStatus.Text = "...";
                    }

                }));

                switch (iCountdown)
                {
                    case 2:
                        pictureBoxCountdown3.Invoke(new Action(() =>
                        {
                            pictureBoxCountdown3.BackColor = Color.Gray;
                        }));

                        break;

                    case 1:
                        pictureBoxCountdown2.Invoke(new Action(() =>
                        {
                            pictureBoxCountdown2.BackColor = Color.Gray;
                        }));

                        break;

                    case 0:
                        pictureBoxCountdown1.Invoke(new Action(() =>
                        {
                            pictureBoxCountdown1.BackColor = Color.Gray;
                        }));

                        break;
                }

                await Task.Delay(1000);
            }

            await Task.Delay(1000 + new Random().Next(1000));

            foreach (PictureBox oBox in flowLayoutPanel.Controls.OfType<PictureBox>())
            {
                oBox.Invoke(new Action(() =>
                {
                    oBox.BackColor = Color.LimeGreen;
                }));
            }
            try
            {
                serialPortToPsoC.Write("g");
            }
            catch (Exception oEx)
            {
                ILogger.LogError(oEx.ToString());
            }            

            labelStatus.Invoke(new Action(() =>
            {
                labelStatus.Text = "Go!";
            }));

            await Task.Run(new Action(async () =>
            {
                try
                {
                    await Task.Delay(3000);

                    if (!bAnswerReceived)
                    {
                        throw new OperationCanceledException();
                    }
                }
                catch (OperationCanceledException)
                {
                    // no answer -> timeout
                    labelStatus.Invoke(new Action(() =>
                    {
                        labelStatus.Text = "Zeitüberschreitung. Keine Antwort von PsoC." + Environment.NewLine + "Bitte überprüfe die Verbindung!";
                    }));
                }
                catch (Exception oEx)
                {
                    ILogger.LogError(oEx.ToString());
                }

                foreach (PictureBox oBox in flowLayoutPanel.Controls.OfType<PictureBox>())
                {
                    oBox.Invoke(new Action(() =>
                    {
                        oBox.BackColor = Color.Gray;
                    }));
                }

                buttonStart.Invoke(new Action(() =>
                {
                    buttonStart.Enabled = true;
                }));

                if (bAnswerReceived)
                {
                    labelStatus.Invoke(new Action(() =>
                    {
                        labelStatus.Text = "Statusanzeige";
                    }));
                }                
            }));
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            sName = textBoxName.Text;
        }
        #endregion

        /// <summary>
        /// Write highscores to file upon form closing.
        /// </summary>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                oHighscores.WriteFile();
            }
            catch(Exception oEx)
            {
                ILogger.LogError(oEx.ToString());
                DialogResult oConfirm = new DialogResult();
                oConfirm = MessageBox.Show("Fehler beim sichern der Highscores. Trotzdem fortfahren?",
                                           "Warnung:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (oConfirm == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
