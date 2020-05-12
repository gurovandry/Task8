using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XMLproperties;
using XMLSeek;

namespace PC_Searching
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        private string file_path;

        /// <summary>
        /// констуруктор формы
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public Form1(string path)
        {
            file_path = path;
            InitializeComponent();
        }

        /// <summary>
        /// метод возврата значения пути к файлу
        /// </summary>
        /// <returns>путь к файлу</returns>
        public string XMLpath()
        {
            return file_path;
        }

        /// <summary>
        /// обработка нажатия нового файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new Forms.Form2(this);
            form2.Show();
        }

        /// <summary>
        /// обработка нажатия на кнопку фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new Forms.Form3(this);
            form3.Show();
        }
        /// <summary>
        /// методод вывода списка записей на листбокс
        /// </summary>
        /// <param name="records"></param>
        public void print_list(XMLRecord[] records)
        {
            listBox1.Items.Clear();
            foreach (var it in records)
            {
                if (it.Code == null)
                {
                    MessageBox.Show("No Data Found");
                }
                else
                {
                    
                    listBox1.Visible = true;
                    listBox1.Items.Add(it.Code + " " + it.Cpu + " " +
                            it.Freq + " " + it.Ram + " " + it.Hdd + " " + it.Vm + " " +
                            it.Price + " " + it.Count);
                }
            }
        }

        /// <summary>
        /// обработка нажатия на кнопу очистить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = false;
        }

        /// <summary>
        /// обработка нажатия на кнопку показать всё
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XMLSearch search_list = new XMLSearch(file_path);
            XMLRecord[] records = search_list.Search_Data(null, null,
                null, null, true);
            print_list(records);
        }

        /// <summary>
        /// обработка нажатия на кнопку удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropFromAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                MessageBox.Show("Please, choose record!");
        }

        /// <summary>
        /// обработка нажатия на кнопку удалить из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var del_string = listBox1.SelectedIndex.ToString();
                string str = listBox1.Items[Convert.ToInt16(del_string)].ToString();
                string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string drop_this = words[0];
                XElement doc = XElement.Load(file_path);
                XMLRecord.del_record(file_path, drop_this);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
                MessageBox.Show("Please, choose record!");
        }
    }
}
