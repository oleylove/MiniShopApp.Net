
namespace MiniShopApp.FrmEmployees
{
    partial class FrmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PtbEmp = new System.Windows.Forms.PictureBox();
            this.TsstTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnAddEmp = new System.Windows.Forms.Button();
            this.BtnEditEmployee = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnNewLoad = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.TxtEmpPhon = new System.Windows.Forms.TextBox();
            this.TxtEmpRole = new System.Windows.Forms.TextBox();
            this.TxtEmpAge = new System.Windows.Forms.TextBox();
            this.TxtEmpGender = new System.Windows.Forms.TextBox();
            this.orderRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtEmpName = new System.Windows.Forms.TextBox();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimerCurrent = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusStripSystem = new System.Windows.Forms.StatusStrip();
            this.TsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstSystemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvEmployee = new System.Windows.Forms.DataGridView();
            this.PtbEmployee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).BeginInit();
            this.StatusStripSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // PtbEmp
            // 
            this.PtbEmp.BackColor = System.Drawing.Color.White;
            this.PtbEmp.Image = global::MiniShopApp.Properties.Resources.selectuser;
            this.PtbEmp.Location = new System.Drawing.Point(12, 12);
            this.PtbEmp.Name = "PtbEmp";
            this.PtbEmp.Size = new System.Drawing.Size(97, 106);
            this.PtbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmp.TabIndex = 355;
            this.PtbEmp.TabStop = false;
            // 
            // TsstTime
            // 
            this.TsstTime.Name = "TsstTime";
            this.TsstTime.Size = new System.Drawing.Size(59, 32);
            this.TsstTime.Text = "Time";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 32);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // BtnAddEmp
            // 
            this.BtnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddEmp.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddEmp.Location = new System.Drawing.Point(1442, 621);
            this.BtnAddEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEmp.Name = "BtnAddEmp";
            this.BtnAddEmp.Size = new System.Drawing.Size(290, 80);
            this.BtnAddEmp.TabIndex = 2;
            this.BtnAddEmp.Text = " เพิ่มข้อมูลพนักงาน";
            this.BtnAddEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddEmp.UseVisualStyleBackColor = false;
            this.BtnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // BtnEditEmployee
            // 
            this.BtnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditEmployee.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditEmployee.Location = new System.Drawing.Point(1442, 711);
            this.BtnEditEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditEmployee.Name = "BtnEditEmployee";
            this.BtnEditEmployee.Size = new System.Drawing.Size(290, 80);
            this.BtnEditEmployee.TabIndex = 3;
            this.BtnEditEmployee.Text = "แก้ข้อมูลพนักงาน";
            this.BtnEditEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditEmployee.UseVisualStyleBackColor = false;
            this.BtnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1594, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 38);
            this.label9.TabIndex = 354;
            this.label9.Text = "รูปพนักงาน";
            // 
            // BtnNewLoad
            // 
            this.BtnNewLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnNewLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNewLoad.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewLoad.Location = new System.Drawing.Point(1442, 801);
            this.BtnNewLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnNewLoad.Name = "BtnNewLoad";
            this.BtnNewLoad.Size = new System.Drawing.Size(290, 80);
            this.BtnNewLoad.TabIndex = 5;
            this.BtnNewLoad.Text = "โหลดข้อมูลใหม่";
            this.BtnNewLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewLoad.UseVisualStyleBackColor = false;
            this.BtnNewLoad.Click += new System.EventHandler(this.BtnNewLoad_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.White;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Image = global::MiniShopApp.Properties.Resources.Home;
            this.BtnMenu.Location = new System.Drawing.Point(1763, 746);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(135, 135);
            this.BtnMenu.TabIndex = 6;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // TxtEmpPhon
            // 
            this.TxtEmpPhon.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpPhon.Location = new System.Drawing.Point(1221, 48);
            this.TxtEmpPhon.Name = "TxtEmpPhon";
            this.TxtEmpPhon.Size = new System.Drawing.Size(210, 43);
            this.TxtEmpPhon.TabIndex = 353;
            this.TxtEmpPhon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEmpRole
            // 
            this.TxtEmpRole.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpRole.Location = new System.Drawing.Point(1065, 48);
            this.TxtEmpRole.Name = "TxtEmpRole";
            this.TxtEmpRole.Size = new System.Drawing.Size(145, 43);
            this.TxtEmpRole.TabIndex = 352;
            this.TxtEmpRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEmpAge
            // 
            this.TxtEmpAge.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpAge.Location = new System.Drawing.Point(924, 48);
            this.TxtEmpAge.Name = "TxtEmpAge";
            this.TxtEmpAge.Size = new System.Drawing.Size(130, 43);
            this.TxtEmpAge.TabIndex = 351;
            this.TxtEmpAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEmpGender
            // 
            this.TxtEmpGender.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpGender.Location = new System.Drawing.Point(783, 48);
            this.TxtEmpGender.Name = "TxtEmpGender";
            this.TxtEmpGender.Size = new System.Drawing.Size(130, 43);
            this.TxtEmpGender.TabIndex = 350;
            this.TxtEmpGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderRows
            // 
            this.orderRows.HeaderText = "ลำดับ";
            this.orderRows.MinimumWidth = 8;
            this.orderRows.Name = "orderRows";
            this.orderRows.ReadOnly = true;
            this.orderRows.Width = 90;
            // 
            // TxtEmpName
            // 
            this.TxtEmpName.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpName.Location = new System.Drawing.Point(422, 48);
            this.TxtEmpName.Name = "TxtEmpName";
            this.TxtEmpName.Size = new System.Drawing.Size(350, 43);
            this.TxtEmpName.TabIndex = 356;
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpID.Location = new System.Drawing.Point(161, 48);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(250, 43);
            this.TxtEmpID.TabIndex = 1;
            this.TxtEmpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEmpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmpID_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1227, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 38);
            this.label7.TabIndex = 349;
            this.label7.Text = "เบอร์โทร";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(931, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 38);
            this.label5.TabIndex = 347;
            this.label5.Text = "อายุ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(787, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 38);
            this.label4.TabIndex = 346;
            this.label4.Text = "เพศ";
            // 
            // TimerCurrent
            // 
            this.TimerCurrent.Enabled = true;
            this.TimerCurrent.Interval = 1000;
            this.TimerCurrent.Tick += new System.EventHandler(this.TimerCurrent_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1068, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 38);
            this.label6.TabIndex = 348;
            this.label6.Text = "ตำแหน่ง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(166, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 38);
            this.label2.TabIndex = 344;
            this.label2.Text = "รหัสพนักงาน";
            // 
            // StatusStripSystem
            // 
            this.StatusStripSystem.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStripSystem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStripSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslUserName,
            this.TsstSystemName,
            this.TsstDate,
            this.TsstTime,
            this.toolStripStatusLabel1});
            this.StatusStripSystem.Location = new System.Drawing.Point(0, 929);
            this.StatusStripSystem.Name = "StatusStripSystem";
            this.StatusStripSystem.Size = new System.Drawing.Size(1898, 39);
            this.StatusStripSystem.TabIndex = 342;
            this.StatusStripSystem.Text = "statusStrip1";
            // 
            // TsslUserName
            // 
            this.TsslUserName.Name = "TsslUserName";
            this.TsslUserName.Size = new System.Drawing.Size(112, 32);
            this.TsslUserName.Text = "User Name";
            // 
            // TsstSystemName
            // 
            this.TsstSystemName.Name = "TsstSystemName";
            this.TsstSystemName.Size = new System.Drawing.Size(1635, 32);
            this.TsstSystemName.Spring = true;
            this.TsstSystemName.Text = "Shop Name";
            // 
            // TsstDate
            // 
            this.TsstDate.Name = "TsstDate";
            this.TsstDate.Size = new System.Drawing.Size(57, 32);
            this.TsstDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(426, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 38);
            this.label3.TabIndex = 345;
            this.label3.Text = "ชื่อ - สกุล";
            // 
            // DgvEmployee
            // 
            this.DgvEmployee.AllowUserToAddRows = false;
            this.DgvEmployee.AllowUserToDeleteRows = false;
            this.DgvEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvEmployee.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kanit Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEmployee.ColumnHeadersHeight = 34;
            this.DgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderRows});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEmployee.Location = new System.Drawing.Point(18, 137);
            this.DgvEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvEmployee.Name = "DgvEmployee";
            this.DgvEmployee.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvEmployee.RowHeadersVisible = false;
            this.DgvEmployee.RowHeadersWidth = 62;
            this.DgvEmployee.RowTemplate.Height = 30;
            this.DgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmployee.Size = new System.Drawing.Size(1413, 744);
            this.DgvEmployee.TabIndex = 341;
            this.DgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducts_CellClick);
            // 
            // PtbEmployee
            // 
            this.PtbEmployee.BackColor = System.Drawing.Color.White;
            this.PtbEmployee.Image = global::MiniShopApp.Properties.Resources.selectuser;
            this.PtbEmployee.Location = new System.Drawing.Point(1442, 48);
            this.PtbEmployee.Name = "PtbEmployee";
            this.PtbEmployee.Size = new System.Drawing.Size(410, 450);
            this.PtbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmployee.TabIndex = 343;
            this.PtbEmployee.TabStop = false;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 968);
            this.ControlBox = false;
            this.Controls.Add(this.PtbEmp);
            this.Controls.Add(this.BtnAddEmp);
            this.Controls.Add(this.BtnEditEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnNewLoad);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.TxtEmpPhon);
            this.Controls.Add(this.TxtEmpRole);
            this.Controls.Add(this.TxtEmpAge);
            this.Controls.Add(this.TxtEmpGender);
            this.Controls.Add(this.TxtEmpName);
            this.Controls.Add(this.TxtEmpID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusStripSystem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvEmployee);
            this.Controls.Add(this.PtbEmployee);
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ข้อมูลพนักงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).EndInit();
            this.StatusStripSystem.ResumeLayout(false);
            this.StatusStripSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbEmp;
        private System.Windows.Forms.ToolStripStatusLabel TsstTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button BtnAddEmp;
        private System.Windows.Forms.Button BtnEditEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnNewLoad;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox TxtEmpPhon;
        private System.Windows.Forms.TextBox TxtEmpRole;
        private System.Windows.Forms.TextBox TxtEmpAge;
        private System.Windows.Forms.TextBox TxtEmpGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRows;
        private System.Windows.Forms.TextBox TxtEmpName;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer TimerCurrent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip StatusStripSystem;
        private System.Windows.Forms.ToolStripStatusLabel TsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel TsstSystemName;
        private System.Windows.Forms.ToolStripStatusLabel TsstDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvEmployee;
        public System.Windows.Forms.PictureBox PtbEmployee;
    }
}