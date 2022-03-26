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

namespace MiniShopApp.FrmProducts
{
    public partial class FrmProduct : Form
    {
        public string _EmpId;
        //public string _PathImagesPro = ConfigurationManager.AppSettings["PathImagesPro"];
        //public string _PathImagesEmp = ConfigurationManager.AppSettings["PathImagesEmp"];

        public Config SysConfig = new Config();
        public static FrmProduct This = null;


        public FrmProduct(string _EmpId)
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

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            using (var db = new MiniShopContext())
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
                    TsstDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
                    TsstSystemName.Text = SysConfig.ShopName;
                    var employee = db.Employees.FirstOrDefault(emp => emp.EmpId.Equals(_EmpId));
                    if (employee != null)
                    {
                        TsslUserName.Text = "ผู้ใช้ : " + employee.EmpTitle.ToString() + employee.EmpName.ToString();
                        TxtProID.Clear();
                        TxtProID.Focus();
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
                                    PtbEmp.Image = Properties.Resources.selectuser;
                                    PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                break;
                        }
                        this.GetDataProduct();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Product_Load \n"+ex.Message);
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

        public void GetDataProduct()
        {
            using (var db = new MiniShopContext())
            {
                try
                {
                    var pro = from p in db.Products
                              join c in db.Categories on p.CatId equals c.CatId
                              orderby p.ProCreate descending
                              select new
                              {
                                  p.ProId,
                                  p.ProName,
                                  p.ProSize,
                                  p.ProCost,
                                  p.ProPrice,
                                  p.ProQty,
                                  c.CatName,
                              };
                    DgvProducts.DataSource = pro.ToList();
                    DgvStockStyle();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("GetDataProduct \n"+ex.Message);
                }
            }
        }
        public void DgvStockStyle()
        {
            for (int rowCount = 0; rowCount < DgvProducts.Rows.Count; rowCount++)
            {
                DgvProducts.Rows[rowCount].Cells["orderRows"].Value = rowCount + 1;
            }
            DgvProducts.Columns["ProId"].HeaderText = "รหัสบาร์โค้ด";
            DgvProducts.Columns["ProName"].HeaderText = "ชื่อสินค้า";
            DgvProducts.Columns["ProSize"].HeaderText = "ขนาด";
            DgvProducts.Columns["ProCost"].HeaderText = "ต้นทุน";
            DgvProducts.Columns["ProPrice"].HeaderText = "ราคาขาย";
            DgvProducts.Columns["ProQty"].HeaderText = "จำนวน";
            DgvProducts.Columns["CatName"].HeaderText = "ประเภท";

            DgvProducts.Columns["ProCost"].DefaultCellStyle.Format = "F2";
            DgvProducts.Columns["ProPrice"].DefaultCellStyle.Format = "F2";

            DgvProducts.Columns["orderRows"].Width = 60;
            DgvProducts.Columns["ProId"].Width = 120;
            DgvProducts.Columns["ProName"].Width = 230;
            DgvProducts.Columns["ProSize"].Width = 120;
            DgvProducts.Columns["ProCost"].Width = 90;
            DgvProducts.Columns["ProPrice"].Width = 90;
            DgvProducts.Columns["ProQty"].Width = 80;
            DgvProducts.Columns["CatName"].Width = 150;

            DgvProducts.Columns["orderRows"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProducts.Columns["ProId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProducts.Columns["ProCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvProducts.Columns["ProPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvProducts.Columns["ProQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvProducts.Columns["orderRows"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProducts.Columns["ProId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProducts.Columns["ProCost"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvProducts.Columns["ProPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvProducts.Columns["ProQty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProducts.Columns["CatName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


        }
        private void TxtProID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new MiniShopContext())
                {
                    try
                    {
                        var pro = from p in db.Products
                                  where p.ProId.Equals(TxtProID.Text)
                                  join c in db.Categories on p.CatId equals c.CatId
                                  select new
                                  {
                                      p.ProId,
                                      p.ProName,
                                      p.ProSize,
                                      p.ProCost,
                                      p.ProPrice,
                                      p.ProQty,
                                      c.CatName,
                                  };
                        if (pro.Count() == 1)
                        {
                            DgvProducts.DataSource = pro.ToList();
                            DgvStockStyle();
                            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " ProductID KeyDown:" + '"' + TxtProID.Text + '"');


                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูลของสินค้าที่ต้องการ กรุณาค้นหาใหม่", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " ProductID KeyDown:" + '"' + TxtProID.Text + '"' + " Not found");
                            TxtProID.Clear();
                            TxtProID.Focus();
                            this.GetDataProduct();
                            return;

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DgvProroducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string _ProID = DgvProducts.Rows[e.RowIndex].Cells["proID"].Value.ToString();
            using (var db = new MiniShopContext())
            {
                try
                {
                    var pro = (from p in db.Products
                              where p.ProId.Equals(_ProID)
                              join c in db.Categories on p.CatId equals c.CatId
                              select new
                              {
                                  p.ProId,
                                  p.ProName,
                                  p.ProSize,
                                  p.ProCost,
                                  p.ProPrice,
                                  p.ProQty,
                                  p.ProPhoto,
                                  c.CatName,
                              }).ToList();

                    if (pro.Count() == 1)
                    {

                        TxtProID.Text = pro[0].ProId.ToString();
                        TxtProName.Text = pro[0].ProName.ToString();
                        TxtProSize.Text = pro[0].ProSize.ToString();
                        TxtProCost.Text = pro[0].ProCost.ToString();
                        TxtProPrice.Text = pro[0].ProPrice.ToString();
                        TxtProQty.Text = pro[0].ProQty.ToString();

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
                                    using (FileStream stream = new FileStream(SysConfig.PathImagesProduct + pro[0].ProPhoto.ToString(),
                                        FileMode.Open,
                                        FileAccess.Read,
                                        FileShare.Delete))
                                    {
                                        PtbProduct.Image = Image.FromStream(stream);
                                        PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                        stream.Close();
                                        stream.Dispose();                                       
                                    }
                                }
                                else
                                {
                                    PtbProduct.Image = Properties.Resources.selectPhoto;
                                    PtbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                break;
                        }
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Cell Click ProductID:" + '"' + _ProID + '"');
                    }
                    else
                    {
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Cell Click ProductID:" + '"' + _ProID + '"' + " Not found");
                        MessageBox.Show("ไม่พบสินค้า กรุณาเลือกสินค้าใหม่","สินค้า",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtProID.Text != "")
                {
                    Form f = Application.OpenForms["FrmProCRUD"];
                    if (((FrmProCRUD)f) != null)
                    {
                        f.Close();
                    }
                    _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click add stock productID:"+'"'+TxtProID.Text+'"');

                    FrmProCRUD frm = new FrmProCRUD(_EmpId, TxtProID.Text, "AddStock");
                    frm.Show();

                }
                else
                {
                    _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click add stock productID:" + '"' + TxtProID.Text + '"'+" Not found");
                    MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการเพิ่มสต๊อกก่อน !", "สต๊อกสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtProID.Text != "")
                {
                    Form f = Application.OpenForms["FrmProCRUD"];
                    if (((FrmProCRUD)f) != null)
                    {
                        f.Close();
                    }
                    _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click edit productID:" + '"' + TxtProID.Text + '"');

                    FrmProCRUD frm = new FrmProCRUD(_EmpId,TxtProID.Text, "EditProduct");
                    frm.Show();

                }
                else
                {
                    _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click edit productID:" + '"' + TxtProID.Text + '"' + " Not found");
                    MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการแก้ไขก่อน !", "แก้ไขสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = Application.OpenForms["FrmProCRUD"];
                if (((FrmProCRUD)f) != null)
                {
                    f.Close();
                }
                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click add productID:" + '"' + "New" + '"');
                FrmProCRUD frm = new FrmProCRUD(_EmpId,"", "AddProduct");
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnNewLoad_Click(object sender, EventArgs e)
        {
            try
            {
                this.GetDataProduct();
                TxtProID.Clear();
                TxtProName.Clear();
                TxtProSize.Clear();
                TxtProCost.Clear();
                TxtProPrice.Clear();
                TxtProQty.Clear();
                PtbProduct.Image = Properties.Resources.selectPhoto;
                PtbEmp.SizeMode = PictureBoxSizeMode.StretchImage;
                _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click new load product list");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Close();
            frm.Show();
        }
    }
}
