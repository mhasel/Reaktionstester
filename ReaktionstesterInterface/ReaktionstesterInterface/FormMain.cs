using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_RS232;

namespace ReaktionstesterInterface
{
    public partial class FormMain : Form
    {
        private string sBuffer;
        private FormRS232 oSetupRS232;
        private SerialPort serialPortToPsoC;
        private CancellationTokenSource oCTS;
        private Random oRandom;

        public FormMain()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;

            oCTS = new CancellationTokenSource();
            oRandom = new Random();
            // SerialPort und Setupform initialisieren und SerialPort object an Konstruktor mitübergeben
            serialPortToPsoC = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            oSetupRS232 = new FormRS232(serialPortToPsoC);
            serialPortToPsoC.DataReceived += new SerialDataReceivedEventHandler(serialPortToPsoC_DataReceived);
            // Menüpunkte "ausgrauen" bis RS232 Setup ausgeführt wurde
            toolStripMenuItemClose.Enabled = false;
            toolStripMenuItemOpen.Enabled = false;
        }

        private delegate void oDataReceivedDeleg(char cReceived);

        #region ----------------------StripMenu---------------------------
        private void toolStripMenuItemSetup_Click(object sender, EventArgs e)
        {
            // Überprüft, ob Instanz der Form existiert bzw. ob die Objekteferenz der Form bereits aus dem Speicher entfernt wurde
            // Notwendig, um ObjectDisposedException zu vermeiden
            if (oSetupRS232 == null || oSetupRS232.IsDisposed)
            {
                // Falls vorherige Instanz geschlossen wurde, neue Instanz öffnen und diese als
                // Listener für FormClosedEventHandler hinzufügen
                oSetupRS232 = new FormRS232(serialPortToPsoC);
                oSetupRS232.FormClosed += new FormClosedEventHandler(FormRS232_Closed);
            }

            // Form als Dialog anzeigen
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

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // Überprüft, ob serial port bereits offen ist
                if (!serialPortToPsoC.IsOpen)
                {
                    serialPortToPsoC.Open();
                    serialPortToPsoC.DiscardInBuffer();
                }

                toolStripMenuItemClose.Enabled = true;
                toolStripMenuItemOpen.Enabled = false;
                sBuffer = string.Empty;

                if (serialPortToPsoC.IsOpen)
                {
                    try
                    {
                        serialPortToPsoC.Write("~");
                    }
                    catch
                    {
                        // leer
                    }
                }
            }
            catch (Exception oEx)
            {
                MessageBox.Show("Error opening serial port : " + oEx.Message, "Error!");
            }
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error opening serial port : " + oEx.Message, "Error!");
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void serialPortToPsoC_DataReceived(object sender, SerialDataReceivedEventArgs e)
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
                    catch
                    {
                        // Fehlermeldungen werden "geschluckt"
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

        private void DisplayResult()
        {            
            if ((sBuffer.Length > 2) && (sBuffer.Substring(0,2) == "R:") && (sBuffer.Substring(sBuffer.Length - 1) == "|"))   
            {
                string sMessage = sBuffer.Substring(2, sBuffer.Length - 3);

                switch (sMessage)
                {                    
                    // Taste gehalten
                    case "-2":
                        labelStatus.Text = "Knopf gedrückt halten gilt nicht :)";
                        break;

                    // Taste nicht gedrückt
                    case "-1":
                        labelStatus.Text = "Knopf nicht gedrückt.";
                        break;

                    // Messung valide
                    default:
                        labelStatus.Text = $"Reaktionszeit: {sMessage} ms.";
                        break;
                }

                sBuffer = string.Empty;
                buttonStart.Enabled = true;
            }
        }

        private async Task Countdown(CancellationToken oCancellationToken)
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
                serialPortToPsoC.Write(iCountdown.ToString());
                labelStatus.Invoke(new Action(() =>
                {
                    labelStatus.Text = $"{iCountdown}";
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
                await Task.Delay(1000, oCTS.Token);
            }

            await Task.Delay(1000 + oRandom.Next(1000), oCTS.Token);
            serialPortToPsoC.Write("g");
            foreach (PictureBox oBox in flowLayoutPanel.Controls.OfType<PictureBox>())
            {
                oBox.Invoke(new Action(() =>
                {
                    oBox.BackColor = Color.LimeGreen;
                }));
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;            

            try
            {
                if (serialPortToPsoC.IsOpen)
                {
                    serialPortToPsoC.Write("s");
                    await Task.Run(async () =>
                    {
                        await Countdown(oCTS.Token);
                    });                    
                }
                else
                {
                    labelStatus.Text = "Port nicht geöffnet.";
                    buttonStart.Enabled = true;
                }
            }
            catch { };
        }
    }
}
