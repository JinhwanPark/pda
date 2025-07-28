namespace DYPI_WMS_PDA
{
    partial class W_PD1U21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1U21));
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
            this.lblTotalqty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.columnHeader0 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lstvMain = new System.Windows.Forms.ListView();
            this.lblMovLoc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPreLoc = new System.Windows.Forms.Label();
            this.plnInput = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.butMovChk = new System.Windows.Forms.Button();
            this.txtMovQty = new System.Windows.Forms.TextBox();
            this.lblMovInvQty = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMovMatcod = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(0, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Transfer";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.Text = "Material transfer (O.K.)";
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
            this.panel2.Controls.Add(this.lblTotalqty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 28);
            // 
            // lblTotalqty
            // 
            this.lblTotalqty.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTotalqty.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalqty.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalqty.Location = new System.Drawing.Point(60, 3);
            this.lblTotalqty.Name = "lblTotalqty";
            this.lblTotalqty.Size = new System.Drawing.Size(52, 21);
            this.lblTotalqty.Text = "9999";
            this.lblTotalqty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 31);
            this.label3.Text = "Total quantity:";
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
            this.txtMsg.Text = "This code is moved already.";
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
            // columnHeader0
            // 
            this.columnHeader0.Text = "Material number";
            this.columnHeader0.Width = 84;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mov. Qty";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 46;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Material name";
            this.columnHeader3.Width = 224;
            // 
            // lstvMain
            // 
            this.lstvMain.Columns.Add(this.columnHeader0);
            this.lstvMain.Columns.Add(this.columnHeader1);
            this.lstvMain.Columns.Add(this.columnHeader2);
            this.lstvMain.Columns.Add(this.columnHeader3);
            this.lstvMain.FullRowSelect = true;
            listViewItem1.Text = "H70038700";
            listViewItem1.SubItems.Add("200");
            listViewItem1.SubItems.Add("100");
            listViewItem1.SubItems.Add("DUST COVER_W18.2W40.5D9");
            this.lstvMain.Items.Add(listViewItem1);
            this.lstvMain.Location = new System.Drawing.Point(0, 54);
            this.lstvMain.Name = "lstvMain";
            this.lstvMain.Size = new System.Drawing.Size(240, 149);
            this.lstvMain.TabIndex = 12;
            this.lstvMain.View = System.Windows.Forms.View.Details;
            this.lstvMain.SelectedIndexChanged += new System.EventHandler(this.lstvMain_SelectedIndexChanged);
            // 
            // lblMovLoc
            // 
            this.lblMovLoc.BackColor = System.Drawing.Color.Khaki;
            this.lblMovLoc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblMovLoc.ForeColor = System.Drawing.Color.Blue;
            this.lblMovLoc.Location = new System.Drawing.Point(96, 22);
            this.lblMovLoc.Name = "lblMovLoc";
            this.lblMovLoc.Size = new System.Drawing.Size(85, 17);
            this.lblMovLoc.Text = "99-99-99";
            this.lblMovLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.lblMovLoc);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblPreLoc);
            this.panel3.Location = new System.Drawing.Point(0, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 46);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.Text = "After transfer :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.Text = "Previous:";
            // 
            // lblPreLoc
            // 
            this.lblPreLoc.BackColor = System.Drawing.Color.Khaki;
            this.lblPreLoc.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblPreLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPreLoc.Location = new System.Drawing.Point(96, 3);
            this.lblPreLoc.Name = "lblPreLoc";
            this.lblPreLoc.Size = new System.Drawing.Size(85, 17);
            this.lblPreLoc.Text = "01-01-01";
            this.lblPreLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plnInput
            // 
            this.plnInput.BackColor = System.Drawing.Color.Lime;
            this.plnInput.Controls.Add(this.btnCancel);
            this.plnInput.Controls.Add(this.butMovChk);
            this.plnInput.Controls.Add(this.txtMovQty);
            this.plnInput.Controls.Add(this.lblMovInvQty);
            this.plnInput.Controls.Add(this.label13);
            this.plnInput.Controls.Add(this.label12);
            this.plnInput.Controls.Add(this.lblMovMatcod);
            this.plnInput.Controls.Add(this.label10);
            this.plnInput.Controls.Add(this.label9);
            this.plnInput.Location = new System.Drawing.Point(246, 73);
            this.plnInput.Name = "plnInput";
            this.plnInput.Size = new System.Drawing.Size(240, 153);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(120, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // butMovChk
            // 
            this.butMovChk.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butMovChk.Location = new System.Drawing.Point(1, 118);
            this.butMovChk.Name = "butMovChk";
            this.butMovChk.Size = new System.Drawing.Size(120, 32);
            this.butMovChk.TabIndex = 16;
            this.butMovChk.Text = "Check";
            this.butMovChk.Click += new System.EventHandler(this.butMovChk_Click);
            // 
            // txtMovQty
            // 
            this.txtMovQty.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtMovQty.Location = new System.Drawing.Point(125, 82);
            this.txtMovQty.MaxLength = 5;
            this.txtMovQty.Name = "txtMovQty";
            this.txtMovQty.Size = new System.Drawing.Size(66, 29);
            this.txtMovQty.TabIndex = 2;
            this.txtMovQty.Text = "100";
            // 
            // lblMovInvQty
            // 
            this.lblMovInvQty.Location = new System.Drawing.Point(125, 58);
            this.lblMovInvQty.Name = "lblMovInvQty";
            this.lblMovInvQty.Size = new System.Drawing.Size(45, 21);
            this.lblMovInvQty.Text = "200";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(15, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 21);
            this.label13.Text = "Mov. Qty:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(15, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 21);
            this.label12.Text = "Current inventory:";
            // 
            // lblMovMatcod
            // 
            this.lblMovMatcod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMovMatcod.ForeColor = System.Drawing.Color.Red;
            this.lblMovMatcod.Location = new System.Drawing.Point(58, 31);
            this.lblMovMatcod.Name = "lblMovMatcod";
            this.lblMovMatcod.Size = new System.Drawing.Size(95, 21);
            this.lblMovMatcod.Text = "H70038700";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.Text = "ITEM:";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 21);
            this.label9.Text = "Enter the transfer quantity.";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(45, 334);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 23);
            this.txtScan.TabIndex = 24;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // W_PD1U21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.plnInput);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lstvMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1U21";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1U21_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lstvMain;
        private System.Windows.Forms.Label lblMovLoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPreLoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel plnInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMovMatcod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button butMovChk;
        private System.Windows.Forms.TextBox txtMovQty;
        private System.Windows.Forms.Label lblMovInvQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Label lblTotalqty;
        private System.Windows.Forms.Label label3;
        
    }
}