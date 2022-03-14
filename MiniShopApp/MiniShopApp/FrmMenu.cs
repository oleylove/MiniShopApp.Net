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
        public string _PathPhoto = ConfigurationManager.AppSettings["PathImagesEmp"];

        public FrmMenu(string _EmpId)
        {
            InitializeComponent();
            this._EmpId = _EmpId;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form main menu");
            using (var db = new MiniShopContext())
            {
                try
                {
                    var employee = db.Employees.FirstOrDefault(emp => emp.EmpId.Equals(_EmpId));
                    if (employee != null)
                    {
                        LabEmpName.Text = "ผู้ใช้ : " + employee.EmpTitle.ToString() + employee.EmpName.ToString();
                        LabEmpId.Text = employee.EmpId.ToString();
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
                                if (File.Exists(_PathPhoto + employee.EmpPhoto))
                                {
                                    using (FileStream stream = new FileStream(_PathPhoto + employee.EmpPhoto,
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
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form sale");
        }

        private void BtnStockMenu_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmProduct"];
            if (((FrmProduct)f) != null)
            {
                f.Close();
            }
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form stock");
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
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form sata employee");
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
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form employee menu");
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
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form sale detail");
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
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form sale detail");
            FrmReport frm = new FrmReport();
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
                    _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Exit Application");
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
