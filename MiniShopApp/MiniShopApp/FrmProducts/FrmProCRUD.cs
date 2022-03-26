using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniShopApp.Models.db;

namespace MiniShopApp.FrmProducts
{
    public partial class FrmProCRUD : Form
    {
        public string _EmpId;
        public string _ProID;
        public string _ActionsFrm;
        public bool _SelectPic = false;
        //public string _PathImagesPro = ConfigurationManager.AppSettings["PathImagesPro"];

        public Config SysConfig = new Config();
        public static FrmProCRUD This = null;

        public FrmProCRUD(string _EmpId, string _ProID ,string _ActionsFrm)
        {
            InitializeComponent();
            this._EmpId = _EmpId;
            this._ProID = _ProID;
            this._ActionsFrm = _ActionsFrm;

            SysConfig = new Config();
            This = this;
            Config deserSetting = SysConfig.DeserializeFromXML();
            if (deserSetting != null)
            {
                SysConfig = deserSetting;
            }

        }

        private void FrmProCRUD_Load(object sender, EventArgs e)
        {

            try
            {
                switch (_ActionsFrm)
                {
                    case "AddStock":
                        Text = "สต๊อกสินค้า";
                        this.DisabledButtonTrue();
                        LabAddQty.Visible = true;
                        TxtAddStock.Visible = true;
                        BtnSelectPicPro.Visible = false;
                        TxtAddStock.Focus();
                        this.GetProductByID();
                        break;
                    case "EditProduct":
                        Text = "แก้ไขข้อมูลสินค้า";
                        this.EnabledButtonTrue();
                        LabAddQty.Visible = false;
                        TxtAddStock.Visible = false;
                        BtnSelectPicPro.Visible = true;
                        TxtProID.Enabled = false;
                        this.BindComboboxCAT();
                        this.BindComboboxSHF();
                        this.GetProductByID();
                        break;
                    case "AddProduct":
                        Text = "เพิ่มสินค้าใหม่";
                        this.EnabledButtonTrue();
                        LabAddQty.Visible = false;
                        TxtAddStock.Visible = false;
                        BtnSelectPicPro.Visible = true;
                        RadioProActive.Checked = true;
                        this.BindComboboxCAT();
                        this.BindComboboxSHF();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ProCRUD_Load \n"+ex.Message);
            }

        }

        private void GetProductByID()
        {
            if (_ProID != "")
            {
                using (var db = new MiniShopContext())
                {
                    var pro = (from p in db.Products where p.ProId.Equals(_ProID) 
                               join c in db.Categories on p.CatId equals c.CatId 
                               join s in db.Shelfs on p.ShfId equals s.ShfId 
                               select new 
                               {
                                   p.ProId,
                                   p.ProName,
                                   p.ProSize,
                                   p.ProCost,
                                   p.ProPrice,
                                   p.ProQty,
                                   p.ProPhoto,
                                   p.ProState,
                                   c.CatName,
                                   s.ShfName,
                               }).ToList();
                    if (pro.Count() == 1)
                    {

                        TxtProID.Text = pro[0].ProId.ToString();
                        TxtProName.Text = pro[0].ProName.ToString();
                        TxtProSize.Text = pro[0].ProSize.ToString();
                        TxtProCost.Text = pro[0].ProCost.ToString();
                        TxtProPrice.Text = pro[0].ProPrice.ToString();
                        TxtProQty.Text = pro[0].ProQty.ToString();
                        CboCatName.Text = pro[0].CatName.ToString();
                        CboShfName.Text = pro[0].ShfName.ToString();
                        if (pro[0].ProState.ToString() == "active")
                        {
                            RadioProActive.Checked = true;
                        }
                        else if (pro[0].ProState.ToString() == "inactive")
                        {
                            RadioProInActive.Checked = true;
                        }
                        switch (pro[0].ProPhoto)
                        {
                            case null:
                                PtbProduct.Image = Properties.Resources.selectPhoto;
                                PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                break;
                            case "":
                                PtbProduct.Image = Properties.Resources.selectPhoto;
                                PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                break;
                            default:
                                if (File.Exists(SysConfig.PathImagesProduct + pro[0].ProPhoto.ToString()))
                                {
                                    PtbProduct.Image = Image.FromFile(SysConfig.PathImagesProduct + pro[0].ProPhoto.ToString());
                                    PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                else
                                {
                                    PtbProduct.Image = Properties.Resources.selectPhoto;
                                    PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบสินค้า กรุณาค้าหาข้อมูลสินค้าใหม่",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }

            }
        }
        private void BindComboboxSHF()
        {
            using (var db = new MiniShopContext())
            {
                var shf = from s in db.Shelfs select s;
                CboShfName.BeginUpdate();
                CboShfName.DataSource = shf.ToList();
                CboShfName.ValueMember = "ShfId";
                CboShfName.DisplayMember = "ShfName";
                CboShfName.Text = "--- เลือกชั้นวางสินค้า ---";
                CboShfName.EndUpdate();
            }
        }
        private void BindComboboxCAT()
        {
            using (var db = new MiniShopContext())
            {
                var cat = from c in db.Categories select c;
                CboCatName.BeginUpdate();
                CboCatName.DataSource = cat.ToList();
                CboCatName.ValueMember = "CatId";
                CboCatName.DisplayMember = "CatName";
                CboCatName.Text = "--- เลือกประเภทสินค้า ---";
                CboCatName.EndUpdate();
            }

        }

        private void BtnSelectPicPro_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog.Filter = "เลือกรูปภาพ|*.jpg;*.jpeg;*.gif;*.png";
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PtbProduct.Image = Image.FromFile(OpenFileDialog.FileName);
                    PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                    _SelectPic = true;
                }
                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click select image product");

            }
            catch (Exception ex)
            {
                MessageBox.Show("SelectPicPro_Click \n" + ex.Message);
            }

        }

        private void BtnSaveCRUD_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_ActionsFrm)
                {
                    case "AddStock":
                        if (this.CheckInputPro("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ก่อนบันทึกข้อมูล"))
                        { 
                            if (int.TryParse(TxtAddStock.Text, out int _ProQtyStock) && TxtAddStock.Text != "")
                            {
                                using (var db = new MiniShopContext())
                                {
                                    var pro = db.Products.Single(p => p.ProId.Equals(_ProID));
                                    pro.ProQty += _ProQtyStock;
                                    var tr = db.Database.BeginTransaction();
                                    db.SaveChanges();
                                    tr.Commit();
                                }
                                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + 
                                    " Click save Add Stock productID:" + '"' + _ProID + "'" + 
                                    "stock:"+'"'+ _ProQtyStock + '"'+ " Successful");
                                this.Close();
                                MessageBox.Show("เพิ่มสต๊อกสินค้าเรียบร้อบแล้ว", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + 
                                    " Click save Add Stock productID:" + '"' + _ProID + "'" + 
                                    "stock:" + '"'+ "Not numbers" + '"' + " Failed");
                                MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtAddStock.Clear();
                                TxtAddStock.Focus();
                            }
                        }
                        break;
                    case "EditProduct":
                        if (this.CheckInputPro("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ก่อนบันทึกการแก้ไขข้อมูล"))
                        {
                            using (var db = new MiniShopContext())
                            {
                                var pro = db.Products.Single(p => p.ProId.Equals(_ProID));
                                pro.ProName = TxtProName.Text;
                                pro.ProSize = TxtProSize.Text;
                                if (double.TryParse(TxtProCost.Text, out double _ProCostEdit))
                                {
                                    pro.ProCost = _ProCostEdit;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                if (double.TryParse(TxtProPrice.Text, out double _ProPriceEdit))
                                {
                                    pro.ProPrice = _ProPriceEdit;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                if (int.TryParse(TxtProQty.Text, out int _ProQtyEdit))
                                {
                                    pro.ProQty = _ProQtyEdit;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกตัวเลขให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (_SelectPic == true)
                                {
                                    if (!File.Exists(SysConfig.PathImagesProduct))
                                    {
                                        Directory.CreateDirectory(SysConfig.PathImagesProduct);
                                    }
                                    string ProPhotoName = TxtProID.Text + Path.GetExtension(OpenFileDialog.FileName);
                                    GC.Collect();
                                    GC.WaitForPendingFinalizers();
                                    File.Copy(Path.Combine(OpenFileDialog.FileName), Path.Combine(SysConfig.PathImagesProduct + ProPhotoName), true) ;
                                    pro.ProPhoto = ProPhotoName;
                                }
                                string _ProStateEdit = null;
                                if (RadioProActive.Checked)
                                {
                                    _ProStateEdit = "active";
                                }
                                else if (RadioProInActive.Checked)
                                {
                                    _ProStateEdit = "inactive";
                                }
                                pro.ProState = _ProStateEdit;
                                pro.CatId = (int)CboCatName.SelectedValue;
                                pro.ShfId = (int)CboShfName.SelectedValue;
                                pro.ProUpdate = DateTime.Now;
                                var tr = db.Database.BeginTransaction();
                                db.SaveChanges();
                                tr.Commit();
                                this.Close();
                                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click save edit productID:" + '"' + _ProID + "''"  + " Successful");
                                MessageBox.Show("แก้ไขสินค้าใหม่เรียบร้อยแล้ว", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    case "AddProduct":
                        if (this.CheckInputPro("กรุณาตรวจสอบข้อมูลให้ถูกต้อง ก่อนบันทึก"))
                        {
                            using (var db = new MiniShopContext())
                            {
                                var ckid = from p in db.Products
                                          select new
                                          {
                                              p.ProId,
                                          };
                                foreach (var item in ckid)
                                {
                                    if (item.ProId == TxtProID.Text)
                                    {
                                        MessageBox.Show("รหัสสินค้านี้มีอยู่ใน Stock แล้ว กรุณาทำการเพิ่มร่ายการสินค้าใหม่",Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return;
                                    }
                                }
                                double _ProCost;
                                double _ProPrice;
                                int _ProQty;
                                string _ProPhoto = null;
                                if (double.TryParse(TxtProCost.Text, out double _ProCostAdd))
                                {
                                    _ProCost = _ProCostAdd;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกตัวเลขต้นทุน ให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                if (double.TryParse(TxtProPrice.Text, out double _ProPriceAdd))
                                {
                                    _ProPrice = _ProPriceAdd;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกตัวเลขราคาขาย ให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                if (int.TryParse(TxtProQty.Text, out int proqty))
                                {
                                    _ProQty = proqty;
                                }
                                else
                                {
                                    MessageBox.Show("กรุณากรอกตัวเลขเป็นจำนวนเต็มของ จำนวนสินค้า ให้ถูกต้อง", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                if (_SelectPic == true)
                                {
                                    if (!File.Exists(SysConfig.PathImagesProduct))
                                    {
                                        Directory.CreateDirectory(SysConfig.PathImagesProduct);
                                    }

                                    File.Copy(OpenFileDialog.FileName, SysConfig.PathImagesProduct + TxtProID.Text + Path.GetExtension(OpenFileDialog.FileName), true);
                                    _ProPhoto = TxtProID.Text + Path.GetExtension(OpenFileDialog.FileName);
                                    _SelectPic = false;
                                }
                                Products pro = new Products
                                {
                                    ProId = TxtProID.Text,
                                    ProName = TxtProName.Text,
                                    ProSize = TxtProSize.Text,
                                    ProCost = _ProCost,
                                    ProPrice = _ProPrice,
                                    ProQty = _ProQty,
                                    ProPhoto = _ProPhoto,
                                    ProState = "active",
                                    ProCreate = DateTime.Now,
                                    ShfId = (int)CboShfName.SelectedValue,
                                    CatId = (int)CboShfName.SelectedValue,
                                };
                                var tr = db.Database.BeginTransaction();
                                db.Products.Add(pro);
                                db.SaveChanges();
                                tr.Commit();
                                this.Close();
                                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click save add new productID:" + '"' + TxtProID.Text + "''" + " Successful");
                                MessageBox.Show("เพิ่มสินค้าใหม่เรียบร้อยแล้ว", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ProSaveCRUD_Click \n"+ex.Message);
            }
        }
        private bool CheckInputPro(string Message)
        {
            if (TxtProID.Text == "" || TxtProName.Text == "" || TxtProSize.Text == "" || TxtProCost.Text == "" || TxtProPrice.Text == "" || TxtProQty.Text == "" || CboCatName.Text == "--- เลือกประเภทสินค้า ---" || CboShfName.Text == "--- เลือกชั้นวางสินค้า ---")
            {
                MessageBox.Show(Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DisabledButtonTrue()
        {
            TxtProID.Enabled = false;
            TxtProName.Enabled = false;
            TxtProSize.Enabled = false;
            TxtProCost.Enabled = false;
            TxtProPrice.Enabled = false;
            TxtProQty.Enabled = false;
            CboCatName.Enabled = false;
            CboShfName.Enabled = false;
            BtnSelectPicPro.Enabled = false;
            RadioProActive.Enabled = false;
            RadioProInActive.Enabled = false;

        }
        private void EnabledButtonTrue()
        {
            TxtProID.Enabled = true;
            TxtProName.Enabled = true;
            TxtProSize.Enabled = true;
            TxtProCost.Enabled = true;
            TxtProPrice.Enabled = true;
            TxtProQty.Enabled = true;
            CboCatName.Enabled = true;
            CboShfName.Enabled = true;
            BtnSelectPicPro.Enabled = true;
            RadioProActive.Enabled = true;
            RadioProInActive.Enabled = true;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click cancel");
            this.Close();
        }

    }
}
