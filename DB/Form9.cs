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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void trans_sredBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trans_sredBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Mark_top". При необходимости она может быть перемещена или удалена.
            this.mark_topTableAdapter.Fill(this.av_sDataSet.Mark_top);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Tip_avto". При необходимости она может быть перемещена или удалена.
            this.tip_avtoTableAdapter.Fill(this.av_sDataSet.Tip_avto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Trans_sred". При необходимости она может быть перемещена или удалена.
            this.trans_sredTableAdapter.Fill(this.av_sDataSet.Trans_sred);

        }

        private void kolonkaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
