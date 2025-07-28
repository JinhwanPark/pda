using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace DYPI_WMS_PDA
{
    public partial class W_PD1S13 : Form
    {

        TCPClient Client;

        public W_PD1S13()
        {
            InitializeComponent();
            Program.multlanguage.DefaultChangLanguage(this);  //lvwenting 20240827
        }


        private void W_PD1S03_Load(object sender, EventArgs e)
        {

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cancel the read 
            //Scanning.StopRead();

            // Exit this form
            this.Close();
        }

        private void W_PD1S13_Load(object sender, EventArgs e)
        {
            //Login UserName Display
            lblUser.Text = "User: " + DYPIPDA.gsUsernm.ToString();

            InitFrm();  //폼 초기화

            //txtMsg.Text = "프로그램이 초기화 되었습니다";
           txtMsg.Text = Program.multlanguage.GetLanguage("The program has been initialized.");//20240827
            Function.Sound sound = new Function.Sound(Function.gSoundSuccess);
            sound.Play();

        }


        //화면 초기화
        private void InitFrm()
        {
            dtpRet.Value = System.DateTime.Now;
            lstvMain.Items.Clear();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            String sDate = dtpRet.Value.ToShortDateString().Replace("-", "");   //선택일자
            DataRet(sDate); //입고정보 조회요청
        }




        //데이터 조회(입고조회)
        //PDA 조회: 품번,입고수,품명,LOC ID,입고일자,입고처,작업자
        private void DataRet(string sDate)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            string sService = "INRET";

            Client = new TCPClient();

            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "MULTI");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);  //UserId
                send.addData("DATE", sDate);      //일자
                send.addData("Plant", ServerConfig.sPlant);      //Plant
                send.addData("STL", ServerConfig.sStrLoc);      //Storage Location

                sSndMsg = send.sendMessage();

                //SEND TO SERVER
                if (sSndMsg != "")
                {
                    try
                    {
                        Client.Send(sSndMsg);
                        bSndOk = true;
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show(e + ":" + "서버로 보내기가 실패하였습니다!");
                          MessageBox.Show(e + ":" + Program.multlanguage.GetLanguage("Could not transfer to the server."));//lvwenting 20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        sound.Play();
                        return;
                    }
                }

                //RECEIVE FROM SERVER
                if (bSndOk)
                {
                    try
                    {
                        int maxRetries = 5; // 최대 반복 횟수
                        int retries = 0;

                        while (!sRcvMsg.EndsWith("</SEND>"))
                        {
                            if (retries >= maxRetries)
                            {
                                break;
                            }

                            sRcvMsg += Client.Receives();
                            retries++;
                        }
                        ReceiveXML XmlRead = new ReceiveXML(sRcvMsg);
                        XmlRead.ReadXML();

                        ReceiveMessage receive = new ReceiveMessage();
                        sRcvService = ReceiveMessage.service;
                        bRcvResult = ReceiveMessage.result;
                        sRcvError = ReceiveMessage.error;

                        sRcvData = new string[ReceiveMessage.rowcnt, ReceiveMessage.colcnt, ReceiveMessage.colcnt]; //배열 초기화

                        sRcvData = ReceiveMessage.data;

                        Client.StartConnection();

                        lstvMain.Items.Clear();

                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {

                                if (ReceiveMessage.rowcnt != 0)
                                {
                                    for (int i = 0; i < ReceiveMessage.rowcnt; i++)
                                    {
                                        System.Windows.Forms.ListViewItem lstvItem = new System.Windows.Forms.ListViewItem();

                                        for (int j = 0; j < ReceiveMessage.colcnt; j++)
                                        {
                                            if (sRcvData[i, j, 0].ToString() != null)
                                            {
                                                if (j == 0)
                                                {
                                                    lstvItem.Text = sRcvData[i, j, 1].ToString();
                                                }
                                                else
                                                {
                                                    lstvItem.SubItems.Add(sRcvData[i, j, 1].ToString());
                                                }
                                            }
                                        }

                                        lstvMain.Items.Add(lstvItem);
                                    }
                                }



                                //txtMsg.Text = ReceiveMessage.rowcnt + " 건의 데이터가 조회되었습니다";
                                txtMsg.Text = ReceiveMessage.rowcnt + Program.multlanguage.GetLanguage("cases of data are displayed."); //lvwenting20240828
                                Function.Sound sound = new Function.Sound(Function.gSoundSearch);
                                sound.Play();

                            }
                            else
                            {
                                txtMsg.Text =  Program.multlanguage.GetLanguage(ReceiveMessage.error);
                                Function.Sound sound = new Function.Sound(Function.gSoundErr);
                                sound.Play();
                            }

                        }

                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                         MessageBox.Show(Program.multlanguage.GetLanguage("Receiving from the server has been failed."));//lvwenting20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        MessageBox.Show(ex.ToString());
                        sound.Play();
                        return;
                    }

                }

            }
            else
            {
                Client.StopConnection(); Function.Sound sound = new Function.Sound(Function.gSoundFail);
                sound.Play();
                //MessageBox.Show("서버와 연결이 끊어졌습니다. 다시 연결을 시도해주세요!!!");
                 MessageBox.Show(Program.multlanguage.GetLanguage("Disconnected from the server! Try to connect again!!!"));//lvwenting 20240827
                return;
            }


        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            InitFrm();

            //txtMsg.Text = "프로그램이 초기화 되었습니다";
           txtMsg.Text = Program.multlanguage.GetLanguage("The program has been initialized.");//20240827
            Function.Sound sound = new Function.Sound(Function.gSoundSuccess);
            sound.Play();

        }




    }

}