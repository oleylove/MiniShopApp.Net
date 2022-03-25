
namespace MiniShopApp
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.LabEmpName = new System.Windows.Forms.Label();
            this.LabEmpId = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BntSaleDetail = new System.Windows.Forms.Button();
            this.BtnAddEmpMenu = new System.Windows.Forms.Button();
            this.BtnDataEmp = new System.Windows.Forms.Button();
            this.BtnEmpMenu = new System.Windows.Forms.Button();
            this.BtnStockMenu = new System.Windows.Forms.Button();
            this.PtbEmp = new System.Windows.Forms.PictureBox();
            this.BtnSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // LabEmpName
            // 
            this.LabEmpName.AutoSize = true;
            this.LabEmpName.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmpName.ForeColor = System.Drawing.Color.Black;
            this.LabEmpName.Location = new System.Drawing.Point(306, 15);
            this.LabEmpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabEmpName.Name = "LabEmpName";
            this.LabEmpName.Size = new System.Drawing.Size(160, 44);
            this.LabEmpName.TabIndex = 57;
            this.LabEmpName.Text = "แสดงชื่อผู้ใช้";
            // 
            // LabEmpId
            // 
            this.LabEmpId.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmpId.ForeColor = System.Drawing.Color.Black;
            this.LabEmpId.Location = new System.Drawing.Point(4, 401);
            this.LabEmpId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabEmpId.Name = "LabEmpId";
            this.LabEmpId.Size = new System.Drawing.Size(285, 44);
            this.LabEmpId.TabIndex = 66;
            this.LabEmpId.Text = "id";
            this.LabEmpId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Image = global::MiniShopApp.Properties.Resources.settings;
            this.BtnSettings.Location = new System.Drawing.Point(1196, 481);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(60, 60);
            this.BtnSettings.TabIndex = 67;
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.White;
            this.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.Location = new System.Drawing.Point(770, 271);
            this.BtnReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(200, 160);
            this.BtnReport.TabIndex = 65;
            this.BtnReport.Text = "รายงาน";
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Image = global::MiniShopApp.Properties.Resources.Exit2;
            this.BtnExit.Location = new System.Drawing.Point(998, 271);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 160);
            this.BtnExit.TabIndex = 64;
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BntSaleDetail
            // 
            this.BntSaleDetail.BackColor = System.Drawing.Color.White;
            this.BntSaleDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntSaleDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BntSaleDetail.FlatAppearance.BorderSize = 0;
            this.BntSaleDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BntSaleDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntSaleDetail.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntSaleDetail.Image = ((System.Drawing.Image)(resources.GetObject("BntSaleDetail.Image")));
            this.BntSaleDetail.Location = new System.Drawing.Point(542, 271);
            this.BntSaleDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BntSaleDetail.Name = "BntSaleDetail";
            this.BntSaleDetail.Size = new System.Drawing.Size(200, 160);
            this.BntSaleDetail.TabIndex = 63;
            this.BntSaleDetail.Text = "ข้อมูลการขาย";
            this.BntSaleDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BntSaleDetail.UseVisualStyleBackColor = false;
            this.BntSaleDetail.Click += new System.EventHandler(this.BntSaleDetail_Click);
            // 
            // BtnAddEmpMenu
            // 
            this.BtnAddEmpMenu.BackColor = System.Drawing.Color.White;
            this.BtnAddEmpMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddEmpMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddEmpMenu.FlatAppearance.BorderSize = 0;
            this.BtnAddEmpMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAddEmpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmpMenu.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEmpMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddEmpMenu.Image")));
            this.BtnAddEmpMenu.Location = new System.Drawing.Point(314, 271);
            this.BtnAddEmpMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddEmpMenu.Name = "BtnAddEmpMenu";
            this.BtnAddEmpMenu.Size = new System.Drawing.Size(200, 160);
            this.BtnAddEmpMenu.TabIndex = 62;
            this.BtnAddEmpMenu.Text = "เพิ่มข้อมูลผู้ใช้";
            this.BtnAddEmpMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddEmpMenu.UseVisualStyleBackColor = false;
            this.BtnAddEmpMenu.Click += new System.EventHandler(this.BtnAddEmpMenu_Click);
            // 
            // BtnDataEmp
            // 
            this.BtnDataEmp.BackColor = System.Drawing.Color.White;
            this.BtnDataEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDataEmp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnDataEmp.FlatAppearance.BorderSize = 0;
            this.BtnDataEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnDataEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataEmp.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDataEmp.Image = ((System.Drawing.Image)(resources.GetObject("BtnDataEmp.Image")));
            this.BtnDataEmp.Location = new System.Drawing.Point(770, 82);
            this.BtnDataEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDataEmp.Name = "BtnDataEmp";
            this.BtnDataEmp.Size = new System.Drawing.Size(200, 159);
            this.BtnDataEmp.TabIndex = 60;
            this.BtnDataEmp.Text = "ข้อมูลผพนักงาน";
            this.BtnDataEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDataEmp.UseVisualStyleBackColor = false;
            this.BtnDataEmp.Click += new System.EventHandler(this.BtnDataEmp_Click);
            // 
            // BtnEmpMenu
            // 
            this.BtnEmpMenu.BackColor = System.Drawing.Color.White;
            this.BtnEmpMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEmpMenu.FlatAppearance.BorderSize = 0;
            this.BtnEmpMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEmpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpMenu.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpMenu.Image")));
            this.BtnEmpMenu.Location = new System.Drawing.Point(998, 82);
            this.BtnEmpMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEmpMenu.Name = "BtnEmpMenu";
            this.BtnEmpMenu.Size = new System.Drawing.Size(200, 159);
            this.BtnEmpMenu.TabIndex = 61;
            this.BtnEmpMenu.Text = "ข้อมูลผู้ใช้";
            this.BtnEmpMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEmpMenu.UseVisualStyleBackColor = false;
            this.BtnEmpMenu.Click += new System.EventHandler(this.BtnEmpMenu_Click);
            // 
            // BtnStockMenu
            // 
            this.BtnStockMenu.BackColor = System.Drawing.Color.White;
            this.BtnStockMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStockMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnStockMenu.FlatAppearance.BorderSize = 0;
            this.BtnStockMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnStockMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStockMenu.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStockMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnStockMenu.Image")));
            this.BtnStockMenu.Location = new System.Drawing.Point(542, 81);
            this.BtnStockMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStockMenu.Name = "BtnStockMenu";
            this.BtnStockMenu.Size = new System.Drawing.Size(200, 160);
            this.BtnStockMenu.TabIndex = 59;
            this.BtnStockMenu.Text = "สต๊อกสินค้า";
            this.BtnStockMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnStockMenu.UseVisualStyleBackColor = false;
            this.BtnStockMenu.Click += new System.EventHandler(this.BtnStockMenu_Click);
            // 
            // PtbEmp
            // 
            this.PtbEmp.Image = global::MiniShopApp.Properties.Resources.selectuser;
            this.PtbEmp.Location = new System.Drawing.Point(12, 50);
            this.PtbEmp.Name = "PtbEmp";
            this.PtbEmp.Size = new System.Drawing.Size(277, 331);
            this.PtbEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbEmp.TabIndex = 56;
            this.PtbEmp.TabStop = false;
            // 
            // BtnSale
            // 
            this.BtnSale.BackColor = System.Drawing.Color.White;
            this.BtnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSale.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSale.FlatAppearance.BorderSize = 0;
            this.BtnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSale.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSale.Image = ((System.Drawing.Image)(resources.GetObject("BtnSale.Image")));
            this.BtnSale.Location = new System.Drawing.Point(314, 81);
            this.BtnSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSale.Name = "BtnSale";
            this.BtnSale.Size = new System.Drawing.Size(200, 160);
            this.BtnSale.TabIndex = 58;
            this.BtnSale.Text = "ขายสินค้า";
            this.BtnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSale.UseVisualStyleBackColor = false;
            this.BtnSale.Click += new System.EventHandler(this.BtnSale_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 544);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.LabEmpId);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BntSaleDetail);
            this.Controls.Add(this.BtnAddEmpMenu);
            this.Controls.Add(this.BtnDataEmp);
            this.Controls.Add(this.BtnEmpMenu);
            this.Controls.Add(this.BtnStockMenu);
            this.Controls.Add(this.LabEmpName);
            this.Controls.Add(this.PtbEmp);
            this.Controls.Add(this.BtnSale);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เมนูหลัก";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BntSaleDetail;
        private System.Windows.Forms.Button BtnAddEmpMenu;
        private System.Windows.Forms.Button BtnDataEmp;
        private System.Windows.Forms.Button BtnEmpMenu;
        private System.Windows.Forms.Button BtnStockMenu;
        private System.Windows.Forms.Label LabEmpName;
        private System.Windows.Forms.PictureBox PtbEmp;
        private System.Windows.Forms.Button BtnSale;
        private System.Windows.Forms.Label LabEmpId;
        private System.Windows.Forms.Button BtnSettings;
    }
}