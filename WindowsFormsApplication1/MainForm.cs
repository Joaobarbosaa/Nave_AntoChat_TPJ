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
    public partial class MainForm : Form
    {
        private ConnectionServer server;
        private Thread update, request;
        public MainForm()
        {
            InitializeComponent();
            request = new Thread(Request);
            update = new Thread(Update);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string host = ipHostBox.Text;
            int port = -1;
            ToolStripItem label = statusBar.Items[0];
            label.Text = "Connecting...";
            int definedPort = Program.Port;
            if (portHostBox.Text != "")
            {
                Int32.TryParse(portHostBox.Text, out definedPort);
            }
            ConnectionClient client = new ConnectionClient(host, definedPort);
            if(client.IsFail)
            {
                label.Text = "Server is Fail!!";
            }
            else
            {
                Form form = new ChatClient(client, this);
                form.Show();
                Visible = false;
            }
        }

        private void butttonStart_Click(object sender, EventArgs e)
        {
            ToolStripItem label = statusBar.Items[0];
            label.Text = "Creating...";
            server = ConnectionServer.Current;
            if (server.IsFail)
            {
                label.Text = "Server is Fail!!";
            }
            else
            {
                label.Text = "Server is Created";

                update.Start();
                request.Start();
            }
        }

        private void Update()
        {
            while(server.IsConnected)
            {
                server.Update();
            }
        }
        private void Request()
        {
            while (server.IsConnected)
            {
                server.Request();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(server != null)
            {
                server.Close();
            }
        }
    }
}
