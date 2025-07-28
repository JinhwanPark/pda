using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HS_ScanQC
{
    public partial class FM_Login : Form
    {
        TCPClient Client;
        ClientConfig ClientConfig = new ClientConfig();
        private System.Windows.Forms.TextBox TB_UserID;
        bool isOK = false;

        public FM_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TB_UserID.Text.Trim().ToString() == "")
            {
                MessageBox.Show("����� ID�� �Է��ϼ���");
                TB_UserID.Focus();
                return;
            }
            else
            {
                if (ServerConfig.ServerIP == "" || ServerConfig.ServerPort == 0)
                {
                    MessageBox.Show("ȯ�漳������ ���� ���� IP �� ���� PORT�� �Է��Ͽ� �ּ���");
                    return;
                }
                else
                {
                    //PN_MenuProgress.Visible = true;
                    ClientRequest("1");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel the read 
            Scanning.StopRead();

            // Exit this form
            this.Close();
        }

        private void BT_Menu_Click(object sender, EventArgs e)
        {
            // Cancel the read 
            Scanning.StopRead();

            // Exit this form
            this.Close();

        }

        //���� ����Ÿ ���
        private void ClientRequest(string sect)
        {
            //�α��� üũ
            if (sect == "1")
            {
                string m_sendmessage = "";
                bool isSendOK = false;

                string m_receivemessage = "";
                string m_service = "";
                bool m_result = false;
                string m_error = "";
                string[, ,] m_data = null;

                string m_userid = "";
                string m_username = "";

                Client = new TCPClient();
                if (Client.StartConnection())
                {
                    SendXML send = new SendXML();
                    send.setService("LOGIN", "SELECT");
                    m_userid = TB_UserID.Text.Trim().ToString();
                    send.setRequestID(TB_UserID.Text.Trim().ToString());
                    send.addData("USERID", TB_UserID.Text.Trim().ToString());
                    m_sendmessage = send.sendMessage();

                    //SEND TO SERVER
                    if (m_sendmessage != "")
                    {
                        try
                        {
                            Client.Send(m_sendmessage);
                            isSendOK = true;
                        }
                        catch (Exception e)
                        {
                            //Client.StopConnection();
                            //PN_MenuProgress.Visible = false;
                            MessageBox.Show(e + ":" + "������ �����Ⱑ �����Ͽ����ϴ�!");
                            return;
                        }
                    }

                    //RECEIVE FROM SERVER
                    if (isSendOK)
                    {
                        try
                        {
                            m_receivemessage = Client.Receive();
                            ReceiveXML read = new ReceiveXML(m_receivemessage);
                            read.ReadXML();

                            ReceiveMessage receive = new ReceiveMessage();
                            m_service = ReceiveMessage.service;
                            m_result = ReceiveMessage.result;
                            m_error = ReceiveMessage.error;
                            m_data = ReceiveMessage.data;

                            Client.StartConnection();

                            if (m_service == "LOGIN")
                            {
                                if (m_result)
                                {
                                    m_username = m_data[0, 0, 1];

                                    ClientConfig = new ClientConfig();
                                    ClientConfig.userid = m_userid;
                                    ClientConfig.username = m_data[0, 0, 1];
                                    isOK = true;

                                    if (isOK)
                                    {

                                        //ClientRequest("2");
                                        //ClientRequest("3");
                                        //ClientRequest("4");

                                        // Cancel the read 
                                        Scanning.StopRead();

                                        // Exit this form
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    //PN_MenuProgress.Visible = false;
                                    MessageBox.Show("����� ID�� ��Ȯ���� �ʽ��ϴ�. !");
                                    TB_UserID.Focus();
                                    return;
                                }
                                //PN_MenuProgress.Visible = false;
                            }
                        }
                        catch (System.SystemException ex)
                        {
                            MessageBox.Show(ex.ToString());
                            Client.StopConnection();
                            //PN_MenuProgress.Visible = false;
                            MessageBox.Show("�������� �ޱⰡ �����Ͽ����ϴ�!");
                            return;
                        }
                    }
                }
                else
                {
                    Client.StopConnection();
                    //PN_MenuProgress.Visible = false;
                    MessageBox.Show("������ ������ ���������ϴ�. �ٽ� ������ �õ����ּ���!!!");
                    return;
                }
            }

            //�ҷ����� ��ȸ
            if (sect == "2")
            {
                string m_sendmessage = "";
                bool isSendOK = false;

                string m_receivemessage = "";
                string m_service = "";
                bool m_result = false;
                string m_error = "";
                string[, ,] m_data = null;

                Client = new TCPClient();
                if (Client.StartConnection())
                {
                    SendXML send = new SendXML();
                    send.setService("ERRDESC", "MULTI");
                    send.setRequestID(ClientConfig.userid);
                    send.addData("CODE", "P01");
                    m_sendmessage = send.sendMessage();

                    //SEND TO SERVER
                    if (m_sendmessage != "")
                    {
                        try
                        {
                            Client.Send(m_sendmessage);
                            isSendOK = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e + ":" + "������ �����Ⱑ �����Ͽ����ϴ�!");
                            return;
                        }
                    }

                    //RECEIVE FROM SERVER
                    if (isSendOK)
                    {
                        try
                        {
                            m_receivemessage = Client.Receive();
                            ReceiveXML read = new ReceiveXML(m_receivemessage);
                            read.ReadXML();

                            ReceiveMessage receive = new ReceiveMessage();
                            m_service = ReceiveMessage.service;
                            m_result = ReceiveMessage.result;
                            m_error = ReceiveMessage.error;
                            m_data = ReceiveMessage.data;

                            Client.StopConnection();
                            if (m_data.ToString() != "")
                            {
                                if (m_service == "ERRDESC")
                                {
                                    if (m_result)
                                    {
                                        if (ReceiveMessage.rowcnt == 0)
                                        {
                                            MessageBox.Show("�ҷ����ο� ���� �׸��� �������� �ʽ��ϴ�.!");
                                            return;

                                        }
                                        else
                                        {
                                            CodeConfig.m_errdesc = new String[ReceiveMessage.rowcnt, ReceiveMessage.colcnt];
                                            CodeConfig.m_errdesc_row = ReceiveMessage.rowcnt;
                                            for (int i = 0; i < ReceiveMessage.rowcnt; i++)
                                            {
                                                for (int j = 0; j < ReceiveMessage.colcnt; j++)
                                                {
                                                    CodeConfig.m_errdesc[i, j] = m_data[i, j, 1];
                                                    CodeConfig.m_errdesc[i, j + 1] = m_data[i, j + 1, 1];
                                                    j = j + 1;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("�ҷ����ο� ���� �׸��� �������� �ʽ��ϴ�.!");
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("�ҷ����ο� ���� �׸��� �������� �ʽ��ϴ�.!");
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            Client.StopConnection();
                            return;
                        }
                    }
                }
                else
                {
                    Client.StopConnection();
                    MessageBox.Show("�ҷ����ο� ���� �׸��� �������� �ʽ��ϴ�.!");
                    return;
                }
            }

            //�ҷ���ġ ��ȸ
            if (sect == "3")
            {
                string m_sendmessage = "";
                bool isSendOK = false;

                string m_receivemessage = "";
                string m_service = "";
                bool m_result = false;
                string m_error = "";
                string[, ,] m_data = null;

                Client = new TCPClient();
                if (Client.StartConnection())
                {
                    SendXML send = new SendXML();
                    send.setService("ERRPROC", "MULTI");
                    send.setRequestID(ClientConfig.userid);
                    send.addData("CODE", "P03");
                    m_sendmessage = send.sendMessage();

                    //SEND TO SERVER
                    if (m_sendmessage != "")
                    {
                        try
                        {
                            Client.Send(m_sendmessage);
                            isSendOK = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e + ":" + "������ �����Ⱑ �����Ͽ����ϴ�!");
                            return;
                        }
                    }

                    //RECEIVE FROM SERVER
                    if (isSendOK)
                    {
                        try
                        {
                            m_receivemessage = Client.Receive();
                            ReceiveXML read = new ReceiveXML(m_receivemessage);
                            read.ReadXML();

                            ReceiveMessage receive = new ReceiveMessage();
                            m_service = ReceiveMessage.service;
                            m_result = ReceiveMessage.result;
                            m_error = ReceiveMessage.error;
                            m_data = ReceiveMessage.data;

                            Client.StopConnection();
                            if (m_data.ToString() != "")
                            {
                                if (m_service == "ERRPROC")
                                {
                                    if (m_result)
                                    {
                                        if (ReceiveMessage.rowcnt == 0)
                                        {
                                            MessageBox.Show("�ҷ���ġ�� ���� �׸��� �������� �ʽ��ϴ�.!");
                                            return;

                                        }
                                        else
                                        {
                                            CodeConfig.m_errproc = new String[ReceiveMessage.rowcnt, ReceiveMessage.colcnt];
                                            CodeConfig.m_errproc_row = ReceiveMessage.rowcnt;
                                            for (int i = 0; i < ReceiveMessage.rowcnt; i++)
                                            {
                                                for (int j = 0; j < ReceiveMessage.colcnt; j++)
                                                {
                                                    CodeConfig.m_errproc[i, j] = m_data[i, j, 1];
                                                    CodeConfig.m_errproc[i, j + 1] = m_data[i, j + 1, 1];
                                                    j = j + 1;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("�ҷ���ġ�� ���� �׸��� �������� �ʽ��ϴ�.!");
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("�ҷ���ġ�� ���� �׸��� �������� �ʽ��ϴ�.!");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                    }
                }
                else
                {
                    Client.StopConnection();
                    MessageBox.Show("�ҷ����ο� ���� �׸��� �������� �ʽ��ϴ�.!");
                    return;
                }
            }
            //��åó ��ȸ
            if (sect == "4")
            {
                string m_sendmessage = "";
                bool isSendOK = false;

                string m_receivemessage = "";
                string m_service = "";
                bool m_result = false;
                string m_error = "";
                string[, ,] m_data = null;

                Client = new TCPClient();
                if (Client.StartConnection())
                {
                    SendXML send = new SendXML();
                    send.setService("VENDCODE", "MULTI");
                    send.setRequestID(ClientConfig.userid);
                    m_sendmessage = send.sendMessage();

                    //SEND TO SERVER
                    if (m_sendmessage != "")
                    {
                        try
                        {
                            Client.Send(m_sendmessage);
                            isSendOK = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e + ":" + "������ �����Ⱑ �����Ͽ����ϴ�!");
                            return;
                        }
                    }

                    //RECEIVE FROM SERVER
                    if (isSendOK)
                    {
                        try
                        {
                            m_receivemessage = Client.Receive();
                            ReceiveXML read = new ReceiveXML(m_receivemessage);
                            read.ReadXML();

                            ReceiveMessage receive = new ReceiveMessage();
                            m_service = ReceiveMessage.service;
                            m_result = ReceiveMessage.result;
                            m_error = ReceiveMessage.error;
                            m_data = ReceiveMessage.data;

                            Client.StopConnection();
                            if (m_data.ToString() != "")
                            {
                                if (m_service == "VENDCODE")
                                {
                                    if (m_result)
                                    {
                                        if (ReceiveMessage.rowcnt == 0)
                                        {
                                            MessageBox.Show("��åó�� ���� �׸��� �������� �ʽ��ϴ�.!");
                                            return;

                                        }
                                        else
                                        {
                                            CodeConfig.m_vendcode = new String[ReceiveMessage.rowcnt, ReceiveMessage.colcnt];
                                            CodeConfig.m_vendcode_row = ReceiveMessage.rowcnt;
                                            for (int i = 0; i < ReceiveMessage.rowcnt; i++)
                                            {
                                                for (int j = 0; j < ReceiveMessage.colcnt; j++)
                                                {
                                                    CodeConfig.m_vendcode[i, j] = m_data[i, j, 1];
                                                    CodeConfig.m_vendcode[i, j + 1] = m_data[i, j + 1, 1];
                                                    j = j + 1;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("��åó�� ���� �׸��� �������� �ʽ��ϴ�.!");
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("��åó�� ���� �׸��� �������� �ʽ��ϴ�.!");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            return;
                        }
                    }
                }
                else
                {
                    Client.StopConnection();
                    MessageBox.Show("��åó�� ���� �׸��� �������� �ʽ��ϴ�.!");
                    return;
                }
            }
        }

        private void FM_Login_Load(object sender, EventArgs e)
        {

        }
    }
}