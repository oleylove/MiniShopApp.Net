using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniShopApp
{
    public partial class FrmSettings : Form
    {
        public Config SysConfig = new Config();
        public static FrmSettings This = null;

        public FrmSettings()
        {
            InitializeComponent();

            SysConfig = new Config();
            This = this;
            Config deserSetting = SysConfig.DeserializeFromXML();
            if (deserSetting != null)
            {
                SysConfig = deserSetting;
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            pgConfig.SelectedObject = SysConfig;
        }

        private void pgConfig_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SysConfig.SerailizeToXml();
            pgConfig.Refresh();

        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
