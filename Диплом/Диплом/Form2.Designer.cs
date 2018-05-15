namespace Диплом
{
    partial class Form2
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
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label выполненLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.дипDataSet = new Диплом.дипDataSet();
            this.чекBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.чекTableAdapter = new Диплом.дипDataSetTableAdapters.ЧекTableAdapter();
            this.tableAdapterManager = new Диплом.дипDataSetTableAdapters.TableAdapterManager();
            this.чекBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.датаTextBox = new System.Windows.Forms.TextBox();
            this.выполненCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.чекBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менюTableAdapter = new Диплом.дипDataSetTableAdapters.менюTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            датаLabel = new System.Windows.Forms.Label();
            выполненLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекBindingNavigator)).BeginInit();
            this.чекBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // дипDataSet
            // 
            this.дипDataSet.DataSetName = "дипDataSet";
            this.дипDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // чекBindingSource
            // 
            this.чекBindingSource.DataMember = "Чек";
            this.чекBindingSource.DataSource = this.дипDataSet;
            // 
            // чекTableAdapter
            // 
            this.чекTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.дипDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксапта_ИВЛ_приходTableAdapter = null;
            this.tableAdapterManager.Блюда_ЧекаTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнвентаризацияTableAdapter = null;
            this.tableAdapterManager.менюTableAdapter = this.менюTableAdapter;
            this.tableAdapterManager.Расход_списанногоTableAdapter = null;
            this.tableAdapterManager.Состав_по_чекуTableAdapter = null;
            this.tableAdapterManager.составTableAdapter = null;
            this.tableAdapterManager.список_продуктовTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = this.чекTableAdapter;
            this.tableAdapterManager.шаблон_блюдаTableAdapter = null;
            // 
            // чекBindingNavigator
            // 
            this.чекBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.чекBindingNavigator.BindingSource = this.чекBindingSource;
            this.чекBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.чекBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.чекBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.чекBindingNavigatorSaveItem});
            this.чекBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.чекBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.чекBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.чекBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.чекBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.чекBindingNavigator.Name = "чекBindingNavigator";
            this.чекBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.чекBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.чекBindingNavigator.TabIndex = 0;
            this.чекBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(11, 46);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 1;
            датаLabel.Text = "Дата:";
            // 
            // датаTextBox
            // 
            this.датаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.чекBindingSource, "Дата", true));
            this.датаTextBox.Location = new System.Drawing.Point(78, 43);
            this.датаTextBox.Name = "датаTextBox";
            this.датаTextBox.Size = new System.Drawing.Size(104, 20);
            this.датаTextBox.TabIndex = 2;
            // 
            // выполненLabel
            // 
            выполненLabel.AutoSize = true;
            выполненLabel.Location = new System.Drawing.Point(11, 92);
            выполненLabel.Name = "выполненLabel";
            выполненLabel.Size = new System.Drawing.Size(61, 13);
            выполненLabel.TabIndex = 3;
            выполненLabel.Text = "Выполнен:";
            // 
            // выполненCheckBox
            // 
            this.выполненCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.чекBindingSource, "Выполнен", true));
            this.выполненCheckBox.Location = new System.Drawing.Point(78, 87);
            this.выполненCheckBox.Name = "выполненCheckBox";
            this.выполненCheckBox.Size = new System.Drawing.Size(104, 24);
            this.выполненCheckBox.TabIndex = 4;
            this.выполненCheckBox.Text = "checkBox1";
            this.выполненCheckBox.UseVisualStyleBackColor = true;
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
            // чекBindingNavigatorSaveItem
            // 
            this.чекBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.чекBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("чекBindingNavigatorSaveItem.Image")));
            this.чекBindingNavigatorSaveItem.Name = "чекBindingNavigatorSaveItem";
            this.чекBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.чекBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.чекBindingNavigatorSaveItem.Click += new System.EventHandler(this.чекBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить блюдо";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.менюBindingSource;
            this.comboBox1.DisplayMember = "наименование блюда";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Код блюда";
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "меню";
            this.менюBindingSource.DataSource = this.дипDataSet;
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(119, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Изменить состав";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 132);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Блюдо:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число порций:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(276, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаTextBox);
            this.Controls.Add(выполненLabel);
            this.Controls.Add(this.выполненCheckBox);
            this.Controls.Add(this.чекBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекBindingNavigator)).EndInit();
            this.чекBindingNavigator.ResumeLayout(false);
            this.чекBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private дипDataSet дипDataSet;
        private System.Windows.Forms.BindingSource чекBindingSource;
        private дипDataSetTableAdapters.ЧекTableAdapter чекTableAdapter;
        private дипDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator чекBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton чекBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox датаTextBox;
        private System.Windows.Forms.CheckBox выполненCheckBox;
        private дипDataSetTableAdapters.менюTableAdapter менюTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}