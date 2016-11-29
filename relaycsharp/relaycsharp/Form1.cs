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
        bool connection, relay1, relay2, relay3, relay4, relay5, relay6, relay7, relay8;
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

                serialPort1.PortName = ComList.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudrate.Text);
                try
                {
                    serialPort1.Open();
                    connection = true;
                    button1.Text = "Disconnect";
                    button1.BackColor = Color.Green;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Heh, somebody is using this port",
                   "Catch him and kill before next try...",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning // for Warning  
                                          //MessageBoxIcon.Error // for Error 
                                          //MessageBoxIcon.Information  // for Information
                                          //MessageBoxIcon.Question // for Question
                  );
                }
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
                serialPort1.WriteLine("relay(1, off)");
            }
            else
            {
                relay1 = true;
                button3.BackColor = Color.Green;
                serialPort1.WriteLine("relay(1, on)");
            }
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
                serialPort1.WriteLine("relay(2, off)");
            }
            else
            {
                relay2 = true;
                button4.BackColor = Color.Green;
                serialPort1.WriteLine("relay(2, on)");
            }
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
                serialPort1.WriteLine("relay(3, off)");
            }
            else
            {
                relay3 = true;
                button5.BackColor = Color.Green;
                serialPort1.WriteLine("relay(3, on)");
            }
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
                serialPort1.WriteLine("relay(4, off)");
            }
            else
            {
                relay4 = true;
                button6.BackColor = Color.Green;
                serialPort1.WriteLine("relay(4, on)");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay5)
            {
                relay5 = false;
                button7.BackColor = Color.Red;
                serialPort1.WriteLine("relay(5, off)");
            }
            else
            {
                relay5 = true;
                button7.BackColor = Color.Green;
                serialPort1.WriteLine("relay(5, on)");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay6)
            {
                relay6 = false;
                button8.BackColor = Color.Red;
                serialPort1.WriteLine("relay(6, off)");
            }
            else
            {
                relay6 = true;
                button8.BackColor = Color.Green;
                serialPort1.WriteLine("relay(6, on)");
            }
        }

        private void baudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay7)
            {
                relay7 = false;
                button10.BackColor = Color.Red;
                serialPort1.WriteLine("relay(7, off)");
            }
            else
            {
                relay7 = true;
                button10.BackColor = Color.Green;
                serialPort1.WriteLine("relay(7, on)");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay8)
            {
                relay8 = false;
                button9.BackColor = Color.Red;
                serialPort1.WriteLine("relay(8, off)");
            }
            else
            {
                relay8 = true;
                button9.BackColor = Color.Green;
                serialPort1.WriteLine("relay(8, on)");
            }
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
           // relayscheck = Convert.ToInt32(serialPort1.ReadLine());
        }

    }
}
