using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DYPI_WMS_PDA
{
    class SendXML
    {
        public static string Service = "";
        public static string Sqltype = "";
        public static string m_sendmessage = "";
        XmlDocument xmlDocument = null;
        XmlElement xmlSend = null;

        public SendXML()
        {
            xmlDocument = new XmlDocument();
        }

        public void setService(string service, string sqltype)
        {
            xmlSend = xmlDocument.CreateElement("SEND");
            xmlSend.InnerText = "SEND";

            XmlElement xmlService = xmlDocument.CreateElement("SERVICE");
            xmlService.InnerText = service;
            xmlSend.AppendChild(xmlService);

            XmlElement xmlSqltype = xmlDocument.CreateElement("SQLTYPE");
            xmlSqltype.InnerText = sqltype;
            xmlSend.AppendChild(xmlSqltype);
        }

        public void setRequestID(string pdaid)
        {
            XmlElement xmlRequestid = xmlDocument.CreateElement("REQUESTID");
            xmlRequestid.InnerText = pdaid;
            xmlSend.AppendChild(xmlRequestid);
        }

        public void addData(string title, string content)
        {
            XmlElement xmlTitle = xmlDocument.CreateElement("TL");
            xmlTitle.InnerText = title;
            xmlSend.AppendChild(xmlTitle);

            XmlElement xmlContent = xmlDocument.CreateElement("CT");
            xmlContent.InnerText = content;
            xmlSend.AppendChild(xmlContent);
        }

        public string sendMessage()
        {
            m_sendmessage = xmlSend.OuterXml;
            return m_sendmessage;
        }
    }
}
