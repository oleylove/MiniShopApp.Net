
namespace MiniShopApp
{
    partial class FrmSettings
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
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.pgConfig = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BtnApply = new System.Windows.Forms.Button();
            this.tpConfig.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpConfig
            // 
            this.tpConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tpConfig.Controls.Add(this.pgConfig);
            this.tpConfig.Location = new System.Drawing.Point(4, 29);
            this.tpConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpConfig.Size = new System.Drawing.Size(642, 551);
            this.tpConfig.TabIndex = 1;
            this.tpConfig.Text = "Config";
            // 
            // pgConfig
            // 
            this.pgConfig.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pgConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgConfig.HelpVisible = false;
            this.pgConfig.Location = new System.Drawing.Point(4, 5);
            this.pgConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pgConfig.Name = "pgConfig";
            this.pgConfig.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.pgConfig.Size = new System.Drawing.Size(634, 536);
            this.pgConfig.TabIndex = 5;
            this.pgConfig.ToolbarVisible = false;
            this.pgConfig.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgConfig_PropertyValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConfig);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 584);
            this.tabControl1.TabIndex = 38;
            // 
            // BtnApply
            // 
            this.BtnApply.BackColor = System.Drawing.Color.Transparent;
            this.BtnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnApply.FlatAppearance.BorderSize = 0;
            this.BtnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Font = new System.Drawing.Font("Kanit", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApply.ForeColor = System.Drawing.Color.Black;
            this.BtnApply.Image = global::MiniShopApp.Properties.Resources.apply24;
            this.BtnApply.Location = new System.Drawing.Point(522, 619);
            this.BtnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(125, 50);
            this.BtnApply.TabIndex = 157;
            this.BtnApply.Text = " Apply";
            this.BtnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnApply.UseVisualStyleBackColor = false;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 683);
            this.ControlBox = false;
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.tpConfig.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.PropertyGrid pgConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button BtnApply;
    }
}