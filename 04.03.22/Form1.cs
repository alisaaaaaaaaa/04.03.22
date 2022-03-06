using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _04._03._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tab_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "+".ToString();
            TabPage tabPage3 = new TabPage(title);
            tab.TabPages.Add(tabPage3);
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://vm.tiktok.com/ZSeKECBdl/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 settings = new Form2();
            settings.Owner = this;
            settings.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surname.Text!= "" && name.Text != "" && description.Text != "")
            {
               DataGridViewRow newrow = new DataGridViewRow();
                students.Rows.Add(new object[] {surname.Text, name.Text,description.Text });

            }
            else
            {
                MessageBox.Show("Введите все данные");
            }
        }
    }
}
