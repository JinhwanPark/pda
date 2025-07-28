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
    public partial class W_PD1S03 : Form
    {
        public W_PD1S03()
        {
            InitializeComponent();
        }


        private void W_PD1S03_Load(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cancel the read 
            //Scanning.StopRead();

            // Exit this form
            this.Close();
        }






    }

    



}