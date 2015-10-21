using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class ChatClient : Form
    {
        private ConnectionClient client;
        private Thread update;
        private Form parent;
        private List<string> messages;
        public ChatClient(ConnectionClient connection, Form form)
        {
            InitializeComponent();
            parent = form;
            client = connection;
            messages = new List<string>();
            update = new Thread(Update);
            update.Start();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void Update()
        {
            while(client.IsConnected)
            {
                string message = client.GetMessage();
                if(message != null && !message.Equals(""))
                    messages.Add(message);
            }
        }

        private void Send()
        {
            string message = messageBox.Text;
            if (!message.Equals(""))
            {
                client.SendMessage(message);
                messageBox.Text = "";
                messageBox.Focus();
            }
        }


        private void messageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void ChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();
            client.Close();
        }

        private void timerMessageView_Tick(object sender, EventArgs e)
        {
            foreach(string message in messages)
            {
                if(!messageView.Items.Contains(message))
                {
                    messageView.Items.Add(message);
                }
            }
        }
    }
}
