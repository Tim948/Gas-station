namespace DB
{
    partial class Form5
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
            System.Windows.Forms.Label katLabel;
            System.Windows.Forms.Label okladLabel;
            System.Windows.Forms.Label stashLabel;
            System.Windows.Forms.Label data_rLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label famLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.av_sDataSet = new DB.Av_sDataSet();
            this.vodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vodTableAdapter = new DB.Av_sDataSetTableAdapters.VodTableAdapter();
            this.tableAdapterManager = new DB.Av_sDataSetTableAdapters.TableAdapterManager();
            this.vodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.famTextBox1 = new System.Windows.Forms.TextBox();
            this.imTextBox1 = new System.Windows.Forms.TextBox();
            this.otTextBox1 = new System.Windows.Forms.TextBox();
            this.stashTextBox1 = new System.Windows.Forms.TextBox();
            this.okladTextBox1 = new System.Windows.Forms.TextBox();
            this.katTextBox1 = new System.Windows.Forms.TextBox();
            this.data_rDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            katLabel = new System.Windows.Forms.Label();
            okladLabel = new System.Windows.Forms.Label();
            stashLabel = new System.Windows.Forms.Label();
            data_rLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodBindingNavigator)).BeginInit();
            this.vodBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // katLabel
            // 
            katLabel.AutoSize = true;
            katLabel.Location = new System.Drawing.Point(238, 122);
            katLabel.Name = "katLabel";
            katLabel.Size = new System.Drawing.Size(121, 13);
            katLabel.TabIndex = 47;
            katLabel.Text = "Каттегории вождения:";
            // 
            // okladLabel
            // 
            okladLabel.AutoSize = true;
            okladLabel.Location = new System.Drawing.Point(317, 96);
            okladLabel.Name = "okladLabel";
            okladLabel.Size = new System.Drawing.Size(42, 13);
            okladLabel.TabIndex = 45;
            okladLabel.Text = "Оклад:";
            // 
            // stashLabel
            // 
            stashLabel.AutoSize = true;
            stashLabel.Location = new System.Drawing.Point(283, 73);
            stashLabel.Name = "stashLabel";
            stashLabel.Size = new System.Drawing.Size(76, 13);
            stashLabel.TabIndex = 43;
            stashLabel.Text = "Стаж работы:";
            // 
            // data_rLabel
            // 
            data_rLabel.AutoSize = true;
            data_rLabel.Location = new System.Drawing.Point(270, 148);
            data_rLabel.Name = "data_rLabel";
            data_rLabel.Size = new System.Drawing.Size(89, 13);
            data_rLabel.TabIndex = 42;
            data_rLabel.Text = "Дата рождения:";
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(22, 122);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(57, 13);
            otLabel.TabIndex = 40;
            otLabel.Text = "Отчество:";
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Location = new System.Drawing.Point(47, 96);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(32, 13);
            imLabel.TabIndex = 38;
            imLabel.Text = "Имя:";
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(20, 73);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 36;
            famLabel.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(204, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 49;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // av_sDataSet
            // 
            this.av_sDataSet.DataSetName = "Av_sDataSet";
            this.av_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vodBindingSource
            // 
            this.vodBindingSource.DataMember = "Vod";
            this.vodBindingSource.DataSource = this.av_sDataSet;
            // 
            // vodTableAdapter
            // 
            this.vodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Mark_topTableAdapter = null;
            this.tableAdapterManager.Put_listTableAdapter = null;
            this.tableAdapterManager.Tip_avtoTableAdapter = null;
            this.tableAdapterManager.Trans_sredTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB.Av_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VodTableAdapter = this.vodTableAdapter;
            this.tableAdapterManager.ZapravkaTableAdapter = null;
            // 
            // vodBindingNavigator
            // 
            this.vodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vodBindingNavigator.BindingSource = this.vodBindingSource;
            this.vodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vodBindingNavigatorSaveItem});
            this.vodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vodBindingNavigator.Name = "vodBindingNavigator";
            this.vodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vodBindingNavigator.Size = new System.Drawing.Size(498, 25);
            this.vodBindingNavigator.TabIndex = 52;
            this.vodBindingNavigator.Text = "bindingNavigator1";
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
            // vodBindingNavigatorSaveItem
            // 
            this.vodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vodBindingNavigatorSaveItem.Image")));
            this.vodBindingNavigatorSaveItem.Name = "vodBindingNavigatorSaveItem";
            this.vodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vodBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.vodBindingNavigatorSaveItem.Click += new System.EventHandler(this.vodBindingNavigatorSaveItem_Click);
            // 
            // famTextBox1
            // 
            this.famTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vodBindingSource, "Fam", true));
            this.famTextBox1.Location = new System.Drawing.Point(85, 70);
            this.famTextBox1.Name = "famTextBox1";
            this.famTextBox1.Size = new System.Drawing.Size(100, 20);
            this.famTextBox1.TabIndex = 53;
            // 
            // imTextBox1
            // 
            this.imTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vodBindingSource, "Im", true));
            this.imTextBox1.Location = new System.Drawing.Point(85, 96);
            this.imTextBox1.Name = "imTextBox1";
            this.imTextBox1.Size = new System.Drawing.Size(100, 20);
            this.imTextBox1.TabIndex = 54;
            // 
            // otTextBox1
            // 
            this.otTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vodBindingSource, "Ot", true));
            this.otTextBox1.Location = new System.Drawing.Point(85, 122);
            this.otTextBox1.Name = "otTextBox1";
            this.otTextBox1.Size = new System.Drawing.Size(100, 20);
            this.otTextBox1.TabIndex = 55;
            // 
            // stashTextBox1
            // 
            this.stashTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vodBindingSource, "Stash", true));
            this.stashTextBox1.Location = new System.Drawing.Point(365, 70);
            this.stashTextBox1.Name = "stashTextBox1";
            this.stashTextBox1.Size = new System.Drawing.Size(100, 20);
            this.stashTextBox1.TabIndex = 56;
            // 
            // okladTextBox1
            // 
            this.okladTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vodBindingSource, "Oklad", true));
            this.okladTextBox1.Location = new System.Drawing.Point(365, 93);
            this.okladTextBox1.Name = "okladTextBox1";
            this.okladTextBox1.Size = new System.Drawing.Size(100, 20);
            this.okladTextBox1.TabIndex = 57;
            // 
            // katTextBox1
            // 
            this.katTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vodBindingSource, "Kat", true));
            this.katTextBox1.Location = new System.Drawing.Point(365, 122);
            this.katTextBox1.Name = "katTextBox1";
            this.katTextBox1.Size = new System.Drawing.Size(100, 20);
            this.katTextBox1.TabIndex = 58;
            // 
            // data_rDateTimePicker1
            // 
            this.data_rDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vodBindingSource, "Data_r", true));
            this.data_rDateTimePicker1.Location = new System.Drawing.Point(365, 148);
            this.data_rDateTimePicker1.Name = "data_rDateTimePicker1";
            this.data_rDateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.data_rDateTimePicker1.TabIndex = 59;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 259);
            this.Controls.Add(this.data_rDateTimePicker1);
            this.Controls.Add(this.katTextBox1);
            this.Controls.Add(this.okladTextBox1);
            this.Controls.Add(this.stashTextBox1);
            this.Controls.Add(this.otTextBox1);
            this.Controls.Add(this.imTextBox1);
            this.Controls.Add(this.famTextBox1);
            this.Controls.Add(this.vodBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(katLabel);
            this.Controls.Add(okladLabel);
            this.Controls.Add(stashLabel);
            this.Controls.Add(data_rLabel);
            this.Controls.Add(otLabel);
            this.Controls.Add(imLabel);
            this.Controls.Add(famLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Добавление водителя";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vodBindingNavigator)).EndInit();
            this.vodBindingNavigator.ResumeLayout(false);
            this.vodBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Av_sDataSet av_sDataSet;
        private System.Windows.Forms.BindingSource vodBindingSource;
        private Av_sDataSetTableAdapters.VodTableAdapter vodTableAdapter;
        private Av_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox famTextBox1;
        private System.Windows.Forms.TextBox imTextBox1;
        private System.Windows.Forms.TextBox otTextBox1;
        private System.Windows.Forms.TextBox stashTextBox1;
        private System.Windows.Forms.TextBox okladTextBox1;
        private System.Windows.Forms.TextBox katTextBox1;
        private System.Windows.Forms.DateTimePicker data_rDateTimePicker1;
    }
}