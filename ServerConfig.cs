using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace DYPI_WMS_PDA
{
    class ServerConfig
    {
        public static string CommSvrIP ;
        public static int CommSvrPort ;


        public static string sPlant ;
        public static string sStrLoc;
        //lvwenting 20240827
        public static string sLang;

        public void ServerConfigInit()
        {
            if (File.Exists(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig_Init.xml"))
            {
                StreamReader streamReader = new StreamReader(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig_Init.xml");
                XmlTextReader xmlReader = new XmlTextReader(streamReader);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlReader);
                XmlElement xmlElement = xmlDocument.DocumentElement;

                CommSvrIP = xmlElement.GetElementsByTagName("CommSvrIP")[0].InnerText;
                CommSvrPort = Convert.ToInt16(xmlElement.GetElementsByTagName("CommSvrPort")[0].InnerText);

                sPlant = xmlElement.GetElementsByTagName("Plant")[0].InnerText;
                sStrLoc = xmlElement.GetElementsByTagName("StrLoc")[0].InnerText;
                //lvwenting 20240827
                sLang = xmlElement.GetElementsByTagName("Lang")[0].InnerText;

                streamReader.Close();
            }

            // TEST 시 반드시 추가
            //CommSvrIP = "172.31.81.25";
            //CommSvrPort = 5005;

            //sPlant = "PB00";
            //sStrLoc = "1200";
        }
        
        public void ServerConfigSet()
        {
            if (File.Exists(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig.xml"))
            {
                StreamReader streamReader = new StreamReader(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig.xml");
                XmlTextReader xmlReader = new XmlTextReader(streamReader);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlReader);
                XmlElement xmlElement = xmlDocument.DocumentElement;

                CommSvrIP = xmlElement.GetElementsByTagName("CommSvrIP")[0].InnerText;
                CommSvrPort = Convert.ToInt16(xmlElement.GetElementsByTagName("CommSvrPort")[0].InnerText);


                sPlant = xmlElement.GetElementsByTagName("Plant")[0].InnerText;
                sStrLoc = xmlElement.GetElementsByTagName("StrLoc")[0].InnerText;
                //lvwenting 20240827
                sLang = xmlElement.GetElementsByTagName("Lang")[0].InnerText;

                streamReader.Close();
            }

            // TEST 시 반드시 추가
            //CommSvrIP = "172.31.81.25";
            //CommSvrPort = 5005;

            //sPlant = "PB00";
            //sStrLoc = "1200";

        }

        public void ServerConfigSave()
        {
            if (File.Exists(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig.xml"))
            {

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig.xml");

                XmlNode CommSvrIP = xmlDocument.SelectSingleNode("ServerConfig/CommSvrIP");
                CommSvrIP.InnerText = ServerConfig.CommSvrIP.ToString();

                XmlNode CommSvrPort = xmlDocument.SelectSingleNode("ServerConfig/CommSvrPort");
                CommSvrPort.InnerText = ServerConfig.CommSvrPort.ToString();

          
                XmlNode Plant = xmlDocument.SelectSingleNode("ServerConfig/Plant");
                Plant.InnerText = ServerConfig.sPlant.ToString();

                XmlNode StrLoc = xmlDocument.SelectSingleNode("ServerConfig/StrLoc");
                StrLoc.InnerText = ServerConfig.sStrLoc.ToString();
                //lvwenting 20240827

                XmlNode iLang = xmlDocument.SelectSingleNode("ServerConfig/Lang");
                iLang.InnerText = ServerConfig.sLang.ToString();

                DYPIPDA CWPDA = new DYPIPDA();                
                string sUserID="";
                string sUserNm="";

                if (DYPIPDA.gsUserid != null)
                {
                    sUserID = DYPIPDA.gsUserid.ToString();
                    sUserNm = DYPIPDA.gsUsernm.ToString();
                }

                XmlNode EditDateTime = xmlDocument.SelectSingleNode("ServerConfig/EditDateTime");
                EditDateTime.InnerText = System.DateTime.Now.ToString(); 

                XmlNode EditUser = xmlDocument.SelectSingleNode("ServerConfig/EditUser");
                EditUser.InnerText = "[" + sUserID.ToString() + "]" + sUserNm.ToString();

                xmlDocument.Save(@"/Program Files/DYPI_WMS_PDA_CAB/ServerConfig.xml");
            }

           
        }

    }
}
