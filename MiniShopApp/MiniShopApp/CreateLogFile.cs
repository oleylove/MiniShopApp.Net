using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace MiniShopApp
{
    public class CreateLogFile
    {
        private readonly string _PathLog = ConfigurationManager.AppSettings["PathLog"] + "\\" + DateTime.Today.ToString("yyyy") + "\\" + DateTime.Today.ToString("MM") + "\\";

        public CreateLogFile(string logMessage)
        {
            LogWrite(logMessage);
        }

        public void LogWrite(string logMessage)
        {
            try
            {
                string logFormat = "[" + DateTime.Now.ToLongTimeString().ToString() + "] ";

                if (!File.Exists(_PathLog))
                {
                    Directory.CreateDirectory(_PathLog);
                }

                Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
                using (StreamWriter writer = File.AppendText(_PathLog + DateTime.Today.ToString("dd-MM-yyyy") + ".log"))
                {
                    writer.WriteLine(logFormat + logMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LogWrite \n" + ex.Message);
            }
        }
    }
}
