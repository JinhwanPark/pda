namespace DYPI_WMS_PDA
{
    partial class W_PD1U90
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1U90));
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
            this.btnInit = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_lang = new System.Windows.Forms.ComboBox();
            this.cboStrLoc = new System.Windows.Forms.ComboBox();
            this.cboPlant = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommSvrPort = new System.Windows.Forms.TextBox();
            this.txtCommSvrIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.Text = "Environment setting";
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.Yellow;
            this.lblUser.Location = new System.Drawing.Point(154, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 22);
            this.lblUser.Text = "User:";
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
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 27);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInit.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnInit.Location = new System.Drawing.Point(176, 3);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(61, 22);
            this.btnInit.TabIndex = 5;
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
            this.txtMsg.TabIndex = 11;
            this.txtMsg.Text = "Display has been completed.";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(119, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbo_lang);
            this.panel4.Controls.Add(this.cboStrLoc);
            this.panel4.Controls.Add(this.cboPlant);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtCommSvrPort);
            this.panel4.Controls.Add(this.txtCommSvrIP);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 198);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(45, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.Text = "Language :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbo_lang
            // 
            this.cbo_lang.Items.Add("English");
            this.cbo_lang.Items.Add("Chinese");
            this.cbo_lang.Items.Add("Korean");
            this.cbo_lang.Items.Add("Spanish");
            this.cbo_lang.Location = new System.Drawing.Point(124, 168);
            this.cbo_lang.Name = "cbo_lang";
            this.cbo_lang.Size = new System.Drawing.Size(98, 23);
            this.cbo_lang.TabIndex = 39;
            // 
            // cboStrLoc
            // 
            this.cboStrLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboStrLoc.Items.Add("1100");
            this.cboStrLoc.Items.Add("1200");
            this.cboStrLoc.Items.Add("1300");
            this.cboStrLoc.Items.Add("1400");
            this.cboStrLoc.Items.Add("1500");
            this.cboStrLoc.Items.Add("1510");
            this.cboStrLoc.Items.Add("1700");
            this.cboStrLoc.Items.Add("1710");
            this.cboStrLoc.Location = new System.Drawing.Point(124, 131);
            this.cboStrLoc.Name = "cboStrLoc";
            this.cboStrLoc.Size = new System.Drawing.Size(58, 23);
            this.cboStrLoc.TabIndex = 8;
            this.cboStrLoc.Text = "1100";
            // 
            // cboPlant
            // 
            this.cboPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboPlant.Enabled = false;
            this.cboPlant.Items.Add("PC00");
            this.cboPlant.Location = new System.Drawing.Point(124, 94);
            this.cboPlant.Name = "cboPlant";
            this.cboPlant.Size = new System.Drawing.Size(58, 23);
            this.cboPlant.TabIndex = 10;
            this.cboPlant.Text = "PC00";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(13, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 21);
            this.label9.Text = "Storage Location:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(69, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.Text = "Plant:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCommSvrPort
            // 
            this.txtCommSvrPort.Location = new System.Drawing.Point(124, 57);
            this.txtCommSvrPort.Name = "txtCommSvrPort";
            this.txtCommSvrPort.Size = new System.Drawing.Size(96, 23);
            this.txtCommSvrPort.TabIndex = 5;
            this.txtCommSvrPort.Text = "5005";
            // 
            // txtCommSvrIP
            // 
            this.txtCommSvrIP.Location = new System.Drawing.Point(124, 17);
            this.txtCommSvrIP.Name = "txtCommSvrIP";
            this.txtCommSvrIP.Size = new System.Drawing.Size(96, 23);
            this.txtCommSvrIP.TabIndex = 4;
            this.txtCommSvrIP.Text = "172.31.95.145";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.Text = "Server Port:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.Text = "Server IP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // W_PD1U90
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1U90";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1U90_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCommSvrPort;
        private System.Windows.Forms.TextBox txtCommSvrIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPlant;
        private System.Windows.Forms.ComboBox cboStrLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_lang;
    }
}