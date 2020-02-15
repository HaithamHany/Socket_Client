using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Socket_Client
{
    public partial class Form1 : Form
    {
        string _serverIp = "localhost";
        int port = 8080;

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(_serverIp, port);

            int byteCount = Encoding.ASCII.GetByteCount(messege.Text); ;

            byte[] sendData = new byte[byteCount];

            sendData = Encoding.ASCII.GetBytes(messege.Text);

            NetworkStream stream = client.GetStream();

            stream.Write(sendData, 0, sendData.Length);

            stream.Close();

        }
    }
}
