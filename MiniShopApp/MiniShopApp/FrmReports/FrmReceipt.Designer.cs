
namespace MiniShopApp.FrmReports
{
    partial class FrmReceipt
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
            this.rptReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptReceipt
            // 
            this.rptReceipt.ActiveViewIndex = -1;
            this.rptReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReceipt.Location = new System.Drawing.Point(0, 0);
            this.rptReceipt.Name = "rptReceipt";
            this.rptReceipt.Size = new System.Drawing.Size(1266, 637);
            this.rptReceipt.TabIndex = 0;
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 637);
            this.Controls.Add(this.rptReceipt);
            this.Name = "FrmReceipt";
            this.Text = "FrmReceipt";
            this.Load += new System.EventHandler(this.FrmReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptReceipt;
    }
}