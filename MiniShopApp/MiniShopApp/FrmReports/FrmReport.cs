using MiniShopApp.Models.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace MiniShopApp.FrmReports
{
    public partial class FrmReport : Form
    {
        private int _SaleYear;
        private readonly MiniShopContext db = new MiniShopContext();
        public FrmReport()
        {
            InitializeComponent();

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            FillChartSaleMonth();
            FillChartSaleYear();
        }
        private void FillChartSaleYear()
        {
            //var Sale = (from s in db.Sales
            //                  group s by s.SaleCreate.Value.Year into g
            //                  select new
            //                  {
            //                      Year = g.Key,
            //                      Total = g.Sum(x => x.SaleAmount),
            //                  }).ToArray();

            var Sale = db.Sales.Select(k => new { k.SaleCreate.Value.Year, k.SaleAmount })
                .GroupBy(x => new { x.Year }, (key, group) => new
                {
                    _Year = key.Year,
                    _SaleAmount = group.Sum(k => k.SaleAmount)
                })
                .OrderBy(j => j._Year).ToList();


            List<string> SaleYear = new List<string>();
            List<double> SaleAmount = new List<double>();

            foreach (var item in Sale)
            {
                SaleYear.Add(Convert.ToString(item._Year));
                SaleAmount.Add(Convert.ToDouble(item._SaleAmount));
            }

            CboSelectYear.DataSource = SaleYear;
            CboSelectYear.Text = SaleYear.Max();
            _SaleYear = Convert.ToInt32(SaleYear.Max());
            ChartSaleYear.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "รายได้",
                    Values = new ChartValues<double>(SaleAmount),
                    //DataLabels = true,
                }
            };
            ChartSaleYear.Series.Add(new ColumnSeries
            {
                Title = "รายจ่าย",
                Values = new ChartValues<double>(SaleAmount),
                //DataLabels = true,
            });

            ChartSaleYear.AxisX.Add(new Axis
            {
                Labels = SaleYear,
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });
            ChartSaleYear.AxisY.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void FillChartSaleMonth()
        {
            if (int.TryParse(CboSelectYear.Text, out int _Year))
            {
                _SaleYear = _Year;
            }
            //var Sale = db.Sales.Where(j=>j.SaleCreate.Value.Year.Equals(_SaleYear))
            //    .Select(k => new { k.SaleCreate.Value.Year, k.SaleCreate.Value.Month, k.SaleAmount })
            //    .GroupBy(x => new { x.Year, x.Month }, (key, group) => new
            //    {
            //        _Year = key.Year,
            //        _Month = key.Month,
            //        _SaleAmount = group.Sum(k => k.SaleAmount)
            //    })
            //    .OrderBy(j=>j._Year).ToList();

            var Sale = db.Sales.Where(j => j.SaleCreate.Value.Year.Equals(_SaleYear))
                .Select(k => new { k.SaleCreate.Value.Month, k.SaleAmount })
                .GroupBy(x => new { x.Month }, (key, group) => new
                {
                    _Month = key.Month,
                    _SaleAmount = group.Sum(k => k.SaleAmount)
                })
                .OrderBy(j => j._Month).ToList();


            //List<int> SaleMonth = new List<int>();
            List<double> SaleAmount = new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (var item in Sale)
            {
                SaleAmount[item._Month - 1] = item._SaleAmount;
            }
            ChartSaleMonth.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "รายได้",
                    Values = new ChartValues<double>(SaleAmount),
                    StrokeThickness = 1,
                    //DataLabels = true,
                    //Fill = System.Windows.Media.Brushes.Green,
        }
            };
            //System.Windows.Controls.Panel.SetZIndex(ChartSaleMonth, 3);
            //ChartSaleMonth.StrokeDashArray = new DoubleCollection { 2 };
            //ChartSaleMonth.StrokeThickness = 3;
            ChartSaleMonth.Series.Add(new ColumnSeries
            {
                Title = "รายจ่าย",
                Values = new ChartValues<double>(SaleAmount),
                //DataLabels = true,
            });


            ChartSaleMonth.AxisX.Add(new Axis
            {
                //Labels = SaleMonth,
                Labels = new[] { "ม.ค.", "ก.พ.", "มี.ค.", "เม.ย", "พ.ค.", "มิ.ย.", "ก.ค.", "ส.ค.", "ก.ย.", "ต.ค.", "พ.ย.", "ธ.ค." },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            });

            ChartSaleMonth.AxisY.Add(new Axis
            {

                LabelFormatter = value => value.ToString("N")
            });
        }

        //private void BtnView_Click(object sender, EventArgs e)
        //{
        //    ChartSaleMonth.Series.Clear();
        //    ChartSaleMonth.AxisX.Clear();
        //    ChartSaleMonth.AxisY.Clear();
        //    FillChartSaleMonth();
        //}

        private void CboSelectYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartSaleMonth.Series.Clear();
            ChartSaleMonth.AxisX.Clear();
            ChartSaleMonth.AxisY.Clear();
            FillChartSaleMonth();

        }
    }
}
