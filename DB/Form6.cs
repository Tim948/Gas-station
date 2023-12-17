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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void zapravkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zapravkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Zapravka". При необходимости она может быть перемещена или удалена.
            this.zapravkaTableAdapter.Fill(this.av_sDataSet.Zapravka);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < zapravkaDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zapravkaDataGridView.RowCount - 1; j++)
                {
                    zapravkaDataGridView[i, j].Style.BackColor = Color.White;
                    zapravkaDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < zapravkaDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zapravkaDataGridView.RowCount - 1; j++)
                {
                    if (zapravkaDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        zapravkaDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        zapravkaDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zapravkaBindingSource.Filter = "Nomer_check='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zapravkaBindingSource.Filter = "";
        }
        private Form7 t;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Form7();
            t.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
