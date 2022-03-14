
namespace MiniShopApp.FrmProducts
{
    partial class FrmProduct
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
            this.TsstDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerCurrent = new System.Windows.Forms.Timer(this.components);
            this.orderRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TsstSystemName = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnAddStock = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnEditProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnNewLoad = new System.Windows.Forms.Button();
            this.TxtProQty = new System.Windows.Forms.TextBox();
            this.TxtProPrice = new System.Windows.Forms.TextBox();
            this.TxtProCost = new System.Windows.Forms.TextBox();
            this.TxtProSize = new System.Windows.Forms.TextBox();
            this.TxtProName = new System.Windows.Forms.TextBox();
            this.TxtProID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusStripSystem = new System.Windows.Forms.StatusStrip();
            this.TsstTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.PtbEmp = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.PtbProduct = new System.Windows.Forms.PictureBox();
            this.StatusStripSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // TsstDate
            // 
            this.TsstDate.Name = "TsstDate";
            this.TsstDate.Size = new System.Drawing.Size(57, 32);
            this.TsstDate.Text = "Date";
            // 
            // TsslUserName
            // 
            this.TsslUserName.Name = "TsslUserName";
            this.TsslUserName.Size = new System.Drawing.Size(112, 32);
            this.TsslUserName.Text = "User Name";
            // 
            // TimerCurrent
            // 
            this.TimerCurrent.Enabled = true;
            this.TimerCurrent.Interval = 1000;
            this.TimerCurrent.Tick += new System.EventHandler(this.TimerCurrent_Tick);
            // 
            // orderRows
            // 
            this.orderRows.HeaderText = "ลำดับ";
            this.orderRows.MinimumWidth = 8;
            this.orderRows.Name = "orderRows";
            this.orderRows.ReadOnly = true;
            this.orderRows.Width = 90;
            // 
            // TsstSystemName
            // 
            this.TsstSystemName.Name = "TsstSystemName";
            this.TsstSystemName.Size = new System.Drawing.Size(1635, 32);
            this.TsstSystemName.Spring = true;
            this.TsstSystemName.Text = "Shop Name";
            // 
            // BtnAddStock
            // 
            this.BtnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddStock.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddStock.Location = new System.Drawing.Point(1442, 531);
            this.BtnAddStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddStock.Name = "BtnAddStock";
            this.BtnAddStock.Size = new System.Drawing.Size(290, 80);
            this.BtnAddStock.TabIndex = 2;
            this.BtnAddStock.Text = "เพิ่มสต๊อกสินค้า";
            this.BtnAddStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddStock.UseVisualStyleBackColor = false;
            this.BtnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddProduct.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddProduct.Location = new System.Drawing.Point(1442, 711);
            this.BtnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(290, 80);
            this.BtnAddProduct.TabIndex = 4;
            this.BtnAddProduct.Text = "เพิ่มสินค้าใหม่";
            this.BtnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnEditProduct
            // 
            this.BtnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditProduct.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditProduct.Location = new System.Drawing.Point(1442, 621);
            this.BtnEditProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditProduct.Name = "BtnEditProduct";
            this.BtnEditProduct.Size = new System.Drawing.Size(290, 80);
            this.BtnEditProduct.TabIndex = 3;
            this.BtnEditProduct.Text = "แก้ไขรายการสินค้า";
            this.BtnEditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditProduct.UseVisualStyleBackColor = false;
            this.BtnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1615, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 38);
            this.label9.TabIndex = 174;
            this.label9.Text = "รูปสินค้า";
            // 
            // BtnNewLoad
            // 
            this.BtnNewLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            // TxtProQty
            // 
            this.TxtProQty.Enabled = false;
            this.TxtProQty.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProQty.Location = new System.Drawing.Point(1236, 48);
            this.TxtProQty.Name = "TxtProQty";
            this.TxtProQty.Size = new System.Drawing.Size(130, 43);
            this.TxtProQty.TabIndex = 169;
            this.TxtProQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProPrice
            // 
            this.TxtProPrice.Enabled = false;
            this.TxtProPrice.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProPrice.Location = new System.Drawing.Point(1095, 48);
            this.TxtProPrice.Name = "TxtProPrice";
            this.TxtProPrice.Size = new System.Drawing.Size(130, 43);
            this.TxtProPrice.TabIndex = 168;
            this.TxtProPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProCost
            // 
            this.TxtProCost.Enabled = false;
            this.TxtProCost.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProCost.Location = new System.Drawing.Point(954, 48);
            this.TxtProCost.Name = "TxtProCost";
            this.TxtProCost.Size = new System.Drawing.Size(130, 43);
            this.TxtProCost.TabIndex = 167;
            this.TxtProCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProSize
            // 
            this.TxtProSize.Enabled = false;
            this.TxtProSize.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProSize.Location = new System.Drawing.Point(783, 48);
            this.TxtProSize.Name = "TxtProSize";
            this.TxtProSize.Size = new System.Drawing.Size(160, 43);
            this.TxtProSize.TabIndex = 166;
            this.TxtProSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProName
            // 
            this.TxtProName.Enabled = false;
            this.TxtProName.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProName.Location = new System.Drawing.Point(422, 48);
            this.TxtProName.Name = "TxtProName";
            this.TxtProName.Size = new System.Drawing.Size(350, 43);
            this.TxtProName.TabIndex = 333;
            this.TxtProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProID
            // 
            this.TxtProID.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProID.Location = new System.Drawing.Point(161, 48);
            this.TxtProID.Name = "TxtProID";
            this.TxtProID.Size = new System.Drawing.Size(250, 43);
            this.TxtProID.TabIndex = 1;
            this.TxtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProID_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1242, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 38);
            this.label7.TabIndex = 161;
            this.label7.Text = "จำนวน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(961, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 38);
            this.label5.TabIndex = 159;
            this.label5.Text = "ต้นทุน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(787, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 38);
            this.label4.TabIndex = 158;
            this.label4.Text = "ขนาดสินค้า";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 32);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1098, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 38);
            this.label6.TabIndex = 160;
            this.label6.Text = "ราคาขาย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(166, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 156;
            this.label2.Text = "รหัสบาร์โค้ด";
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
            this.StatusStripSystem.TabIndex = 153;
            this.StatusStripSystem.Text = "statusStrip1";
            // 
            // TsstTime
            // 
            this.TsstTime.Name = "TsstTime";
            this.TsstTime.Size = new System.Drawing.Size(59, 32);
            this.TsstTime.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(426, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 38);
            this.label3.TabIndex = 157;
            this.label3.Text = "ชื่อสินค้า";
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.AllowUserToDeleteRows = false;
            this.DgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kanit Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProducts.ColumnHeadersHeight = 34;
            this.DgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderRows});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProducts.Location = new System.Drawing.Point(18, 137);
            this.DgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProducts.RowHeadersVisible = false;
            this.DgvProducts.RowHeadersWidth = 62;
            this.DgvProducts.RowTemplate.Height = 30;
            this.DgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducts.Size = new System.Drawing.Size(1413, 744);
            this.DgvProducts.TabIndex = 152;
            this.DgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProroducts_CellClick);
            // 
            // PtbEmp
            // 
            this.PtbEmp.BackColor = System.Drawing.Color.White;
            this.PtbEmp.Image = global::MiniShopApp.Properties.Resources.selectuser;
            this.PtbEmp.Location = new System.Drawing.Point(12, 12);
            this.PtbEmp.Name = "PtbEmp";
            this.PtbEmp.Size = new System.Drawing.Size(97, 106);
            this.PtbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmp.TabIndex = 178;
            this.PtbEmp.TabStop = false;
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
            // PtbProduct
            // 
            this.PtbProduct.BackColor = System.Drawing.Color.White;
            this.PtbProduct.Image = global::MiniShopApp.Properties.Resources.selectPhoto;
            this.PtbProduct.Location = new System.Drawing.Point(1455, 48);
            this.PtbProduct.Name = "PtbProduct";
            this.PtbProduct.Size = new System.Drawing.Size(410, 450);
            this.PtbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbProduct.TabIndex = 155;
            this.PtbProduct.TabStop = false;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 968);
            this.ControlBox = false;
            this.Controls.Add(this.PtbEmp);
            this.Controls.Add(this.BtnAddStock);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.BtnEditProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnNewLoad);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.TxtProQty);
            this.Controls.Add(this.TxtProPrice);
            this.Controls.Add(this.TxtProCost);
            this.Controls.Add(this.TxtProSize);
            this.Controls.Add(this.TxtProName);
            this.Controls.Add(this.TxtProID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusStripSystem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvProducts);
            this.Controls.Add(this.PtbProduct);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ข้อมูลสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.StatusStripSystem.ResumeLayout(false);
            this.StatusStripSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel TsstDate;
        private System.Windows.Forms.ToolStripStatusLabel TsslUserName;
        private System.Windows.Forms.Timer TimerCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderRows;
        private System.Windows.Forms.ToolStripStatusLabel TsstSystemName;
        private System.Windows.Forms.Button BtnAddStock;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnEditProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnNewLoad;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox TxtProQty;
        private System.Windows.Forms.TextBox TxtProPrice;
        private System.Windows.Forms.TextBox TxtProCost;
        private System.Windows.Forms.TextBox TxtProSize;
        private System.Windows.Forms.TextBox TxtProName;
        private System.Windows.Forms.TextBox TxtProID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip StatusStripSystem;
        private System.Windows.Forms.ToolStripStatusLabel TsstTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.PictureBox PtbEmp;
        public System.Windows.Forms.PictureBox PtbProduct;
    }
}