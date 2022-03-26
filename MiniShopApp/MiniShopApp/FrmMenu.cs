using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using MiniShopApp.Models.db;
using MiniShopApp.FamSales;
using MiniShopApp.FrmProducts;
using MiniShopApp.FrmEmployees;
using MiniShopApp.FrmReports;
using System.Configuration;

namespace MiniShopApp
{
    public partial class FrmMenu : Form
    {
        public string _EmpId;
        //public string _PathPhoto = ConfigurationManager.AppSettings["PathImagesEmp"];
        public Config SysConfig = new Config();
        public static FrmMenu This = null;

        public FrmMenu(string _EmpId)
        {
            InitializeComponent();
            this._EmpId = _EmpId;

            SysConfig = new Config();
            This = this;
            Config deserSetting = SysConfig.DeserializeFromXML();
            if (deserSetting != null)
            {
                SysConfig = deserSetting;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            // Get the bitmap.
            Bitmap bm = new Bitmap(Properties.Resources.menu_icon64);
            // Convert to an icon and use for the form's icon.
            this.Icon = Icon.FromHandle(bm.GetHicon());

            using (var db = new MiniShopContext())
            {
                try
                {
                    var employee = db.Employees.FirstOrDefault(emp => emp.EmpId.Equals(_EmpId));
                    if (employee != null)
                    {
                        LabEmpName.Text = "ผู้ใช้ : " + employee.EmpTitle.ToString() + employee.EmpName.ToString();
                        LabEmpId.Text = employee.EmpId.ToString();
                        if (employee.EmpRole.ToString() == "เจ้าของร้าน")
                        {
                            BtnSettings.Visible = true;
                        }else
                        {
                            BtnSettings.Visible = false;
                        }

                        switch (employee.EmpPhoto)
                        {
                            case null:
                                PtbEmp.Image = Properties.Resources.selectuser;
                                PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                                break;
                            case "":
                                PtbEmp.Image = Properties.Resources.selectuser;
                                PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                                break;
                            default:
                                if (File.Exists(SysConfig.PathImagesEmployee + employee.EmpPhoto))
                                {
                                    using (FileStream stream = new FileStream(SysConfig.PathImagesEmployee + employee.EmpPhoto,
                                        FileMode.Open,
                                        FileAccess.Read,
                                        FileShare.Delete))
                                    {
                                        PtbEmp.Image = Image.FromStream(stream);
                                        PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                                        stream.Close();
                                        stream.Dispose();
                                    }
                                }
                                else
                                {
                                    PtbEmp.Image = Properties.Resources.selectPhoto;
                                    PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {

            Form f = Application.OpenForms["FrmSale"];
            if (((FrmSale)f) != null)
            {
                f.Close();
            }
            FrmSale frm = new FrmSale(_EmpId);
            this.Close();
            frm.Show();
        }

        private void BtnStockMenu_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmProduct"];
            if (((FrmProduct)f) != null)
            {
                f.Close();
            }
            FrmProduct frm = new FrmProduct(_EmpId);
            this.Close();
            frm.Show();
        }

        private void BtnDataEmp_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmEmployee"];
            if (((FrmEmployee)f) != null)
            {
                f.Close();
            }
            FrmEmployee frm = new FrmEmployee(_EmpId);
            this.Close();
            frm.Show();
        }

        private void BtnEmpMenu_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmEmpCRUD"];
            if (((FrmEmpCRUD)f) != null)
            {
                f.Close();
            }
            FrmEmpCRUD frm = new FrmEmpCRUD(_EmpId, "", "ShowEmployee");
            frm.Show();
        }

        private void BtnAddEmpMenu_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmEmpCRUD"];
            if (((FrmEmpCRUD)f) != null)
            {
                f.Close();
            }
            FrmEmpCRUD frm = new FrmEmpCRUD(_EmpId,"","AddEmployee");
            frm.Show();
        }

        private void BntSaleDetail_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FamSalesDtl"];
            if (((FrmSalesDtl)f) != null)
            {
                f.Close();
            }
            FrmSalesDtl frm = new FrmSalesDtl(_EmpId);
            this.Close();
            frm.Show();

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmReport"];
            if (((FrmReport)f) != null)
            {
                f.Close();
            }
            FrmReport frm = new FrmReport(_EmpId);
            this.Close();
            frm.Show();

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmSettings"];
            if (((FrmSettings)f) != null)
            {
                f.Close();
            }
            FrmSettings frm = new FrmSettings();
            frm.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Close();
            frm.Show();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("คุณต้องการจะปิดโปรแกรมหรือไม่ ?", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Exit Application");
                    this.Close();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
