using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UART_RS232;

namespace ReaktionstesterInterface
{
    public partial class FormMain : Form
    {
        private string sBuffer;
        int iState = -1;
        private FormRS232 oSetupRS232;
        private SerialPort serialPortToPsoC;

        public FormMain()
        {
            InitializeComponent();

            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;

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
                textBox.AppendText("---Buffer Overflow.Buffer has been reset to avoid memory leakage. Please check sender protocol!---");
            }

            sBuffer += cChar;
            Reaktionstest();
        }

        private void Reaktionstest()
        {
            string sCountdown = string.Empty;
            switch (iState)
            {
                // Warten
                case -1:
                    switch (sBuffer)
                    {
                        case "T:":
                            iState = 0;
                            sBuffer = string.Empty;
                            break;
                        case "C:":
                            iState = 1;
                            sBuffer = string.Empty;
                            break;
                        case "R:":
                            iState = 2;
                            sBuffer = string.Empty;
                            break;
                    }
                    break;

                // Text
                case 0:
                    if ((sBuffer.Length != 0) && (sBuffer.Substring(sBuffer.Length - 1) == "|"))
                    {
                        textBox.AppendText($"{sBuffer.Substring(0, sBuffer.Length - 1)}");
                        iState = -1;
                        sBuffer = string.Empty;
                        textBox.AppendText(Environment.NewLine);
                    }
                    
                    break;
                
                // Countdown
                case 1:
                    if ((sBuffer.Length != 0) && (sBuffer.Substring(sBuffer.Length - 1) == "|"))
                    {
                        sCountdown = $"{sBuffer.Substring(0, 1)}";
                        if (sCountdown != "^")
                        {
                            textBox.AppendText($"{sBuffer.Substring(0, sBuffer.Length - 1)}");
                        }                 
                        iState = -1;
                        sBuffer = string.Empty;
                        textBox.AppendText(Environment.NewLine);
                    }
                    switch (sCountdown)
                    {
                        case "^":
                            pictureBoxCountdown1.BackColor = Color.LimeGreen;
                            pictureBoxCountdown2.BackColor = Color.LimeGreen;
                            pictureBoxCountdown3.BackColor = Color.LimeGreen;
                            break;
                        case "l":
                            pictureBoxCountdown1.BackColor = Color.Gray;
                            break;
                        case "1":
                            pictureBoxCountdown2.BackColor = Color.Gray;
                            break;
                        case "2":
                            pictureBoxCountdown3.BackColor = Color.Gray;                            
                            break;
                        case "3":
                            pictureBoxCountdown1.BackColor = Color.DarkRed;
                            pictureBoxCountdown2.BackColor = Color.DarkRed;
                            pictureBoxCountdown3.BackColor = Color.DarkRed;
                            break;
                    }
                    break;

                // Ergebnis
                case 2: 
                    if ((sBuffer.Length != 0) && (sBuffer.Substring(sBuffer.Length - 1) == "|"))
                    {
                        textBox.AppendText($"{sBuffer.Substring(0, sBuffer.Length - 1)}");
                        iState = -1;
                        sBuffer = string.Empty;
                        textBox.AppendText(Environment.NewLine);
                    }
                    break;
            }
            

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (serialPortToPsoC.IsOpen)
            {
                try
                {
                    serialPortToPsoC.Write(e.KeyChar.ToString());
                }
                catch
                {
                    // leer
                }
            }
        }
    }
}
