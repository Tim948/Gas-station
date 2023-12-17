namespace DB
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            System.Windows.Forms.Label tip_avtoLabel;
            this.av_sDataSet = new DB.Av_sDataSet();
            this.tip_avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_avtoTableAdapter = new DB.Av_sDataSetTableAdapters.Tip_avtoTableAdapter();
            this.tableAdapterManager = new DB.Av_sDataSetTableAdapters.TableAdapterManager();
            this.tip_avtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tip_avtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tip_avtoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            tip_avtoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_avtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_avtoBindingNavigator)).BeginInit();
            this.tip_avtoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // av_sDataSet
            // 
            this.av_sDataSet.DataSetName = "Av_sDataSet";
            this.av_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tip_avtoBindingSource
            // 
            this.tip_avtoBindingSource.DataMember = "Tip_avto";
            this.tip_avtoBindingSource.DataSource = this.av_sDataSet;
            // 
            // tip_avtoTableAdapter
            // 
            this.tip_avtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Mark_topTableAdapter = null;
            this.tableAdapterManager.Put_listTableAdapter = null;
            this.tableAdapterManager.Tip_avtoTableAdapter = this.tip_avtoTableAdapter;
            this.tableAdapterManager.Trans_sredTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB.Av_sDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VodTableAdapter = null;
            this.tableAdapterManager.ZapravkaTableAdapter = null;
            // 
            // tip_avtoBindingNavigator
            // 
            this.tip_avtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tip_avtoBindingNavigator.BindingSource = this.tip_avtoBindingSource;
            this.tip_avtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tip_avtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tip_avtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tip_avtoBindingNavigatorSaveItem});
            this.tip_avtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tip_avtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tip_avtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tip_avtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tip_avtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tip_avtoBindingNavigator.Name = "tip_avtoBindingNavigator";
            this.tip_avtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tip_avtoBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.tip_avtoBindingNavigator.TabIndex = 0;
            this.tip_avtoBindingNavigator.Text = "bindingNavigator1";
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
            // tip_avtoBindingNavigatorSaveItem
            // 
            this.tip_avtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tip_avtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tip_avtoBindingNavigatorSaveItem.Image")));
            this.tip_avtoBindingNavigatorSaveItem.Name = "tip_avtoBindingNavigatorSaveItem";
            this.tip_avtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tip_avtoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tip_avtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tip_avtoBindingNavigatorSaveItem_Click);
            // 
            // tip_avtoLabel
            // 
            tip_avtoLabel.AutoSize = true;
            tip_avtoLabel.Location = new System.Drawing.Point(88, 55);
            tip_avtoLabel.Name = "tip_avtoLabel";
            tip_avtoLabel.Size = new System.Drawing.Size(107, 13);
            tip_avtoLabel.TabIndex = 1;
            tip_avtoLabel.Text = "Типы автомобилей:";
            // 
            // tip_avtoTextBox
            // 
            this.tip_avtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tip_avtoBindingSource, "Tip_avto", true));
            this.tip_avtoTextBox.Location = new System.Drawing.Point(53, 80);
            this.tip_avtoTextBox.Name = "tip_avtoTextBox";
            this.tip_avtoTextBox.Size = new System.Drawing.Size(176, 20);
            this.tip_avtoTextBox.TabIndex = 2;
            this.tip_avtoTextBox.TextChanged += new System.EventHandler(this.tip_avtoTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(97, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 55;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(tip_avtoLabel);
            this.Controls.Add(this.tip_avtoTextBox);
            this.Controls.Add(this.tip_avtoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form11";
            this.Text = "Типы автомобиля";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_avtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tip_avtoBindingNavigator)).EndInit();
            this.tip_avtoBindingNavigator.ResumeLayout(false);
            this.tip_avtoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Av_sDataSet av_sDataSet;
        private System.Windows.Forms.BindingSource tip_avtoBindingSource;
        private Av_sDataSetTableAdapters.Tip_avtoTableAdapter tip_avtoTableAdapter;
        private Av_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tip_avtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tip_avtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tip_avtoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}