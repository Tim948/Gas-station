using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void put_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.put_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Put_list". При необходимости она может быть перемещена или удалена.
            this.put_listTableAdapter.Fill(this.av_sDataSet.Put_list);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < put_listDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < put_listDataGridView.RowCount - 1; j++)
                {
                    put_listDataGridView[i, j].Style.BackColor = Color.White;
                    put_listDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < put_listDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < put_listDataGridView.RowCount - 1; j++)
                {
                    if (put_listDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        put_listDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        put_listDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn10;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn11;
                    break;

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) put_listDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else put_listDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            put_listBindingSource.Filter = "Vod='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            put_listBindingSource.Filter = "";
        }
        private Form3 t;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Form3();
            t.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
