using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace DY_WMS_CWPDA
{
    public partial class W_PD1S01 : Form
    {
        public W_PD1S01()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult m_result = MessageBox.Show("프로그램을 종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
            if (m_result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void W_PD1S01_Load(object sender, EventArgs e)
        {
            GettingXML();
        }

        //서버 데이타 설정
        private void GettingXML()
        {
            //if (File.Exists(@"/Application/ServerConfig.xml"))
            if (File.Exists(@"/Program Files/DY_WMS_CWPDA_CAB/ServerConfig.xml"))
            {
                StreamReader streamReader = new StreamReader(@"/Program Files/DY_WMS_CWPDA_CAB/ServerConfig.xml");
                XmlTextReader xmlReader = new XmlTextReader(streamReader);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlReader);
                XmlElement xmlElement = xmlDocument.DocumentElement;

                string serverIP = xmlElement.GetElementsByTagName("serverIP")[0].InnerText;
                string serverPort = xmlElement.GetElementsByTagName("serverPORT")[0].InnerText;

                ServerConfig.ServerIP = serverIP;
                ServerConfig.ServerPort = Convert.ToInt16(serverPort);

                streamReader.Close();

                DialogResult m_result = MessageBox.Show("Socket Server IP: " + serverIP + " Port: " + serverPort, "Socket Server Info.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult m_result = MessageBox.Show("서버정의 파일을 찾을수 없습니다", "System Info.", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GettingXML();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            ClientConfig.userid = "07093";      //임시설정

            if (ClientConfig.userid == "")
            {
                MessageBox.Show("사용자 인증을 먼저 하셔야 합니다.");
                return;
            }
            else
            {
                // Create an instance of the secondary form
                W_PD1S02 W_PD1S02 = new W_PD1S02();

                // Cancel the read 
                //Scanning.StopRead();

                // Bring the modal dialog to the front 
                W_PD1S02.ShowDialog();

                // Upon return dispose the secondary form instance
                W_PD1S02.Dispose();
            }
        }






    }

    



}