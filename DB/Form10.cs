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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void mark_topBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mark_topBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Mark_top". При необходимости она может быть перемещена или удалена.
            this.mark_topTableAdapter.Fill(this.av_sDataSet.Mark_top);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
