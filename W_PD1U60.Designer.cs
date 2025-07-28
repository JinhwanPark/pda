namespace DYPI_WMS_PDA
{
    partial class W_PD1U60
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1U60));
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
            this.lblAufnr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRmk = new System.Windows.Forms.Label();
            this.lblMatcod2 = new System.Windows.Forms.Label();
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
            this.rdoGood = new System.Windows.Forms.RadioButton();
            this.rdoBad = new System.Windows.Forms.RadioButton();
            this.cboCode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.btnSave.Text = "保   存";
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
            this.label1.Text = "涂装实绩（保存）";
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
            this.panel2.Controls.Add(this.lblAufnr);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblRmk);
            this.panel2.Controls.Add(this.lblMatcod2);
            this.panel2.Controls.Add(this.lblMatcod);
            this.panel2.Controls.Add(this.lblMatnam);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 131);
            // 
            // lblAufnr
            // 
            this.lblAufnr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblAufnr.Location = new System.Drawing.Point(69, 7);
            this.lblAufnr.Name = "lblAufnr";
            this.lblAufnr.Size = new System.Drawing.Size(87, 21);
            this.lblAufnr.Text = "01100123456";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.Text = "作业指示:";
            // 
            // lblRmk
            // 
            this.lblRmk.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblRmk.ForeColor = System.Drawing.Color.Red;
            this.lblRmk.Location = new System.Drawing.Point(69, 107);
            this.lblRmk.Name = "lblRmk";
            this.lblRmk.Size = new System.Drawing.Size(166, 21);
            this.lblRmk.Text = "涂装不良3回发生.";
            // 
            // lblMatcod2
            // 
            this.lblMatcod2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblMatcod2.Location = new System.Drawing.Point(69, 84);
            this.lblMatcod2.Name = "lblMatcod2";
            this.lblMatcod2.Size = new System.Drawing.Size(166, 21);
            this.lblMatcod2.Text = "123456789";
            // 
            // lblMatcod
            // 
            this.lblMatcod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatcod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(192)))));
            this.lblMatcod.Location = new System.Drawing.Point(41, 28);
            this.lblMatcod.Name = "lblMatcod";
            this.lblMatcod.Size = new System.Drawing.Size(95, 21);
            this.lblMatcod.Text = "H70038700";
            // 
            // lblMatnam
            // 
            this.lblMatnam.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblMatnam.Location = new System.Drawing.Point(41, 49);
            this.lblMatnam.Name = "lblMatnam";
            this.lblMatnam.Size = new System.Drawing.Size(194, 26);
            this.lblMatnam.Text = "DUST COVER_W18.2W40.5D9 DUST COVER_W18.2W40.5D9";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.Text = "客户品号:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(7, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.Text = "注意事项:";
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
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.Text = "品名:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.Text = "品号:";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(51, 325);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(127, 23);
            this.txtScan.TabIndex = 23;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
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
            this.txtMsg.Text = "保存完成。";
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
            this.lblScanBarCode.Text = "标签编号";
            this.lblScanBarCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdoGood
            // 
            this.rdoGood.Enabled = false;
            this.rdoGood.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rdoGood.Location = new System.Drawing.Point(10, 7);
            this.rdoGood.Name = "rdoGood";
            this.rdoGood.Size = new System.Drawing.Size(68, 20);
            this.rdoGood.TabIndex = 28;
            this.rdoGood.Text = "良品";
            this.rdoGood.CheckedChanged += new System.EventHandler(this.rdoGood_CheckedChanged);
            // 
            // rdoBad
            // 
            this.rdoBad.Enabled = false;
            this.rdoBad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.rdoBad.Location = new System.Drawing.Point(81, 7);
            this.rdoBad.Name = "rdoBad";
            this.rdoBad.Size = new System.Drawing.Size(68, 20);
            this.rdoBad.TabIndex = 29;
            this.rdoBad.Text = "不良";
            this.rdoBad.CheckedChanged += new System.EventHandler(this.rdoBad_CheckedChanged);
            // 
            // cboCode
            // 
            this.cboCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCode.Items.Add("");
            this.cboCode.Items.Add("01:TUBE 찍힘,요철");
            this.cboCode.Items.Add("02:누유");
            this.cboCode.Items.Add("03:주단조 외관");
            this.cboCode.Items.Add("04:용접부 외과");
            this.cboCode.Items.Add("05:가공부 외관");
            this.cboCode.Items.Add("06:도장불량");
            this.cboCode.Items.Add("07:조립불량");
            this.cboCode.Items.Add("08:ROD 외관");
            this.cboCode.Items.Add("09:일반 관리");
            this.cboCode.Items.Add("10:기타");
            this.cboCode.Location = new System.Drawing.Point(118, 31);
            this.cboCode.Name = "cboCode";
            this.cboCode.Size = new System.Drawing.Size(119, 23);
            this.cboCode.TabIndex = 31;
            this.cboCode.SelectedIndexChanged += new System.EventHandler(this.cboCode_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(51, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.Text = "不良类型:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.rdoGood);
            this.panel4.Controls.Add(this.rdoBad);
            this.panel4.Controls.Add(this.cboCode);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 62);
            // 
            // W_PD1U60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
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
            this.Name = "W_PD1U60";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1U60_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rdoGood;
        private System.Windows.Forms.RadioButton rdoBad;
        private System.Windows.Forms.ComboBox cboCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatnam;
        private System.Windows.Forms.Label lblMatcod;
        private System.Windows.Forms.Label lblRmk;
        private System.Windows.Forms.Label lblMatcod2;
        private System.Windows.Forms.Label lblAufnr;
        private System.Windows.Forms.Label label7;
    }
}