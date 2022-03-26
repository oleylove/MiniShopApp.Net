
namespace MiniShopApp
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerLogin = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsstSystemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsstDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsstTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LabRegister = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.TimeRegister = new System.Windows.Forms.Timer(this.components);
            this.BtnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(304, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 56);
            this.label3.TabIndex = 65;
            this.label3.Text = "กรุณาลงชื่อก่อนเข้าใช้งาน";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(436, 171);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(269, 43);
            this.TxtPassword.TabIndex = 62;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(436, 105);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(269, 43);
            this.TxtUserName.TabIndex = 61;
            this.TxtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUserName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(281, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 44);
            this.label2.TabIndex = 60;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(267, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 59;
            this.label1.Text = "UserName :";
            // 
            // TimerLogin
            // 
            this.TimerLogin.Enabled = true;
            this.TimerLogin.Interval = 1000;
            this.TimerLogin.Tick += new System.EventHandler(this.TimerLogin_Tick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StatusStrip.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsstSystemName,
            this.tsstDate,
            this.tsstTime,
            this.toolStripStatusLabel4});
            this.StatusStrip.Location = new System.Drawing.Point(0, 365);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(968, 39);
            this.StatusStrip.TabIndex = 67;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // tsstSystemName
            // 
            this.tsstSystemName.Name = "tsstSystemName";
            this.tsstSystemName.Size = new System.Drawing.Size(817, 32);
            this.tsstSystemName.Spring = true;
            this.tsstSystemName.Text = "Shop Name";
            // 
            // tsstDate
            // 
            this.tsstDate.Name = "tsstDate";
            this.tsstDate.Size = new System.Drawing.Size(57, 32);
            this.tsstDate.Text = "Date";
            // 
            // tsstTime
            // 
            this.tsstTime.Name = "tsstTime";
            this.tsstTime.Size = new System.Drawing.Size(59, 32);
            this.tsstTime.Text = "Time";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(20, 32);
            this.toolStripStatusLabel4.Text = " ";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLogin.Location = new System.Drawing.Point(723, 105);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(130, 109);
            this.BtnLogin.TabIndex = 63;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LabRegister
            // 
            this.LabRegister.AutoSize = true;
            this.LabRegister.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LabRegister.ForeColor = System.Drawing.Color.Red;
            this.LabRegister.Location = new System.Drawing.Point(13, 286);
            this.LabRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabRegister.Name = "LabRegister";
            this.LabRegister.Size = new System.Drawing.Size(722, 56);
            this.LabRegister.TabIndex = 68;
            this.LabRegister.Text = "ยังไม่มีข้อมูลผู้จัดการร้าน กรุณาลงทะเบียนก่อน";
            this.LabRegister.Visible = false;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.Blue;
            this.BtnRegister.Location = new System.Drawing.Point(743, 279);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(95, 71);
            this.BtnRegister.TabIndex = 69;
            this.BtnRegister.Text = "OK";
            this.BtnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Visible = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TimeRegister
            // 
            this.TimeRegister.Enabled = true;
            this.TimeRegister.Tick += new System.EventHandler(this.TimeRegister_Tick);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(875, 275);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 80);
            this.BtnExit.TabIndex = 66;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniShopApp.Properties.Resources.Security;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 404);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.LabRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerLogin;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsstSystemName;
        private System.Windows.Forms.ToolStripStatusLabel tsstDate;
        private System.Windows.Forms.ToolStripStatusLabel tsstTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabRegister;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Timer TimeRegister;
    }
}