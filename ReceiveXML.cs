using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace DYPI_WMS_PDA
{
    class ReceiveXML
    {
        public static string m_receivemessage = "";

        int rowcnt = 0;
        int colcnt = 0;
        int k = 0;
        string m_service = "";
        bool m_result = false;
        string m_error = "";
        string[, ,] m_data = null;

        public ReceiveXML(string receivemessage)
        {
            m_receivemessage = receivemessage;
        }

        public void ReadXML()
        {
            StringReader stringReader = new StringReader(m_receivemessage);
            XmlTextReader xmlReader = new XmlTextReader(stringReader);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlReader);
            XmlElement xmlElement = xmlDocument.DocumentElement;

            if (m_receivemessage != "")
            {
                m_service = xmlElement.GetElementsByTagName("SERVICE")[0].InnerText;
                m_result = Convert.ToBoolean(xmlElement.GetElementsByTagName("RESULT")[0].InnerText);

                if (m_result)
                {
                    XmlNode xNode = xmlDocument.FirstChild;
                    XmlNodeList xNodes = xNode.ChildNodes;

                    foreach (XmlNode chilNode in xNodes)
                    {
                        if (chilNode.Name == "RECORD")
                        {
                            colcnt = 0;
                            XmlNodeList xChildNodes = chilNode.ChildNodes;

                            foreach (XmlNode m_chilNode in xChildNodes)
                            {
                                if (m_chilNode.Name == "TL")
                                {
                                    colcnt = colcnt + 1;
                                }
                            }
                        }
                    }

                    rowcnt = xmlElement.GetElementsByTagName("RECORD").Count;

                    m_data = new string[rowcnt, colcnt, 2];

                    for (int i = 0; i < rowcnt; i++)
                    {
                        for (int j = 0; j < colcnt; j++)
                        {
                            m_data[i, j, 0] = xmlElement.GetElementsByTagName("TL")[k].InnerText;
                            m_data[i, j, 1] = xmlElement.GetElementsByTagName("CT")[k].InnerText;

                            k = k + 1;
                        }
                    }
                }
                else
                {
                    m_error = xmlDocument.GetElementsByTagName("ERROR")[0].InnerText;
                }
            }
            ReceiveMessage.service = m_service;
            ReceiveMessage.result = m_result;
            ReceiveMessage.error = m_error;
            ReceiveMessage.data = m_data;
            ReceiveMessage.colcnt = this.colcnt;
            ReceiveMessage.rowcnt = this.rowcnt;
        }
    }
}
