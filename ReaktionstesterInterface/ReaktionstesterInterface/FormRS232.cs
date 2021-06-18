using System;
using System.Windows.Forms;

namespace UART_RS232
{
    public partial class FormRS232 : Form
    {
        readonly System.IO.Ports.SerialPort oPort;

        public FormRS232(System.IO.Ports.SerialPort serialPort)
        {
            InitializeComponent();

            // Assign instance of SerialPort class that was passed via constructor to local instance 
            // (both instances now point to the same location/address in heap memory)
            oPort = serialPort;

            ButtonRefresh_Click(null, null);
            KeyPreview = true;

            // default Parameter auswählen
            comboBoxRate.SelectedIndex = 0;
            comboBoxDataBits.SelectedIndex = 1;
            comboBoxParity.SelectedIndex = 0;

            if (comboBoxPort.Items.Count > 0)
            {
                comboBoxPort.SelectedIndex = comboBoxPort.Items.Count - 1;
            }
        }

        /// <summary>
        /// Confirm setup-option selection
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.Text == string.Empty)
            {
                MessageBox.Show("Portname darf nicht leer sein.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    oPort.PortName = comboBoxPort.Text;
                    oPort.BaudRate = Convert.ToInt32(comboBoxRate.Text);
                    oPort.DataBits = Convert.ToInt32(comboBoxDataBits.Text);

                    switch (comboBoxParity.Text)
                    {
                        case "Even":
                            oPort.Parity = System.IO.Ports.Parity.Even;
                            break;
                        case "Odd":
                            oPort.Parity = System.IO.Ports.Parity.Odd;
                            break;
                        default:
                            oPort.Parity = System.IO.Ports.Parity.None;
                            break;
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Port geöffnet. Parameter können derzeit nicht verändert werden!");
                }

                Visible = false;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Discard changes
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // reset displayed selection to actual selection
            comboBoxPort.Text = oPort.PortName;
            comboBoxRate.Text = Convert.ToString(oPort.BaudRate);
            comboBoxDataBits.Text = Convert.ToString(oPort.DataBits);

            switch (oPort.Parity)
            {
                case System.IO.Ports.Parity.Even:
                    comboBoxParity.Text = "Even";
                    break;
                case System.IO.Ports.Parity.Odd:
                    comboBoxParity.Text = "Odd";
                    break;
                default:
                    comboBoxParity.Text = "None";
                    break;
            }

            Visible = false;
            DialogResult = DialogResult.Cancel;
        }
        
        /// <summary>
        /// Refresh available ports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            // get currently available ports and add them to port-combobox
            string[] sActivePorts = System.IO.Ports.SerialPort.GetPortNames();

            comboBoxPort.Items.Clear();

            foreach (string sPort in sActivePorts)
            {
                comboBoxPort.Items.Add(sPort);
            }

            // disable all menu options if no ports are available
            if (sActivePorts.Length == 0)
            {
                comboBoxPort.Enabled = false;
                comboBoxRate.Enabled = false;
                comboBoxDataBits.Enabled = false;
                comboBoxParity.Enabled = false;
            }
            else
            {
                comboBoxPort.Enabled = true;
                comboBoxRate.Enabled = true;
                comboBoxDataBits.Enabled = true;
                comboBoxParity.Enabled = true;
            }
        }

        private void FormRS232_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ButtonCancel_Click(null, null);
            }
        }
    }
}
