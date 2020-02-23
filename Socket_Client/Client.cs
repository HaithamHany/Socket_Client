using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Socket_Client
{
    public class Client
    {
        Form1 form;
        private string _serverIp = "localhost";
        int _port = 8080;
        private TcpClient _tcpClient;

        public  TcpClient TcpClient { get { return _tcpClient; } private set { } }

        public Client()
        {
            form = new Form1();
        }

        public void ExecuteClinet()
        {
            try
            {
                _tcpClient = new TcpClient(_serverIp, _port);
                //Console.WriteLine("Socket connected to -> {0} ", _tcpClient.Connected);
                form.Label.Text = _tcpClient.Connected.ToString();
            }
            catch (Exception ex)
            {

                form.Label.Text = ex.ToString();
            }
        }
    }
}
