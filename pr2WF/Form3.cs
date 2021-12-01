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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = 100, p, t;
            while (n < 1000)
            {
                p = Convert.ToInt32(n / 100);
                t = n % 10;
                if (p == t)
                    wh.Text += $"{n}\n";
                n++;
            }
            n = 100;
            Console.WriteLine();
            Console.WriteLine("do...while");
            do
            {
                p = Convert.ToInt32(n / 100);
                t = n % 10;
                if (p == t)
                    d.Text += $"{n}\n";
                n++;
            } while (n < 1000);
            Console.WriteLine();
            Console.WriteLine("for");
            for (n = 100; n < 1000; n++)
            {
                p = Convert.ToInt32(n / 100);
                t = n % 10;
                if (p == t)
                    f.Text += $"{n}\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
