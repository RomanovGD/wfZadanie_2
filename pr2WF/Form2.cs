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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox1.Text, out n))
            {              
                switch (n)
                {
                    case 1: label5.Text = "Новости \n«Время покажет»"; break;
                    case 2: label5.Text = "Вести \n«Судьба человека» \n«Личное дело»"; break;
                    case 3: label5.Text = label5.Text = "«Сваты»"; break;
                    case 4: label5.Text = "«Воронины» \n«Послезавтра»"; break;
                    case 5: label5.Text = "«Три кота» \n«Ералаш» \n«Маша и медведь»"; break;
                    case 6: label5.Text = "«Вокруг света» \n«Уроки выживания»"; break;
                    case 7: label5.Text = "«Орёл и решка»"; break;
                    case 8: label5.Text = "«Звёздные войны» \n«Стартрек»"; break;
                    case 9: label5.Text = "«Мертвые души» \n«Война и мир» \n«Екатерина»"; break;
                    case 10: label5.Text = "«Судьба: Сага Викс» \n«Рагнарек»"; break;
                    case 11: label5.Text = "«Мстители»\n«Человек-паук» \n«Черная пантера» \n«Стражи Галактики»"; break;
                    case 12: label5.Text = "«Чужой» \n«Чужой против Хищника»"; break;
                    case 13: label5.Text = "«Кошмар на улице Вязов» \n«Сонная Лощина» \n«Кладбище домашних животных»"; break;
                    case 14: label5.Text = "«Алиса в Зазеркалье»"; break;
                    case 15: label5.Text = "«Маугли» \n«Ну, погоди!» \n«Трое из Простоквашино»"; break;
                    default: label5.Text = "У Вас нет этого канала :("; break;

                }
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
