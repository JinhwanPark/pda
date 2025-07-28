namespace DYPI_WMS_PDA
{
    partial class W_PD1U32
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1U32));
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.plnInput = new System.Windows.Forms.Panel();
            this.lblMatnam = new System.Windows.Forms.Label();
            this.txtOutqty = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPono = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblLocid = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOderqty = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMatcod = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.lstvDetail = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.btnAll = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.Text = "GI processing";
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
            this.panel2.Controls.Add(this.txtScan);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 64);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(65, 3);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(105, 23);
            this.txtScan.TabIndex = 40;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
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
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Moccasin;
            this.txtMsg.Location = new System.Drawing.Point(0, 249);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(240, 39);
            this.txtMsg.TabIndex = 19;
            this.txtMsg.Text = "GI has been completed.";
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
            // plnInput
            // 
            this.plnInput.BackColor = System.Drawing.Color.Lime;
            this.plnInput.Controls.Add(this.lblMatnam);
            this.plnInput.Controls.Add(this.txtOutqty);
            this.plnInput.Controls.Add(this.btnSave);
            this.plnInput.Controls.Add(this.lblLine);
            this.plnInput.Controls.Add(this.label23);
            this.plnInput.Controls.Add(this.lblPono);
            this.plnInput.Controls.Add(this.label17);
            this.plnInput.Controls.Add(this.lblLocid);
            this.plnInput.Controls.Add(this.label12);
            this.plnInput.Controls.Add(this.label18);
            this.plnInput.Controls.Add(this.label16);
            this.plnInput.Controls.Add(this.btnCancel);
            this.plnInput.Controls.Add(this.lblOderqty);
            this.plnInput.Controls.Add(this.label13);
            this.plnInput.Controls.Add(this.lblMatcod);
            this.plnInput.Controls.Add(this.label10);
            this.plnInput.Controls.Add(this.label9);
            this.plnInput.Location = new System.Drawing.Point(242, 56);
            this.plnInput.Name = "plnInput";
            this.plnInput.Size = new System.Drawing.Size(240, 194);
            // 
            // lblMatnam
            // 
            this.lblMatnam.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblMatnam.Location = new System.Drawing.Point(43, 42);
            this.lblMatnam.Name = "lblMatnam";
            this.lblMatnam.Size = new System.Drawing.Size(191, 29);
            this.lblMatnam.Text = "DUST COVER_W18.2W40.5D9 DUST COVER_W18.2W40.5D9";
            // 
            // txtOutqty
            // 
            this.txtOutqty.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtOutqty.Location = new System.Drawing.Point(171, 100);
            this.txtOutqty.Name = "txtOutqty";
            this.txtOutqty.Size = new System.Drawing.Size(66, 29);
            this.txtOutqty.TabIndex = 2;
            this.txtOutqty.Text = "100";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(0, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLine
            // 
            this.lblLine.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(192)))));
            this.lblLine.Location = new System.Drawing.Point(47, 114);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(38, 21);
            this.lblLine.Text = "E25";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label23.Location = new System.Drawing.Point(4, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 21);
            this.label23.Text = "LINE:";
            // 
            // lblPono
            // 
            this.lblPono.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblPono.Location = new System.Drawing.Point(52, 94);
            this.lblPono.Name = "lblPono";
            this.lblPono.Size = new System.Drawing.Size(99, 21);
            this.lblPono.Text = "2100080584";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label17.Location = new System.Drawing.Point(3, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 21);
            this.label17.Text = "PO:";
            // 
            // lblLocid
            // 
            this.lblLocid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblLocid.Location = new System.Drawing.Point(52, 75);
            this.lblLocid.Name = "lblLocid";
            this.lblLocid.Size = new System.Drawing.Size(70, 21);
            this.lblLocid.Text = "01-01-02";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(141, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 21);
            this.label12.Text = "Picking:";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(6, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 21);
            this.label18.Text = "M NM:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label16.Location = new System.Drawing.Point(4, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 21);
            this.label16.Text = "LOC ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(120, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblOderqty
            // 
            this.lblOderqty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblOderqty.ForeColor = System.Drawing.Color.Red;
            this.lblOderqty.Location = new System.Drawing.Point(172, 24);
            this.lblOderqty.Name = "lblOderqty";
            this.lblOderqty.Size = new System.Drawing.Size(62, 21);
            this.lblOderqty.Text = "200";
            this.lblOderqty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(173, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.Text = "GI qty:";
            // 
            // lblMatcod
            // 
            this.lblMatcod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatcod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(192)))));
            this.lblMatcod.Location = new System.Drawing.Point(47, 24);
            this.lblMatcod.Name = "lblMatcod";
            this.lblMatcod.Size = new System.Drawing.Size(95, 21);
            this.lblMatcod.Text = "H70038700";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(5, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.Text = "M NO:";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 23);
            this.label9.Text = "Please enter the issue quantity.";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOut.Location = new System.Drawing.Point(79, 287);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(78, 32);
            this.btnOut.TabIndex = 31;
            this.btnOut.Text = "GI";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lstvDetail
            // 
            this.lstvDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lstvDetail.Columns.Add(this.columnHeader2);
            this.lstvDetail.Columns.Add(this.columnHeader7);
            this.lstvDetail.Columns.Add(this.columnHeader8);
            this.lstvDetail.Columns.Add(this.columnHeader9);
            this.lstvDetail.Columns.Add(this.columnHeader10);
            this.lstvDetail.Columns.Add(this.columnHeader11);
            this.lstvDetail.Columns.Add(this.columnHeader13);
            this.lstvDetail.Columns.Add(this.columnHeader12);
            this.lstvDetail.Columns.Add(this.columnHeader1);
            this.lstvDetail.Columns.Add(this.columnHeader5);
            this.lstvDetail.ForeColor = System.Drawing.Color.Black;
            this.lstvDetail.FullRowSelect = true;
            listViewItem1.Text = "H70038700";
            listViewItem1.SubItems.Add("01-01-05");
            listViewItem1.SubItems.Add("200");
            listViewItem1.SubItems.Add("100");
            listViewItem1.SubItems.Add("DUST COVER_W18.2W40.5D9");
            listViewItem1.SubItems.Add("2");
            listViewItem1.SubItems.Add("311");
            listViewItem2.Text = "";
            listViewItem3.Text = "";
            listViewItem4.Text = "";
            this.lstvDetail.Items.Add(listViewItem1);
            this.lstvDetail.Items.Add(listViewItem2);
            this.lstvDetail.Items.Add(listViewItem3);
            this.lstvDetail.Items.Add(listViewItem4);
            this.lstvDetail.Location = new System.Drawing.Point(0, 56);
            this.lstvDetail.Name = "lstvDetail";
            this.lstvDetail.Size = new System.Drawing.Size(240, 194);
            this.lstvDetail.TabIndex = 46;
            this.lstvDetail.View = System.Windows.Forms.View.Details;
            this.lstvDetail.SelectedIndexChanged += new System.EventHandler(this.lstvDetail_SelectedIndexChanged_1);
            this.lstvDetail.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstvDetail_ItemCheck);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Seq";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Material number";
            this.columnHeader7.Width = 84;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "LOC ID";
            this.columnHeader8.Width = 60;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Picking";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 38;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Quantity";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader10.Width = 38;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Material name";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "M/T";
            this.columnHeader13.Width = 60;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "OUTSEQ";
            this.columnHeader12.Width = 50;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SEQ";
            this.columnHeader1.Width = 60;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Barcode";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "ColumnHeader";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAll.Location = new System.Drawing.Point(0, 287);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(82, 32);
            this.btnAll.TabIndex = 49;
            this.btnAll.Text = "Total";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // W_PD1U32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 769);
            this.ControlBox = false;
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.plnInput);
            this.Controls.Add(this.lstvDetail);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1U32";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1U32_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel plnInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMatcod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOutqty;
        private System.Windows.Forms.Label lblOderqty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label lblMatnam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPono;
        private System.Windows.Forms.Label lblLocid;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.ListView lstvDetail;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        
    }
}