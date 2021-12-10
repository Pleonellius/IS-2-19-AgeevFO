using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_AgeevFO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Открывает Form1
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
        //Открывает Form2
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        //Открывает Form3
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        //Открывает Form4
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
        //Открывает Form5
        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
        //Закрытие формы
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
