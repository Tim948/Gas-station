namespace DB
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.Label marka_topLabel;
            this.av_sDataSet = new DB.Av_sDataSet();
            this.mark_topBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mark_topTableAdapter = new DB.Av_sDataSetTableAdapters.Mark_topTableAdapter();
            this.tableAdapterManager = new DB.Av_sDataSetTableAdapters.TableAdapterManager();
            this.mark_topBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mark_topBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.marka_topTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            marka_topLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_topBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_topBindingNavigator)).BeginInit();
            this.mark_topBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // av_sDataSet
            // 
            this.av_sDataSet.DataSetName = "Av_sDataSet";
            this.av_sDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mark_topBindingSource
            // 
            this.mark_topBindingSource.DataMember = "Mark_top";
            this.mark_topBindingSource.DataSource = this.av_sDataSet;
            // 
            // mark_topTableAdapter
            // 
            this.mark_topTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ZapravkaTableAdapter = null;
            // 
            // mark_topBindingNavigator
            // 
            this.mark_topBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mark_topBindingNavigator.BindingSource = this.mark_topBindingSource;
            this.mark_topBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mark_topBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mark_topBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mark_topBindingNavigatorSaveItem});
            this.mark_topBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mark_topBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mark_topBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mark_topBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mark_topBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mark_topBindingNavigator.Name = "mark_topBindingNavigator";
            this.mark_topBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mark_topBindingNavigator.Size = new System.Drawing.Size(287, 25);
            this.mark_topBindingNavigator.TabIndex = 0;
            this.mark_topBindingNavigator.Text = "bindingNavigator1";
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
            // mark_topBindingNavigatorSaveItem
            // 
            this.mark_topBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mark_topBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mark_topBindingNavigatorSaveItem.Image")));
            this.mark_topBindingNavigatorSaveItem.Name = "mark_topBindingNavigatorSaveItem";
            this.mark_topBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mark_topBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mark_topBindingNavigatorSaveItem.Click += new System.EventHandler(this.mark_topBindingNavigatorSaveItem_Click);
            // 
            // marka_topLabel
            // 
            marka_topLabel.AutoSize = true;
            marka_topLabel.Location = new System.Drawing.Point(101, 42);
            marka_topLabel.Name = "marka_topLabel";
            marka_topLabel.Size = new System.Drawing.Size(87, 13);
            marka_topLabel.TabIndex = 1;
            marka_topLabel.Text = "Марка топлива:";
            // 
            // marka_topTextBox
            // 
            this.marka_topTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mark_topBindingSource, "Marka_top", true));
            this.marka_topTextBox.Location = new System.Drawing.Point(58, 71);
            this.marka_topTextBox.Name = "marka_topTextBox";
            this.marka_topTextBox.Size = new System.Drawing.Size(174, 20);
            this.marka_topTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(102, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 22);
            this.button1.TabIndex = 55;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(287, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(marka_topLabel);
            this.Controls.Add(this.marka_topTextBox);
            this.Controls.Add(this.mark_topBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form10";
            this.Text = "Добавить марку топлива";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.av_sDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_topBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mark_topBindingNavigator)).EndInit();
            this.mark_topBindingNavigator.ResumeLayout(false);
            this.mark_topBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Av_sDataSet av_sDataSet;
        private System.Windows.Forms.BindingSource mark_topBindingSource;
        private Av_sDataSetTableAdapters.Mark_topTableAdapter mark_topTableAdapter;
        private Av_sDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mark_topBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mark_topBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox marka_topTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}