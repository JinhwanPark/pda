namespace DYPI_WMS_PDA
{
    partial class W_PD1S00
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1S00));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnEtc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pgbBattState = new System.Windows.Forms.ProgressBar();
            this.lblBattState = new System.Windows.Forms.Label();
            this.tmrState = new System.Windows.Forms.Timer();
            this.pnlBattPlus = new System.Windows.Forms.Panel();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.btnEnvSet = new System.Windows.Forms.Button();
            this.btndual = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l_Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 325);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIn.Location = new System.Drawing.Point(143, 31);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(92, 32);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "Good Receipt";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMove.Location = new System.Drawing.Point(143, 77);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(92, 32);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Transfer";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOut.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnOut.Location = new System.Drawing.Point(143, 124);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(92, 32);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Good Issue";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnEtc
            // 
            this.btnEtc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEtc.Location = new System.Drawing.Point(143, 171);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(92, 32);
            this.btnEtc.TabIndex = 4;
            this.btnEtc.Text = "Etc";
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(143, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 32);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblVer
            // 
            this.lblVer.Location = new System.Drawing.Point(8, 228);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(105, 17);
            this.lblVer.Text = "9999-00-00";
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(6, 204);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(122, 24);
            this.lblUser.Text = "LogOut";
            // 
            // pgbBattState
            // 
            this.pgbBattState.Location = new System.Drawing.Point(6, 253);
            this.pgbBattState.Name = "pgbBattState";
            this.pgbBattState.Size = new System.Drawing.Size(44, 18);
            // 
            // lblBattState
            // 
            this.lblBattState.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblBattState.Location = new System.Drawing.Point(45, 248);
            this.lblBattState.Name = "lblBattState";
            this.lblBattState.Size = new System.Drawing.Size(83, 28);
            this.lblBattState.Text = "Sufficient(100%)";
            this.lblBattState.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrState
            // 
            this.tmrState.Enabled = true;
            this.tmrState.Interval = 1000;
            this.tmrState.Tick += new System.EventHandler(this.tmrState_Tick);
            // 
            // pnlBattPlus
            // 
            this.pnlBattPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBattPlus.Location = new System.Drawing.Point(45, 257);
            this.pnlBattPlus.Name = "pnlBattPlus";
            this.pnlBattPlus.Size = new System.Drawing.Size(10, 10);
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(28, 175);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 23);
            this.txtScan.TabIndex = 8;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            this.txtScan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScan_KeyPress);
            // 
            // btnEnvSet
            // 
            this.btnEnvSet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnvSet.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btnEnvSet.Location = new System.Drawing.Point(143, 218);
            this.btnEnvSet.Name = "btnEnvSet";
            this.btnEnvSet.Size = new System.Drawing.Size(92, 32);
            this.btnEnvSet.TabIndex = 15;
            this.btnEnvSet.Text = "Configuration";
            this.btnEnvSet.Click += new System.EventHandler(this.btnEnvSet_Click);
            // 
            // btndual
            // 
            this.btndual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndual.Location = new System.Drawing.Point(177, 3);
            this.btndual.Name = "btndual";
            this.btndual.Size = new System.Drawing.Size(10, 17);
            this.btndual.TabIndex = 22;
            this.btndual.Text = "异种品防止";
            this.btndual.Visible = false;
            this.btndual.Click += new System.EventHandler(this.btndual_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(161, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(10, 22);
            this.btnConfirm.TabIndex = 29;
            this.btnConfirm.Text = "涂装管理";
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.Text = "ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_Version
            // 
            this.l_Version.Location = new System.Drawing.Point(-1, 43);
            this.l_Version.Name = "l_Version";
            this.l_Version.Size = new System.Drawing.Size(100, 20);
            // 
            // W_PD1S00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.l_Version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btndual);
            this.Controls.Add(this.btnEnvSet);
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.pgbBattState);
            this.Controls.Add(this.pnlBattPlus);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lblBattState);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEtc);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1S00";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1S00_Load);
            this.Activated += new System.EventHandler(this.W_PD1S00_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ProgressBar pgbBattState;
        private System.Windows.Forms.Label lblBattState;
        private System.Windows.Forms.Timer tmrState;
        private System.Windows.Forms.Panel pnlBattPlus;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.Button btnEnvSet;
        private System.Windows.Forms.Button btndual;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_Version;
    }
}