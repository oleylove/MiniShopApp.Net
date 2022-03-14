
namespace MiniShopApp.FrmEmployees
{
    partial class FrmEmpCRUD
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
            this.TxtEmpPhon = new System.Windows.Forms.TextBox();
            this.TxtEmpName = new System.Windows.Forms.TextBox();
            this.BtnSelectPic = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEmpId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PtbEmpPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbCRUD = new System.Windows.Forms.GroupBox();
            this.RadioStateInActive = new System.Windows.Forms.RadioButton();
            this.RadioStateActive = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEmpPassword = new System.Windows.Forms.TextBox();
            this.TxtEmpAddress = new System.Windows.Forms.TextBox();
            this.CboEmpRole = new System.Windows.Forms.ComboBox();
            this.DtpEmpBirthday = new System.Windows.Forms.DateTimePicker();
            this.TxtEmpAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CboEmpGender = new System.Windows.Forms.ComboBox();
            this.CboEmpTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmpPhoto)).BeginInit();
            this.grbCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtEmpPhon
            // 
            this.TxtEmpPhon.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpPhon.Location = new System.Drawing.Point(217, 388);
            this.TxtEmpPhon.Name = "TxtEmpPhon";
            this.TxtEmpPhon.Size = new System.Drawing.Size(360, 43);
            this.TxtEmpPhon.TabIndex = 8;
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpName.Location = new System.Drawing.Point(217, 208);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Size = new System.Drawing.Size(360, 43);
            this.TxtEmpName.TabIndex = 4;
            // 
            // BtnSelectPic
            // 
            this.BtnSelectPic.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.BtnSelectPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSelectPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectPic.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BtnSelectPic.ForeColor = System.Drawing.Color.Blue;
            this.BtnSelectPic.Location = new System.Drawing.Point(149, 401);
            this.BtnSelectPic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelectPic.Name = "BtnSelectPic";
            this.BtnSelectPic.Size = new System.Drawing.Size(181, 48);
            this.BtnSelectPic.TabIndex = 11;
            this.BtnSelectPic.Text = "เลือกรูป/ถ่ายรูป";
            this.BtnSelectPic.UseVisualStyleBackColor = false;
            this.BtnSelectPic.Click += new System.EventHandler(this.BtnSelectPic_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(87, 584);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 38);
            this.label8.TabIndex = 139;
            this.label8.Text = "ตำแหน่ง : ";
            // 
            // TxtEmpId
            // 
            this.TxtEmpId.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpId.Location = new System.Drawing.Point(216, 33);
            this.TxtEmpId.Name = "TxtEmpId";
            this.TxtEmpId.Size = new System.Drawing.Size(360, 43);
            this.TxtEmpId.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PtbEmpPhoto);
            this.groupBox1.Controls.Add(this.BtnSelectPic);
            this.groupBox1.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(672, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 470);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " รูปพนักงาน";
            // 
            // PtbEmpPhoto
            // 
            this.PtbEmpPhoto.BackColor = System.Drawing.Color.White;
            this.PtbEmpPhoto.Image = global::MiniShopApp.Properties.Resources.selectuser;
            this.PtbEmpPhoto.Location = new System.Drawing.Point(81, 53);
            this.PtbEmpPhoto.Name = "PtbEmpPhoto";
            this.PtbEmpPhoto.Size = new System.Drawing.Size(290, 340);
            this.PtbEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmpPhoto.TabIndex = 135;
            this.PtbEmpPhoto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 38);
            this.label2.TabIndex = 132;
            this.label2.Text = "เบอร์โทร : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(106, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 131;
            this.label3.Text = "วันเกิด : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(133, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 38);
            this.label4.TabIndex = 130;
            this.label4.Text = "เพศ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(75, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 38);
            this.label5.TabIndex = 129;
            this.label5.Text = "ชื่อ - สกุล : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 38);
            this.label6.TabIndex = 128;
            this.label6.Text = "คำนำหน้า : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(84, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 38);
            this.label7.TabIndex = 127;
            this.label7.Text = "รหัสบัตร : ";
            // 
            // grbCRUD
            // 
            this.grbCRUD.Controls.Add(this.RadioStateInActive);
            this.grbCRUD.Controls.Add(this.RadioStateActive);
            this.grbCRUD.Controls.Add(this.label10);
            this.grbCRUD.Controls.Add(this.TxtEmpPassword);
            this.grbCRUD.Controls.Add(this.TxtEmpAddress);
            this.grbCRUD.Controls.Add(this.CboEmpRole);
            this.grbCRUD.Controls.Add(this.DtpEmpBirthday);
            this.grbCRUD.Controls.Add(this.TxtEmpAge);
            this.grbCRUD.Controls.Add(this.label9);
            this.grbCRUD.Controls.Add(this.CboEmpGender);
            this.grbCRUD.Controls.Add(this.CboEmpTitle);
            this.grbCRUD.Controls.Add(this.label8);
            this.grbCRUD.Controls.Add(this.TxtEmpPhon);
            this.grbCRUD.Controls.Add(this.TxtEmpName);
            this.grbCRUD.Controls.Add(this.TxtEmpId);
            this.grbCRUD.Controls.Add(this.label1);
            this.grbCRUD.Controls.Add(this.label2);
            this.grbCRUD.Controls.Add(this.label3);
            this.grbCRUD.Controls.Add(this.label4);
            this.grbCRUD.Controls.Add(this.label5);
            this.grbCRUD.Controls.Add(this.label6);
            this.grbCRUD.Controls.Add(this.label7);
            this.grbCRUD.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCRUD.Location = new System.Drawing.Point(18, 21);
            this.grbCRUD.Name = "grbCRUD";
            this.grbCRUD.Size = new System.Drawing.Size(626, 672);
            this.grbCRUD.TabIndex = 148;
            this.grbCRUD.TabStop = false;
            this.grbCRUD.Text = "ข้อมูลพนักงาน";
            // 
            // RadioStateInActive
            // 
            this.RadioStateInActive.AutoSize = true;
            this.RadioStateInActive.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioStateInActive.Location = new System.Drawing.Point(473, 624);
            this.RadioStateInActive.Name = "RadioStateInActive";
            this.RadioStateInActive.Size = new System.Drawing.Size(107, 42);
            this.RadioStateInActive.TabIndex = 149;
            this.RadioStateInActive.Text = "ยกเลิก";
            this.RadioStateInActive.UseVisualStyleBackColor = true;
            // 
            // RadioStateActive
            // 
            this.RadioStateActive.AutoSize = true;
            this.RadioStateActive.Checked = true;
            this.RadioStateActive.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioStateActive.Location = new System.Drawing.Point(474, 580);
            this.RadioStateActive.Name = "RadioStateActive";
            this.RadioStateActive.Size = new System.Drawing.Size(103, 42);
            this.RadioStateActive.TabIndex = 148;
            this.RadioStateActive.TabStop = true;
            this.RadioStateActive.Text = "ใช้งาน";
            this.RadioStateActive.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(86, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 38);
            this.label10.TabIndex = 147;
            this.label10.Text = "รหัสผ่าน : ";
            // 
            // TxtEmpPassword
            // 
            this.TxtEmpPassword.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpPassword.Location = new System.Drawing.Point(217, 87);
            this.TxtEmpPassword.Name = "TxtEmpPassword";
            this.TxtEmpPassword.Size = new System.Drawing.Size(360, 43);
            this.TxtEmpPassword.TabIndex = 2;
            this.TxtEmpPassword.UseSystemPasswordChar = true;
            // 
            // TxtEmpAddress
            // 
            this.TxtEmpAddress.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpAddress.Location = new System.Drawing.Point(218, 447);
            this.TxtEmpAddress.Multiline = true;
            this.TxtEmpAddress.Name = "TxtEmpAddress";
            this.TxtEmpAddress.Size = new System.Drawing.Size(359, 115);
            this.TxtEmpAddress.TabIndex = 9;
            // 
            // CboEmpRole
            // 
            this.CboEmpRole.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEmpRole.FormattingEnabled = true;
            this.CboEmpRole.Items.AddRange(new object[] {
            "เจ้าของร้าน",
            "พนักงานขาย"});
            this.CboEmpRole.Location = new System.Drawing.Point(217, 581);
            this.CboEmpRole.Name = "CboEmpRole";
            this.CboEmpRole.Size = new System.Drawing.Size(223, 46);
            this.CboEmpRole.TabIndex = 10;
            // 
            // DtpEmpBirthday
            // 
            this.DtpEmpBirthday.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEmpBirthday.Location = new System.Drawing.Point(217, 329);
            this.DtpEmpBirthday.Name = "DtpEmpBirthday";
            this.DtpEmpBirthday.Size = new System.Drawing.Size(360, 43);
            this.DtpEmpBirthday.TabIndex = 7;
            // 
            // TxtEmpAge
            // 
            this.TxtEmpAge.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpAge.Location = new System.Drawing.Point(465, 267);
            this.TxtEmpAge.Name = "TxtEmpAge";
            this.TxtEmpAge.Size = new System.Drawing.Size(112, 43);
            this.TxtEmpAge.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(381, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 38);
            this.label9.TabIndex = 144;
            this.label9.Text = "อายุ : ";
            // 
            // CboEmpGender
            // 
            this.CboEmpGender.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEmpGender.FormattingEnabled = true;
            this.CboEmpGender.Items.AddRange(new object[] {
            "ชาย",
            "หญิง"});
            this.CboEmpGender.Location = new System.Drawing.Point(217, 267);
            this.CboEmpGender.Name = "CboEmpGender";
            this.CboEmpGender.Size = new System.Drawing.Size(157, 46);
            this.CboEmpGender.TabIndex = 5;
            // 
            // CboEmpTitle
            // 
            this.CboEmpTitle.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEmpTitle.FormattingEnabled = true;
            this.CboEmpTitle.Items.AddRange(new object[] {
            "นาย",
            "นาง",
            "นางสาว"});
            this.CboEmpTitle.Location = new System.Drawing.Point(217, 146);
            this.CboEmpTitle.Name = "CboEmpTitle";
            this.CboEmpTitle.Size = new System.Drawing.Size(360, 46);
            this.CboEmpTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 38);
            this.label1.TabIndex = 133;
            this.label1.Text = "ที่อยู่ : ";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = global::MiniShopApp.Properties.Resources.cancel;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.Location = new System.Drawing.Point(908, 550);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(225, 80);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "ยกเลิก";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = global::MiniShopApp.Properties.Resources.SaveNew;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(672, 550);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(225, 80);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = " บันทึกข้อมูล";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmEmpCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 734);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.grbCRUD);
            this.Name = "FrmEmpCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.FrmEmpCRUD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmpPhoto)).EndInit();
            this.grbCRUD.ResumeLayout(false);
            this.grbCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtEmpPhon;
        private System.Windows.Forms.TextBox TxtEmpName;
        private System.Windows.Forms.Button BtnSelectPic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmpId;
        private System.Windows.Forms.PictureBox PtbEmpPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox grbCRUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ComboBox CboEmpTitle;
        private System.Windows.Forms.ComboBox CboEmpGender;
        private System.Windows.Forms.TextBox TxtEmpAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpEmpBirthday;
        private System.Windows.Forms.ComboBox CboEmpRole;
        private System.Windows.Forms.TextBox TxtEmpAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEmpPassword;
        private System.Windows.Forms.RadioButton RadioStateActive;
        private System.Windows.Forms.RadioButton RadioStateInActive;
    }
}