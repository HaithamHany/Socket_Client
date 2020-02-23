using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Socket_Client
{
    class ClientRun
    {

        private IPHostEntry _ipHost;
        private IPAddress _ipAddr;
        private IPEndPoint _localEndPoint;
        private Socket _sender;
        public Socket Sender
        {
            get
            {
                return _sender;
            }

        }

        public ClientRun()
        {
            Initialize();
            ConnectClient();
        }

        private void Initialize()
        {
            try
            {
                //Establish the remote endpoint for the socket uses port 11111 on the local computer
                _ipHost = Dns.GetHostEntry(Dns.GetHostName());
                _ipAddr = _ipHost.AddressList[0];
                _localEndPoint = new IPEndPoint(_ipAddr, 11111);

                _sender = new Socket(_ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Unexpected exception : {0}", e.ToString());
                Form1._lblStatusConnect.Text = e.ToString();
            }

        }

        private void ConnectClient()
        {

            try
            {
                _sender.Connect(_localEndPoint);

                Form1._lblStatusConnect.Text = "Remote EndPoint " +
                    _sender.RemoteEndPoint.ToString() + " is connected";

                string textToSend = DateTime.Now.ToString();

                byte[] messageSent = Encoding.ASCII.GetBytes(("Client connected " + textToSend+" <EOF>"));
                int byteSent = _sender.Send(messageSent);

                // Data buffer 
                byte[] messageReceived = new byte[1024];

                //we recive msg using recive() method.
                int byteRecive = _sender.Receive(messageReceived);
                //Console.WriteLine("Message from Server -> {0}",
                Form1._lblStatusConnect.Text = Encoding.ASCII.GetString(messageReceived, 0, byteRecive);

                // Close Socket using  
                // the method Close() 
                //_sender.Shutdown(SocketShutdown.Both);
                //_sender.Close();
            }
            catch (ArgumentNullException ane)
            {
                Form1._lblStatusConnect.Text = ane.ToString();
            }

            catch (SocketException se)
            {
                Form1._lblStatusConnect.Text = se.ToString();
            }
            catch (Exception e)
            {
                //Console.WriteLine("Unexpected exception : {0}", e.ToString());
                Form1._lblStatusConnect.Text = e.ToString();
            }

        }

        public void SendMessage(string messege, string userName)
        {
            try
            {
                //_sender.Connect(_localEndPoint);
                //creation of msg sent to server
                byte[] messageSent = Encoding.ASCII.GetBytes((messege + "<EOF>"));

                int byteCount = Encoding.ASCII.GetByteCount(messege); ;

                byte[] sendData = new byte[byteCount];

                sendData = Encoding.ASCII.GetBytes(messege);


                int byteSent = _sender.Send(sendData);
                byte[] messageReceived = new byte[1024];
                // byte[] messageReceived = new byte[1024];

                try
                {
                    int byteRecive = _sender.Receive(messageReceived);
                    Form1._lblStatusConnect.Text = Encoding.ASCII.GetString(messageReceived, 0, byteRecive);
                }
                catch (ArgumentNullException ane)
                {
                    Form1._lblStatusConnect.Text = ane.ToString();
                }

                catch (SocketException se)
                {
                    Form1._lblStatusConnect.Text = se.ToString();
                }
                catch (Exception ex)
                {

                }
                //Console.WriteLine("Message from Server -> {0}",
                

                // Close Socket using  
                // the method Close() 
                //  _sender.Shutdown(SocketShutdown.Both);
                // _sender.Close();
            }
            catch (ArgumentNullException ane)
            {
                Form1._lblStatusConnect.Text = ane.ToString();
            }

            catch (SocketException se)
            {
                Form1._lblStatusConnect.Text = se.ToString();
            }

            catch (Exception e)
            {
                //Console.WriteLine("Unexpected exception : {0}", e.ToString());
                Form1._lblStatusConnect.Text = e.ToString();
            }
        }
    }
}
