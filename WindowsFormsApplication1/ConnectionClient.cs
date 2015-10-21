using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public class ConnectionClient
    {
        private bool fail;
        private TcpClient client;
        public ConnectionClient(string host, int port)
        {
            client = null;
            try
            {
                client = new TcpClient(host, port);
            }
            catch(Exception e)
            {
                fail = true;
            }
        }
        public bool IsFail
        {
            get { return fail; }
        }
        public bool IsConnected
        {
            get { return client.Connected; }
        } 

        public bool SendMessage(string message)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] info = Encoding.UTF8.GetBytes(message);
                stream.Write(info, 0, info.Length);
                stream.Flush();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public string GetMessage()
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] info = new byte[1024];
                stream.Read(info, 0, info.Length);
                string message = Encoding.UTF8.GetString(info);

                return message;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public void Close()
        {
            client.Close();
        }
    }
}
