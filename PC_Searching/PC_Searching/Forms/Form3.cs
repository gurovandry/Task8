using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLproperties;
using XMLSeek;

namespace PC_Searching.Forms
{
    /// <summary>
    /// конструктор формы 3 - фильтра для поиска
    /// </summary>
    public partial class Form3 : Form
    {
        public Form1 MainForm;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            MainForm = form1;
        }

        /// <summary>
        /// обработка закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        /// <summary>
        /// обработка нажатия кнопки поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_button_Click(object sender, EventArgs e)
        {
            if ((cpu_text_box.Text == "") & (ram_text_box.Text == "") &
                (vm_text_box.Text == "") & (hdd_text_box.Text == ""))
            {
                MessageBox.Show("Empty Filtres");
            }
            else
            {
                XMLSearch search_list = new XMLSearch(MainForm.XMLpath());
                XMLRecord[] records = search_list.Search_Data(cpu_text_box.Text, ram_text_box.Text,
                    vm_text_box.Text, hdd_text_box.Text, false);
                MainForm.print_list(records);
                this.Close();
            }
        }
        

    }
}
