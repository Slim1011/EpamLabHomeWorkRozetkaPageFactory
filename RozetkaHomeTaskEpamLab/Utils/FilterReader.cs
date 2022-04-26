using RozetkaHomeTaskEpamLab.DataSource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RozetkaHomeTaskEpamLab.Utils
{
    class FilterReader
    {
        private Filters filters;

        public FilterReader()
        {
            this.filters =  ReadFromXMLFile();
        }


        public  static Filters ReadFromXMLFile()
        {
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(Filters));
                try
                {
                    string path = Directory.GetCurrentDirectory();
                    path = path.Substring(0, path.Length - 17);
                    path = Path.Combine(path, @"DataSource\Filters.xml");
                    using (Stream fStream = File.OpenRead(path))
                    {
                        return (Filters)xmlFormat.Deserialize(fStream);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Can`t open filter file");
                    return null;
                }
            }
        }
        public string GetTypeOfGood()
        {
            return filters.TypeOfGood;
        }
        public string GetBrand()
        {
            return filters.Brand;
        }
        public string GetTypeOfSort()
        {
            return filters.TypeOfSort;
        }
        public int GetPriceLimit()
        {
            return filters.PriceLimit;
        }
    }
}
