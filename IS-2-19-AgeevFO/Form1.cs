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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Komplect<k>
        {
            //Переменные класса
            protected string price;
            protected string god;
            protected string articul;
            //Конструктор класса
            public Komplect(string Price, string God, string Articul)
            {
                price = Price;
                god = God;
                articul = Articul;
            }
            //Метод для вывода информации в listbox
            public abstract void Display(ListBox listBox1);
        }
        //Создание класса-наследника
        class CP : Komplect<string>
        {
            //Переменные класс
            public string chast;
            public string core;
            public string potoki;
            //Конструктор класс
            public CP(string Chast, string Core, string Potoki, string Price, string God, string Articul)
                : base(Price, God, Articul)
            {
                chast = Chast;
                core = Core;
                potoki = Potoki;
            }
            //Свойства для создания дополнительной логики полям
            public string chasta { get { return chast; } set { chast = value; } }
            public string cores { get { return core; } set { core = value; } }
            public string potoks { get { return potoki; } set { potoki = value; } }
            //Метод для вывода информации в listbox
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена - {price},Год - {god},Частота - {chast},Ядра - {core},Потоки - {potoki}, Артикуль - {articul}");
            }
        }
        //Создание второго класса-наследника
        class VideoCard : Komplect<string>
        {
            //Переменные класс
            public string chastgpu;
            public string proizvod;
            public string pamat;
            //Конструктор класс
            public VideoCard(string Price, string God, string Articul, string Chastgpu, string Proizvod, string Pamat)
                : base(Price, God, Articul)
            {
                chastgpu = Chastgpu;
                proizvod = Proizvod;
                pamat = Pamat;
            }
            //Свойства для создания дополнительной логики полям
            public string chastgpuu { get { return chastgpu; } set { chastgpu = value; } }
            public string proiz { get { return proizvod; } set { proizvod = value; } }
            public string pamats { get { return pamat; } set { pamat = value; } }
            //Метод для вывода информации в listbox
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена - {price},Год - {god},ЧастотаГПУ - {chastgpu},Производитель - {proizvod},Память - {pamat}, Артикуль - {articul}");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Присваивание переменным ТекстБоксы
            string price = Convert.ToString(textBox1.Text);
            string god = Convert.ToString(textBox2.Text);
            string chast = Convert.ToString(textBox3.Text);
            string core = Convert.ToString(textBox4.Text);
            string potoki = Convert.ToString(textBox5.Text);
            string articul = Convert.ToString(textBox6.Text);
            //Инициализая экземпляра класса
            CP cp1 = new CP(price, god, chast, core, potoki, articul);
            //Вывод в listbox
            cp1.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Присваивание переменным ТекстБоксы
            string price = Convert.ToString(textBox7.Text);
            string god = Convert.ToString(textBox8.Text);
            string chast = Convert.ToString(textBox9.Text);
            string proizvod = Convert.ToString(textBox10.Text);
            string pamat = Convert.ToString(textBox11.Text);
            string articul = Convert.ToString(textBox12.Text);
            //Инициализая экземпляра класса
            VideoCard vd1 = new VideoCard(price, god, chast, proizvod, pamat, articul);
            //Вывод в listbox
            vd1.Display(listBox1);
        }
        //Очитска listbox'a
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //Закрытие формы
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
