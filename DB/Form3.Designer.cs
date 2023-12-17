namespace DB
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label massa_gruzLabel;
            System.Windows.Forms.Label rasstoyanieLabel;
            System.Windows.Forms.Label mesto_nazLabel;
            System.Windows.Forms.Label top_vozLabel;
            System.Windows.Forms.Label top_vLabel;
            System.Windows.Forms.Label spid_vozLabel;
            System.Windows.Forms.Label spid_vLabel;
            System.Windows.Forms.Label data_vozLabel;
            System.Windows.Forms.Label data_vLabel;
            System.Windows.Forms.Label vodLabel;
            System.Windows.Forms.Label trn_sredLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.av_sDataSet = new DB.Av_sDataSet();
            this.put_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.put_listTableAdapter = new DB.Av_sDataSetTableAdapters.Put_listTableAdapter();
            this.tableAdapterManager = new DB.Av_sDataSetTableAdapters.TableAdapterManager();
            this.trans_sredTableAdapter = new DB.Av_sDataSetTableAdapters.Trans_sredTableAdapter();
            this.vodTableAdapter = new DB.Av_sDataSetTableAdapters.VodTableAdapter();
            this.put_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.put_listBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.trn_sredComboBox = new System.Windows.Forms.ComboBox();
            this.transsredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vodComboBox = new System.Windows.Forms.ComboBox();
            this.vodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_vDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.data_vozDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.top_vTextBox1 = new System.Windows.Forms.TextBox();
            this.top_vozTextBox1 = new System.Windows.Forms.TextBox();
            this.mesto_nazTextBox1 = new System.Windows.Forms.TextBox();
            this.rasstoyanieTextBox1 = new System.Windows.Forms.TextBox();
            this.massa_gruzTextBox = new System.Windows.Forms.TextBox();
            this.spid_vMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.spid_vozMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            massa_gruzLabel = new System.Windows.Forms.Label();
            rasstoyanieLabel = new System.Windows.Forms.Label();
            mesto_nazLabel = new System.Windows.Forms.Label();
            top_vozLabel = new System.Windows.Forms.Label();
            top_vLabel = new System.Windows.Forms.Label();
            spid_vozLabel = new System.Windows.Forms.Label();
            spid_vLabel = new System.Windows.Forms.Label();
            data_vozLabel = new System.Windows.Forms.Label();
            data_vLabel = new System.Windows.Forms.Label();
            vodLabel = new System.Windows.Forms.Label();
            trn_sredLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.put_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.put_listBindingNavigator)).BeginInit();
            this.put_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transsredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // massa_gruzLabel
            // 
            massa_gruzLabel.AutoSize = true;
            massa_gruzLabel.Location = new System.Drawing.Point(334, 204);
            massa_gruzLabel.Name = "massa_gruzLabel";
            massa_gruzLabel.Size = new System.Drawing.Size(92, 13);
            massa_gruzLabel.TabIndex = 53;
            massa_gruzLabel.Text = "Масса загрузки:";
            // 
            // rasstoyanieLabel
            // 
            rasstoyanieLabel.AutoSize = true;
            rasstoyanieLabel.Location = new System.Drawing.Point(464, 141);
            rasstoyanieLabel.Name = "rasstoyanieLabel";
            rasstoyanieLabel.Size = new System.Drawing.Size(70, 13);
            rasstoyanieLabel.TabIndex = 51;
            rasstoyanieLabel.Text = "Расстояние:";
            // 
            // mesto_nazLabel
            // 
            mesto_nazLabel.AutoSize = true;
            mesto_nazLabel.Location = new System.Drawing.Point(430, 115);
            mesto_nazLabel.Name = "mesto_nazLabel";
            mesto_nazLabel.Size = new System.Drawing.Size(104, 13);
            mesto_nazLabel.TabIndex = 49;
            mesto_nazLabel.Text = "Место назначения:";
            // 
            // top_vozLabel
            // 
            top_vozLabel.AutoSize = true;
            top_vozLabel.Location = new System.Drawing.Point(388, 84);
            top_vozLabel.Name = "top_vozLabel";
            top_vozLabel.Size = new System.Drawing.Size(146, 13);
            top_vozLabel.TabIndex = 47;
            top_vozLabel.Text = "Топливо при возвращении:";
            // 
            // top_vLabel
            // 
            top_vLabel.AutoSize = true;
            top_vLabel.Location = new System.Drawing.Point(419, 58);
            top_vLabel.Name = "top_vLabel";
            top_vLabel.Size = new System.Drawing.Size(115, 13);
            top_vLabel.TabIndex = 45;
            top_vLabel.Text = "Топливо при выезде:";
            // 
            // spid_vozLabel
            // 
            spid_vozLabel.AutoSize = true;
            spid_vozLabel.Location = new System.Drawing.Point(394, 165);
            spid_vozLabel.Name = "spid_vozLabel";
            spid_vozLabel.Size = new System.Drawing.Size(140, 13);
            spid_vozLabel.TabIndex = 43;
            spid_vozLabel.Text = "Пробег при возвращении:";
            // 
            // spid_vLabel
            // 
            spid_vLabel.AutoSize = true;
            spid_vLabel.Location = new System.Drawing.Point(71, 170);
            spid_vLabel.Name = "spid_vLabel";
            spid_vLabel.Size = new System.Drawing.Size(109, 13);
            spid_vLabel.TabIndex = 41;
            spid_vLabel.Text = "Пробег при выезде:";
            // 
            // data_vozLabel
            // 
            data_vozLabel.AutoSize = true;
            data_vozLabel.Location = new System.Drawing.Point(72, 141);
            data_vozLabel.Name = "data_vozLabel";
            data_vozLabel.Size = new System.Drawing.Size(108, 13);
            data_vozLabel.TabIndex = 39;
            data_vozLabel.Text = "Дата возвращения:";
            // 
            // data_vLabel
            // 
            data_vLabel.AutoSize = true;
            data_vLabel.Location = new System.Drawing.Point(103, 115);
            data_vLabel.Name = "data_vLabel";
            data_vLabel.Size = new System.Drawing.Size(77, 13);
            data_vLabel.TabIndex = 37;
            data_vLabel.Text = "Дата выезда:";
            // 
            // vodLabel
            // 
            vodLabel.AutoSize = true;
            vodLabel.Location = new System.Drawing.Point(86, 84);
            vodLabel.Name = "vodLabel";
            vodLabel.Size = new System.Drawing.Size(94, 13);
            vodLabel.TabIndex = 36;
            vodLabel.Text = "Номер водителя:";
            // 
            // trn_sredLabel
            // 
            trn_sredLabel.AutoSize = true;
            trn_sredLabel.Location = new System.Drawing.Point(8, 58);
            trn_sredLabel.Name = "trn_sredLabel";
            trn_sredLabel.Size = new System.Drawing.Size(172, 13);
            trn_sredLabel.TabIndex = 35;
            trn_sredLabel.Text = "Номер транспортного средства:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(319, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 55;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // av_sDataSet
            // 
            this.av_sDataSet.DataSetName = "Av_sDataSet";
            this.av_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // put_listBindingSource
            // 
            this.put_listBindingSource.DataMember = "Put_list";
            this.put_listBindingSource.DataSource = this.av_sDataSet;
            // 
            // put_listTableAdapter
            // 
            this.put_listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Mark_topTableAdapter = null;
            this.tableAdapterManager.Put_listTableAdapter = this.put_listTableAdapter;
            this.tableAdapterManager.Tip_avtoTableAdapter = null;
            this.tableAdapterManager.Trans_sredTableAdapter = this.trans_sredTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB.Av_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VodTableAdapter = this.vodTableAdapter;
            this.tableAdapterManager.ZapravkaTableAdapter = null;
            // 
            // trans_sredTableAdapter
            // 
            this.trans_sredTableAdapter.ClearBeforeFill = true;
            // 
            // vodTableAdapter
            // 
            this.vodTableAdapter.ClearBeforeFill = true;
            // 
            // put_listBindingNavigator
            // 
            this.put_listBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.put_listBindingNavigator.BindingSource = this.put_listBindingSource;
            this.put_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.put_listBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.put_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.put_listBindingNavigatorSaveItem});
            this.put_listBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.put_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.put_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.put_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.put_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.put_listBindingNavigator.Name = "put_listBindingNavigator";
            this.put_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.put_listBindingNavigator.Size = new System.Drawing.Size(728, 25);
            this.put_listBindingNavigator.TabIndex = 59;
            this.put_listBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // put_listBindingNavigatorSaveItem
            // 
            this.put_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.put_listBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("put_listBindingNavigatorSaveItem.Image")));
            this.put_listBindingNavigatorSaveItem.Name = "put_listBindingNavigatorSaveItem";
            this.put_listBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.put_listBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.put_listBindingNavigatorSaveItem.Click += new System.EventHandler(this.put_listBindingNavigatorSaveItem_Click);
            // 
            // trn_sredComboBox
            // 
            this.trn_sredComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Trn_sred", true));
            this.trn_sredComboBox.DataSource = this.transsredBindingSource;
            this.trn_sredComboBox.DisplayMember = "id";
            this.trn_sredComboBox.FormattingEnabled = true;
            this.trn_sredComboBox.Location = new System.Drawing.Point(197, 54);
            this.trn_sredComboBox.Name = "trn_sredComboBox";
            this.trn_sredComboBox.Size = new System.Drawing.Size(165, 21);
            this.trn_sredComboBox.TabIndex = 60;
            // 
            // transsredBindingSource
            // 
            this.transsredBindingSource.DataMember = "Trans_sred";
            this.transsredBindingSource.DataSource = this.av_sDataSet;
            // 
            // vodComboBox
            // 
            this.vodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Vod", true));
            this.vodComboBox.DataSource = this.vodBindingSource;
            this.vodComboBox.DisplayMember = "id_v";
            this.vodComboBox.FormattingEnabled = true;
            this.vodComboBox.Location = new System.Drawing.Point(197, 85);
            this.vodComboBox.Name = "vodComboBox";
            this.vodComboBox.Size = new System.Drawing.Size(165, 21);
            this.vodComboBox.TabIndex = 61;
            // 
            // vodBindingSource
            // 
            this.vodBindingSource.DataMember = "Vod";
            this.vodBindingSource.DataSource = this.av_sDataSet;
            // 
            // data_vDateTimePicker1
            // 
            this.data_vDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.put_listBindingSource, "data_v", true));
            this.data_vDateTimePicker1.Location = new System.Drawing.Point(197, 118);
            this.data_vDateTimePicker1.Name = "data_vDateTimePicker1";
            this.data_vDateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.data_vDateTimePicker1.TabIndex = 62;
            // 
            // data_vozDateTimePicker1
            // 
            this.data_vozDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.put_listBindingSource, "data_voz", true));
            this.data_vozDateTimePicker1.Location = new System.Drawing.Point(197, 144);
            this.data_vozDateTimePicker1.Name = "data_vozDateTimePicker1";
            this.data_vozDateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.data_vozDateTimePicker1.TabIndex = 63;
            // 
            // top_vTextBox1
            // 
            this.top_vTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Top_v", true));
            this.top_vTextBox1.Location = new System.Drawing.Point(540, 58);
            this.top_vTextBox1.Name = "top_vTextBox1";
            this.top_vTextBox1.Size = new System.Drawing.Size(152, 20);
            this.top_vTextBox1.TabIndex = 65;
            // 
            // top_vozTextBox1
            // 
            this.top_vozTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Top_voz", true));
            this.top_vozTextBox1.Location = new System.Drawing.Point(540, 84);
            this.top_vozTextBox1.Name = "top_vozTextBox1";
            this.top_vozTextBox1.Size = new System.Drawing.Size(152, 20);
            this.top_vozTextBox1.TabIndex = 66;
            // 
            // mesto_nazTextBox1
            // 
            this.mesto_nazTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Mesto-naz", true));
            this.mesto_nazTextBox1.Location = new System.Drawing.Point(540, 110);
            this.mesto_nazTextBox1.Name = "mesto_nazTextBox1";
            this.mesto_nazTextBox1.Size = new System.Drawing.Size(152, 20);
            this.mesto_nazTextBox1.TabIndex = 67;
            // 
            // rasstoyanieTextBox1
            // 
            this.rasstoyanieTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Rasstoyanie", true));
            this.rasstoyanieTextBox1.Location = new System.Drawing.Point(540, 136);
            this.rasstoyanieTextBox1.Name = "rasstoyanieTextBox1";
            this.rasstoyanieTextBox1.Size = new System.Drawing.Size(152, 20);
            this.rasstoyanieTextBox1.TabIndex = 68;
            // 
            // massa_gruzTextBox
            // 
            this.massa_gruzTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Massa_gruz", true));
            this.massa_gruzTextBox.Location = new System.Drawing.Point(250, 229);
            this.massa_gruzTextBox.Name = "massa_gruzTextBox";
            this.massa_gruzTextBox.Size = new System.Drawing.Size(255, 20);
            this.massa_gruzTextBox.TabIndex = 70;
            // 
            // spid_vMaskedTextBox
            // 
            this.spid_vMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Spid_v", true));
            this.spid_vMaskedTextBox.Location = new System.Drawing.Point(197, 170);
            this.spid_vMaskedTextBox.Mask = "000000";
            this.spid_vMaskedTextBox.Name = "spid_vMaskedTextBox";
            this.spid_vMaskedTextBox.Size = new System.Drawing.Size(165, 20);
            this.spid_vMaskedTextBox.TabIndex = 71;
            // 
            // spid_vozMaskedTextBox
            // 
            this.spid_vozMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.put_listBindingSource, "Spid_voz", true));
            this.spid_vozMaskedTextBox.Location = new System.Drawing.Point(540, 162);
            this.spid_vozMaskedTextBox.Mask = "000000";
            this.spid_vozMaskedTextBox.Name = "spid_vozMaskedTextBox";
            this.spid_vozMaskedTextBox.Size = new System.Drawing.Size(152, 20);
            this.spid_vozMaskedTextBox.TabIndex = 72;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 345);
            this.Controls.Add(this.spid_vozMaskedTextBox);
            this.Controls.Add(this.spid_vMaskedTextBox);
            this.Controls.Add(this.massa_gruzTextBox);
            this.Controls.Add(this.rasstoyanieTextBox1);
            this.Controls.Add(this.mesto_nazTextBox1);
            this.Controls.Add(this.top_vozTextBox1);
            this.Controls.Add(this.top_vTextBox1);
            this.Controls.Add(this.data_vozDateTimePicker1);
            this.Controls.Add(this.data_vDateTimePicker1);
            this.Controls.Add(this.vodComboBox);
            this.Controls.Add(this.trn_sredComboBox);
            this.Controls.Add(this.put_listBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(massa_gruzLabel);
            this.Controls.Add(rasstoyanieLabel);
            this.Controls.Add(mesto_nazLabel);
            this.Controls.Add(top_vozLabel);
            this.Controls.Add(top_vLabel);
            this.Controls.Add(spid_vozLabel);
            this.Controls.Add(spid_vLabel);
            this.Controls.Add(data_vozLabel);
            this.Controls.Add(data_vLabel);
            this.Controls.Add(vodLabel);
            this.Controls.Add(trn_sredLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Добавление путевого листа";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.put_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.put_listBindingNavigator)).EndInit();
            this.put_listBindingNavigator.ResumeLayout(false);
            this.put_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transsredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Av_sDataSet av_sDataSet;
        private System.Windows.Forms.BindingSource put_listBindingSource;
        private Av_sDataSetTableAdapters.Put_listTableAdapter put_listTableAdapter;
        private Av_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator put_listBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton put_listBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox trn_sredComboBox;
        private Av_sDataSetTableAdapters.Trans_sredTableAdapter trans_sredTableAdapter;
        private System.Windows.Forms.BindingSource transsredBindingSource;
        private Av_sDataSetTableAdapters.VodTableAdapter vodTableAdapter;
        private System.Windows.Forms.ComboBox vodComboBox;
        private System.Windows.Forms.BindingSource vodBindingSource;
        private System.Windows.Forms.DateTimePicker data_vDateTimePicker1;
        private System.Windows.Forms.DateTimePicker data_vozDateTimePicker1;
        private System.Windows.Forms.TextBox top_vTextBox1;
        private System.Windows.Forms.TextBox top_vozTextBox1;
        private System.Windows.Forms.TextBox mesto_nazTextBox1;
        private System.Windows.Forms.TextBox rasstoyanieTextBox1;
        private System.Windows.Forms.TextBox massa_gruzTextBox;
        private System.Windows.Forms.MaskedTextBox spid_vMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox spid_vozMaskedTextBox;
    }
}