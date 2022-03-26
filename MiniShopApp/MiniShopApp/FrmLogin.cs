using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using MiniShopApp.Models.db;
using System.Configuration;
using System.IO;
using MiniShopApp.FrmEmployees;
using System.Reflection;


namespace MiniShopApp
{
    public partial class FrmLogin : Form
    {
        //public string _PathLog = ConfigurationManager.AppSettings["PathLog"];
        public static int count = 0;

        public Config SysConfig = new Config();
        public static FrmLogin This = null;
        public FrmLogin()
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //AssemblyName assmName = Assembly.GetExecutingAssembly().GetName();
            //this.Text = String.Format("{0} {1}", assmName.Name, assmName.Version);



            // Get the bitmap.
            Bitmap bm = new Bitmap(Properties.Resources.check_in64);

            // Convert to an icon and use for the form's icon.
            this.Icon = Icon.FromHandle(bm.GetHicon());


            tsstSystemName.Text = SysConfig.ShopName;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
            tsstDate.Text = DateTime.Today.ToString("dd MMMM yyyy");

            if (!File.Exists(SysConfig.PathLogFile))
            {
                Directory.CreateDirectory(SysConfig.PathLogFile);
            }
            _ = new CreateLogFile("Open Application");

            using (var db = new MiniShopContext())
            {
                var emp = from em in db.Employees select em;
                if (emp.Count() == 0)
                {
                    LabRegister.Visible = true;
                    BtnRegister.Visible = true;
                    TxtUserName.Enabled = false;
                    TxtPassword.Enabled = false;
                    BtnLogin.Enabled = false;
                }
            }
        }

        private void TimerLogin_Tick(object sender, EventArgs e)
        {
            tsstTime.Text = DateTime.Now.TimeOfDay.ToString();
            tsstTime.Text = DateTime.Now.Hour + ":" +
            DateTime.Now.Minute + ":" +
            DateTime.Now.Second;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtUserName.Text != "" || TxtPassword.Text != "")
                {
                    using (var db = new MiniShopContext())
                    {

                        var employee = db.Employees.FirstOrDefault(emp => emp.EmpId.Equals(TxtUserName.Text) && emp.EmpPassword.Equals(TxtPassword.Text));
                        if (employee != null)
                        {
                            _ = new CreateLogFile("EmployeeID:" + '"' + employee.EmpId + '"'  + " login");
                            FrmMenu frm = new FrmMenu(employee.EmpId.ToString());
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ข้อมูลไม่ถูกต้อง!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบ!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("คุณต้องการจะปิดโปรแกรมหรือไม่ ?", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _ = new CreateLogFile("Exit Application");
                    this.Close();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnLogin_Click(sender,e);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmEmpCRUD"];
            if (((FrmEmpCRUD)f) != null)
            {
                f.Close();
            }

            FrmEmpCRUD frm = new FrmEmpCRUD("", "", "AddEmployee");
            this.Hide();
            frm.Show();

        }

        private void TimeRegister_Tick(object sender, EventArgs e)
        {
            count += 1;
            if (count%2 == 0)
            {
                LabRegister.ForeColor = Color.Red;
            }
            else
            {
                LabRegister.ForeColor = Color.Black;
            }

        }
    }
}
