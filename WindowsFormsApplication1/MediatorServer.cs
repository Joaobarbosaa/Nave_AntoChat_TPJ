using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication1
{
    class MediatorServer
    {
        private List<ClientServer> clients;
        public MediatorServer()
        {
            clients = new List<ClientServer>();
        }
        public void Send(string message)
        {
            foreach(ClientServer client in clients)
            {
                client.Notify(message);
            }
        }
        public void Request()
        {
            int length = clients.Count;
            for (int i = 0; i < length; i++)
            {
                ClientServer client = clients[i];
                if(client.IsConnected && !client.IsRequested)
                {
                    Thread thread = new Thread(new ThreadStart(client.Request));
                    thread.Start();
                }
            }
        }
        public void Add(ClientServer client)
        {
            clients.Add(client);
        }
        public int GetLength()
        {
            return clients.Count;
        }
    }
}
