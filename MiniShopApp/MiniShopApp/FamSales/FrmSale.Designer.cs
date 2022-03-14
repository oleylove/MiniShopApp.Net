
namespace MiniShopApp.FamSales
{
    partial class FrmSale
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtProQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKeyProID = new System.Windows.Forms.TextBox();
            this.LabTotalAmount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabChange = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusStripSystem = new System.Windows.Forms.StatusStrip();
            this.TsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstSystemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsstTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerCurrent = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PtbEmp = new System.Windows.Forms.PictureBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.DgvSaleDetail = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.StatusStripSystem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Lime;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(1348, 554);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(541, 154);
            this.BtnSave.TabIndex = 68;
            this.BtnSave.Text = " บันทึกการขาย";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtProQty
            // 
            this.TxtProQty.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProQty.Location = new System.Drawing.Point(701, 102);
            this.TxtProQty.Name = "TxtProQty";
            this.TxtProQty.Size = new System.Drawing.Size(120, 43);
            this.TxtProQty.TabIndex = 9;
            this.TxtProQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kanit", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(699, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 51);
            this.label6.TabIndex = 8;
            this.label6.Text = "จำนวน";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "บาร์โคดสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKeyProID
            // 
            this.TxtKeyProID.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKeyProID.Location = new System.Drawing.Point(289, 102);
            this.TxtKeyProID.Name = "TxtKeyProID";
            this.TxtKeyProID.Size = new System.Drawing.Size(376, 43);
            this.TxtKeyProID.TabIndex = 4;
            this.TxtKeyProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKeyProID_KeyDown);
            // 
            // LabTotalAmount
            // 
            this.LabTotalAmount.BackColor = System.Drawing.Color.Black;
            this.LabTotalAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabTotalAmount.Font = new System.Drawing.Font("Kanit Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalAmount.ForeColor = System.Drawing.Color.White;
            this.LabTotalAmount.Location = new System.Drawing.Point(202, 47);
            this.LabTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTotalAmount.Name = "LabTotalAmount";
            this.LabTotalAmount.Size = new System.Drawing.Size(316, 116);
            this.LabTotalAmount.TabIndex = 17;
            this.LabTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabChange);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtCash);
            this.groupBox2.Controls.Add(this.LabTotalAmount);
            this.groupBox2.Location = new System.Drawing.Point(1348, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 513);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // LabChange
            // 
            this.LabChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabChange.Font = new System.Drawing.Font("Kanit Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabChange.Location = new System.Drawing.Point(202, 348);
            this.LabChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabChange.Name = "LabChange";
            this.LabChange.Size = new System.Drawing.Size(316, 116);
            this.LabChange.TabIndex = 22;
            this.LabChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kanit", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 70);
            this.label8.TabIndex = 21;
            this.label8.Text = "เงินทอน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kanit", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 70);
            this.label7.TabIndex = 19;
            this.label7.Text = "รับเงิน";
            // 
            // TxtCash
            // 
            this.TxtCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtCash.Font = new System.Drawing.Font("Kanit Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCash.Location = new System.Drawing.Point(202, 198);
            this.TxtCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCash.Name = "TxtCash";
            this.TxtCash.Size = new System.Drawing.Size(316, 115);
            this.TxtCash.TabIndex = 20;
            this.TxtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCash_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kanit", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 70);
            this.label5.TabIndex = 18;
            this.label5.Text = "ราคารวม";
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
            this.StatusStripSystem.TabIndex = 71;
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
            // TimerCurrent
            // 
            this.TimerCurrent.Enabled = true;
            this.TimerCurrent.Interval = 1000;
            this.TimerCurrent.Tick += new System.EventHandler(this.TimerCurrent_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PtbEmp);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.TxtProQty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtKeyProID);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1327, 205);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // PtbEmp
            // 
            this.PtbEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PtbEmp.Location = new System.Drawing.Point(6, 17);
            this.PtbEmp.Name = "PtbEmp";
            this.PtbEmp.Size = new System.Drawing.Size(150, 180);
            this.PtbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmp.TabIndex = 20;
            this.PtbEmp.TabStop = false;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClear.Font = new System.Drawing.Font("Kanit", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Image = global::MiniShopApp.Properties.Resources.clear;
            this.BtnClear.Location = new System.Drawing.Point(1084, 80);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 80);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = " เคลียร์";
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.White;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Image = global::MiniShopApp.Properties.Resources.Home;
            this.BtnMenu.Location = new System.Drawing.Point(1754, 782);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(135, 135);
            this.BtnMenu.TabIndex = 72;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // DgvSaleDetail
            // 
            this.DgvSaleDetail.AllowUserToAddRows = false;
            this.DgvSaleDetail.AllowUserToDeleteRows = false;
            this.DgvSaleDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvSaleDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvSaleDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kanit Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvSaleDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSaleDetail.ColumnHeadersHeight = 34;
            this.DgvSaleDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.ProId,
            this.ProName,
            this.ProSize,
            this.ProPrice,
            this.SdtQty,
            this.SdtAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSaleDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSaleDetail.Location = new System.Drawing.Point(13, 241);
            this.DgvSaleDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvSaleDetail.Name = "DgvSaleDetail";
            this.DgvSaleDetail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvSaleDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvSaleDetail.RowHeadersVisible = false;
            this.DgvSaleDetail.RowHeadersWidth = 62;
            this.DgvSaleDetail.RowTemplate.Height = 30;
            this.DgvSaleDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSaleDetail.Size = new System.Drawing.Size(1327, 676);
            this.DgvSaleDetail.TabIndex = 153;
            // 
            // Order
            // 
            this.Order.HeaderText = "ลำดับ";
            this.Order.MinimumWidth = 8;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 150;
            // 
            // ProId
            // 
            this.ProId.HeaderText = "รหัสบาร์โค้ด";
            this.ProId.MinimumWidth = 8;
            this.ProId.Name = "ProId";
            this.ProId.ReadOnly = true;
            this.ProId.Width = 150;
            // 
            // ProName
            // 
            this.ProName.HeaderText = "ชื่อสินค้า";
            this.ProName.MinimumWidth = 8;
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            this.ProName.Width = 150;
            // 
            // ProSize
            // 
            this.ProSize.HeaderText = "ขนาด";
            this.ProSize.MinimumWidth = 8;
            this.ProSize.Name = "ProSize";
            this.ProSize.ReadOnly = true;
            this.ProSize.Width = 150;
            // 
            // ProPrice
            // 
            this.ProPrice.HeaderText = "ราคา";
            this.ProPrice.MinimumWidth = 8;
            this.ProPrice.Name = "ProPrice";
            this.ProPrice.ReadOnly = true;
            this.ProPrice.Width = 150;
            // 
            // SdtQty
            // 
            this.SdtQty.HeaderText = "จำนวน";
            this.SdtQty.MinimumWidth = 8;
            this.SdtQty.Name = "SdtQty";
            this.SdtQty.ReadOnly = true;
            this.SdtQty.Width = 150;
            // 
            // SdtAmount
            // 
            this.SdtAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SdtAmount.HeaderText = "รวม";
            this.SdtAmount.MinimumWidth = 8;
            this.SdtAmount.Name = "SdtAmount";
            this.SdtAmount.ReadOnly = true;
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 968);
            this.ControlBox = false;
            this.Controls.Add(this.DgvSaleDetail);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StatusStripSystem);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ขายหน้าร้าน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSale_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StatusStripSystem.ResumeLayout(false);
            this.StatusStripSystem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSaleDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox PtbEmp;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtProQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKeyProID;
        private System.Windows.Forms.Label LabTotalAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip StatusStripSystem;
        private System.Windows.Forms.ToolStripStatusLabel TsslUserName;
        private System.Windows.Forms.ToolStripStatusLabel TsstSystemName;
        private System.Windows.Forms.ToolStripStatusLabel TsstDate;
        private System.Windows.Forms.ToolStripStatusLabel TsstTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer TimerCurrent;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvSaleDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtAmount;
    }
}