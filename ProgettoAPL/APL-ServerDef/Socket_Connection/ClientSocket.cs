using System.Net;
using System.Net.Sockets;
using System.Text;

namespace APL_ServerDef.Socket_Connection
{
    public class ClientSocket
    {
        private readonly string RemoteHost;
        private readonly int RemotePort;
        
        private Socket InternalSocket;
        private IPEndPoint RemoteEndpoint;

        public ClientSocket(string host, int port)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            RemoteHost = host;
            RemotePort = port;
            var resultBuild = Build();

            InternalSocket = resultBuild.Item1;
            RemoteEndpoint = resultBuild.Item2;
        }
        
        private (Socket, IPEndPoint) Build()
        {
            IPAddress remoteIpAddress = IPAddress.Parse(RemoteHost);
            IPEndPoint remoteServerAddress = new IPEndPoint(remoteIpAddress, RemotePort);
            var retunSocket = new Socket(remoteIpAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //Restituzione della tupla (oltre al socket ritorna pure l'indirizzo del server)
            return (retunSocket, remoteServerAddress);
        }

        public void Connect()
        {
            InternalSocket.Connect(RemoteEndpoint);
        }

        private string ReadSocketData(Socket referSocket)
        {
            var stringBuilder = new StringBuilder();
            byte[] buffer = new byte[4096];
            var received = referSocket.Receive(buffer);
            stringBuilder.Append(Encoding.Default.GetString(buffer, 0, received));
            return stringBuilder.ToString();
        }

        private void WriteSocketData(Socket referSocket, string message)
        {
            var bytesDataToWrite = Encoding.Default.GetBytes(message);
            referSocket.Send(bytesDataToWrite);
        }

        public void SendData(string message)
        {
            WriteSocketData(InternalSocket, message);
        }

        public string ReceiveData()
        {
            return ReadSocketData(InternalSocket);
        }

        public void Close()
        {
            InternalSocket.Shutdown(SocketShutdown.Both);
            InternalSocket.Close();
        }

    }
}
