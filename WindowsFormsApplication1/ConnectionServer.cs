using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    class ConnectionServer
    {
        private TcpListener listener;
        private MediatorServer mediator;
        private bool fail, connected;
        private ConnectionServer()
        {
            try
            {
                listener = new TcpListener(Program.Port);
                mediator = new MediatorServer();
                listener.Start();
                connected = true;
            }
            catch(Exception e)
            {
                fail = true;
            }
        }

        public void Update()
        {
            try
            {
                TcpClient tcp = listener.AcceptTcpClient();
                ClientServer client = new ClientServer(tcp, mediator);
                mediator.Add(client);
            }
            catch(Exception e)
            {
                connected = false;
            }
        }
        public void Request()
        {
            try
            {
                if(connected)
                    mediator.Request();
            }
            catch(Exception e)
            {
                connected = false;
            }
        }

        public void Close()
        {
            connected = false;
            listener.Stop();
        }
        public bool IsFail
        {
            get { return fail; }
        }
        public bool IsConnected
        {
            get { return connected; }
        } 

        private static ConnectionServer current;
        public static ConnectionServer Current
        {
            get
            {
                if(current == null)
                    current = new ConnectionServer();
                
                return current;
            }
        }
    }
}
