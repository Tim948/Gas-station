namespace DB
{
    partial class Form7
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
            System.Windows.Forms.Label id_p_listLabel;
            System.Windows.Forms.Label nomer_checkLabel;
            System.Windows.Forms.Label time_zapravkiLabel;
            System.Windows.Forms.Label toplivoLabel;
            System.Windows.Forms.Label kolLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.av_sDataSet = new DB.Av_sDataSet();
            this.zapravkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapravkaTableAdapter = new DB.Av_sDataSetTableAdapters.ZapravkaTableAdapter();
            this.tableAdapterManager = new DB.Av_sDataSetTableAdapters.TableAdapterManager();
            this.mark_topTableAdapter = new DB.Av_sDataSetTableAdapters.Mark_topTableAdapter();
            this.zapravkaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zapravkaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_p_listComboBox = new System.Windows.Forms.ComboBox();
            this.nomer_checkTextBox = new System.Windows.Forms.TextBox();
            this.time_zapravkiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toplivoComboBox = new System.Windows.Forms.ComboBox();
            this.marktopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.putlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.put_listTableAdapter = new DB.Av_sDataSetTableAdapters.Put_listTableAdapter();
            id_p_listLabel = new System.Windows.Forms.Label();
            nomer_checkLabel = new System.Windows.Forms.Label();
            time_zapravkiLabel = new System.Windows.Forms.Label();
            toplivoLabel = new System.Windows.Forms.Label();
            kolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaBindingNavigator)).BeginInit();
            this.zapravkaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marktopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.putlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_p_listLabel
            // 
            id_p_listLabel.AutoSize = true;
            id_p_listLabel.Location = new System.Drawing.Point(12, 61);
            id_p_listLabel.Name = "id_p_listLabel";
            id_p_listLabel.Size = new System.Drawing.Size(124, 13);
            id_p_listLabel.TabIndex = 1;
            id_p_listLabel.Text = "Номер путевого листа:";
            // 
            // nomer_checkLabel
            // 
            nomer_checkLabel.AutoSize = true;
            nomer_checkLabel.Location = new System.Drawing.Point(66, 94);
            nomer_checkLabel.Name = "nomer_checkLabel";
            nomer_checkLabel.Size = new System.Drawing.Size(70, 13);
            nomer_checkLabel.TabIndex = 3;
            nomer_checkLabel.Text = "Номер чека:";
            // 
            // time_zapravkiLabel
            // 
            time_zapravkiLabel.AutoSize = true;
            time_zapravkiLabel.Location = new System.Drawing.Point(42, 123);
            time_zapravkiLabel.Name = "time_zapravkiLabel";
            time_zapravkiLabel.Size = new System.Drawing.Size(94, 13);
            time_zapravkiLabel.TabIndex = 5;
            time_zapravkiLabel.Text = "Время заправки:";
            // 
            // toplivoLabel
            // 
            toplivoLabel.AutoSize = true;
            toplivoLabel.Location = new System.Drawing.Point(83, 149);
            toplivoLabel.Name = "toplivoLabel";
            toplivoLabel.Size = new System.Drawing.Size(53, 13);
            toplivoLabel.TabIndex = 7;
            toplivoLabel.Text = "Топливо:";
            // 
            // kolLabel
            // 
            kolLabel.AutoSize = true;
            kolLabel.Location = new System.Drawing.Point(61, 175);
            kolLabel.Name = "kolLabel";
            kolLabel.Size = new System.Drawing.Size(75, 13);
            kolLabel.TabIndex = 9;
            kolLabel.Text = "Колличество:";
            // 
            // av_sDataSet
            // 
            this.av_sDataSet.DataSetName = "Av_sDataSet";
            this.av_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapravkaBindingSource
            // 
            this.zapravkaBindingSource.DataMember = "Zapravka";
            this.zapravkaBindingSource.DataSource = this.av_sDataSet;
            // 
            // zapravkaTableAdapter
            // 
            this.zapravkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Mark_topTableAdapter = this.mark_topTableAdapter;
            this.tableAdapterManager.Put_listTableAdapter = null;
            this.tableAdapterManager.Tip_avtoTableAdapter = null;
            this.tableAdapterManager.Trans_sredTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB.Av_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VodTableAdapter = null;
            this.tableAdapterManager.ZapravkaTableAdapter = this.zapravkaTableAdapter;
            // 
            // mark_topTableAdapter
            // 
            this.mark_topTableAdapter.ClearBeforeFill = true;
            // 
            // zapravkaBindingNavigator
            // 
            this.zapravkaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zapravkaBindingNavigator.BindingSource = this.zapravkaBindingSource;
            this.zapravkaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zapravkaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zapravkaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zapravkaBindingNavigatorSaveItem});
            this.zapravkaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zapravkaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zapravkaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zapravkaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zapravkaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zapravkaBindingNavigator.Name = "zapravkaBindingNavigator";
            this.zapravkaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zapravkaBindingNavigator.Size = new System.Drawing.Size(307, 25);
            this.zapravkaBindingNavigator.TabIndex = 0;
            this.zapravkaBindingNavigator.Text = "bindingNavigator1";
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
            // zapravkaBindingNavigatorSaveItem
            // 
            this.zapravkaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zapravkaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zapravkaBindingNavigatorSaveItem.Image")));
            this.zapravkaBindingNavigatorSaveItem.Name = "zapravkaBindingNavigatorSaveItem";
            this.zapravkaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.zapravkaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.zapravkaBindingNavigatorSaveItem.Click += new System.EventHandler(this.zapravkaBindingNavigatorSaveItem_Click);
            // 
            // id_p_listComboBox
            // 
            this.id_p_listComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapravkaBindingSource, "id_p_list", true));
            this.id_p_listComboBox.DataSource = this.putlistBindingSource;
            this.id_p_listComboBox.DisplayMember = "id_list";
            this.id_p_listComboBox.FormattingEnabled = true;
            this.id_p_listComboBox.Location = new System.Drawing.Point(142, 58);
            this.id_p_listComboBox.Name = "id_p_listComboBox";
            this.id_p_listComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_p_listComboBox.TabIndex = 2;
            // 
            // nomer_checkTextBox
            // 
            this.nomer_checkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapravkaBindingSource, "Nomer_check", true));
            this.nomer_checkTextBox.Location = new System.Drawing.Point(142, 94);
            this.nomer_checkTextBox.Name = "nomer_checkTextBox";
            this.nomer_checkTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomer_checkTextBox.TabIndex = 4;
            // 
            // time_zapravkiDateTimePicker
            // 
            this.time_zapravkiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zapravkaBindingSource, "time_zapravki", true));
            this.time_zapravkiDateTimePicker.Location = new System.Drawing.Point(142, 123);
            this.time_zapravkiDateTimePicker.Name = "time_zapravkiDateTimePicker";
            this.time_zapravkiDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.time_zapravkiDateTimePicker.TabIndex = 6;
            // 
            // toplivoComboBox
            // 
            this.toplivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapravkaBindingSource, "Toplivo", true));
            this.toplivoComboBox.DataSource = this.marktopBindingSource;
            this.toplivoComboBox.DisplayMember = "id_mark_top";
            this.toplivoComboBox.FormattingEnabled = true;
            this.toplivoComboBox.Location = new System.Drawing.Point(142, 149);
            this.toplivoComboBox.Name = "toplivoComboBox";
            this.toplivoComboBox.Size = new System.Drawing.Size(121, 21);
            this.toplivoComboBox.TabIndex = 8;
            // 
            // marktopBindingSource
            // 
            this.marktopBindingSource.DataMember = "Mark_top";
            this.marktopBindingSource.DataSource = this.av_sDataSet;
            // 
            // kolTextBox
            // 
            this.kolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zapravkaBindingSource, "kol", true));
            this.kolTextBox.Location = new System.Drawing.Point(142, 176);
            this.kolTextBox.Name = "kolTextBox";
            this.kolTextBox.Size = new System.Drawing.Size(121, 20);
            this.kolTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(110, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 51;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // putlistBindingSource
            // 
            this.putlistBindingSource.DataMember = "Put_list";
            this.putlistBindingSource.DataSource = this.av_sDataSet;
            // 
            // put_listTableAdapter
            // 
            this.put_listTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(kolLabel);
            this.Controls.Add(this.kolTextBox);
            this.Controls.Add(toplivoLabel);
            this.Controls.Add(this.toplivoComboBox);
            this.Controls.Add(time_zapravkiLabel);
            this.Controls.Add(this.time_zapravkiDateTimePicker);
            this.Controls.Add(nomer_checkLabel);
            this.Controls.Add(this.nomer_checkTextBox);
            this.Controls.Add(id_p_listLabel);
            this.Controls.Add(this.id_p_listComboBox);
            this.Controls.Add(this.zapravkaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.Text = "Добавление информации о заправке";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapravkaBindingNavigator)).EndInit();
            this.zapravkaBindingNavigator.ResumeLayout(false);
            this.zapravkaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marktopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.putlistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Av_sDataSet av_sDataSet;
        private System.Windows.Forms.BindingSource zapravkaBindingSource;
        private Av_sDataSetTableAdapters.ZapravkaTableAdapter zapravkaTableAdapter;
        private Av_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zapravkaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zapravkaBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox id_p_listComboBox;
        private Av_sDataSetTableAdapters.Mark_topTableAdapter mark_topTableAdapter;
        private System.Windows.Forms.TextBox nomer_checkTextBox;
        private System.Windows.Forms.DateTimePicker time_zapravkiDateTimePicker;
        private System.Windows.Forms.ComboBox toplivoComboBox;
        private System.Windows.Forms.BindingSource marktopBindingSource;
        private System.Windows.Forms.TextBox kolTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource putlistBindingSource;
        private Av_sDataSetTableAdapters.Put_listTableAdapter put_listTableAdapter;
    }
}