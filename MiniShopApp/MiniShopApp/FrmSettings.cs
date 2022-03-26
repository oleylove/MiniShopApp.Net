using MiniShopApp.Models.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Xamarin.Essentials;

namespace MiniShopApp
{
    public partial class FrmSettings : Form
    {
        public Config SysConfig = new Config();
        public static FrmSettings This = null;

        public FrmSettings()
        {
            InitializeComponent();

            SysConfig = new Config();
            This = this;
            Config deserSetting = SysConfig.DeserializeFromXML();
            if (deserSetting != null)
            {
                SysConfig = deserSetting;
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            pgConfig.SelectedObject = SysConfig;
        }

        private void pgConfig_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SysConfig.SerailizeToXml();
            pgConfig.Refresh();

        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBackupDB_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(SysConfig.MyConnection);
            string database = conn.Database.ToString();
            try
            {
                string sqlStmt = "BACKUP DATABASE [" + database + "] TO DISK='" + SysConfig.PathBackupDB + "\\" + "minishop" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                using (SqlCommand cm = new SqlCommand(sqlStmt, conn))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cm.ExecuteNonQuery();
                    conn.Close();
                    System.Windows.MessageBox.Show("Database backup done successfully");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }

        }


        private void BtnRestoreDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "SQLServer backup file|*.bak",
                Title = "Database Restore"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var connectionString = SysConfig.MyConnection;
                SqlConnection conn = new SqlConnection(connectionString);
                string database = conn.Database.ToString();
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                try
                {
                    string sqlStmt1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cm1 = new SqlCommand(sqlStmt1, conn);
                    cm1.ExecuteNonQuery();

                    string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + dlg.FileName + "'WITH REPLACE;";
                    SqlCommand cm2 = new SqlCommand(sqlStmt3, conn);
                    cm2.ExecuteNonQuery();

                    string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand cm3 = new SqlCommand(sqlStmt4, conn);
                    cm3.ExecuteNonQuery();
                    conn.Close();
                    System.Windows.MessageBox.Show("Database restoration done successfully");
                    this.Close();

                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.ToString());
                }
            }
        }
            
    }
}
