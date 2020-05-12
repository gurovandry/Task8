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

namespace PC_Searching.Forms
{
    /// <summary>
    /// класс форму номер 2 - новогй записи
    /// </summary>
    public partial class Form2 : Form
    {
        public Form1 MainForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            MainForm = form1;
        }

        /// <summary>
        /// обработка нажатия на кнопку пинять
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data_set = new string[8];
            data_set[0] = code_text_box.Text;
            data_set[1] = cpu_text_box.Text;
            data_set[2] = freq_text_box.Text;
            data_set[3] = ram_text_box.Text;
            data_set[4] = hdd_text_box.Text;
            data_set[5] = vm_text_box.Text;
            data_set[6] = price_text_box.Text;
            data_set[7] = count_text_box.Text;
            bool correct = false;
            foreach (string s in data_set)
            {
                if (s.Replace(" ", "").Length == 0)
                {
                    correct = false;
                    break;
                }
                else
                {
                    correct = true;
                }
            }
            if (correct)
            {
                XMLRecord record = new XMLRecord(data_set[0], data_set[1], data_set[2], data_set[3],
                        data_set[4], data_set[5], data_set[6], data_set[7]);
                if (record.is_UniqueXML_record(MainForm.XMLpath()))
                {
                    record.ToXMLInput(MainForm.XMLpath());
                    code_text_box.Clear();
                    cpu_text_box.Clear();
                    freq_text_box.Clear();
                    ram_text_box.Clear();
                    hdd_text_box.Clear();
                    vm_text_box.Clear();
                    price_text_box.Clear();
                    count_text_box.Clear();
                }
                else
                {
                    MessageBox.Show("Not Unique Data");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Data");
            }
            correct = false;
        }
    }
}
