using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UART_RS232
{
    public partial class FormRS232 : Form
    {
        private readonly System.IO.Ports.SerialPort oPort;

        /// <summary>
        /// Constructor
        /// Initialisiert FormRS232 und Komponenten.
        /// </summary>
        /// <param name="serialPort">Instanz der SerialPort Klasse für UART Verbindung.</param>
        public FormRS232(System.IO.Ports.SerialPort serialPort)
        {
            InitializeComponent();

            // Speicheradresse von serialPort auch an oPort zuweisen
            oPort = serialPort;

            ButtonRefresh_Click(null, null);

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
        /// Einstellungen von Setup übernehmen.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // eingestellte Parameter übernehmen
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
        /// Einstellungen verwerfen
        /// </summary>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // eingestellte Parameter verwerfen
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
        /// Aktive Ports aktualisieren.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            // combobox items (collection) um einträge zu ändern
            string[] sActivePorts = System.IO.Ports.SerialPort.GetPortNames();

            comboBoxPort.Items.Clear();

            foreach (string sPort in sActivePorts)
            {
                comboBoxPort.Items.Add(sPort);
            }

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
    }
}
