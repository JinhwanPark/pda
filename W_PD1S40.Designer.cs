namespace DYPI_WMS_PDA
{
    partial class W_PD1S40
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1S40));
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisuse = new System.Windows.Forms.Button();
            this.btnLocRet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.btnDisuseCan = new System.Windows.Forms.Button();
            this.btnMatcodRet = new System.Windows.Forms.Button();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 320);
            // 
            // btnDisuse
            // 
            this.btnDisuse.BackColor = System.Drawing.Color.Gold;
            this.btnDisuse.Location = new System.Drawing.Point(9, 147);
            this.btnDisuse.Name = "btnDisuse";
            this.btnDisuse.Size = new System.Drawing.Size(205, 21);
            this.btnDisuse.TabIndex = 1;
            this.btnDisuse.Text = "Scrap processing";
            this.btnDisuse.Click += new System.EventHandler(this.btnDisuse_Click);
            // 
            // btnLocRet
            // 
            this.btnLocRet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLocRet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnLocRet.Location = new System.Drawing.Point(9, 197);
            this.btnLocRet.Name = "btnLocRet";
            this.btnLocRet.Size = new System.Drawing.Size(205, 21);
            this.btnLocRet.TabIndex = 2;
            this.btnLocRet.Text = "LOC inventory (issue)";
            this.btnLocRet.Click += new System.EventHandler(this.btnLocRet_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(9, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 21);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.Text = "Etc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.Blue;
            this.lblUser.Location = new System.Drawing.Point(6, 73);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 22);
            this.lblUser.Text = "User: 김진춘";
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(59, 326);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 23);
            this.txtScan.TabIndex = 12;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // btnDisuseCan
            // 
            this.btnDisuseCan.BackColor = System.Drawing.Color.Gold;
            this.btnDisuseCan.Location = new System.Drawing.Point(9, 172);
            this.btnDisuseCan.Name = "btnDisuseCan";
            this.btnDisuseCan.Size = new System.Drawing.Size(205, 21);
            this.btnDisuseCan.TabIndex = 16;
            this.btnDisuseCan.Text = "Cancle scrap";
            this.btnDisuseCan.Click += new System.EventHandler(this.btnDisuseCan_Click);
            // 
            // btnMatcodRet
            // 
            this.btnMatcodRet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMatcodRet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnMatcodRet.Location = new System.Drawing.Point(9, 222);
            this.btnMatcodRet.Name = "btnMatcodRet";
            this.btnMatcodRet.Size = new System.Drawing.Size(205, 21);
            this.btnMatcodRet.TabIndex = 17;
            this.btnMatcodRet.Text = "Material inventory display";
            this.btnMatcodRet.Click += new System.EventHandler(this.btnMatcodRet_Click);
            // 
            // W_PD1S40
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.btnMatcodRet);
            this.Controls.Add(this.btnDisuseCan);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLocRet);
            this.Controls.Add(this.btnDisuse);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1S40";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1S40_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDisuse;
        private System.Windows.Forms.Button btnLocRet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Button btnDisuseCan;
        private System.Windows.Forms.Button btnMatcodRet;
    }
}