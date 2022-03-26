
namespace MiniShopApp.FamSales
{
    partial class FrmSalesDtl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StatusStripSystem = new System.Windows.Forms.StatusStrip();
            this.TsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstSystemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvSale = new System.Windows.Forms.DataGridView();
            this.orderRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerCurrent = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DtpBegin = new System.Windows.Forms.DateTimePicker();
            this.DtbEnd = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.DgvSaleDtl = new System.Windows.Forms.DataGridView();
            this.orderRows2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.LabSaleAmount = new System.Windows.Forms.Label();
            this.TxtEmpId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.PtbEmp = new System.Windows.Forms.PictureBox();
            this.StatusStripSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleDtl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(385, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 38);
            this.label2.TabIndex = 344;
            this.label2.Text = "วันที่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(728, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 38);
            this.label3.TabIndex = 345;
            this.label3.Text = "วันที่";
            // 
            // DgvSale
            // 
            this.DgvSale.AllowUserToAddRows = false;
            this.DgvSale.AllowUserToDeleteRows = false;
            this.DgvSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvSale.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kanit Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSale.ColumnHeadersHeight = 34;
            this.DgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderRows});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSale.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSale.Location = new System.Drawing.Point(18, 162);
            this.DgvSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvSale.Name = "DgvSale";
            this.DgvSale.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSale.RowHeadersVisible = false;
            this.DgvSale.RowHeadersWidth = 62;
            this.DgvSale.RowTemplate.Height = 30;
            this.DgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSale.Size = new System.Drawing.Size(635, 744);
            this.DgvSale.TabIndex = 341;
            this.DgvSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSale_CellClick);
            // 
            // orderRows
            // 
            this.orderRows.HeaderText = "ลำดับ";
            this.orderRows.MinimumWidth = 8;
            this.orderRows.Name = "orderRows";
            this.orderRows.ReadOnly = true;
            this.orderRows.Width = 90;
            // 
            // TimerCurrent
            // 
            this.TimerCurrent.Enabled = true;
            this.TimerCurrent.Interval = 1000;
            this.TimerCurrent.Tick += new System.EventHandler(this.TimerCurrent_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(678, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 38);
            this.label1.TabIndex = 357;
            this.label1.Text = "ถึง";
            // 
            // DtpBegin
            // 
            this.DtpBegin.CalendarFont = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpBegin.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpBegin.Location = new System.Drawing.Point(386, 59);
            this.DtpBegin.Name = "DtpBegin";
            this.DtpBegin.Size = new System.Drawing.Size(285, 43);
            this.DtpBegin.TabIndex = 358;
            this.DtpBegin.ValueChanged += new System.EventHandler(this.DtpBegin_ValueChanged);
            // 
            // DtbEnd
            // 
            this.DtbEnd.CalendarFont = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtbEnd.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtbEnd.Location = new System.Drawing.Point(732, 58);
            this.DtbEnd.Name = "DtbEnd";
            this.DtbEnd.Size = new System.Drawing.Size(285, 43);
            this.DtbEnd.TabIndex = 359;
            this.DtbEnd.ValueChanged += new System.EventHandler(this.DtbEnd_ValueChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.Location = new System.Drawing.Point(1029, 54);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(145, 48);
            this.BtnSearch.TabIndex = 360;
            this.BtnSearch.Text = "ค้นหา";
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.AutoSize = true;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.Location = new System.Drawing.Point(1182, 54);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(145, 48);
            this.BtnClear.TabIndex = 361;
            this.BtnClear.Text = "เคลียร์";
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // DgvSaleDtl
            // 
            this.DgvSaleDtl.AllowUserToAddRows = false;
            this.DgvSaleDtl.AllowUserToDeleteRows = false;
            this.DgvSaleDtl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvSaleDtl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvSaleDtl.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Kanit Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvSaleDtl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSaleDtl.ColumnHeadersHeight = 34;
            this.DgvSaleDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderRows2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSaleDtl.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvSaleDtl.Location = new System.Drawing.Point(661, 162);
            this.DgvSaleDtl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvSaleDtl.Name = "DgvSaleDtl";
            this.DgvSaleDtl.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvSaleDtl.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvSaleDtl.RowHeadersVisible = false;
            this.DgvSaleDtl.RowHeadersWidth = 62;
            this.DgvSaleDtl.RowTemplate.Height = 30;
            this.DgvSaleDtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSaleDtl.Size = new System.Drawing.Size(1070, 744);
            this.DgvSaleDtl.TabIndex = 366;
            // 
            // orderRows2
            // 
            this.orderRows2.HeaderText = "ลำดับ";
            this.orderRows2.MinimumWidth = 8;
            this.orderRows2.Name = "orderRows2";
            this.orderRows2.ReadOnly = true;
            this.orderRows2.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1338, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 56);
            this.label4.TabIndex = 367;
            this.label4.Text = "รวมยอดขาย : ";
            // 
            // LabSaleAmount
            // 
            this.LabSaleAmount.AutoSize = true;
            this.LabSaleAmount.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSaleAmount.ForeColor = System.Drawing.Color.Black;
            this.LabSaleAmount.Location = new System.Drawing.Point(1581, 49);
            this.LabSaleAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabSaleAmount.Name = "LabSaleAmount";
            this.LabSaleAmount.Size = new System.Drawing.Size(330, 56);
            this.LabSaleAmount.TabIndex = 368;
            this.LabSaleAmount.Text = "0,000,000.00 บาท";
            // 
            // TxtEmpId
            // 
            this.TxtEmpId.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpId.Location = new System.Drawing.Point(153, 59);
            this.TxtEmpId.Name = "TxtEmpId";
            this.TxtEmpId.Size = new System.Drawing.Size(217, 43);
            this.TxtEmpId.TabIndex = 369;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(150, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 38);
            this.label5.TabIndex = 370;
            this.label5.Text = "หาจากรหัสพนักงาน";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Kanit Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.Red;
            this.BtnLogout.Image = global::MiniShopApp.Properties.Resources.check_out32;
            this.BtnLogout.Location = new System.Drawing.Point(1750, 789);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(140, 110);
            this.BtnLogout.TabIndex = 371;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
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
            this.BtnMenu.Location = new System.Drawing.Point(1750, 664);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(140, 110);
            this.BtnMenu.TabIndex = 364;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PtbEmp
            // 
            this.PtbEmp.BackColor = System.Drawing.Color.White;
            this.PtbEmp.Image = global::MiniShopApp.Properties.Resources.selectuser;
            this.PtbEmp.Location = new System.Drawing.Point(12, 14);
            this.PtbEmp.Name = "PtbEmp";
            this.PtbEmp.Size = new System.Drawing.Size(97, 106);
            this.PtbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmp.TabIndex = 355;
            this.PtbEmp.TabStop = false;
            // 
            // FrmSalesDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 968);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmpId);
            this.Controls.Add(this.LabSaleAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvSaleDtl);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DtbEnd);
            this.Controls.Add(this.DtpBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PtbEmp);
            this.Controls.Add(this.StatusStripSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvSale);
            this.Name = "FrmSalesDtl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ข้อมูลการขาย";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSalesDtl_Load);
            this.StatusStripSystem.ResumeLayout(false);
            this.StatusStripSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleDtl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PtbEmp;
        private System.Windows.Forms.StatusStrip StatusStripSystem;
        private System.Windows.Forms.ToolStripStatusLabel TsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel TsstSystemName;
        private System.Windows.Forms.ToolStripStatusLabel TsstDate;
        private System.Windows.Forms.ToolStripStatusLabel TsstTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRows;
        private System.Windows.Forms.Timer TimerCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpBegin;
        private System.Windows.Forms.DateTimePicker DtbEnd;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.DataGridView DgvSaleDtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRows2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabSaleAmount;
        private System.Windows.Forms.TextBox TxtEmpId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLogout;
    }
}