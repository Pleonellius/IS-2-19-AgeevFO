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

namespace IS_2_19_AgeevFO
{
    public partial class Form2 : Form
    {
        //Класс для подключения к БД
        static class DBUtils
        {
            public static string GetDBConnection()
            {
                string host = "caseum.ru";
                string port = "33333";
                string database = "db_test";
                string username = "test_user";
                string password = "test_pass";
                string connString = $"server={host};port={port};user={username};database={database};password={password};";
                return connString;
            }
        }
        //Создание объекта для подключения к БД
        MySqlConnection conn = new MySqlConnection(DBUtils.GetDBConnection());
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Если подключение установленно, то выводится MessageBox с надписью Подключено
            try
            {
                conn.Open();
                MessageBox.Show("Подключено");
            }
            //Если подключение не установленно, то выводится ошибка и название ошибки
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex);
            }
            finally
            {

            }
        }
        //Закрытие формы
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
