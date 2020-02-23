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
        ClientRun _client;
        public Form1()
        {
            InitializeComponent();
            _client = new ClientRun();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            _client.SendMessage(inputMessege.Text, "Haitham");
        }

    }
}
