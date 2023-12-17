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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void zapravkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zapravkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Put_list". При необходимости она может быть перемещена или удалена.
            this.put_listTableAdapter.Fill(this.av_sDataSet.Put_list);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Mark_top". При необходимости она может быть перемещена или удалена.
            this.mark_topTableAdapter.Fill(this.av_sDataSet.Mark_top);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Zapravka". При необходимости она может быть перемещена или удалена.
            this.zapravkaTableAdapter.Fill(this.av_sDataSet.Zapravka);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
