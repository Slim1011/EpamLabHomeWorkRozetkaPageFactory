using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RozetkaHomeTaskEpamLab.DataSource
{
    [Serializable]
    public class Filters
    {
        public string TypeOfGood { get; set; }
        public string Brand { get; set; }
        public string TypeOfSort { get; set; }
        public int PriceLimit { get; set; }


        public static readonly string FiltersFilePath = Path.Combine("DataSource", "Filters.xml");
       
        public static Filters RestoreCreate()
        {
            Filters result = null;
            if (File.Exists(FiltersFilePath))
            {
                using var strReader = new StreamReader(FiltersFilePath);
                var xmlSer = new XmlSerializer(typeof(Filters));
                result = (Filters)xmlSer.Deserialize(strReader);
            }

            if (result == null)
            {
                throw new Exception();
            }

            return result;
        }


        public static void InitCurrent()
        {
            m_Current = RestoreCreate();

        }
        public static Filters Current
        {
            get => m_Current;
        }

        private static Filters m_Current;
    }
}
