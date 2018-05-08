﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3WifiLib;


/*namespace Final_Versie
{
    public partial class MainForm : Form
    {
        MainFrame MAINFRAME;
        public MainForm(MainFrame MFrame)
        {
            InitializeComponent();
            MAINFRAME = MFrame;
        }

        private void buttonSluitenMainmenu_Click(object sender, EventArgs e)
        {
            MAINFRAME.XpToLevel(3);
            Close();

        }
    }
}*/

namespace Final_Versie
{
    public partial class Mainform : Form
    {
        // myEV3 is used to communicate with the LEGO EV3.
        private EV3Wifi myEV3;

        // You need a timer to receive messages from the EV3
        // at specified time intervals.
        private Timer messageReceiveTimer;

        MainFrame MAINFRAME;
        public Mainform()
        {
            InitializeComponent();
            MAINFRAME = MFrame;

            // Create the Timer object and set it to generate a timer tick event 
            // every 100 milliseconds. The timer tick can be used to execute code at fixed intervals.
            messageReceiveTimer = new Timer();
            messageReceiveTimer.Interval = 100;

            // Set the "messageReadTimer_Tick" method as method that is executed when
            // a timer tick event occurs.
            // The "messageReadTimer_Tick" method is defined later in this code (search!).
            messageReceiveTimer.Tick += new System.EventHandler(messageReadTimer_Tick);

            // EV3: Create an EV3Wifi object which you can use to talk to the EV3.
            myEV3 = new EV3Wifi();

            UpdateButtonsAndConnectionInfo();
        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            string ipAddress = ipAddressBox.Text;
            if (!IPAddress.TryParse(ipAddress, out IPAddress address))
            {
                MessageBox.Show("Fill in valid IP address of EV3");
            }
            else if (myEV3.Connect("1234", ipAddress) == true)
            {
                UpdateButtonsAndConnectionInfo();
                receivedMessagesListBox.Items.Clear();
                messageReceiveTimer.Start();
                myEV3.SendMessage("1", "0");
            }
            else
            {
                myEV3.Disconnect();
                MessageBox.Show("Failed to connect to EV3 with IP address " + ipAddress);
            }
        }


        private void disconnectButton_Click(object sender, EventArgs e)
        {
            messageReceiveTimer.Stop();
            myEV3.Disconnect();
            UpdateButtonsAndConnectionInfo();
        }


        private void UpdateButtonsAndConnectionInfo()
        {
            bool isConnected = myEV3.isConnected;

            connectButton.Enabled = !isConnected;
            disconnectButton.Enabled = isConnected;

            if (isConnected)
            {
                connectedDeviceLabel.Text = "Connected to EV3\n" + "IP address:" + myEV3.ipAddress;
                connectedDeviceLabel.BackColor = Color.LightGreen;
            }
            else
            {
                connectedDeviceLabel.Text = "No connection";
                connectedDeviceLabel.BackColor = Color.Red;
            }
        }


        private void clearReceivedMessagesButton_Click(object sender, EventArgs e)
        {
            receivedMessagesListBox.Items.Clear();
        }


        // EV3: This method is the event handler for the messageReadTimer.
        //      The method is called when the timer has reached its 'interval' value.
        //      It receives a message from the EV3.
        //      Make sure that in the code below you comply with the message format sent by the EV3.
        //      The message itself is always one string.
        //      In the code below it is assumed that the message sent by the EV3 string consists of three substrings separated by a space:
        //      substring 0: message count
        //      substring 1: distance in cm
        //      substring 2: angle in degrees
        private void messageReadTimer_Tick(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                // EV3: ReceiveMessage is asynchronous so it actually gets the message read at the previous call to ReceiveMessage
                //      and it triggers reading the next message from the specified mailbox.
                //      Due to the simple implementation the message read does not contain information of the mailbox it came from.
                //      Therefore the advise is to only use one mailbox to read from: EV3_OUTBOX0.
                string strMessage = myEV3.ReceiveMessage("EV3_OUTBOX0");
                if (strMessage == "2*")//als de string begint met een 2
                {
                    string3("3A123B123C123"); //stuur ... naar inbox 0
                }
                if (strMessage == "4*")
                {
                    string5("3A123B123C123");
                }
            }
        }

        public void string3(string string3)
        {
            myEV3.SendMessage(string3, "0");
        }

        public void string5(string string5)
        {
            myEV3.SendMessage(string5, "0");
        }


        // EV3: This method sends the text typed in the 'EV3 message send' box to the EV3.
        //      This can be used for test purposes.
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (myEV3.isConnected)
            {
                myEV3.SendMessage(commandBox.Text, "0");  // "0" means EV3_INBOX0
            }
        }

        // EV3: The method below is called when the form is closed. Stop the timer and disconnect.
        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop the timer
            messageReceiveTimer.Stop();

            // Disconnect
            if (myEV3.isConnected)
            {
                myEV3.Disconnect();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string strMessage = myEV3.ReceiveMessage("EV3_OUTBOX0");
            if (strMessage.IndexOf("A") == 0)
            {
                MessageBox.Show("XPLOOTBOX STRING = " + strMessage);
                myEV3.SendMessage("0", "0");

            }
        }

        private void buttonMainformTerug_Click(object sender, EventArgs e)
        {

        }
    }
}
