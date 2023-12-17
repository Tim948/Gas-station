namespace DB
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.Label markaLabel;
            System.Windows.Forms.Label tip_avtoLabel;
            System.Windows.Forms.Label organLabel;
            System.Windows.Forms.Label kolonkaLabel;
            System.Windows.Forms.Label god_vLabel;
            System.Windows.Forms.Label gos_nomLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label id_dviglaLabel;
            System.Windows.Forms.Label id_kuzvaLabel;
            System.Windows.Forms.Label tex_sostLabel;
            System.Windows.Forms.Label sr_skorLabel;
            System.Windows.Forms.Label gruzopodLabel;
            System.Windows.Forms.Label marka_topLabel;
            System.Windows.Forms.Label rasxodLabel;
            this.av_sDataSet = new DB.Av_sDataSet();
            this.trans_sredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trans_sredTableAdapter = new DB.Av_sDataSetTableAdapters.Trans_sredTableAdapter();
            this.tableAdapterManager = new DB.Av_sDataSetTableAdapters.TableAdapterManager();
            this.trans_sredBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.trans_sredBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.tip_avtoComboBox = new System.Windows.Forms.ComboBox();
            this.tipavtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_avtoTableAdapter = new DB.Av_sDataSetTableAdapters.Tip_avtoTableAdapter();
            this.organTextBox = new System.Windows.Forms.TextBox();
            this.kolonkaTextBox = new System.Windows.Forms.TextBox();
            this.god_vDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gos_nomTextBox = new System.Windows.Forms.TextBox();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.id_dviglaTextBox = new System.Windows.Forms.TextBox();
            this.id_kuzvaTextBox = new System.Windows.Forms.TextBox();
            this.tex_sostTextBox = new System.Windows.Forms.TextBox();
            this.sr_skorTextBox = new System.Windows.Forms.TextBox();
            this.marka_topComboBox = new System.Windows.Forms.ComboBox();
            this.rasxodTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.marktopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mark_topTableAdapter = new DB.Av_sDataSetTableAdapters.Mark_topTableAdapter();
            this.gruzopodMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            markaLabel = new System.Windows.Forms.Label();
            tip_avtoLabel = new System.Windows.Forms.Label();
            organLabel = new System.Windows.Forms.Label();
            kolonkaLabel = new System.Windows.Forms.Label();
            god_vLabel = new System.Windows.Forms.Label();
            gos_nomLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            id_dviglaLabel = new System.Windows.Forms.Label();
            id_kuzvaLabel = new System.Windows.Forms.Label();
            tex_sostLabel = new System.Windows.Forms.Label();
            sr_skorLabel = new System.Windows.Forms.Label();
            gruzopodLabel = new System.Windows.Forms.Label();
            marka_topLabel = new System.Windows.Forms.Label();
            rasxodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trans_sredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trans_sredBindingNavigator)).BeginInit();
            this.trans_sredBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipavtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marktopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // av_sDataSet
            // 
            this.av_sDataSet.DataSetName = "Av_sDataSet";
            this.av_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trans_sredBindingSource
            // 
            this.trans_sredBindingSource.DataMember = "Trans_sred";
            this.trans_sredBindingSource.DataSource = this.av_sDataSet;
            // 
            // trans_sredTableAdapter
            // 
            this.trans_sredTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Mark_topTableAdapter = this.mark_topTableAdapter;
            this.tableAdapterManager.Put_listTableAdapter = null;
            this.tableAdapterManager.Tip_avtoTableAdapter = this.tip_avtoTableAdapter;
            this.tableAdapterManager.Trans_sredTableAdapter = this.trans_sredTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB.Av_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VodTableAdapter = null;
            this.tableAdapterManager.ZapravkaTableAdapter = null;
            // 
            // trans_sredBindingNavigator
            // 
            this.trans_sredBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.trans_sredBindingNavigator.BindingSource = this.trans_sredBindingSource;
            this.trans_sredBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.trans_sredBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.trans_sredBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.trans_sredBindingNavigatorSaveItem});
            this.trans_sredBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.trans_sredBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.trans_sredBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.trans_sredBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.trans_sredBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.trans_sredBindingNavigator.Name = "trans_sredBindingNavigator";
            this.trans_sredBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.trans_sredBindingNavigator.Size = new System.Drawing.Size(579, 25);
            this.trans_sredBindingNavigator.TabIndex = 0;
            this.trans_sredBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // trans_sredBindingNavigatorSaveItem
            // 
            this.trans_sredBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.trans_sredBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("trans_sredBindingNavigatorSaveItem.Image")));
            this.trans_sredBindingNavigatorSaveItem.Name = "trans_sredBindingNavigatorSaveItem";
            this.trans_sredBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.trans_sredBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.trans_sredBindingNavigatorSaveItem.Click += new System.EventHandler(this.trans_sredBindingNavigatorSaveItem_Click);
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Location = new System.Drawing.Point(12, 60);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new System.Drawing.Size(107, 13);
            markaLabel.TabIndex = 1;
            markaLabel.Text = "Марка автомобиля:";
            // 
            // markaTextBox
            // 
            this.markaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Marka", true));
            this.markaTextBox.Location = new System.Drawing.Point(125, 60);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(154, 20);
            this.markaTextBox.TabIndex = 2;
            // 
            // tip_avtoLabel
            // 
            tip_avtoLabel.AutoSize = true;
            tip_avtoLabel.Location = new System.Drawing.Point(26, 89);
            tip_avtoLabel.Name = "tip_avtoLabel";
            tip_avtoLabel.Size = new System.Drawing.Size(93, 13);
            tip_avtoLabel.TabIndex = 3;
            tip_avtoLabel.Text = "Тип автомобиля:";
            // 
            // tip_avtoComboBox
            // 
            this.tip_avtoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Tip_avto", true));
            this.tip_avtoComboBox.DataSource = this.tipavtoBindingSource;
            this.tip_avtoComboBox.DisplayMember = "id_avto";
            this.tip_avtoComboBox.FormattingEnabled = true;
            this.tip_avtoComboBox.Location = new System.Drawing.Point(125, 86);
            this.tip_avtoComboBox.Name = "tip_avtoComboBox";
            this.tip_avtoComboBox.Size = new System.Drawing.Size(154, 21);
            this.tip_avtoComboBox.TabIndex = 4;
            // 
            // tipavtoBindingSource
            // 
            this.tipavtoBindingSource.DataMember = "Tip_avto";
            this.tipavtoBindingSource.DataSource = this.av_sDataSet;
            // 
            // tip_avtoTableAdapter
            // 
            this.tip_avtoTableAdapter.ClearBeforeFill = true;
            // 
            // organLabel
            // 
            organLabel.AutoSize = true;
            organLabel.Location = new System.Drawing.Point(42, 116);
            organLabel.Name = "organLabel";
            organLabel.Size = new System.Drawing.Size(77, 13);
            organLabel.TabIndex = 5;
            organLabel.Text = "Организация:";
            // 
            // organTextBox
            // 
            this.organTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Organ", true));
            this.organTextBox.Location = new System.Drawing.Point(125, 113);
            this.organTextBox.Name = "organTextBox";
            this.organTextBox.Size = new System.Drawing.Size(154, 20);
            this.organTextBox.TabIndex = 6;
            // 
            // kolonkaLabel
            // 
            kolonkaLabel.AutoSize = true;
            kolonkaLabel.Location = new System.Drawing.Point(66, 139);
            kolonkaLabel.Name = "kolonkaLabel";
            kolonkaLabel.Size = new System.Drawing.Size(53, 13);
            kolonkaLabel.TabIndex = 7;
            kolonkaLabel.Text = "Колонна:";
            kolonkaLabel.Click += new System.EventHandler(this.kolonkaLabel_Click);
            // 
            // kolonkaTextBox
            // 
            this.kolonkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Kolonka", true));
            this.kolonkaTextBox.Location = new System.Drawing.Point(125, 139);
            this.kolonkaTextBox.Name = "kolonkaTextBox";
            this.kolonkaTextBox.Size = new System.Drawing.Size(154, 20);
            this.kolonkaTextBox.TabIndex = 8;
            // 
            // god_vLabel
            // 
            god_vLabel.AutoSize = true;
            god_vLabel.Location = new System.Drawing.Point(45, 165);
            god_vLabel.Name = "god_vLabel";
            god_vLabel.Size = new System.Drawing.Size(74, 13);
            god_vLabel.TabIndex = 9;
            god_vLabel.Text = "Год выпуска:";
            // 
            // god_vDateTimePicker
            // 
            this.god_vDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trans_sredBindingSource, "God_v", true));
            this.god_vDateTimePicker.Location = new System.Drawing.Point(125, 165);
            this.god_vDateTimePicker.Name = "god_vDateTimePicker";
            this.god_vDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.god_vDateTimePicker.TabIndex = 10;
            // 
            // gos_nomLabel
            // 
            gos_nomLabel.AutoSize = true;
            gos_nomLabel.Location = new System.Drawing.Point(53, 191);
            gos_nomLabel.Name = "gos_nomLabel";
            gos_nomLabel.Size = new System.Drawing.Size(66, 13);
            gos_nomLabel.TabIndex = 11;
            gos_nomLabel.Text = "Гос. номер:";
            // 
            // gos_nomTextBox
            // 
            this.gos_nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Gos_nom", true));
            this.gos_nomTextBox.Location = new System.Drawing.Point(125, 191);
            this.gos_nomTextBox.Name = "gos_nomTextBox";
            this.gos_nomTextBox.Size = new System.Drawing.Size(154, 20);
            this.gos_nomTextBox.TabIndex = 12;
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(56, 217);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(63, 13);
            vINLabel.TabIndex = 13;
            vINLabel.Text = "VIN номер:";
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(125, 217);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(154, 20);
            this.vINTextBox.TabIndex = 14;
            // 
            // id_dviglaLabel
            // 
            id_dviglaLabel.AutoSize = true;
            id_dviglaLabel.Location = new System.Drawing.Point(344, 60);
            id_dviglaLabel.Name = "id_dviglaLabel";
            id_dviglaLabel.Size = new System.Drawing.Size(99, 13);
            id_dviglaLabel.TabIndex = 15;
            id_dviglaLabel.Text = "Номер двигателя:";
            // 
            // id_dviglaTextBox
            // 
            this.id_dviglaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "id_dvigla", true));
            this.id_dviglaTextBox.Location = new System.Drawing.Point(449, 57);
            this.id_dviglaTextBox.Name = "id_dviglaTextBox";
            this.id_dviglaTextBox.Size = new System.Drawing.Size(118, 20);
            this.id_dviglaTextBox.TabIndex = 16;
            // 
            // id_kuzvaLabel
            // 
            id_kuzvaLabel.AutoSize = true;
            id_kuzvaLabel.Location = new System.Drawing.Point(361, 89);
            id_kuzvaLabel.Name = "id_kuzvaLabel";
            id_kuzvaLabel.Size = new System.Drawing.Size(82, 13);
            id_kuzvaLabel.TabIndex = 17;
            id_kuzvaLabel.Text = "Номер кузова:";
            // 
            // id_kuzvaTextBox
            // 
            this.id_kuzvaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "id_kuzva", true));
            this.id_kuzvaTextBox.Location = new System.Drawing.Point(449, 86);
            this.id_kuzvaTextBox.Name = "id_kuzvaTextBox";
            this.id_kuzvaTextBox.Size = new System.Drawing.Size(118, 20);
            this.id_kuzvaTextBox.TabIndex = 18;
            // 
            // tex_sostLabel
            // 
            tex_sostLabel.AutoSize = true;
            tex_sostLabel.Location = new System.Drawing.Point(312, 116);
            tex_sostLabel.Name = "tex_sostLabel";
            tex_sostLabel.Size = new System.Drawing.Size(131, 13);
            tex_sostLabel.TabIndex = 19;
            tex_sostLabel.Text = "Техническое состояние:";
            // 
            // tex_sostTextBox
            // 
            this.tex_sostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Tex_sost", true));
            this.tex_sostTextBox.Location = new System.Drawing.Point(449, 113);
            this.tex_sostTextBox.Name = "tex_sostTextBox";
            this.tex_sostTextBox.Size = new System.Drawing.Size(118, 20);
            this.tex_sostTextBox.TabIndex = 20;
            // 
            // sr_skorLabel
            // 
            sr_skorLabel.AutoSize = true;
            sr_skorLabel.Location = new System.Drawing.Point(340, 142);
            sr_skorLabel.Name = "sr_skorLabel";
            sr_skorLabel.Size = new System.Drawing.Size(103, 13);
            sr_skorLabel.TabIndex = 21;
            sr_skorLabel.Text = "Средняя скорость:";
            // 
            // sr_skorTextBox
            // 
            this.sr_skorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Sr_skor", true));
            this.sr_skorTextBox.Location = new System.Drawing.Point(449, 139);
            this.sr_skorTextBox.Name = "sr_skorTextBox";
            this.sr_skorTextBox.Size = new System.Drawing.Size(118, 20);
            this.sr_skorTextBox.TabIndex = 22;
            // 
            // gruzopodLabel
            // 
            gruzopodLabel.AutoSize = true;
            gruzopodLabel.Location = new System.Drawing.Point(337, 171);
            gruzopodLabel.Name = "gruzopodLabel";
            gruzopodLabel.Size = new System.Drawing.Size(106, 13);
            gruzopodLabel.TabIndex = 23;
            gruzopodLabel.Text = "Грузоподьемность:";
            // 
            // marka_topLabel
            // 
            marka_topLabel.AutoSize = true;
            marka_topLabel.Location = new System.Drawing.Point(356, 194);
            marka_topLabel.Name = "marka_topLabel";
            marka_topLabel.Size = new System.Drawing.Size(87, 13);
            marka_topLabel.TabIndex = 25;
            marka_topLabel.Text = "Марка топлива:";
            // 
            // marka_topComboBox
            // 
            this.marka_topComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "marka_top", true));
            this.marka_topComboBox.DataSource = this.marktopBindingSource;
            this.marka_topComboBox.DisplayMember = "id_mark_top";
            this.marka_topComboBox.FormattingEnabled = true;
            this.marka_topComboBox.Location = new System.Drawing.Point(449, 191);
            this.marka_topComboBox.Name = "marka_topComboBox";
            this.marka_topComboBox.Size = new System.Drawing.Size(118, 21);
            this.marka_topComboBox.TabIndex = 26;
            // 
            // rasxodLabel
            // 
            rasxodLabel.AutoSize = true;
            rasxodLabel.Location = new System.Drawing.Point(353, 221);
            rasxodLabel.Name = "rasxodLabel";
            rasxodLabel.Size = new System.Drawing.Size(90, 13);
            rasxodLabel.TabIndex = 27;
            rasxodLabel.Text = "Расход топлива:";
            // 
            // rasxodTextBox
            // 
            this.rasxodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Rasxod", true));
            this.rasxodTextBox.Location = new System.Drawing.Point(449, 218);
            this.rasxodTextBox.Name = "rasxodTextBox";
            this.rasxodTextBox.Size = new System.Drawing.Size(118, 20);
            this.rasxodTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(253, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 53;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marktopBindingSource
            // 
            this.marktopBindingSource.DataMember = "Mark_top";
            this.marktopBindingSource.DataSource = this.av_sDataSet;
            // 
            // mark_topTableAdapter
            // 
            this.mark_topTableAdapter.ClearBeforeFill = true;
            // 
            // gruzopodMaskedTextBox
            // 
            this.gruzopodMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trans_sredBindingSource, "Gruzopod", true));
            this.gruzopodMaskedTextBox.Location = new System.Drawing.Point(449, 165);
            this.gruzopodMaskedTextBox.Mask = "0000";
            this.gruzopodMaskedTextBox.Name = "gruzopodMaskedTextBox";
            this.gruzopodMaskedTextBox.Size = new System.Drawing.Size(118, 20);
            this.gruzopodMaskedTextBox.TabIndex = 55;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 349);
            this.Controls.Add(this.gruzopodMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(rasxodLabel);
            this.Controls.Add(this.rasxodTextBox);
            this.Controls.Add(marka_topLabel);
            this.Controls.Add(this.marka_topComboBox);
            this.Controls.Add(gruzopodLabel);
            this.Controls.Add(sr_skorLabel);
            this.Controls.Add(this.sr_skorTextBox);
            this.Controls.Add(tex_sostLabel);
            this.Controls.Add(this.tex_sostTextBox);
            this.Controls.Add(id_kuzvaLabel);
            this.Controls.Add(this.id_kuzvaTextBox);
            this.Controls.Add(id_dviglaLabel);
            this.Controls.Add(this.id_dviglaTextBox);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(gos_nomLabel);
            this.Controls.Add(this.gos_nomTextBox);
            this.Controls.Add(god_vLabel);
            this.Controls.Add(this.god_vDateTimePicker);
            this.Controls.Add(kolonkaLabel);
            this.Controls.Add(this.kolonkaTextBox);
            this.Controls.Add(organLabel);
            this.Controls.Add(this.organTextBox);
            this.Controls.Add(tip_avtoLabel);
            this.Controls.Add(this.tip_avtoComboBox);
            this.Controls.Add(markaLabel);
            this.Controls.Add(this.markaTextBox);
            this.Controls.Add(this.trans_sredBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9";
            this.Text = "Добавление транспортного средства";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trans_sredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trans_sredBindingNavigator)).EndInit();
            this.trans_sredBindingNavigator.ResumeLayout(false);
            this.trans_sredBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipavtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marktopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Av_sDataSet av_sDataSet;
        private System.Windows.Forms.BindingSource trans_sredBindingSource;
        private Av_sDataSetTableAdapters.Trans_sredTableAdapter trans_sredTableAdapter;
        private Av_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator trans_sredBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton trans_sredBindingNavigatorSaveItem;
        private Av_sDataSetTableAdapters.Tip_avtoTableAdapter tip_avtoTableAdapter;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.ComboBox tip_avtoComboBox;
        private System.Windows.Forms.BindingSource tipavtoBindingSource;
        private System.Windows.Forms.TextBox organTextBox;
        private System.Windows.Forms.TextBox kolonkaTextBox;
        private System.Windows.Forms.DateTimePicker god_vDateTimePicker;
        private System.Windows.Forms.TextBox gos_nomTextBox;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.TextBox id_dviglaTextBox;
        private System.Windows.Forms.TextBox id_kuzvaTextBox;
        private System.Windows.Forms.TextBox tex_sostTextBox;
        private System.Windows.Forms.TextBox sr_skorTextBox;
        private System.Windows.Forms.ComboBox marka_topComboBox;
        private System.Windows.Forms.TextBox rasxodTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Av_sDataSetTableAdapters.Mark_topTableAdapter mark_topTableAdapter;
        private System.Windows.Forms.BindingSource marktopBindingSource;
        private System.Windows.Forms.MaskedTextBox gruzopodMaskedTextBox;
    }
}