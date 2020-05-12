using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLproperties;

namespace XMLSeek
{
    /// <summary>
    /// класс работы с поиском записей
    /// </summary>
    public class XMLSearch
    {
        private string pathToXML;
        public XMLSearch(string path)
        {
            pathToXML = path;
        }
        /// <summary>
        /// метод поиска записи по значениям
        /// </summary>
        /// <param name="cpu">цп</param>
        /// <param name="ram">озу</param>
        /// <param name="vm">видео карта</param>
        /// <param name="hdd">пзу</param>
        /// <param name="all">флаг поиска всех записей</param>
        /// <returns></returns>
        public XMLRecord[] Search_Data(string cpu, string ram, string vm, string hdd, bool all)
        {
            bool f1 = true;
            bool f2 = true;
            bool f3 = true;
            bool f4 = true;
            XDocument xdoc = XDocument.Load(pathToXML);

            var items_all = from xe in xdoc.Element("PCs").Elements("PC")
                        where xe.Attribute("code").Value != null
                        select xe;
            var items_cpu = from xe in xdoc.Element("PCs").Elements("PC")
                            where xe.Element("cpu").Value == cpu
                            select xe;
            var items_ram = from xe in xdoc.Element("PCs").Elements("PC")
                           where xe.Element("ram").Value == ram
                           select xe;
            var items_vm = from xe in xdoc.Element("PCs").Elements("PC")
                           where xe.Element("vm").Value == cpu
                           select xe;
            var items_hdd = from xe in xdoc.Element("PCs").Elements("PC")
                            where xe.Element("hdd").Value == cpu
                            select xe;
            if ((cpu != "") & (items_all.Intersect(items_cpu).Count() != 0))
            {
                items_all = items_all.Intersect(items_cpu);
                f1 = false;
            }
            if ((ram != "") & (items_all.Intersect(items_ram).Count() != 0))
            {
                items_all = items_all.Intersect(items_ram);
                f2 = false;
            }
            if ((vm != "") & (items_all.Intersect(items_vm).Count() != 0))
            {
                items_all = items_all.Intersect(items_vm);
                f3 = false;
            }
            if ((hdd != "") & (items_all.Intersect(items_hdd).Count() != 0))
            {
                items_all = items_all.Intersect(items_hdd);
                f4 = false;
            }

            if (f1 & f2 & f3 & f4 & !all)
            {
                XMLRecord record = new XMLRecord(null, null, null, null, null, null, null, null);
                XMLRecord[] str_result = new XMLRecord[1];
                str_result[0] = record;
                return str_result;
            }
            else 
            {
                XMLRecord[] str_result;
                str_result = new XMLRecord[items_all.Count()];
                int i = 0;
                foreach (var it in items_all)
                {
                    
                    XMLRecord record_mas = new XMLRecord(it.Attribute("code").Value, it.Element("cpu").Value,
                        it.Element("freq").Value, it.Element("ram").Value,
                        it.Element("hdd").Value, it.Element("vm").Value,
                        it.Element("price").Value, it.Element("count").Value);
                    str_result[i] = record_mas;
                    i++;
                }
                return str_result;
            }
        }
    }
}