namespace HS_ScanQC
{
    partial class FM_Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Login));
            this.LB_UserID = new System.Windows.Forms.Label();
            this.TB_UserID = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BT_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_UserID
            // 
            this.LB_UserID.Location = new System.Drawing.Point(65, 97);
            this.LB_UserID.Name = "LB_UserID";
            this.LB_UserID.Size = new System.Drawing.Size(79, 25);
            this.LB_UserID.Text = "사용자 ID:";
            // 
            // TB_UserID
            // 
            this.TB_UserID.Location = new System.Drawing.Point(140, 97);
            this.TB_UserID.Name = "TB_UserID";
            this.TB_UserID.Size = new System.Drawing.Size(113, 23);
            this.TB_UserID.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(72, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 48);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 48);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BT_Menu
            // 
            this.BT_Menu.Location = new System.Drawing.Point(185, 216);
            this.BT_Menu.Name = "BT_Menu";
            this.BT_Menu.Size = new System.Drawing.Size(64, 31);
            this.BT_Menu.TabIndex = 4;
            this.BT_Menu.Text = "메뉴";
            this.BT_Menu.Click += new System.EventHandler(this.BT_Menu_Click);
            // 
            // FM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.BT_Menu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TB_UserID);
            this.Controls.Add(this.LB_UserID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FM_Login";
            this.Text = "로그인";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_UserID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BT_Menu;
    }
}