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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Создание экземпляра
            Class1 conn4 = new Class1();
            MySqlConnection connect = new MySqlConnection(conn4.connDB);
            string sql = $"SELECT idStud, fioStud, drStud FROM t_datetime";
            //Проверка подключения
            try
            {
                connect.Open();

                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, connect);

                DataSet dataset = new DataSet();

                IDataAdapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
            finally
            {
                connect.Close();
            }
        }
        string id_rows5 = "0";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Срабатывание кода на кнопку мыши
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                //Определение строки
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];

                dataGridView1.CurrentRow.Selected = true;

                string index_rows5;

                index_rows5 = dataGridView1.SelectedCells[0].RowIndex.ToString();

                id_rows5 = dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString();
                DateTime x = DateTime.Today;
                //Переменной присваивается значение выбранной строки
                DateTime y = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString());
                string resultDays = (x - y).ToString();
                MessageBox.Show("Со дня рождения прошло " + resultDays.Substring(0, resultDays.Length - 9) + " дней");
            }
        }
        //Закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
