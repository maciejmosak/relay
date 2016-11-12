using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace relaycsharp
{
    public partial class Form1 : Form
 
    {
        bool connection, relay1, relay2, relay3, relay4;
        int relays, relayscheck;
        static SerialPort serialPort1;
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
            serialPort1 = new SerialPort();
            serialPort1.DataReceived += SerialDataReceivedEventHandler;
        }

        private void RELAYS_Paint(object sender, PaintEventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(connection)
            {
                serialPort1.Close();
                button1.BackColor = Color.Empty;
                connection = false;
                button1.Text = "Connect";
            }
            else if (ComList.Text == "" || baudrate.Text == "")
            {
                button1.BackColor = Color.Red;
                MessageBox.Show("Choose port and baudrate first!",
                    "No port/baudrate choosen!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning // for Warning  
                                           //MessageBoxIcon.Error // for Error 
                                           //MessageBoxIcon.Information  // for Information
                                           //MessageBoxIcon.Question // for Question
                   );
            }
            else
            {

                button1.BackColor = Color.Green;
                serialPort1.PortName = ComList.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudrate.Text);
                serialPort1.Open();
                connection = true;
                button1.Text = "Disconnect";
            }

        }
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            ComList.Items.Clear();
            ComList.Items.AddRange(ports);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay1)
            {
                relay1 = false;
                button3.BackColor = Color.Red;
            }
            else
            {
                relay1 = true;
                button3.BackColor = Color.Green;
            }
            upload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay2)
            {
                relay2 = false;
                button4.BackColor = Color.Red;
            }
            else
            {
                relay2 = true;
                button4.BackColor = Color.Green;
            }
            upload();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay3)
            {
                relay3 = false;
                button5.BackColor = Color.Red;
            }
            else
            {
                relay3 = true;
                button5.BackColor = Color.Green;
            }
            upload();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay4)
            {
                relay4 = false;
                button6.BackColor = Color.Red;
            }
            else
            {
                relay4 = true;
                button6.BackColor = Color.Green;
            }
            upload();
        }

        private void baudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }

        private void RELAY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SerialDataReceivedEventHandler(object sender,
                                   SerialDataReceivedEventArgs e)
        {
            relayscheck = Convert.ToInt32(serialPort1.ReadLine());
        }
        void upload()
        {
            relays = 0;
            if (relay1) relays++;
            if (relay2) relays = relays + 2;
            if (relay3) relays = relays + 4;
            if (relay4) relays = relays + 8;
            serialPort1.WriteLine(Convert.ToString(relays));
        }
    }
}
