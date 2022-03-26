using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using MiniShopApp.Models.db;
using System.Configuration;
using System.IO;

namespace MiniShopApp.FamSales
{
    public partial class FrmSalesDtl : Form
    {
        public string _EmpId;
        //public string _PathImagesEmp = ConfigurationManager.AppSettings["PathImagesEmp"];
        public Config SysConfig = new Config();
        public static FrmSalesDtl This = null;

        public FrmSalesDtl(string _EmpId)
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

        private void FrmSalesDtl_Load(object sender, EventArgs e)
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
                        if (employee.EmpRole == "เจ้าของร้าน")
                        {
                            TxtEmpId.Enabled = true;
                        }
                        else
                        {
                            TxtEmpId.Enabled = false;
                            TxtEmpId.Text = employee.EmpId.ToString();
                        }

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
                        this.GetDataSale();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SalesDtlLoad \n"+ex.Message);
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

        public void GetDataSale()
        {
            try
            {
                using (var db = new MiniShopContext())
                {
                    var emp = db.Employees.FirstOrDefault(em => em.EmpId.Equals(_EmpId));
                    if (emp != null)
                    {
                        if (emp.EmpRole == "เจ้าของร้าน")
                        {
                            var sales = from s in db.Sales
                                        select new
                                        {
                                            s.SaleId,
                                            s.SaleAmount,
                                            s.SaleCreate,
                                        };
                            DgvSale.DataSource = sales.ToList();
                            DgvSaleStyle();
                        }
                        else
                        {
                            var sales = from s in db.Sales
                                        where s.EmpId.Equals(_EmpId)
                                        select new
                                        {
                                            s.SaleId,
                                            s.SaleAmount,
                                            s.SaleCreate,
                                        };
                            DgvSale.DataSource = sales.ToList();
                            DgvSaleStyle();
                        }
                        double SaleAmount = 0;
                        for (int i = 0; i < DgvSale.Rows.Count; i++)
                        {
                            SaleAmount += Convert.ToDouble(DgvSale.Rows[i].Cells["SaleAmount"].Value);
                        }

                        LabSaleAmount.Text = String.Format("{0:0,0.00}", SaleAmount) + " บาท";
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลพนักงาน",Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetDataSale \n"+ex.Message);   
            }
        }

        public void DgvSaleStyle()
        {
            for (int rowCount = 0; rowCount < DgvSale.Rows.Count; rowCount++)
            {
                DgvSale.Rows[rowCount].Cells["orderRows"].Value = rowCount + 1;

            }
            DgvSale.Columns["SaleId"].HeaderText = "รหัสการขาย";
            DgvSale.Columns["SaleAmount"].HeaderText = "ยอดขาย";
            DgvSale.Columns["SaleCreate"].HeaderText = "วันที่ขาย";

            DgvSale.Columns["SaleAmount"].DefaultCellStyle.Format = "F2";

            DgvSale.Columns["orderRows"].Width = 58;
            DgvSale.Columns["SaleId"].Width = 120;
            DgvSale.Columns["SaleAmount"].Width = 115;
            DgvSale.Columns["SaleCreate"].Width = 110;

            DgvSale.Columns["orderRows"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSale.Columns["SaleId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSale.Columns["SaleAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSale.Columns["SaleCreate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvSale.Columns["orderRows"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSale.Columns["SaleId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSale.Columns["SaleAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSale.Columns["SaleCreate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void DgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int _SaleId = int.Parse(DgvSale.Rows[e.RowIndex].Cells["SaleId"].Value.ToString());
                using (var db = new MiniShopContext())
                {
                    var saledtl = from s in db.Sales where s.SaleId.Equals(_SaleId)
                                  join d in db.SalesDtl on s.SaleId equals d.SaleId
                                  join em in db.Employees on s.EmpId equals em.EmpId
                                  join p in db.Products on d.ProId equals p.ProId
                                  select new
                                  {
                                      em.EmpName,
                                      p.ProName,
                                      p.ProSize,
                                      p.ProPrice,
                                      d.SdtQty,
                                      d.SdtAmount,
                                  };


                    DgvSaleDtl.DataSource = saledtl.ToList();
                    DgvSaleDtlStyle();
                    _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Cell click saleID:" + '"' + _SaleId.ToString() + '"');

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DgvSaleDtlStyle()
        {
            for (int rowCount2 = 0; rowCount2 < DgvSaleDtl.Rows.Count; rowCount2++)
            {
                DgvSaleDtl.Rows[rowCount2].Cells["orderRows2"].Value = rowCount2 + 1;
            }
            DgvSaleDtl.Columns["EmpName"].HeaderText = "พนักงานขาย";
            DgvSaleDtl.Columns["ProName"].HeaderText = "ชื่อสินค้า";
            DgvSaleDtl.Columns["ProSize"].HeaderText = "ขนาด";
            DgvSaleDtl.Columns["ProPrice"].HeaderText = "ราคา";
            DgvSaleDtl.Columns["SdtQty"].HeaderText = "จำนวน";
            DgvSaleDtl.Columns["SdtAmount"].HeaderText = "รวม";

            DgvSaleDtl.Columns["ProPrice"].DefaultCellStyle.Format = "F2";
            DgvSaleDtl.Columns["SdtAmount"].DefaultCellStyle.Format = "F2";

            DgvSaleDtl.Columns["orderRows2"].Width = 60;
            DgvSaleDtl.Columns["EmpName"].Width = 120;
            DgvSaleDtl.Columns["ProName"].Width = 160;
            DgvSaleDtl.Columns["ProSize"].Width = 100;
            DgvSaleDtl.Columns["ProPrice"].Width = 90;
            DgvSaleDtl.Columns["SdtQty"].Width = 80;
            DgvSaleDtl.Columns["SdtAmount"].Width = 100;

            DgvSaleDtl.Columns["orderRows2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDtl.Columns["EmpName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDtl.Columns["ProName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDtl.Columns["ProSize"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDtl.Columns["ProPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSaleDtl.Columns["SdtQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDtl.Columns["SdtAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DgvSaleDtl.Columns["orderRows2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDtl.Columns["EmpName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDtl.Columns["ProName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDtl.Columns["ProSize"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvSaleDtl.Columns["ProPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSaleDtl.Columns["SdtQty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvSaleDtl.Columns["SdtAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click search sale detail from->to:"+'"'+DtpBegin.Value.ToString()+"->"+DtbEnd.Value.ToString()+'"');

            using (var db = new MiniShopContext())
            {
                try 
                {
                    var sales = from s in db.Sales where s.SaleCreate >= DtpBegin.Value && s.SaleCreate <= DtbEnd.Value
                                select new
                                {
                                    s.SaleId,
                                    s.SaleAmount,
                                    s.SaleCreate,
                                };

                    DgvSale.DataSource = sales.ToList();
                    DgvSaleDtl.DataSource = null;
                    DgvSaleStyle();
                    double SaleAmount = 0;
                    for (int i = 0; i < DgvSale.Rows.Count; i++)
                    {
                        SaleAmount += Convert.ToDouble(DgvSale.Rows[i].Cells["SaleAmount"].Value);
                    }
                    LabSaleAmount.Text = String.Format("{0:0,0.00}", SaleAmount) + " บาท";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' + " Click clear data");
            DgvSaleDtl.DataSource = null;
            FrmSalesDtl_Load(sender,e);
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

        private void DtpBegin_ValueChanged(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' +
                " Date Begin Value Changed:"+'"'+ DtpBegin.Value.ToString()+'"');

        }

        private void DtbEnd_ValueChanged(object sender, EventArgs e)
        {
            _ = new CreateLogFile("EmployeeID:" + '"' + _EmpId + '"' +
                " Date End Value Changed:" + '"' + DtpBegin.Value.ToString() + '"');

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Close();
            frm.Show();
        }
    }
}
