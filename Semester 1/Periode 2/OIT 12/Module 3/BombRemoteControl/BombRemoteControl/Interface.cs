using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombRemoteControl
{
    public partial class Interface : Form
    {
        private SerialMessenger serialMessenger;
        private Timer readMessageTimer;

        public Interface()
        {
            InitializeComponent();

            MessageBuilder messageBuilder = new MessageBuilder('#', '%');
            serialMessenger = new SerialMessenger("COM3", 9600, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }

        private void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string[] messages = serialMessenger.ReadMessages();
            if (messages != null)
            {
                foreach (string message in messages)
                {
                    processReceivedMessage(message);
                }
            }
        }

        private void ConnectButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialMessenger.Connect();
                ConnectStatusLabel.Text = "Arduino";
                readMessageTimer.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            disconnect();
            ConnectStatusLabel.Text = "-";
        }

        private void processReceivedMessage(string message)
        {
            testlabel.Text = message;
            if (message.StartsWith("BLUE_STATUS:"))
            {
                int value = getParamValue(message);
            }
        }

        private int getParamValue(string message)
        {
            int colonIndex = message.IndexOf(':');
            if (colonIndex != -1)
            {
                string param = message.Substring(colonIndex + 1);
                int value;
                bool done = int.TryParse(param, out value);
                if (done)
                {
                    return value;
                }
            }
            throw new ArgumentException("message contains no value parameter");
        }

        private void RemoteControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            try
            {
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
