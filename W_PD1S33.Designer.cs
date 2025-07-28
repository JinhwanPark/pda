namespace DYPI_WMS_PDA
{
    partial class W_PD1S33
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1S33));
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkY01 = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.columnHeader0 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lstvMain = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnAll = new System.Windows.Forms.Button();
            this.plnInput = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblOutDes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.butPrtChk = new System.Windows.Forms.Button();
            this.lblOutQty = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMatcod = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.plnInput.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(83, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Print";
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
            this.label1.Text = "Issue Idn\' Label";
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
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.chkY01);
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 82);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(34, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.Text = ":All Worker";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(144, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.Text = ":Subcontracting GI";
            // 
            // chkY01
            // 
            this.chkY01.Location = new System.Drawing.Point(121, 27);
            this.chkY01.Name = "chkY01";
            this.chkY01.Size = new System.Drawing.Size(25, 19);
            this.chkY01.TabIndex = 45;
            this.chkY01.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // chkAll
            // 
            this.chkAll.Location = new System.Drawing.Point(12, 27);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(25, 19);
            this.chkAll.TabIndex = 38;
            this.chkAll.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInit.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnInit.Location = new System.Drawing.Point(176, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(61, 22);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Initialize";
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(66, 325);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 23);
            this.txtScan.TabIndex = 25;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Moccasin;
            this.txtMsg.Location = new System.Drawing.Point(0, 249);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(240, 39);
            this.txtMsg.TabIndex = 19;
            this.txtMsg.Text = "Release is complete.";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(154, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "PO";
            this.columnHeader0.Width = 92;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Material number";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Issue";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Print";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Supplying S/L";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Material name";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PO";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "GI Order";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "GI time";
            this.columnHeader8.Width = 200;
            // 
            // lstvMain
            // 
            this.lstvMain.Columns.Add(this.columnHeader1);
            this.lstvMain.Columns.Add(this.columnHeader5);
            this.lstvMain.Columns.Add(this.columnHeader2);
            this.lstvMain.Columns.Add(this.columnHeader3);
            this.lstvMain.Columns.Add(this.columnHeader4);
            this.lstvMain.Columns.Add(this.columnHeader0);
            this.lstvMain.Columns.Add(this.columnHeader6);
            this.lstvMain.Columns.Add(this.columnHeader7);
            this.lstvMain.Columns.Add(this.columnHeader8);
            this.lstvMain.Columns.Add(this.columnHeader9);
            listViewItem1.Text = "002000000010";
            listViewItem1.SubItems.Add("H70038700");
            listViewItem1.SubItems.Add("DUST COVER_W18.2W40.5D9");
            listViewItem1.SubItems.Add("200");
            listViewItem1.SubItems.Add("100");
            listViewItem1.SubItems.Add("E25");
            listViewItem1.SubItems.Add("002100000001");
            listViewItem1.SubItems.Add("0000000001");
            this.lstvMain.Items.Add(listViewItem1);
            this.lstvMain.Location = new System.Drawing.Point(0, 77);
            this.lstvMain.Name = "lstvMain";
            this.lstvMain.Size = new System.Drawing.Size(240, 172);
            this.lstvMain.TabIndex = 12;
            this.lstvMain.View = System.Windows.Forms.View.Details;
            this.lstvMain.SelectedIndexChanged += new System.EventHandler(this.lstvMain_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SEQ";
            this.columnHeader9.Width = 40;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAll.Location = new System.Drawing.Point(0, 287);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(86, 32);
            this.btnAll.TabIndex = 50;
            this.btnAll.Text = "Total";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // plnInput
            // 
            this.plnInput.BackColor = System.Drawing.Color.Lime;
            this.plnInput.Controls.Add(this.txtQty);
            this.plnInput.Controls.Add(this.lblOutDes);
            this.plnInput.Controls.Add(this.label6);
            this.plnInput.Controls.Add(this.btnCancel);
            this.plnInput.Controls.Add(this.butPrtChk);
            this.plnInput.Controls.Add(this.lblOutQty);
            this.plnInput.Controls.Add(this.label13);
            this.plnInput.Controls.Add(this.label12);
            this.plnInput.Controls.Add(this.lblMatcod);
            this.plnInput.Controls.Add(this.label10);
            this.plnInput.Controls.Add(this.label9);
            this.plnInput.Location = new System.Drawing.Point(245, 77);
            this.plnInput.Name = "plnInput";
            this.plnInput.Size = new System.Drawing.Size(240, 174);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtQty.Location = new System.Drawing.Point(125, 87);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(66, 29);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "100";
            // 
            // lblOutDes
            // 
            this.lblOutDes.Location = new System.Drawing.Point(103, 67);
            this.lblOutDes.Name = "lblOutDes";
            this.lblOutDes.Size = new System.Drawing.Size(134, 21);
            this.lblOutDes.Text = "E25";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.Text = "Supplying S/L:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(120, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // butPrtChk
            // 
            this.butPrtChk.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butPrtChk.Location = new System.Drawing.Point(1, 119);
            this.butPrtChk.Name = "butPrtChk";
            this.butPrtChk.Size = new System.Drawing.Size(120, 32);
            this.butPrtChk.TabIndex = 16;
            this.butPrtChk.Text = "Print";
            this.butPrtChk.Click += new System.EventHandler(this.butPrtChk_Click);
            // 
            // lblOutQty
            // 
            this.lblOutQty.Location = new System.Drawing.Point(72, 46);
            this.lblOutQty.Name = "lblOutQty";
            this.lblOutQty.Size = new System.Drawing.Size(119, 21);
            this.lblOutQty.Text = "200";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(15, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 21);
            this.label13.Text = "Print qty:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 21);
            this.label12.Text = "GI qty:";
            // 
            // lblMatcod
            // 
            this.lblMatcod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatcod.ForeColor = System.Drawing.Color.Red;
            this.lblMatcod.Location = new System.Drawing.Point(58, 25);
            this.lblMatcod.Name = "lblMatcod";
            this.lblMatcod.Size = new System.Drawing.Size(95, 21);
            this.lblMatcod.Text = "H70038700";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(15, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.Text = "ITEM:";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 21);
            this.label9.Text = "Please input the print quantity.";
            // 
            // W_PD1S33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.plnInput);
            this.Controls.Add(this.lstvMain);
            this.Controls.Add(this.btnAll);
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
            this.Name = "W_PD1S33";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1S33_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.plnInput.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lstvMain;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.CheckBox chkY01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel plnInput;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblOutDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button butPrtChk;
        private System.Windows.Forms.Label lblOutQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMatcod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        
    }
}