using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;

namespace MiniShopApp
{
    public class Config
    {

        //General
        private string _shopName = "ShopName";
        [Category("General")]
        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }

        private string _shopPhone = "ShopPhone";
        [Category("General")]
        public string ShopPhone
        {
            get { return _shopPhone; }
            set { _shopPhone = value; }
        }

        //Path
        private string _pathLogFile = @"D:\MiniShopApp\Log\";
        [Category("Path")]
        public string PathLogFile
        {
            get { return _pathLogFile; }
            set { _pathLogFile = value; }
        }

        private string _pathImagesEmployee = @"D:\MiniShopApp\EmployeeImages\";
        [Category("Path")]
        public string PathImagesEmployee
        {
            get { return _pathImagesEmployee; }
            set { _pathImagesEmployee = value; }
        }

        private string _pathImagesProduct = @"D:\MiniShopApp\ProductImages\";
        [Category("Path")]
        public string PathImagesProduct
        {
            get { return _pathImagesProduct; }
            set { _pathImagesProduct = value; }
        }

        private string _pathBackupDB = @"D:\MiniShopApp\Database\";
        [Category("Path")]
        public string PathBackupDB
        {
            get { return _pathBackupDB; }
            set { _pathBackupDB = value; }
        }


        public void SerailizeToXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            TextWriter textWriter = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\Setting.XML");
            serializer.Serialize(textWriter, this);
            textWriter.Close();
        }

        public Config DeserializeFromXML()
        {

            Config returnObject = null;
            try
            {
                TextReader reader = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\Setting.XML");
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                returnObject = (Config)serializer.Deserialize(reader);
                reader.Close();
            }
            catch
            {
                return null;
            }
            return returnObject;
        }

    }
}
