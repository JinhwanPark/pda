using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace DYPI_WMS_PDA
{
    class TCPClient
    {
        //Server IP,Port

        public static IPAddress serverIPAddress = IPAddress.Parse(ServerConfig.CommSvrIP);
        public static IPEndPoint serverIPEndPoint = new IPEndPoint(serverIPAddress, ServerConfig.CommSvrPort);


        //public static IPAddress serverIPAddress = IPAddress.Parse("172.31.15.5");
        //public static IPEndPoint serverIPEndPoint = new IPEndPoint(serverIPAddress, 5000);

        Socket m_client = null;
        private bool isConn = false;

        public TCPClient()
        {
            m_client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool StartConnection()
        {
            try
            {
                m_client.Connect(serverIPEndPoint);
                isConn = true;
            }
            catch (System.SystemException)
            {
                ////MessageBox.Show(ex.ToString());
                isConn = false;
                m_client = null;
            }
            return isConn;
        }

        public void Send(string sendmessage)
        {
            if (m_client != null)
            {
                if (isConn == true)
                {
                    m_client.Send(Encoding.UTF8.GetBytes(sendmessage));
                }
            }
        }

        public string Receive()
        {
            int size = 0;
            Byte[] byteBuffer = new Byte[1000480];
            size = m_client.Receive(byteBuffer, 0, byteBuffer.Length, 0);
            string data = Encoding.UTF8.GetString(byteBuffer, 0, size);
            //Console.WriteLine(data);
            byteBuffer = null;

            return data;
        }
        public string Receives()
        {
            int size = 0;
            Byte[] byteBuffer = new Byte[1000480];
            Thread.Sleep(2000);
            size = m_client.Receive(byteBuffer, 0, byteBuffer.Length, 0);
            string data = Encoding.UTF8.GetString(byteBuffer, 0, size);
            //Console.WriteLine(data);
            byteBuffer = null;

            return data;
        }

        public void StopConnection()
        {
            if (m_client != null)
            {
                try
                {
                    isConn = false;
                    m_client.Shutdown(SocketShutdown.Both);
                    m_client.Close();
                    m_client = null;
                }
                catch (System.Net.Sockets.SocketException ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
