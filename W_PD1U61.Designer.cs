namespace DYPI_WMS_PDA
{
    partial class W_PD1U61
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu MainMenu;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1U61));
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEXEC_QTY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpday = new System.Windows.Forms.DateTimePicker();
            this.lblREMAINDER_QTY = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPLAN_QTY = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDATE_SPLAN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAufnr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.lblWC_DESC = new System.Windows.Forms.Label();
            this.lblMatcod = new System.Windows.Forms.Label();
            this.lblMatnam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblScanBarCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.Add(this.menuItem1);
            this.MainMenu.MenuItems.Add(this.menuItem2);
            this.MainMenu.MenuItems.Add(this.menuItem3);
            this.MainMenu.MenuItems.Add(this.menuItem4);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "입고";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "이동";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "출고";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "기타";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(0, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保    存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.Text = "S/K 实绩登录";
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblUser.Location = new System.Drawing.Point(154, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 22);
            this.lblUser.Text = "User: 김진춘";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 25);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtEXEC_QTY);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpday);
            this.panel2.Controls.Add(this.lblREMAINDER_QTY);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblPLAN_QTY);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblDATE_SPLAN);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblAufnr);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblRegUser);
            this.panel2.Controls.Add(this.lblWC_DESC);
            this.panel2.Controls.Add(this.lblMatcod);
            this.panel2.Controls.Add(this.lblMatnam);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 193);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(97, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 17);
            this.label13.Text = "ea";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(7, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.Text = "实绩残量:";
            // 
            // txtEXEC_QTY
            // 
            this.txtEXEC_QTY.Location = new System.Drawing.Point(181, 93);
            this.txtEXEC_QTY.Name = "txtEXEC_QTY";
            this.txtEXEC_QTY.Size = new System.Drawing.Size(36, 23);
            this.txtEXEC_QTY.TabIndex = 54;
            this.txtEXEC_QTY.Text = "000";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(218, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.Text = "ea";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(97, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.Text = "ea";
            // 
            // dtpday
            // 
            this.dtpday.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.dtpday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpday.Location = new System.Drawing.Point(69, 168);
            this.dtpday.Name = "dtpday";
            this.dtpday.Size = new System.Drawing.Size(97, 22);
            this.dtpday.TabIndex = 32;
            // 
            // lblREMAINDER_QTY
            // 
            this.lblREMAINDER_QTY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblREMAINDER_QTY.ForeColor = System.Drawing.Color.Red;
            this.lblREMAINDER_QTY.Location = new System.Drawing.Point(69, 112);
            this.lblREMAINDER_QTY.Name = "lblREMAINDER_QTY";
            this.lblREMAINDER_QTY.Size = new System.Drawing.Size(29, 17);
            this.lblREMAINDER_QTY.Text = "000";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label14.Location = new System.Drawing.Point(118, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.Text = "实绩数量:";
            // 
            // lblPLAN_QTY
            // 
            this.lblPLAN_QTY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPLAN_QTY.ForeColor = System.Drawing.Color.Blue;
            this.lblPLAN_QTY.Location = new System.Drawing.Point(69, 96);
            this.lblPLAN_QTY.Name = "lblPLAN_QTY";
            this.lblPLAN_QTY.Size = new System.Drawing.Size(29, 17);
            this.lblPLAN_QTY.Text = "000";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(7, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.Text = "计划数量:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(7, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.Text = "实绩日期:";
            // 
            // lblDATE_SPLAN
            // 
            this.lblDATE_SPLAN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblDATE_SPLAN.Location = new System.Drawing.Point(69, 150);
            this.lblDATE_SPLAN.Name = "lblDATE_SPLAN";
            this.lblDATE_SPLAN.Size = new System.Drawing.Size(166, 16);
            this.lblDATE_SPLAN.Text = "20140501";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(7, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.Text = "计划日期:";
            // 
            // lblAufnr
            // 
            this.lblAufnr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblAufnr.Location = new System.Drawing.Point(69, 7);
            this.lblAufnr.Name = "lblAufnr";
            this.lblAufnr.Size = new System.Drawing.Size(87, 16);
            this.lblAufnr.Text = "01100123456";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.Text = "作业指示:";
            // 
            // lblRegUser
            // 
            this.lblRegUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblRegUser.Location = new System.Drawing.Point(59, 130);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(176, 16);
            this.lblRegUser.Text = "99999 (洪吉童)";
            // 
            // lblWC_DESC
            // 
            this.lblWC_DESC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblWC_DESC.Location = new System.Drawing.Point(86, 77);
            this.lblWC_DESC.Name = "lblWC_DESC";
            this.lblWC_DESC.Size = new System.Drawing.Size(149, 16);
            this.lblWC_DESC.Text = "P070 (SEAL KITTING)";
            // 
            // lblMatcod
            // 
            this.lblMatcod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatcod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(192)))));
            this.lblMatcod.Location = new System.Drawing.Point(41, 26);
            this.lblMatcod.Name = "lblMatcod";
            this.lblMatcod.Size = new System.Drawing.Size(95, 16);
            this.lblMatcod.Text = "H70038700";
            // 
            // lblMatnam
            // 
            this.lblMatnam.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblMatnam.Location = new System.Drawing.Point(41, 46);
            this.lblMatnam.Name = "lblMatnam";
            this.lblMatnam.Size = new System.Drawing.Size(194, 26);
            this.lblMatnam.Text = "DUST COVER_W18.2W40.5D9 DUST COVER_W18.2W40.5D9";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.Text = "Work Center:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(7, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.Text = "登录者:";
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInit.Location = new System.Drawing.Point(174, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(65, 24);
            this.btnInit.TabIndex = 3;
            this.btnInit.Text = "Initialize";
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.Text = "品名:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.Text = "品号:";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(41, 325);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(127, 23);
            this.txtScan.TabIndex = 23;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Moccasin;
            this.txtMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.txtMsg.Location = new System.Drawing.Point(0, 249);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.Size = new System.Drawing.Size(240, 37);
            this.txtMsg.TabIndex = 19;
            this.txtMsg.Text = "保存完成.";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(120, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel5.Controls.Add(this.lblScanBarCode);
            this.panel5.Location = new System.Drawing.Point(0, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 28);
            // 
            // lblScanBarCode
            // 
            this.lblScanBarCode.BackColor = System.Drawing.Color.Khaki;
            this.lblScanBarCode.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblScanBarCode.ForeColor = System.Drawing.Color.Blue;
            this.lblScanBarCode.Location = new System.Drawing.Point(3, 2);
            this.lblScanBarCode.Name = "lblScanBarCode";
            this.lblScanBarCode.Size = new System.Drawing.Size(234, 24);
            this.lblScanBarCode.Text = "作业指示编号";
            this.lblScanBarCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // W_PD1U61
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1U61";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1U61_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblScanBarCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatnam;
        private System.Windows.Forms.Label lblMatcod;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.Label lblWC_DESC;
        private System.Windows.Forms.Label lblAufnr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblREMAINDER_QTY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPLAN_QTY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDATE_SPLAN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEXEC_QTY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}