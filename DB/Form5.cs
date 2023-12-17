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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void vodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.av_sDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "av_sDataSet.Vod". При необходимости она может быть перемещена или удалена.
            this.vodTableAdapter.Fill(this.av_sDataSet.Vod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
