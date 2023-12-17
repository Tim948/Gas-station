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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void put_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.put_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Vod". При необходимости она может быть перемещена или удалена.
            this.vodTableAdapter.Fill(this.av_sDataSet.Vod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Trans_sred". При необходимости она может быть перемещена или удалена.
            this.trans_sredTableAdapter.Fill(this.av_sDataSet.Trans_sred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Put_list". При необходимости она может быть перемещена или удалена.
            this.put_listTableAdapter.Fill(this.av_sDataSet.Put_list);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
