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
using MiniShopApp.FrmReports;
using System.Configuration;

namespace MiniShopApp.FamSales
{
    public partial class FrmSale : Form
    {
        public int i = 0; //กำหนดแถวกิต
        public string _EmpId;
        public string _PathImagesEmp = ConfigurationManager.AppSettings["PathImagesEmp"];

        public FrmSale(string _EmpId)
        {
            InitializeComponent();
            this._EmpId = _EmpId;
        }
        private void FrmSale_Load(object sender, EventArgs e)
        {
            using (var db = new MiniShopContext())
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
                    TsstDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
                    DataGridViewStyle();
                    var employee = db.Employees.FirstOrDefault(emp => emp.EmpId.Equals(_EmpId));
                    if (employee != null)
                    {
                        TsslUserName.Text = "ผู้ใช้ : " + employee.EmpTitle.ToString() + employee.EmpName.ToString();
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click Clear Data");
            DgvSaleDetail.Rows.Clear();
            TxtCash.Clear();
            TxtKeyProID.Clear();
            LabTotalAmount.Text = "";
            LabChange.Text = "";
            LabChange.Text = "";
            i = 0;
            TxtKeyProID.Focus();
        }

        private void TxtCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (double.TryParse(TxtCash.Text, out double cash))
                    {
                        cash = double.Parse(TxtCash.Text);
                        double toltalAll = double.Parse(LabTotalAmount.Text);
                        if (cash < toltalAll)
                        {
                            MessageBox.Show("รับเงินมาผิดพลาด กรุณาดูเงินที่รับมา", "เงินทอน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LabChange.Text = "";
                            TxtCash.Clear();
                            TxtCash.Focus();
                            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Cash KeyDown:get paid wrong");
                            return;
                        }
                        else
                        {
                            double change = cash - toltalAll;
                            LabChange.Text = String.Format("{0:F2}", change);
                            BtnSave.Focus();
                            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Cash KeyDown:Cash->Toltal All->Change:" + cash + "->" + toltalAll + "->" + change);
                        }
                    }
                    else
                    {
                        MessageBox.Show("รับเงินมาผิดพลาด กรุณาดูเงินที่รับมา", "เงินทอน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCash.Clear();
                        TxtCash.Focus();
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Cash KeyDown:not numbers");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu(_EmpId);
            this.Close();
            frm.Show();
        }


        public void DataGridViewStyle()
        {
            DgvSaleDetail.Columns["Order"].Width = 60;
            DgvSaleDetail.Columns["ProId"].Width = 120;
            DgvSaleDetail.Columns["ProName"].Width = 250;
            DgvSaleDetail.Columns["ProSize"].Width = 115;
            DgvSaleDetail.Columns["ProPrice"].Width = 100;
            DgvSaleDetail.Columns["SdtQty"].Width = 90;
            DgvSaleDetail.Columns["SdtQty"].Width = 100;

            DgvSaleDetail.Columns["Order"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDetail.Columns["ProId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDetail.Columns["ProName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDetail.Columns["ProSize"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDetail.Columns["ProPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSaleDetail.Columns["SdtQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDetail.Columns["SdtAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DgvSaleDetail.Columns["Order"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDetail.Columns["ProId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDetail.Columns["ProName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDetail.Columns["ProSize"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDetail.Columns["ProPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSaleDetail.Columns["SdtQty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDetail.Columns["SdtAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void TxtKeyProID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new MiniShopContext())
                {
                    try
                    {
                        var pro = db.Products.FirstOrDefault(p => p.ProId.Equals(TxtKeyProID.Text));
                        if (pro != null)
                        {
                            if (int.TryParse(TxtProQty.Text, out int proQuantity) && TxtProQty.Text != "")
                            {
                                proQuantity = int.Parse(TxtProQty.Text.ToString());
                            }
                            else if (TxtProQty.Text == "")
                            {
                                proQuantity = 1;
                            }
                            string _ProId = "";
                            for (int ii = 0; ii < DgvSaleDetail.Rows.Count; ii++)
                            {
                                if (DgvSaleDetail.Rows[ii].Cells["ProId"].Value.ToString() == TxtKeyProID.Text.ToString())
                                {
                                    _ProId = DgvSaleDetail.Rows[ii].Cells["ProId"].Value.ToString();
                                    break;
                                }
                            }
                            if (_ProId == "")
                            {
                                DgvSaleDetail.Rows.Add();
                                DgvSaleDetail.Rows[i].Cells["Order"].Value = i + 1;
                                DgvSaleDetail.Rows[i].Cells["ProId"].Value = pro.ProId.ToString();
                                DgvSaleDetail.Rows[i].Cells["ProName"].Value = pro.ProName.ToString();
                                DgvSaleDetail.Rows[i].Cells["ProSize"].Value = pro.ProSize.ToString();
                                DgvSaleDetail.Rows[i].Cells["ProPrice"].Value = String.Format("{0:F2}", double.Parse(pro.ProPrice.ToString()));
                                DgvSaleDetail.Rows[i].Cells["SdtQty"].Value = proQuantity;
                                DgvSaleDetail.Rows[i].Cells["SdtAmount"].Value = String.Format("{0:F2}", double.Parse(pro.ProPrice.ToString()) * proQuantity);

                                _ = new CreateLogFile("EmployeeID:" + '"'+_EmpId+'"' + 
                                    " KeyDown ProductID:" + '"' + pro.ProId.ToString() + '"' + 
                                    " Price:"+'"'+ pro.ProPrice.ToString()+'"'+
                                    " Quantity:" + '"' + proQuantity + '"' + 
                                    " Amount:" + '"'+ DgvSaleDetail.Rows[i].Cells["SdtAmount"].Value.ToString() + '"');
                                i++;
                            }
                            else
                            {
                                for (int ii = 0; ii < DgvSaleDetail.Rows.Count; ii++)
                                {
                                    if (_ProId == DgvSaleDetail.Rows[ii].Cells["ProId"].Value.ToString())
                                    {
                                        proQuantity += int.Parse(DgvSaleDetail.Rows[ii].Cells["SdtQty"].Value.ToString());
                                        double total = double.Parse(pro.ProPrice.ToString()) * proQuantity;

                                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' +
                                            " KeyDown ProductID:" + '"' + pro.ProId.ToString() + '"' +
                                            " Price:" + '"' + pro.ProPrice.ToString() + '"' +
                                            " Chang Quantity Form->To:" + '"' + DgvSaleDetail.Rows[ii].Cells["SdtQty"].Value.ToString() + "->" + proQuantity + '"' +
                                            " Chang Amount Form->To:" + '"' + DgvSaleDetail.Rows[ii].Cells["SdtAmount"].Value.ToString() + "->" + total + '"');

                                        DgvSaleDetail.Rows[ii].Cells["SdtQty"].Value = proQuantity;
                                        DgvSaleDetail.Rows[ii].Cells["SdtAmount"].Value = String.Format("{0:F2}", total);
                                        break;
                                    }
                                }
                            }
                            double NetPay = 0;
                            for (int iii = 0; iii < i; iii++)
                            {
                                NetPay += double.Parse(DgvSaleDetail.Rows[iii].Cells["SdtAmount"].Value.ToString());
                            }
                            LabTotalAmount.Text = NetPay.ToString("#,###0.00");
                            TxtKeyProID.Clear();
                            TxtProQty.Clear();
                            TxtKeyProID.Focus();
                            DataGridViewStyle(); 
                        }
                        else
                        {
                            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " ProductID KeyDown:Product not found");                      
                            if (MessageBox.Show("ไม่พบสินค้าภายในร้านคะ กรุณาเพิ่มสิ้นค้ารายการใหม่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                            {
                                TxtKeyProID.Clear();
                                TxtKeyProID.Focus();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LabTotalAmount.Text == "" || TxtCash.Text == "" || LabChange.Text == "")
            {
                MessageBox.Show("ไม่สามารถบักกข้อมูลการขายได้ กรุณาตรวจสอบข้อมูลให้ถูกต้องก่อนบันทึก...!", "บันทึกรายการขาย", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCash.Clear();
                return;
            }
            else
            {
                using (var db = new MiniShopContext())
                {
                    //บัททึกการขายลง sale
                    Sales s = new Sales
                    {
                        EmpId = _EmpId,
                        SaleAmount = double.Parse(LabTotalAmount.Text),
                        SaleCreate = DateTime.Now
                    };
                    var trs = db.Database.BeginTransaction();
                    db.Sales.Add(s);
                    db.SaveChanges();
                    trs.Commit();

                    int _SaleId = s.SaleId;
                    var sale = db.Sales.FirstOrDefault(ss => ss.SaleId.Equals(_SaleId));
                    if (sale != null)
                    {
                        for (int ii = 0; ii < DgvSaleDetail.Rows.Count; ii++)
                        {
                            SalesDtl sdt = new SalesDtl
                            {
                                SaleId = _SaleId,
                                ProId = DgvSaleDetail.Rows[ii].Cells["ProId"].Value.ToString(),
                                SdtQty = int.Parse(DgvSaleDetail.Rows[ii].Cells["SdtQty"].Value.ToString()),
                                SdtAmount = double.Parse(DgvSaleDetail.Rows[ii].Cells["SdtAmount"].Value.ToString())
                            };
                            var trsdtl = db.Database.BeginTransaction();
                            db.SalesDtl.Add(sdt);
                            db.SaveChanges();
                            trsdtl.Commit();

                            // ตัด stock  จากตาราง Products
                            string _ProId = DgvSaleDetail.Rows[ii].Cells["ProId"].Value.ToString();
                            int _ProQty = int.Parse(DgvSaleDetail.Rows[ii].Cells["SdtQty"].Value.ToString());
                            var pro = db.Products.FirstOrDefault(p => p.ProId.Equals(_ProId));
                            if (pro != null)
                            {
                                pro.ProQty -= _ProQty;
                                var trp = db.Database.BeginTransaction();
                                db.SaveChanges();
                                trp.Commit();
                            }
                            else
                            {
                                MessageBox.Show("ไม่สามารตัด Stock สินค้าได้ เนื่องจากไม่มีรหัสของสินค้า", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Save Sale Click " +
                            " Amount : " + '"' + LabTotalAmount.Text + '"' +
                            " Cash : " + '"' + TxtCash.Text + '"' +
                            " Change : " + '"' + LabChange.Text + '"' +
                            " SaleID:" + '"' + _SaleId + '"' + "Successfully");

                        MessageBox.Show("บันทึกรายการขายแล้ว", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DgvSaleDetail.Rows.Clear();
                        LabTotalAmount.Text = "";
                        LabChange.Text = "";
                        TxtCash.Clear();
                        TxtKeyProID.Focus();
                        i = 0;
                        //FrmReceipt frm = new FrmReceipt(_SaleId);
                        //frm.Show();
                    }
                    else
                    {
                        _ = new CreateLogFile("EmployeeID : " + '"' + _EmpId + '"' + " Save Sale Click:Failed to sell, sales code not found.");
                        MessageBox.Show("ไม่สามารบันทึกการขายได้ เนื่องจากไม่มีรหัสการขาย", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
