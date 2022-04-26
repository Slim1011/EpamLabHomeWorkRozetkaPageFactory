using RozetkaHomeTaskEpamLab.DataSource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RozetkaHomeTaskEpamLab.Utils
{
    class PropertyReader
    {
        private Properties properties;

        public PropertyReader()
        {
            ReadPropertiesFromXML();
        }

        private void ReadPropertiesFromXML()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Properties));
            try
            {
                string path = Directory.GetCurrentDirectory();
                path = path.Substring(0, path.Length - 17);
                path = Path.Combine(path, @"DataSource\Properties.xml");
                using (Stream fStream = File.OpenRead(path))
                {
                    properties = (Properties)xmlFormat.Deserialize(fStream);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("I cannot open properties file");
            }
        }
        public string GetURL()
        {
            return properties.URL;
        }
    }
}

