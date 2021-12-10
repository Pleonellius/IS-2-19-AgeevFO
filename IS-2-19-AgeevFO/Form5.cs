using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassLibrary3;

namespace IS_2_19_AgeevFO
{
    public partial class Form5 : Form
    {
        MySqlConnection conn;
        //Строка для подчения к БД
        readonly string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создаём экземпляр 
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //Открываем соединение
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO t_PraktStud (fioStud,datetimeStud) " +
                   "VALUES (@name, @date)", conn))
                {
                    //Условная конструкция
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Введите Ф.И.О студента");
                    }
                    else
                    {
                        //Использование параметров в запросах. Это повышает безопасность работы программы
                        cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@date", MySqlDbType.Timestamp).Value = dateTimePicker1.Value;
                        int insertedRows = cmd.ExecuteNonQuery();
                        // закрываем подключение  БД
                        conn.Close();
                    }
                }
            }
        }
        //Закрытие формы
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
