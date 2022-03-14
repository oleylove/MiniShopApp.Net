using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using MiniShopApp.Models.db;
using System.Configuration;

namespace MiniShopApp.FrmEmployees
{
    public partial class FrmEmployee : Form
    {
        public string _EmpId;
        public string _PathImagesEmp = ConfigurationManager.AppSettings["PathImagesEmp"];

        public FrmEmployee(string _EmpId)
        {
            InitializeComponent();
            this._EmpId = _EmpId;
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            using (var db = new MiniShopContext())
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
                    TsstDate.Text = DateTime.Today.ToString("dd MMMM yyyy");

                    var employee = db.Employees.FirstOrDefault(emp => emp.EmpId.Equals(_EmpId));
                    if (employee != null)
                    {
                        TsslUserName.Text = "ผู้ใช้ : " + employee.EmpTitle.ToString() + employee.EmpName.ToString();
                        TxtEmpID.Clear();
                        TxtEmpID.Focus();
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
                                if (File.Exists(_PathImagesEmp + employee.EmpPhoto))
                                {
                                    using (FileStream stream = new FileStream(_PathImagesEmp + employee.EmpPhoto,
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
                                    PtbEmp.Image = Properties.Resources.selectuser;
                                    PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                break;
                        }
                        this.GetDataEmployee();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TimerCurrent_Tick(object sender, EventArgs e)
        {
            TsstTime.Text = DateTime.Now.TimeOfDay.ToString();
            TsstTime.Text = DateTime.Now.Hour + ":" +
            DateTime.Now.Minute + ":" +
            DateTime.Now.Second;

        }
        private void GetDataEmployee()
        {
            using (var db = new MiniShopContext())
            {
                try
                {
                    var employee = from emp in db.Employees
                              orderby emp.EmpCraete descending
                              select new
                              {
                                  emp.EmpId,
                                  emp.EmpTitle,
                                  emp.EmpName,
                                  emp.EmpGender,
                                  emp.EmpAge,
                                  emp.EmpRole,
                                  emp.EmpPhon,
                              };
                    DgvEmployee.DataSource = employee.ToList();
                    this.DgvStockStyle();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ClearTextBox()
        {
            TxtEmpName.Clear();
            TxtEmpGender.Clear();
            TxtEmpAge.Clear();
            TxtEmpRole.Clear();
            TxtEmpPhon.Clear();

        }
        private void DgvStockStyle()
        {
            for (int rowCount = 0; rowCount < DgvEmployee.Rows.Count; rowCount++)
            {
                DgvEmployee.Rows[rowCount].Cells["orderRows"].Value = rowCount + 1;
            }
            DgvEmployee.Columns["EmpId"].HeaderText = "รหัสพนักงาน";
            DgvEmployee.Columns["EmpTitle"].HeaderText = "คำนำ";
            DgvEmployee.Columns["EmpName"].HeaderText = "ชื่อ - สกุล";
            DgvEmployee.Columns["EmpGender"].HeaderText = "เพศ";
            DgvEmployee.Columns["EmpAge"].HeaderText = "อายุ";
            DgvEmployee.Columns["EmpRole"].HeaderText = "ตำแหน่ง";
            DgvEmployee.Columns["EmpPhon"].HeaderText = "เบอร์โทร";

            DgvEmployee.Columns["orderRows"].Width = 70;
            DgvEmployee.Columns["EmpId"].Width = 130;
            DgvEmployee.Columns["EmpTitle"].Width = 90;
            DgvEmployee.Columns["EmpName"].Width = 200;
            DgvEmployee.Columns["EmpGender"].Width = 90;
            DgvEmployee.Columns["EmpAge"].Width = 90;
            DgvEmployee.Columns["EmpRole"].Width = 130;
            DgvEmployee.Columns["EmpPhon"].Width = 140;

            DgvEmployee.Columns["orderRows"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpTitle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvEmployee.Columns["EmpName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvEmployee.Columns["EmpGender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpAge"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpRole"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpPhon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvEmployee.Columns["orderRows"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpTitle"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvEmployee.Columns["EmpName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvEmployee.Columns["EmpGender"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpAge"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpRole"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvEmployee.Columns["EmpPhon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void TxtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (TxtEmpID.Text != "")
                    {
                        using (var db = new MiniShopContext())
                        {
                            this.ClearTextBox();
                            var employee = (from emp in db.Employees
                                            where emp.EmpId.Equals(TxtEmpID.Text)
                                            select new
                                            {
                                                emp.EmpId,
                                                emp.EmpTitle,
                                                emp.EmpName,
                                                emp.EmpGender,
                                                emp.EmpAge,
                                                emp.EmpRole,
                                                emp.EmpPhon,

                                            }).ToList();
                            if (employee.Count() == 1)
                            {
                                DgvEmployee.DataSource = employee.ToList();
                                this.DgvStockStyle();
                            }
                            else
                            {
                                MessageBox.Show("ไม่พบข้อมูลของพนักงานที่ต้องการ กรุณาค้นหาใหม่", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                TxtEmpID.Clear();
                                TxtEmpID.Focus();
                                return;

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกรหัสพนักก่อนค้นหา", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (var db = new MiniShopContext())
                {
                    var emp = db.Employees.FirstOrDefault(id => id.EmpId.Equals(DgvEmployee.Rows[e.RowIndex].Cells["EmpId"].Value.ToString()));
                    if (emp != null)
                    {
                        TxtEmpID.Text = emp.EmpId.ToString();
                        TxtEmpName.Text = emp.EmpTitle.ToString() + emp.EmpName.ToString();
                        TxtEmpGender.Text = emp.EmpGender.ToString();
                        TxtEmpAge.Text = emp.EmpAge.ToString();
                        TxtEmpRole.Text = emp.EmpRole.ToString();
                        TxtEmpPhon.Text = emp.EmpPhon.ToString();

                        switch (emp.EmpPhoto)
                        {
                            case null:
                                PtbEmployee.Image = Properties.Resources.selectuser;
                                PtbEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                                break;
                            case "":
                                PtbEmployee.Image = Properties.Resources.selectuser;
                                PtbEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                                break;
                            default:
                                if (File.Exists(_PathImagesEmp + emp.EmpPhoto.ToString()))
                                {
                                    using (FileStream stream = new FileStream(_PathImagesEmp + emp.EmpPhoto.ToString(),
                                        FileMode.Open,
                                        FileAccess.Read,
                                        FileShare.Delete))
                                    {
                                        PtbEmployee.Image = Image.FromStream(stream);
                                        PtbEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                                        stream.Close();
                                        stream.Dispose();
                                    }
                                }
                                else
                                {
                                    PtbEmployee.Image = Properties.Resources.selectuser;
                                    PtbEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("กรุณากรอกรหัสพนักก่อนค้นหา", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddEmp_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FrmEmpCRUD"];
            if (((FrmEmpCRUD)f) != null)
            {
                f.Close();
            }
            FrmEmpCRUD frm = new FrmEmpCRUD(_EmpId, "","AddEmployee");
            frm.Show();

        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (TxtEmpID.Text != "")
            {
                Form f = Application.OpenForms["FrmEmpCRUD"];
                if (((FrmEmpCRUD)f) != null)
                {
                    f.Close();
                }
                FrmEmpCRUD frm = new FrmEmpCRUD(_EmpId, TxtEmpID.Text, "EditEmployee");
                frm.Show();

            }
            else
            {
                MessageBox.Show("กรุณาเลือกข้อมูลพนักงานที่ต้องการแก้ไขก่อน",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void BtnNewLoad_Click(object sender, EventArgs e)
        {
            TxtEmpID.Clear();
            this.ClearTextBox();
            this.GetDataEmployee();
            TxtEmpID.Focus();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenu frm = new FrmMenu(_EmpId);
                this.Close();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
