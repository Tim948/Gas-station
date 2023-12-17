﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void vodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Vod". При необходимости она может быть перемещена или удалена.
            this.vodTableAdapter.Fill(this.av_sDataSet.Vod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < vodDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < vodDataGridView.RowCount - 1; j++)
                {
                    vodDataGridView[i, j].Style.BackColor = Color.White;
                    vodDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < vodDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < vodDataGridView.RowCount - 1; j++)
                {
                    if (vodDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        vodDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        vodDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn7;
                    break;

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) vodDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else vodDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vodBindingSource.Filter = "Fam='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vodBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form5 t;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Form5();
            t.Visible = true;
        }
    }
}
