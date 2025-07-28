namespace DYPI_WMS_PDA
{
    partial class W_PD1S43
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_PD1S43));
            this.MainMenu = new System.Windows.Forms.MainMenu();
            this.btnRet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMatcod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lstvMain = new System.Windows.Forms.ListView();
            this.txtScan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRet
            // 
            this.btnRet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRet.Location = new System.Drawing.Point(0, 287);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(120, 32);
            this.btnRet.TabIndex = 3;
            this.btnRet.Text = "Display";
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.Text = "Material inventory display";
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
            this.panel2.Controls.Add(this.txtMatcod);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnInit);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 43);
            // 
            // txtMatcod
            // 
            this.txtMatcod.Location = new System.Drawing.Point(22, 4);
            this.txtMatcod.Name = "txtMatcod";
            this.txtMatcod.Size = new System.Drawing.Size(81, 23);
            this.txtMatcod.TabIndex = 34;
            this.txtMatcod.Text = "70038700";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.Text = "H";
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
            this.txtMsg.TabIndex = 19;
            this.txtMsg.Text = "Denter the material number to display.";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(119, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Termination";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "LOC ID";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Material number";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qualified material";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Block";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Material name";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gr date";
            this.columnHeader6.Width = 105;
            // 
            // lstvMain
            // 
            this.lstvMain.Columns.Add(this.columnHeader1);
            this.lstvMain.Columns.Add(this.columnHeader2);
            this.lstvMain.Columns.Add(this.columnHeader3);
            this.lstvMain.Columns.Add(this.columnHeader4);
            this.lstvMain.Columns.Add(this.columnHeader5);
            this.lstvMain.Columns.Add(this.columnHeader6);
            listViewItem1.Text = "H70038700";
            listViewItem1.SubItems.Add("200");
            listViewItem1.SubItems.Add("3");
            listViewItem1.SubItems.Add("DUST COVER_W18.2W40.5D9");
            listViewItem1.SubItems.Add("2009.06.23 12:00:00");
            listViewItem1.SubItems.Add("김진춘");
            this.lstvMain.Items.Add(listViewItem1);
            this.lstvMain.Location = new System.Drawing.Point(0, 54);
            this.lstvMain.Name = "lstvMain";
            this.lstvMain.Size = new System.Drawing.Size(240, 197);
            this.lstvMain.TabIndex = 12;
            this.lstvMain.View = System.Windows.Forms.View.Details;
            // 
            // txtScan
            // 
            this.txtScan.Location = new System.Drawing.Point(71, 337);
            this.txtScan.Name = "txtScan";
            this.txtScan.Size = new System.Drawing.Size(100, 23);
            this.txtScan.TabIndex = 23;
            this.txtScan.TextChanged += new System.EventHandler(this.txtScan_TextChanged);
            // 
            // W_PD1S43
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 769);
            this.ControlBox = false;
            this.Controls.Add(this.txtScan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRet);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lstvMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W_PD1S43";
            this.Text = "WMS PDA System";
            this.Load += new System.EventHandler(this.W_PD1S43_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lstvMain;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.TextBox txtScan;
        private System.Windows.Forms.TextBox txtMatcod;
        private System.Windows.Forms.Label label2;
    }
}