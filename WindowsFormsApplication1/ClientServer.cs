using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    class ClientServer
    {
        private string name;
        private TcpClient tcp;
        private MediatorServer mediator;
        private bool requested;
        public ClientServer(TcpClient client, MediatorServer server)
        {
            tcp = client;
            mediator = server;
            name = "CLIENT " + mediator.GetLength();
        }
        public void Notify(string message)
        {
            try
            {
                NetworkStream stream = tcp.GetStream();
                byte[] info = Encoding.UTF8.GetBytes(message);
                stream.Write(info, 0, info.Length);
                stream.Flush();
            }
            catch (Exception e)
            {
            }
        }

        public bool IsConnected
        {
            get { return tcp.Connected; }
        }
        public bool IsRequested
        {
            get { return requested; }
        } 

        public void Request()
        {
            requested = true;
            try
            {
                NetworkStream stream = tcp.GetStream();
                byte[] info = new byte[1024];
                stream.Read(info, 0, info.Length);
                string message = Encoding.UTF8.GetString(info);

                if(!message.Equals("") && IsConnected)
                {
                    string notify = name + " say: " + message;
                    mediator.Send(notify);
                }
                requested = false;
            }
            catch (Exception e)
            {
                tcp.Close();
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
