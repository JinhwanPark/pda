namespace DYPI_WMS_PDA
{
    partial class W_PD1S34
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1S34));
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.btnPreout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPodel = new System.Windows.Forms.Button();
            this.txtPono = new System.Windows.Forms.TextBox();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOutday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstvMain = new System.Windows.Forms.ListView();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.btnPreoutdsc = new System.Windows.Forms.Button();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.lstvDetail = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // btnPreout
            // 
            this.btnPreout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreout.Location = new System.Drawing.Point(0, 287);
            this.btnPreout.Name = "btnPreout";
            this.btnPreout.Size = new System.Drawing.Size(80, 32);
            this.btnPreout.TabIndex = 3;
            this.btnPreout.Text = "Display";
            this.btnPreout.Click += new System.EventHandler(this.btnPreout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.Text = "Good Issue Display";
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
            this.panel2.Controls.Add(this.btnPodel);
            this.panel2.Controls.Add(this.txtPono);
            this.panel2.Controls.Add(this.cboLine);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpOutday);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 64);
            // 
            // btnPodel
            // 
            this.btnPodel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPodel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnPodel.Location = new System.Drawing.Point(151, 3);
            this.btnPodel.Name = "btnPodel";
            this.btnPodel.Size = new System.Drawing.Size(21, 22);
            this.btnPodel.TabIndex = 50;
            this.btnPodel.Text = "◀";
            this.btnPodel.Click += new System.EventHandler(this.btnPodel_Click);
            // 
            // txtPono
            // 
            this.txtPono.Location = new System.Drawing.Point(39, 3);
            this.txtPono.Name = "txtPono";
            this.txtPono.Size = new System.Drawing.Size(111, 23);
            this.txtPono.TabIndex = 40;
            // 
            // cboLine
            // 
            this.cboLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLine.Location = new System.Drawing.Point(148, 30);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(89, 23);
            this.cboLine.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(108, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.Text = "LINE:";
            // 
            // dtpOutday
            // 
            this.dtpOutday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOutday.Location = new System.Drawing.Point(5, 31);
            this.dtpOutday.Name = "dtpOutday";
            this.dtpOutday.Size = new System.Drawing.Size(92, 24);
            this.dtpOutday.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.Text = "PO:";
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInit.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnInit.Location = new System.Drawing.Point(180, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(57, 22);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Initialize";
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Moccasin;
            this.txtMsg.Location = new System.Drawing.Point(0, 249);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(240, 39);
            this.txtMsg.TabIndex = 19;
            this.txtMsg.Text = "GI complete.";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(160, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstvMain
            // 
            this.lstvMain.Columns.Add(this.columnHeader14);
            this.lstvMain.Columns.Add(this.columnHeader15);
            this.lstvMain.Columns.Add(this.columnHeader16);
            this.lstvMain.Columns.Add(this.columnHeader17);
            this.lstvMain.Columns.Add(this.columnHeader18);
            this.lstvMain.FullRowSelect = true;
            listViewItem1.Text = "002100080584";
            listViewItem1.SubItems.Add("E25");
            listViewItem1.SubItems.Add("50%");
            listViewItem1.SubItems.Add("광덕산업");
            listViewItem1.SubItems.Add("000000000001");
            listViewItem2.Text = "";
            listViewItem3.Text = "";
            listViewItem4.Text = "";
            this.lstvMain.Items.Add(listViewItem1);
            this.lstvMain.Items.Add(listViewItem2);
            this.lstvMain.Items.Add(listViewItem3);
            this.lstvMain.Items.Add(listViewItem4);
            this.lstvMain.Location = new System.Drawing.Point(0, 84);
            this.lstvMain.Name = "lstvMain";
            this.lstvMain.Size = new System.Drawing.Size(240, 166);
            this.lstvMain.TabIndex = 29;
            this.lstvMain.View = System.Windows.Forms.View.Details;
            this.lstvMain.SelectedIndexChanged += new System.EventHandler(this.lstvMain_SelectedIndexChanged);
            this.lstvMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstvMain_ColumnClick);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "PO";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "LINE";
            this.columnHeader15.Width = 60;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Progress Rate";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 70;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Supplying S/L";
            this.columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "PONO";
            this.columnHeader18.Width = 0;
            // 
            // btnPreoutdsc
            // 
            this.btnPreoutdsc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreoutdsc.Location = new System.Drawing.Point(80, 287);
            this.btnPreoutdsc.Name = "btnPreoutdsc";
            this.btnPreoutdsc.Size = new System.Drawing.Size(80, 32);
            this.btnPreoutdsc.TabIndex = 36;
            this.btnPreoutdsc.Text = "Details";
            this.btnPreoutdsc.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(57, 325);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 23);
            this.txtScan.TabIndex = 40;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // lstvDetail
            // 
            this.lstvDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lstvDetail.Columns.Add(this.columnHeader7);
            this.lstvDetail.Columns.Add(this.columnHeader8);
            this.lstvDetail.Columns.Add(this.columnHeader9);
            this.lstvDetail.Columns.Add(this.columnHeader10);
            this.lstvDetail.Columns.Add(this.columnHeader11);
            this.lstvDetail.Columns.Add(this.columnHeader12);
            this.lstvDetail.Columns.Add(this.columnHeader13);
            this.lstvDetail.ForeColor = System.Drawing.Color.Black;
            this.lstvDetail.FullRowSelect = true;
            listViewItem5.Text = "01-01-05";
            listViewItem5.SubItems.Add("H70038700");
            listViewItem5.SubItems.Add("200");
            listViewItem5.SubItems.Add("100");
            listViewItem5.SubItems.Add("DUST COVER_W18.2W40.5D9");
            listViewItem5.SubItems.Add("2");
            listViewItem5.SubItems.Add("311");
            listViewItem6.Text = "02-03-05";
            listViewItem6.SubItems.Add("H70038300");
            listViewItem6.SubItems.Add("5");
            listViewItem6.SubItems.Add("5");
            listViewItem6.SubItems.Add("DUST COVER_19W33D10");
            listViewItem6.SubItems.Add("2");
            listViewItem6.SubItems.Add("311");
            listViewItem7.Text = "02-05-01";
            listViewItem7.SubItems.Add("H70038400");
            listViewItem7.SubItems.Add("30");
            listViewItem7.SubItems.Add("");
            listViewItem7.SubItems.Add("DUST COVER_W20.6W33.1D12");
            listViewItem7.SubItems.Add("02");
            listViewItem7.SubItems.Add("311");
            listViewItem8.Text = "02-05-05";
            listViewItem8.SubItems.Add("H70037500");
            listViewItem8.SubItems.Add("200");
            listViewItem8.SubItems.Add("");
            listViewItem8.SubItems.Add("DUST COVER_W22.2W47.6D12");
            listViewItem8.SubItems.Add("2");
            listViewItem8.SubItems.Add("311");
            this.lstvDetail.Items.Add(listViewItem5);
            this.lstvDetail.Items.Add(listViewItem6);
            this.lstvDetail.Items.Add(listViewItem7);
            this.lstvDetail.Items.Add(listViewItem8);
            this.lstvDetail.Location = new System.Drawing.Point(137, 84);
            this.lstvDetail.Name = "lstvDetail";
            this.lstvDetail.Size = new System.Drawing.Size(240, 166);
            this.lstvDetail.TabIndex = 46;
            this.lstvDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "LOC ID";
            this.columnHeader7.Width = 60;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Material Number";
            this.columnHeader8.Width = 84;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Picking";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 38;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "GI";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 38;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Material Name";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "GI Order";
            this.columnHeader12.Width = 82;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "MT";
            this.columnHeader13.Width = 113;
            // 
            // W_PD1S34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 769);
            this.ControlBox = false;
            this.Controls.Add(this.lstvDetail);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPreoutdsc);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnPreout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstvMain);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1S34";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1S34_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Button btnPreout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.ListView lstvMain;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOutday;
        private System.Windows.Forms.Button btnPreoutdsc;
        private System.Windows.Forms.TextBox txtPono;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.ListView lstvDetail;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btnPodel;
        
    }
}