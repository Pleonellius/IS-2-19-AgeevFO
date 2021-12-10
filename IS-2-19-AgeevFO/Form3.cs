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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Создание экземпляра
            ConnectBD conn = new ConnectBD();
            MySqlConnection connect = new MySqlConnection(conn.conn);
            string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
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
        string id_rows = "0";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Срабатываниие при нажатии лкм
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                //Отвечает за то куда нажали
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];

                dataGridView1.CurrentRow.Selected = true;

                string index_rows;

                index_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();
                //Переменной присваивается значение выбранной строки
                id_rows = dataGridView1.Rows[Convert.ToInt32(index_rows)].Cells[1].Value.ToString();
                MessageBox.Show(id_rows);
            }
        }
        //Закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
