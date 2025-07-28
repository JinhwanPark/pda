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
    public partial class W_PD1U50 : Form
    {
        TCPClient Client;
        string sPreLoc; //이전 Location
        string sMovLoc; //이동 Location   
        Int32 iInvCnt = 0; //조회된 재고정보 Count

        string sSelMatcod = "";
        double iSelInvQty = 0;
        Int32 iSelIndex = 0;

        Boolean bQueIn = false;
        Boolean bMakeseq = false;
        Boolean bChkQue = false;
        string sLocchkrst;

        string sPdaId;
        string sProcSeq;
        Boolean bSpCall = false;

        string sLocMstRst;


        public W_PD1U50()
        {
            InitializeComponent();
        }


        private void btnInit_Click(object sender, EventArgs e)
        {
            InitFrm();

            FuncBtnEnable();   //기능키 활성화

            //txtMsg.Text = "프로그램이 초기화 되었습니다";
            txtMsg.Text = "程序初始化完成";
            Function.Sound sound = new Function.Sound(Function.gSoundSuccess);
            sound.Play();

        }


        //화면 초기화
        private void InitFrm()
        {
            lblTotalqty.Text = "0";
            //lblLocid.Text = "";
            lstvMain.Items.Clear();
            lstvMain.FullRowSelect = true;
            sPreLoc = "";   //이전 Location
            sMovLoc = "";   //이동 Location   
            lblPreLoc.Text = "";
            lblMovLoc.Text = "";
            plnInput.Left = 246;    //이동상세 숨김

            iInvCnt = 0; //조회된 재고정보 Count

            ScanFocus();
        }

        //Scan 입력에따른 처리
        //private void ScanProc(string sScanBar)
        //{
        //    //string sScanBar;
        //    Int32 iCnt;

        //    iCnt = sScanBar.Length;

        //    try
        //    {
        //       if (iCnt == 6)
        //       {

        //                //이동전 Location ID 가 입력되었나?
        //                //이동전 Location의 재고가 확인되었나?
        //                //이동전 Location의 이동재고수가 입력되었나?

        //                if (sPreLoc == "")      //이동전 Location 입력이 없는경우, 이동전 Location의 재고정보를 조회
        //                {
        //                    PreLocScan(sScanBar);   //Location 재고정보 조회, Listview 정보 Listup
        //                }
        //                else                    //이동전 Location 입력 후 이동후 Location을 입력한경우. 
        //                {
        //                    if (sPreLoc != sScanBar)
        //                    {
        //                        //이미 입력된 LOC ID의 이동 적정성을 검증한다(이동금지 LOC ID 인경우 이후 처리 불가)
        //                        LocStat(sPreLoc);       //LOCATION 현상태 조회(결과값이 없거나, 1이 아닌경우 false)


        //                        if (sLocchkrst != "1")
        //                        {
        //                            sMovLoc = "";        //검증 LOCID 초기화
        //                            lblMovLoc.Text = "";
        //                            txtMsg.Text = sPreLoc + " 이동불가! 이동불가 LOC ID 입니다.";
        //                            Function.Sound sound = new Function.Sound(Function.gSoundErr);
        //                            sound.Play();
        //                            return;
        //                        }                                

        //                        sMovLoc = "";

        //                        if (lstvMain.Items.Count > 0)       //조회된 내용이 있는경우
        //                        {
        //                            Int32 iQty = 0;
        //                            Boolean bMovQtyChk = false;

        //                            //이동재고수가 입력되었는지 확인
        //                            for (int i = 0; i < lstvMain.Items.Count; i++)      //순차 적재처리
        //                            {
        //                                iQty = Convert.ToInt32(lstvMain.Items[i].SubItems[2].Text.ToString()); //QTY

        //                                if (iQty > 0)
        //                                {
        //                                    bMovQtyChk = true;
        //                                    break;
        //                                }
        //                            }

        //                            if (bMovQtyChk == true) //이동재고수가 입력됨
        //                            {

        //                                txtMsg.Text = "이동적재 LOC 검증중";

        //                                //순차적으로 이동수량이 입력된 품번을 이동할 LOC 적재 검증
        //                                for (int i = 0; i < lstvMain.Items.Count; i++)      //순차 적재처리
        //                                {
        //                                    string sChkMatcod;
        //                                    Int32 iChkQty = 0;

        //                                    sChkMatcod = lstvMain.Items[i].SubItems[0].Text.ToString(); //품번
        //                                    iChkQty = Convert.ToInt32(lstvMain.Items[i].SubItems[2].Text.ToString());

        //                                    if (iChkQty > 0)
        //                                    {
        //                                        sMovLoc = sScanBar;      //검증 LOC ID
        //                                        LocChk(sScanBar, sChkMatcod);       //Location 적정성 검증요청

        //                                        if (sLocchkrst == "")
        //                                        {
        //                                            sMovLoc = "";        //검증 LOCID 초기화
        //                                            lblMovLoc.Text = "";
        //                                            txtMsg.Text = "이동불가! 등록되지 않은 LOC ID 입니다.";
        //                                            Function.Sound sound = new Function.Sound(Function.gSoundErr);
        //                                            sound.Play();
        //                                            break;
        //                                        }
        //                                        else
        //                                        {
        //                                            if (sLocchkrst == "1")
        //                                            {
        //                                                if (sLocMstRst != sScanBar.Substring(0, 2))
        //                                                {
        //                                                    //DialogResult result;

        //                                                    //result = MessageBox.Show(sChkMatcod + " 는 " + sScanBar + " 에 적합하지 않은 공간입니다.계속하시겠습니까?", "부적절 적재공간",
        //                                                    //                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        //                                                    //if (result == DialogResult.No)
        //                                                    //{
        //                                                    //    sMovLoc = "";        //검증 LOCID 초기화
        //                                                    //    lblMovLoc.Text = "";
        //                                                    //    txtMsg.Text = "이동처리가 취소되었습니다";
        //                                                    //    Function.Sound sound = new Function.Sound(Function.gSoundErr);
        //                                                    //    sound.Play();
        //                                                    //    break;
        //                                                    //}
        //                                                }
        //                                            }

        //                                            else
        //                                            {
        //                                                sMovLoc = "";        //검증 LOCID 초기화
        //                                                lblMovLoc.Text = "";
        //                                                txtMsg.Text = sScanBar + " 이동불가! 이동불가 LOC ID 입니다.";
        //                                                Function.Sound sound = new Function.Sound(Function.gSoundErr);
        //                                                sound.Play();
        //                                                break;
        //                                            }
        //                                        }

        //                                    }
        //                                }

        //                                if (sMovLoc != "") //검증완료
        //                                {
        //                                    lblMovLoc.Text = sScanBar.Substring(0, 2) + "-" + sScanBar.Substring(2, 2) + "-" + sScanBar.Substring(4, 2);
        //                                    sMovLoc = sScanBar;

        //                                    txtMsg.Text = "적재공간 검증완료.이동버튼을 클릭하여 이동처리완료하세요";
        //                                    Function.Sound sound = new Function.Sound(Function.gSoundFunc);
        //                                    sound.Play();

        //                                }
        //                            }
        //                            else
        //                            {
        //                                txtMsg.Text = "이동할 자재의 이동수량을 먼저 입력하세요";
        //                                Function.Sound sound = new Function.Sound(Function.gSoundErr);
        //                                sound.Play();
        //                            }
        //                        }

        //                    }
        //                    else
        //                    {
        //                        txtMsg.Text = "동일한 적재공간으로 이동할 수 없습니다";
        //                        Function.Sound sound = new Function.Sound(Function.gSoundErr);
        //                        sound.Play();
        //                    }

        //                }  
        //            }
        //        }
        //    catch (Exception x)
        //    {
        //        MessageBox.Show("오류:" + x.Message);
        //    }

        //    ScanFocus();
        //}




        //LOCATION 현상태 조회(결과값이 없거나, 1이 아닌경우 false)
        private void LocStat(string sScanBar)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            Client = new TCPClient();


            string sService = "LOCSTAT";

            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "MULTI");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);
                send.addData("PLANT", ServerConfig.sPlant);
                send.addData("STL", ServerConfig.sStrLoc);
                send.addData("LOCID", sScanBar); //Location ID (Rack 번호만 검증)

                sSndMsg = send.sendMessage();

                sLocchkrst = "";     //RACK 등록상태(NULL=MAST 무등록, 1=정상,6=금지)

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
                        MessageBox.Show(e + ":" + "与服务器连接失败!");
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
                        sRcvData = ReceiveMessage.data;

                        Client.StartConnection();

                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {
                                sLocchkrst = sRcvData[0, 0, 1];     //RACK 등록상태(NULL=MAST 무등록, 1=정상,6=금지)
                                return;

                            }

                        }

                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                        MessageBox.Show(Program.multlanguage.GetLanguage("Receiving from the server has been failed."));//lvwenting20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        //MessageBox.Show(ex.ToString());
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




        //Loctaion 적정성 Check (LOCCHK)
        private void LocChk(string sScanBar, string sMatcod)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            Client = new TCPClient();


            string sService = "LOCCHK";

            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "MULTI");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);
                send.addData("PLANT", ServerConfig.sPlant);
                send.addData("STL", ServerConfig.sStrLoc);
                send.addData("LOCID", sScanBar); //Location ID (Rack 번호만 검증)
                send.addData("MATCD", sMatcod.Trim());                 //품번

                sSndMsg = send.sendMessage();

                sLocchkrst = "";     //RACK 등록상태(NULL=MAST 무등록, 1=정상,6=금지)
                sLocMstRst = "";     //RACK 적정성 검증결과(RACK 번호=적정)

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
                        sRcvData = ReceiveMessage.data;

                        Client.StartConnection();

                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {
                                //string sRcvPrgId;

                                sLocchkrst = sRcvData[0, 0, 1];             //RACK 등록상태(NULL=MAST 무등록, 1=정상,6=금지)
                                sLocMstRst = sRcvData[0, 1, 1].Trim();      //RACK 적정성 검증결과(RACK 번호=적정)

                                return;

                            }

                        }

                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                        MessageBox.Show(Program.multlanguage.GetLanguage("Receiving from the server has been failed."));//lvwenting20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        //MessageBox.Show(ex.ToString());
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


        //이동전 Location ID 입력, 재고가 있는 경우 재고정보를 Listup 한다.
        private void PreLocScan(string sScanBar)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            string sService = "PRELOCGOODSCAN";

            Client = new TCPClient();

            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "MULTI");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);
                send.addData("PLANT", ServerConfig.sPlant);
                send.addData("STL", ServerConfig.sStrLoc);
                send.addData("LOC", sScanBar);
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


                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {

                                if (ReceiveMessage.rowcnt != 0)
                                {
                                    lstvMain.Items.Clear();

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
                                        //sScanbarval[0] = sScanBar.ToString();
                                        iInvCnt = iInvCnt + 1;
                                    }

                                    ReceiveMessage.rowcnt = iInvCnt;
                                }


                                SumQty();

                                lblPreLoc.Text = sScanBar.Substring(0, 2) + "-" + sScanBar.Substring(2, 2) + "-" + sScanBar.Substring(4, 2);
                                lblMovLoc.Text = "";
                                sPreLoc = sScanBar;

                                txtMsg.Text = ReceiveMessage.rowcnt + " 件数据查询成功. 请输入要移动的品号数量";                                //txtMsg.Text = ReceiveMessage.rowcnt + " 건의 데이터가 조회되었습니다. 이동할 품번과 수량을 입력하세요";
                                Function.Sound sound = new Function.Sound(Function.gSoundSearch);
                                sound.Play();

                            }
                            else
                            {
                                txtMsg.Text =  Program.multlanguage.GetLanguage(ReceiveMessage.error);//20240830
                                Function.Sound sound = new Function.Sound(Function.gSoundErr);
                                sound.Play();
                            }

                        }

                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                        MessageBox.Show("服务器接收出现错误！");
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        //MessageBox.Show(ex.ToString());
                        sound.Play();
                        //return;
                    }

                }

            }
            else
            {
                Client.StopConnection(); Function.Sound sound = new Function.Sound(Function.gSoundFail);
                sound.Play();
                //MessageBox.Show("서버와 연결이 끊어졌습니다. 다시 연결을 시도해주세요!!!");
                 MessageBox.Show(Program.multlanguage.GetLanguage("Disconnected from the server! Try to connect again!!!"));//lvwenting 20240827
                //return;
            }
            ScanFocus();

        }


        //Listview 수량의 총합계산
        private void SumQty()
        {
            double iSumQty = 0;
            for (int iCnt = 0; iCnt < lstvMain.Items.Count; iCnt++)
            {
                iSumQty += double.Parse(lstvMain.Items[iCnt].SubItems[2].Text);
            }

            lblTotalqty.Text = Convert.ToString(iSumQty);
        }


        //Keypad or Scan키 입력 초기화/대기
        private void ScanFocus()
        {
            txtScan.Text = "";
            txtScan.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cancel the read 
            //Scanning.StopRead();

            // Exit this form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FuncBtnEnable();   //기능키 활성화
            plnInput.Left = 246;    //이동상세 숨김
            ScanFocus();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    txtMsg.Text = "정상적으로 처리되었습니다.";
        //    Function.Sound sound = new Function.Sound(Function.gSoundGood);
        //    sound.Play();
        //}


        private void W_PD1U21_Load(object sender, EventArgs e)
        {
            //Login UserName Display
            lblUser.Text = "User: " + DYPIPDA.gsUsernm.ToString();

            InitFrm();  //폼 초기화

            //txtMsg.Text = "프로그램이 초기화 되었습니다";
            txtMsg.Text = "程序初始化成功";
            Function.Sound sound = new Function.Sound(Function.gSoundSuccess);
            sound.Play();

            ScanFocus();
        }



        private void lstvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //현재 선택된 Index 확인
            //현재 품번과 재고수량 확인
            //이동수량 입력 Panel view
            //품번,재고수 Mapp
            //이동수 입력
            //확인: Listview 이동수량 Mapp, Listview Index check: true

            Int32 iIndex;
            string sSelInvQty;
            double iInvQty;



            if (lstvMain.Items.Count > 0)       //조회된 내용이 있는경우
            {
                if (Convert.ToInt32(lstvMain.SelectedIndices.Count) > 0)
                {
                    iSelIndex = Convert.ToInt32(lstvMain.FocusedItem.Index);     //선택 Index

                    sSelMatcod = lstvMain.Items[iSelIndex].SubItems[0].Text;   //선택품번
                    sSelInvQty = lstvMain.Items[iSelIndex].SubItems[1].Text;   //선택 재고수량
                    iSelInvQty = Convert.ToDouble(sSelInvQty);   //선택품번(int)

                    lblMovMatcod.Text = sSelMatcod;    //품번
                    lblMovInvQty.Text = sSelInvQty;    //재고수량
                    txtMovQty.Text = sSelInvQty;       //이동수량(Max)

                    FuncBtnDisable();   //기능키 비활성화

                    plnInput.Left = 0;

                }
            }
            else
            {
                //txtMsg.Text = "조회된 재고가 없습니다. 이동할 재고의 Location ID 를 먼저 입력하세요";
                txtMsg.Text = "没有可查询的在库信息. 请先输入要移动的 Location ID";
                Function.Sound sound = new Function.Sound(Function.gSoundErr);
                sound.Play();
            }

            ScanFocus();
        }

        private void butMovChk_Click(object sender, EventArgs e)
        {
            double iMovQty;
            iMovQty = Convert.ToDouble(txtMovQty.Text.ToString());

            try
            {

                if (iMovQty > 0)    //이동수량 정상확인
                {

                    if (iMovQty <= iSelInvQty) // 이동대상수 <= 현재고수
                    {
                        //정상 입력확인
                        //Listview에 이동수량을 Mapp.

                        lstvMain.Items[iSelIndex].SubItems[2].Text = iMovQty.ToString();


                        plnInput.Left = 246;    //이동상세 숨김
                        //txtMsg.Text = "수량이 입력되었습니다.";
                        txtMsg.Text = "数量输入完毕.";
                        Function.Sound sound = new Function.Sound(Function.gSoundSuccess);
                        sound.Play();

                        FuncBtnEnable();   //기능키 활성화

                    }
                    else
                    {
                        txtMovQty.Focus();
                        //plnInput.Left = 0;   
                        //txtMsg.Text = "이동수량은 재고수량을 초과할수 없습니다";
                        txtMsg.Text = "移动数量不能超过在库数量";
                        Function.Sound sound = new Function.Sound(Function.gSoundErr);
                        sound.Play();
                    }
                }
                else
                {
                    txtMovQty.Focus();
                    //txtMsg.Text = "수량은 0 이상 입력하세요";
                    txtMsg.Text = "输入的数量必须大于0";
                    Function.Sound sound = new Function.Sound(Function.gSoundErr);
                    sound.Play();
                }
            }
            catch
            {
                txtMovQty.Focus();
                //txtMsg.Text = "수량 입력중 오류발생";
                txtMsg.Text = "数量输入中发现错误";
                //plnInput.Left = 246;
                Function.Sound sound = new Function.Sound(Function.gSoundFail);
                sound.Play();

            }


            ScanFocus();

        }


        private void FuncBtnDisable()   //기능키 비활성화
        {
            btnSave.Enabled = false;
            btnExit.Enabled = false;
            btnInit.Enabled = false;
        }

        private void FuncBtnEnable()    //기능키 활성화
        {
            btnSave.Enabled = true;
            btnExit.Enabled = true;
            btnInit.Enabled = true;
        }

        #region 실적처리

        //Step.0: 이동버튼 클릭(입력정보 검증 및 저장)
        private void btnSave_Click(object sender, EventArgs e)
        {

            //FuncBtnDisable();   //기능키 비활성화

            //이동전 Location ID 가 입력되었나?
            //이동전 Location의 재고가 확인되었나?
            //이동전 Location의 이동재고수가 입력되었나?

            //if (sPreLoc != "")      //이동전 Location 입력이 없는경우, 이동전 Location의 재고정보를 조회
            //{                
            //    if (lstvMain.Items.Count > 0)       //조회된 내용이 있는경우
            //    {
            //        Int32 iQty = 0;
            //        Boolean bMovQtyChk = false;


            //        //이동재고수가 입력되었는지 확인
            //        for (int i = 0; i < lstvMain.Items.Count; i++)      //순차 적재처리
            //        {
            //            iQty = Convert.ToInt32(lstvMain.Items[i].SubItems[2].Text.ToString()); //QTY

            //            if (iQty > 0)
            //            {
            //                bMovQtyChk = true;
            //                break;
            //            }
            //        }

            //        if (bMovQtyChk == true) //이동재고수가 입력됨
            //        {

            //            if (sMovLoc == "")
            //            {
            //                txtMsg.Text = "이동할 Location ID 를 입력하세요";
            //                Function.Sound sound = new Function.Sound(Function.gSoundErr);
            //                sound.Play();                            
            //            }
            //            else
            //            {                          
            //                if (FuncSave() != true) //적재처리
            //                {
            //                    txtMsg.Text = "처리중 오류가 발생하였습니다";
            //                    Function.Sound sound = new Function.Sound(Function.gSoundFail);
            //                    sound.Play();
            //                }
            //                else
            //                {
            //                    InitFrm();  //폼 초기화

            //                    txtMsg.Text = "정상적으로 처리되었습니다";
            //                    Function.Sound sound = new Function.Sound(Function.gSoundGood);
            //                    sound.Play();
            //                }


            //            }
            //        }
            //        else
            //        {
            //            txtMsg.Text = "이동할 자재의 이동수량을 먼저 입력하세요";
            //            Function.Sound sound = new Function.Sound(Function.gSoundErr);
            //            sound.Play();
            //        }


            //    }
            //    else
            //    {
            //        txtMsg.Text = "이동할 재고정보가 없습니다";
            //        Function.Sound sound = new Function.Sound(Function.gSoundErr);
            //        sound.Play();
            //    }


            //}
            //else                    //이동전 Location 입력전
            //{
            //    txtMsg.Text = "이동할 자재의 Location ID 를 입력하세요";
            //    Function.Sound sound = new Function.Sound(Function.gSoundErr);
            //    sound.Play();
            //}           
        }

        //Step.1:저장실행
        private bool FuncSave()
        {
            string sFbarcode;
            string sSbarcode;
            string sQty;


            //txtMsg.Text = "이동처리중입니다";
            txtMsg.Text = "移动处理中";

            sPdaId = Convert.ToString(System.DateTime.Now.Year) +
                        Convert.ToString(System.DateTime.Now.Month) +
                        Convert.ToString(System.DateTime.Now.Day) +
                        Convert.ToString(System.DateTime.Now.Hour) +
                        Convert.ToString(System.DateTime.Now.Minute) +
                        Convert.ToString(System.DateTime.Now.Second) +
                        DYPIPDA.gsUserid.ToString();

            string sProc = "DUAL";
            sFbarcode = lblPreLoc.Text;
            sSbarcode = lblMovLoc.Text;

            try
            {
                //Que 테이블에 순서대로 insert 후 최종 적재처리 SP 실행
                //for (int i = 0; i < lstvMain.Items.Count; i++)      //순차 적재처리
                //{
                //    sMatcod = lstvMain.Items[i].SubItems[0].Text;            //MATCOD
                //    sQty = lstvMain.Items[i].SubItems[2].Text; //QTY

                //    if (Convert.ToInt32(sQty) > 0)      //이동수량이 입력된것만 처리
                //    {
                //        //QUE 저장: 작업구분,품번,PDAID, 이동수량
                //        if (MoveIn(sProc, sMatcod, sPdaId, sQty) != true) //처리실패
                //        {
                //            return false;
                //        }
                //    }
                //}


                if (MoveIn(sProc, sPdaId, sFbarcode, sSbarcode) != true) //처리실패
                {
                    return false;
                }
                else
                {
                    if (sFbarcode != sSbarcode)
                    {
                        //txtMsg.Text = "바코드가 잘못되었습니다.";
                        txtMsg.Text = "BARCODE不一致.";
                        txtMsg.ForeColor = Color.Blue;
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        sound.Play();
                    }
                    else
                    {
                        txtMsg.ForeColor = Color.Red;
                        //txtMsg.Text = "정상적으로 처리되었습니다.";
                        txtMsg.Text = "已正常处理完成.";
                        Function.Sound sound = new Function.Sound(Function.gSoundGood);
                        sound.Play();
                    }

                }

                if (SpCall(sProc, sPdaId) == true) //QUE SP 처리: 작업구분,품번, PDAID, 입고순번, 입고수량
                {
                    if (ChkQue(sProc, sPdaId) == true)    //QUE SP처리내역을 확인한다. 해당 PDAID 중 하나라도 처리되지 않으면 오류
                    {
                        return true;
                    }
                }

            }
            catch (System.SystemException ex)
            {
                return false;
            }

            return false;
        }

        //Step.2: 이동정보 Que 테이블(CW_PDAQUE) 저장 (MOVE)
        private bool MoveIn(string sProc, string sPdaId, string sFbarcode, string sSbarcode)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            Client = new TCPClient();

            string sService = "DUAL";

            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "INSERT");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);
                send.addData("PRC", sProc);
                send.addData("PDAID", sPdaId);
                send.addData("PRELOCID", sFbarcode);
                send.addData("MOVLOCID", sSbarcode);
                //send.addData("PDAID", sProcseq);


                //sProcSeq, sInseq, iQty

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
                        return false;
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
                        sRcvData = ReceiveMessage.data;

                        Client.StartConnection();

                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {
                                return true;
                            }
                        }
                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                        MessageBox.Show(Program.multlanguage.GetLanguage("Receiving from the server has been failed."));//lvwenting20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        //MessageBox.Show(ex.ToString());
                        sound.Play();
                        return false;
                    }

                }

            }
            else
            {
                Client.StopConnection(); Function.Sound sound = new Function.Sound(Function.gSoundFail);
                sound.Play();
                //MessageBox.Show("서버와 연결이 끊어졌습니다. 다시 연결을 시도해주세요!!!");
                 MessageBox.Show(Program.multlanguage.GetLanguage("Disconnected from the server! Try to connect again!!!"));//lvwenting 20240827
                return false;
            }

            return false;
        }


        //Step 3: 이동 Que 저장정보 일괄처리 SP 실행(INSPCALL)
        private bool SpCall(string sProc, string sPdaId)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            Client = new TCPClient();

            string sService = "DUALSPCALL";

            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "INSERT");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);
                send.addData("PRC", sProc);
                send.addData("PDAID", sPdaId);
                //send.addData("PDAID", sProcseq);


                //sProcSeq, sInseq, iQty

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
                        return false;
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
                        sRcvData = ReceiveMessage.data;

                        Client.StartConnection();

                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {
                                return true;
                            }
                        }
                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                        MessageBox.Show(Program.multlanguage.GetLanguage("Receiving from the server has been failed."));//lvwenting20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        //MessageBox.Show(ex.ToString());
                        sound.Play();
                        return false;
                    }

                }

            }
            else
            {
                Client.StopConnection(); Function.Sound sound = new Function.Sound(Function.gSoundFail);
                sound.Play();
                //MessageBox.Show("서버와 연결이 끊어졌습니다. 다시 연결을 시도해주세요!!!");
                 MessageBox.Show(Program.multlanguage.GetLanguage("Disconnected from the server! Try to connect again!!!"));//lvwenting 20240827
                return false;
            }

            return false;
        }

        //Step.4: Que SP 실행결과 조회(CHKQUE)
        private bool ChkQue(string sProc, string spdaid)
        {
            string sSndMsg = "";
            bool bSndOk = false;
            string sRcvMsg = "";
            string sRcvService = "";
            bool bRcvResult = false;
            string sRcvError = "";
            string[, ,] sRcvData = null;

            Client = new TCPClient();


            string sService = "CHKQUE";


            if (Client.StartConnection())
            {
                SendXML send = new SendXML();
                send.setService(sService, "SELECT");
                send.setRequestID(DYPIPDA.gsUserid);
                send.addData("USERID", DYPIPDA.gsUserid);
                send.addData("PLANT", ServerConfig.sPlant);
                send.addData("STL", ServerConfig.sStrLoc);
                send.addData("PROC", sProc);
                send.addData("PDAID", spdaid);

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
                        return false;
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
                        sRcvData = ReceiveMessage.data;

                        Client.StartConnection();

                        if (sRcvService == sService)
                        {
                            if (bRcvResult)     //처리결과확인
                            {
                                string sErrCnt;

                                sErrCnt = sRcvData[0, 0, 1];     //Err Counter

                                if (sErrCnt == "0")
                                {
                                    return true;
                                }

                            }

                        }

                    }
                    catch (System.SystemException ex)
                    {
                        Client.StopConnection();
                        //MessageBox.Show("서버에서 받기가 실패하였습니다!");
                        MessageBox.Show(Program.multlanguage.GetLanguage("Receiving from the server has been failed."));//lvwenting20240827
                        Function.Sound sound = new Function.Sound(Function.gSoundFail);
                        //MessageBox.Show(ex.ToString());
                        sound.Play();
                        return false;
                    }

                }

            }
            else
            {
                Client.StopConnection(); Function.Sound sound = new Function.Sound(Function.gSoundFail);
                sound.Play();
                //MessageBox.Show("서버와 연결이 끊어졌습니다. 다시 연결을 시도해주세요!!!");
                 MessageBox.Show(Program.multlanguage.GetLanguage("Disconnected from the server! Try to connect again!!!"));//lvwenting 20240827
                return false;
            }

            return false;

        }

        # endregion 실적처리

        //Keypad or Scan키입력 감시/처리
        private void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {

            string sKeyStr;

            try
            {
                sKeyStr = e.KeyChar.ToString();
                int a = Convert.ToInt32(Convert.ToChar(sKeyStr));

                if (a == 13)    //Enter 입력확인
                {
                    //ScanProc(txtScan.Text.ToString());
                    if (lblPreLoc.Text == "")
                        lblPreLoc.Text = txtScan.Text;
                    else
                    {
                        lblMovLoc.Text = txtScan.Text;

                        //저장처리 한다.
                        FuncBtnDisable();   //기능키 비활성화

                        if (FuncSave() == true) //적재처리
                        {
                            InitFrm();  //폼 초기화
                        }

                        FuncBtnEnable();   //기능키 활성화
                        ScanFocus();

                    }

                    ScanFocus();
                }
            }
            catch (Exception x)
            {
                //MessageBox.Show("오류:" + x.Message);
              MessageBox.Show("Error:" + x.Message); //20240827
                ScanFocus();
            }

        }

    }

}