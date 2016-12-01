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
        bool connection;
        int relay_number;
        bool[] relay_state = new bool[9];
        Dictionary<Button, RelayButtons> buttons = new Dictionary<Button, RelayButtons>();
        static SerialPort serialPort1; //oryginalna nazwa, prawda?
        int relay_no;
        bool[] isrelay = new bool[9];
        private void relay_switch(object _sender, int relay_number)
        {
            Button sender = (Button)_sender;
            if (!connection)
            {
                MessageBox.Show("Please connect to any device before changing states",
                    "No connection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else if (relay_state[relay_number])
            {
                relay_state[relay_number] = false;
                sender.BackColor = Color.Red;
                serialPort1.WriteLine("relay(" + relay_number.ToString() + ", off)");
            }
            else
            {
                relay_state[relay_number] = true;
                sender.BackColor = Color.Green;
                serialPort1.WriteLine("relay(" + relay_number.ToString() + ", on)");
            }
        }
        public Form1()
        {
            InitializeComponent();
            buttons[button3] = new RelayButtons(1);
            buttons[button4] = new RelayButtons(2);
            buttons[button5] = new RelayButtons(3);
            buttons[button6] = new RelayButtons(4);
            buttons[button7] = new RelayButtons(5);
            buttons[button8] = new RelayButtons(6);
            buttons[button9] = new RelayButtons(7);
            buttons[button10] = new RelayButtons(8);
            getAvailablePorts();
            serialPort1 = new SerialPort();
            baudrate.SelectedIndex = 0;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            
        }

        void unlock()
        {

            for (int i = 8; i>relay_no; i--)
            {
                isrelay[i] = false;
            }
            for (int i = relay_no; i > 0; i--)
            {
                isrelay[i] = true;
            }
            button3.Enabled = isrelay[1];
            button4.Enabled = isrelay[2];
            button5.Enabled = isrelay[3];
            button6.Enabled = isrelay[4];
            button7.Enabled = isrelay[5];
            button8.Enabled = isrelay[6];
            button9.Enabled = isrelay[7];
            button10.Enabled = isrelay[8];
        }
        String receiveddata;
        delegate void valueDelegate(object sender, SerialDataReceivedEventArgs e);
        public void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (label4.InvokeRequired)
            {
                label4.Invoke(new valueDelegate(DataReceived), sender, e);
            }
            else
            {
            }
            try
            {
                receiveddata = serialPort1.ReadLine();
            }
            catch (TimeoutException) { }
            catch (InvalidOperationException) { }
            catch (System.IO.IOException) { }

            //label4.Text = receiveddata;


                if(receiveddata.Substring(0, 4) == "name")
                {
                  label4.Text = receiveddata.Substring(5, (receiveddata.Length - 8));

                 Int32.TryParse(receiveddata.Substring((receiveddata.Length - 2),1), out relay_no);
                unlock();
            }
        }
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            ComList.Items.Clear();
            ComList.Items.AddRange(ports);
            if (ComList.Items.Count != 0) ComList.SelectedIndex = 0;
        }
        void AnyButtonClick(object sender, System.EventArgs e)
        {
            relay_number = buttons[(Button)sender].relaynumber;
            relay_switch(sender, relay_number);
        }
        //przycisk połączenia


        private void button1_Click(object sender, EventArgs e)
        {
            if(connection)
            {

                serialPort1.WriteLine("all(off)");
                serialPort1.Close();
                button1.BackColor = Color.Empty;
                button3.BackColor = Color.Empty;
                button4.BackColor = Color.Empty;
                button5.BackColor = Color.Empty;
                button6.BackColor = Color.Empty;
                button7.BackColor = Color.Empty;
                button8.BackColor = Color.Empty;
                button9.BackColor = Color.Empty;
                button10.BackColor = Color.Empty;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                for(int i=8; i>0; i--)
                {
                    relay_state[i] = false;
                }

                connection = false;
                button1.Text = "Connect";
                label4.Text = "No device connected";
            }
            else if (ComList.Text == "" || baudrate.Text == "")
            {
                button1.BackColor = Color.Red;
                MessageBox.Show("Choose port and baudrate first!",
                    "No port/baudrate choosen!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    label4.Text = "default";
                    
                    serialPort1.WriteLine("hey");
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

//przycisk odświeżenia dostępnych portów
        private void button2_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }

    }

    struct RelayButtons
    {

        public RelayButtons(int relaynumber)
        {
            this.relaynumber = relaynumber;
        }
        public int relaynumber;
    }

}
