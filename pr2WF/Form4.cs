using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2WF
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder str1 = new StringBuilder();
            StringBuilder str2 = new StringBuilder();
            str1.Append(3);
            str2.Append(0);
            label2.Text = $"{str1}\n";
            label2.Text = $"{str2}\n";
            int k = 9;
            for (int i = 5; i > 1; i--)
            {
                for (int j = 0; j < 1; j++)
                {
                    str1.Insert(0, 2 + " ");
                    label2.Text += $"{str1}";
                }
                label2.Text += $"\n";
                for (int j = 0; j < 1; j++)
                {
                    str2.Insert(0, k + " ");
                    label2.Text += $"{str2}";
                    k--;
                }
                label2.Text += $"\n";
            }
        }
    }
}
