
namespace MiniShopApp.FrmReports
{
    partial class FrmReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChartSaleYear = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.CboSelectYear = new System.Windows.Forms.ComboBox();
            this.ChartSaleMonth = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(975, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "รายรับ-จ่ายแบบแยกเดือน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "รายรับ-จ่ายแบบรายปี";
            // 
            // ChartSaleYear
            // 
            this.ChartSaleYear.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartSaleYear.Location = new System.Drawing.Point(33, 160);
            this.ChartSaleYear.Name = "ChartSaleYear";
            this.ChartSaleYear.Size = new System.Drawing.Size(900, 450);
            this.ChartSaleYear.TabIndex = 2;
            this.ChartSaleYear.Text = "ChartSaleYear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1571, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "เลือกปี";
            // 
            // CboSelectYear
            // 
            this.CboSelectYear.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSelectYear.FormattingEnabled = true;
            this.CboSelectYear.Location = new System.Drawing.Point(1684, 44);
            this.CboSelectYear.Name = "CboSelectYear";
            this.CboSelectYear.Size = new System.Drawing.Size(179, 46);
            this.CboSelectYear.TabIndex = 5;
            this.CboSelectYear.SelectedIndexChanged += new System.EventHandler(this.CboSelectYear_SelectedIndexChanged);
            // 
            // ChartSaleMonth
            // 
            this.ChartSaleMonth.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartSaleMonth.Location = new System.Drawing.Point(986, 160);
            this.ChartSaleMonth.Name = "ChartSaleMonth";
            this.ChartSaleMonth.Size = new System.Drawing.Size(900, 450);
            this.ChartSaleMonth.TabIndex = 6;
            this.ChartSaleMonth.Text = "ChartSaleMonth";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 968);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChartSaleYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboSelectYear);
            this.Controls.Add(this.ChartSaleMonth);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายงานการขาย";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboSelectYear;
        private LiveCharts.WinForms.CartesianChart ChartSaleYear;
        private LiveCharts.WinForms.CartesianChart ChartSaleMonth;
    }
}