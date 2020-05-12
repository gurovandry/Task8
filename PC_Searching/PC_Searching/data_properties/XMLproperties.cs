using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using XMLSeek;


namespace XMLproperties
{
    /// <summary>
    /// класс работы с xml
    /// </summary>
    public class XMLRecord
    {
        public string Code { get; set; }
        public string Cpu { get; set; }
        public string Freq { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string Vm { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }

        /// <summary>
        /// констуктор класса
        /// </summary>
        /// <param name="code">код</param>
        /// <param name="cpu">цп</param>
        /// <param name="freq">частота</param>
        /// <param name="ram">озу</param>
        /// <param name="hdd">пзу</param>
        /// <param name="vm">видео карта</param>
        /// <param name="price">цена</param>
        /// <param name="count">количество</param>
        public XMLRecord(string code, string cpu, string freq, string ram, string hdd, string vm, string price, string count)
        {
            Code = code;
            Cpu = cpu;
            Freq = freq;
            Ram = ram;
            Hdd = hdd;
            Vm = vm;
            Price = price;
            Count = count;
        }

        /// <summary>
        /// метод занесения записи
        /// </summary>
        /// <param name="pathToXml"></param>
        public void ToXMLInput(string pathToXml)
        {
         
                XmlDocument document = new XmlDocument();
                document.Load(pathToXml);

                XmlNode element = document.CreateElement("PC");
                document.DocumentElement.AppendChild(element);
                XmlAttribute attribute = document.CreateAttribute("code");
                attribute.Value = Code;
                element.Attributes.Append(attribute);

                XmlNode subElement1 = document.CreateElement("cpu");
                subElement1.InnerText = Cpu;
                element.AppendChild(subElement1);

                XmlNode subElement2 = document.CreateElement("freq");
                subElement2.InnerText = Freq;
                element.AppendChild(subElement2);

                XmlNode subElement3 = document.CreateElement("ram");
                subElement3.InnerText = Ram;
                element.AppendChild(subElement3);

                XmlNode subElement4 = document.CreateElement("hdd");
                subElement4.InnerText = Hdd;
                element.AppendChild(subElement4);

                XmlNode subElement5 = document.CreateElement("vm");
                subElement5.InnerText = Vm;
                element.AppendChild(subElement5);

                XmlNode subElement6 = document.CreateElement("price");
                subElement6.InnerText = Price;
                element.AppendChild(subElement6);

                XmlNode subElement7 = document.CreateElement("count");
                subElement7.InnerText = Count;
                element.AppendChild(subElement7);

                document.Save(pathToXml);
        }

        /// <summary>
        /// метод проверки записи на уникальность
        /// </summary>
        /// <param name="pathToXml">путь к файлу</param>
        /// <returns></returns>
        public bool is_UniqueXML_record(string pathToXml)
        {
            XMLSearch Find_record_class = new XMLSearch(pathToXml);
            XMLRecord[] FindXML = Find_record_class.Search_Data(Cpu, Ram, Vm, Hdd,true);
            foreach (var s in FindXML)
            {
                if (s.Code == Code)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// метод удаляения записи
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <param name="drop_this">значения строки удаления</param>
        public static void del_record(string path, string drop_this)
        {
            XElement doc = XElement.Load(path);
            doc.Elements("PC").Where(p => p.Attribute("code").Value == drop_this).Remove();
            doc.Save(path);
        }
    }
    
}