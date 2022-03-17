using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MiniShopApp.Models.db;

namespace MiniShopApp.FrmReports
{
    public partial class FrmReceipt : Form
    {
        public int _SaleId;
        public string _Cash;
        public string _Change;
        public string _ShopName = ConfigurationManager.AppSettings["ShopName"];
        public string _ShopPhone = ConfigurationManager.AppSettings["ShopPhone"];
        public FrmReceipt(int _SaleId, string _Cash, string _Change)
        {
            InitializeComponent();
            this._SaleId = _SaleId;
            this._Cash = _Cash;
            this._Change = _Change;
        }


        private void FrmReceipt_Load(object sender, EventArgs e)
        {

            using (var db = new MiniShopContext())
            {
                var sale = db.SalesDtl.FirstOrDefault(SaleId => SaleId.SaleId.Equals(_SaleId));
                if (sale != null)
                {
                    var receipt = (from s in db.Sales
                                   join std in db.SalesDtl on s.SaleId equals std.SaleId
                                   join p in db.Products on std.ProId equals p.ProId
                                   where s.SaleId == _SaleId
                                   select new
                                   {
                                        s.SaleId,
                                        s.SaleAmount,
                                        s.SaleCreate,
                                        p.ProName,
                                        p.ProSize,
                                        p.ProPrice,
                                        std.SdtQty,
                                        std.SdtAmount,
                                   }).ToList();
                    DataTable dt = LINQResultToDataTable(receipt);
                    Receipt rpt = new Receipt();
                    rpt.SetDataSource(dt);
                    TextObject txtShopName = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["ShopName"];
                    TextObject txtShopPhone = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["ShopPhone"];
                    TextObject txtCash = (TextObject)rpt.ReportDefinition.Sections["Section4"].ReportObjects["Cash"];
                    TextObject txtChange = (TextObject)rpt.ReportDefinition.Sections["Section4"].ReportObjects["Change"];
                    txtShopName.Text = _ShopName;
                    txtShopPhone.Text = "Tel : " + _ShopPhone;
                    txtCash.Text =  _Cash;
                    txtChange.Text = _Change;
                    rptReceipt.ReportSource = rpt;
                }
            }
        }
        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;
            if (Linqlist == null) return dt;
            foreach (T Record in Linqlist)
            {
                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;
                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();
                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

    }
}
