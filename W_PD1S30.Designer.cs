namespace DYPI_WMS_PDA
{
    partial class W_PD1S30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1S30));
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOutOrd = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnOutPrt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnOutRet = new System.Windows.Forms.Button();
            this.txtScan = new System.Windows.Forms.TextBox();
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
            // btnOutOrd
            // 
            this.btnOutOrd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutOrd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnOutOrd.Location = new System.Drawing.Point(51, 355);
            this.btnOutOrd.Name = "btnOutOrd";
            this.btnOutOrd.Size = new System.Drawing.Size(101, 32);
            this.btnOutOrd.TabIndex = 1;
            this.btnOutOrd.Text = "PICKING指示查询";
            this.btnOutOrd.Visible = false;
            this.btnOutOrd.Click += new System.EventHandler(this.btnOutOrd_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Gold;
            this.btnOut.Location = new System.Drawing.Point(17, 143);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(205, 28);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Good Issue";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnOutPrt
            // 
            this.btnOutPrt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutPrt.Location = new System.Drawing.Point(17, 215);
            this.btnOutPrt.Name = "btnOutPrt";
            this.btnOutPrt.Size = new System.Drawing.Size(205, 28);
            this.btnOutPrt.TabIndex = 3;
            this.btnOutPrt.Text = "Issue Idn\' Label";
            this.btnOutPrt.Click += new System.EventHandler(this.btnOutPrt_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(17, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.Text = "Good Issue";
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
            // btnOutRet
            // 
            this.btnOutRet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutRet.Location = new System.Drawing.Point(17, 179);
            this.btnOutRet.Name = "btnOutRet";
            this.btnOutRet.Size = new System.Drawing.Size(205, 28);
            this.btnOutRet.TabIndex = 6;
            this.btnOutRet.Text = "Good Issue Display";
            this.btnOutRet.Click += new System.EventHandler(this.btnOutRet_Click);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(52, 326);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(114, 23);
            this.txtScan.TabIndex = 11;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // W_PD1S30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.btnOutRet);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOutPrt);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnOutOrd);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1S30";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1S30_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOutOrd;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnOutPrt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnOutRet;
        private System.Windows.Forms.TextBox txtScan;
    }
}