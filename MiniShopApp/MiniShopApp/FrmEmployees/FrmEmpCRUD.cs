using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniShopApp.Models.db;
using System.Globalization;
using System.Threading;
using System.Configuration;

namespace MiniShopApp.FrmEmployees
{
    public partial class FrmEmpCRUD : Form
    {
        public string _EmpId;
        public string _EditEmpId;
        public string _ActionsFrm;
        public bool _SelectPic = false;
        //public string _PathImagesEmp = ConfigurationManager.AppSettings["PathImagesEmp"];

        public Config SysConfig = new Config();
        public static FrmEmpCRUD This = null;

        public FrmEmpCRUD(string _EmpId, string _EditEmpId, string _ActionsFrm)
        {
            InitializeComponent();
            this._EmpId = _EmpId;
            this._EditEmpId = _EditEmpId;
            this._ActionsFrm = _ActionsFrm;

            SysConfig = new Config();
            This = this;
            Config deserSetting = SysConfig.DeserializeFromXML();
            if (deserSetting != null)
            {
                SysConfig = deserSetting;
            }

        }
        private void FrmEmpCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
                DtpEmpBirthday.MinDate = DateTime.Today.AddYears(-80);
                DtpEmpBirthday.MaxDate =  DateTime.Today.AddYears(-10);
                switch (_ActionsFrm)
                {
                    case "AddEmployee":
                        Text = "เพิ่มข้อมูลพนักงาน";
                        TxtEmpId.Enabled = true;
                        CboEmpGender.Text = " เลือกเพศ";
                        CboEmpTitle.Text = " --- เลือกคำนำหน้าชื่อ ---";
                        CboEmpRole.Text = " --- เลือกตำแหน่ง ---";
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form add employee");
                        break;
                    case "EditEmployee":
                        Text = "แก้ไขข้อมูลพนักงาน";
                        TxtEmpId.Enabled = false;
                        this.GetEmployeeByID();
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form edit employee");
                        break;
                    case "ShowEmployee":
                        Text = "ข้อมูลพนักงาน";
                        TxtEmpId.Enabled = false;
                        BtnSave.Visible = false;
                        BtnSelectPic.Visible = false;
                        this.GetEmployeeByID();
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Open form show employee");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetEmployeeByID()
        {
            string _id = _EditEmpId != "" ? _EditEmpId : _EmpId;
            using (var db = new MiniShopContext())
            {
                var emp = db.Employees.FirstOrDefault(p => p.EmpId.Equals(_id));
                if (emp != null)
                {
                    TxtEmpId.Text = emp.EmpId;
                    TxtEmpPassword.Text = emp.EmpPassword;
                    CboEmpTitle.Text = emp.EmpTitle;
                    TxtEmpName.Text = emp.EmpName;
                    CboEmpGender.SelectedItem = emp.EmpGender;
                    TxtEmpAge.Text = emp.EmpAge.ToString();
                    DtpEmpBirthday.Value = emp.EmpBirthday;
                    TxtEmpPhon.Text = emp.EmpPhon;
                    TxtEmpAddress.Text = emp.EmpAddress;
                    CboEmpRole.Text = emp.EmpRole;
                    CboEmpRole.SelectedItem = emp.EmpRole;
                    if (emp.EmpState == "active")
                    {
                        RadioStateActive.Checked = true;
                    }
                    else if (emp.EmpState == "inactive")
                    {
                        RadioStateActive.Checked = true;
                    }

                    switch (emp.EmpPhoto)
                    {
                        case null:
                            PtbEmpPhoto.Image = Properties.Resources.selectPhoto;
                            PtbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case "":
                            PtbEmpPhoto.Image = Properties.Resources.selectPhoto;
                            PtbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        default:
                            if (File.Exists(SysConfig.PathImagesEmployee + emp.EmpPhoto))
                            {
                                using (FileStream stream = new FileStream(SysConfig.PathImagesEmployee + emp.EmpPhoto,
                                        FileMode.Open,
                                        FileAccess.Read,
                                        FileShare.Delete))
                                {
                                    PtbEmpPhoto.Image = Image.FromStream(stream);
                                    PtbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                                    stream.Close();
                                    stream.Dispose();
                                }
                            }
                            else
                            {
                                PtbEmpPhoto.Image = Properties.Resources.selectPhoto;
                                PtbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลผู้ใช้", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnSelectPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog.Filter = "เลือกรูปภาพ|*.jpg;*.jpeg;*.gif;*.png";
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PtbEmpPhoto.Image = Image.FromFile(OpenFileDialog.FileName);
                    PtbEmpPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    _SelectPic = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ChackInputText("กรุณากรอกข้อมูลให้ครบถ้วน ก่อนบันทึกข้อมูล"))
                {
                    switch (_ActionsFrm)
                    {
                        case "AddEmployee":
                            if (this.ChackInputText("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ก่อนบันทึกการแก้ไขข้อมูล"))
                            {
                                using (var db = new MiniShopContext())
                                {
                                    var addemp = from emp in db.Employees select new { emp.EmpId };
                                    foreach (var item in addemp)
                                    {
                                        if (item.EmpId == TxtEmpId.Text)
                                        {
                                            MessageBox.Show("รหัสพนักงานนี้มีอยู่ในรายชื่อแล้ว กรุณาตรวจสอบใหม่อีกครั้ง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                    }

                                    int _EmpAge;
                                    if (int.TryParse(TxtEmpAge.Text, out int _EmpAgeAdd))
                                    {
                                        _EmpAge = _EmpAgeAdd;
                                    }
                                    else
                                    {
                                        MessageBox.Show("กรุณากรอกอายุเป็นตัวเลข", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }

                                    string _ProPhoto = "";
                                    if (_SelectPic == true)
                                    {
                                        if (!File.Exists(SysConfig.PathImagesEmployee))
                                        {
                                            Directory.CreateDirectory(SysConfig.PathImagesEmployee);
                                        }
                                        GC.Collect();
                                        GC.WaitForPendingFinalizers();
                                        File.Copy(OpenFileDialog.FileName, SysConfig.PathImagesEmployee + TxtEmpId.Text + Path.GetExtension(OpenFileDialog.FileName), true);
                                        _ProPhoto = TxtEmpId.Text + Path.GetExtension(OpenFileDialog.FileName);
                                        _SelectPic = false;
                                    }
                                    
                                    string _EmpState = "";
                                    if (RadioStateActive.Checked == true)
                                    {
                                        _EmpState = "active";
                                    }
                                    else if (RadioStateInActive.Checked == true)
                                    {
                                        _EmpState = "inactive";
                                    }
                                    Employees em = new Employees
                                    {
                                        EmpId = TxtEmpId.Text,
                                        EmpPassword = TxtEmpPassword.Text,
                                        EmpTitle = CboEmpTitle.SelectedItem.ToString(),
                                        EmpName = TxtEmpName.Text,
                                        EmpGender = CboEmpGender.SelectedItem.ToString(),
                                        EmpAge = _EmpAge,
                                        EmpBirthday = DtpEmpBirthday.Value,
                                        EmpPhon = TxtEmpPhon.Text,
                                        EmpAddress = TxtEmpAddress.Text,
                                        EmpPhoto = _ProPhoto,
                                        EmpRole = _EmpState,
                                        EmpState = "active",
                                        EmpCraete = DateTime.Now,
                                    };
                                    var tr = db.Database.BeginTransaction();
                                    db.Employees.Add(em);
                                    db.SaveChanges();
                                    tr.Commit();
                                    this.Close();
                                    MessageBox.Show("เพิ่มชื่อพนักงานใหม่เรียบร้อยแล้ว", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }   
                            break;
                        case "EditEmployee":
                            if (this.ChackInputText("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ก่อนบันทึกการแก้ไขข้อมูล"))
                            {
                                int _EmpAge;
                                if (int.TryParse(TxtEmpAge.Text, out int _EmpAgeEdit))
                                {
                                   _EmpAge = _EmpAgeEdit;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกอายุตัวเลข ให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                string _EmpState = "";
                                if (RadioStateActive.Checked == true)
                                {
                                    _EmpState = "active";
                                }
                                else if (RadioStateInActive.Checked == true)
                                {
                                    _EmpState = "inactive";
                                }

                                string _EmpPhoto = "";
                                if (_SelectPic == true)
                                {
                                    if (!File.Exists(SysConfig.PathImagesEmployee))
                                    {
                                        Directory.CreateDirectory(SysConfig.PathImagesEmployee);
                                    }
                                    string EmpPhotoName = TxtEmpId.Text + Path.GetExtension(OpenFileDialog.FileName);
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    File.Copy(Path.Combine(OpenFileDialog.FileName), Path.Combine(SysConfig.PathImagesEmployee + EmpPhotoName), true);
                                    _EmpPhoto = EmpPhotoName;
                                }

                                using (var db = new MiniShopContext())
                                {
                                    var emp = db.Employees.Single(p => p.EmpId.Equals(_EditEmpId));
                                    emp.EmpPassword = TxtEmpPassword.Text;
                                    emp.EmpTitle = CboEmpTitle.Text.ToString();
                                    emp.EmpName = TxtEmpName.Text;
                                    emp.EmpGender = CboEmpGender.Text.ToString();
                                    emp.EmpAge = _EmpAge;
                                    emp.EmpBirthday = DtpEmpBirthday.Value;
                                    emp.EmpPhon = TxtEmpPhon.Text;
                                    emp.EmpAddress = TxtEmpAddress.Text;
                                    emp.EmpRole = CboEmpRole.SelectedItem.ToString();
                                    emp.EmpPhoto = _EmpPhoto;
                                    emp.EmpState = _EmpState;
                                    emp.EmpUpdate = DateTime.Today;
                                    var tr = db.Database.BeginTransaction();
                                    db.SaveChanges();
                                    tr.Commit();
                                    this.Close();
                                    MessageBox.Show("แก้ไขสินค้าใหม่เรียบร้อยแล้ว", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ChackInputText(string Message)
        {
            if (TxtEmpId.Text == "" || 
                CboEmpTitle.SelectedItem == null || 
                TxtEmpName.Text == "" || 
                CboEmpGender.SelectedItem == null || 
                TxtEmpAge.Text == "" || 
                TxtEmpPhon.Text == "" || 
                TxtEmpAddress.Text == "" || 
                CboEmpRole.SelectedItem == null)
            {
                MessageBox.Show(Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
