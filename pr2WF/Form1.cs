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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double x, y;
            if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
            {
                if (x * x + y * y < 100 && y < (Math.Abs(x)))
                    label5.Text = "Да";
                else if (x * x + y * y == 625 || y == 0 || y == (Math.Abs(x)))
                    label5.Text = "На границе";
                else label5.Text = "Нет";
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
