namespace Диплом
{
    partial class Касса
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
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дипDataSet = new Диплом.дипDataSet();
            this.дипDataSet1 = new Диплом.дипDataSet();
            this.блюда_ЧекаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.блюда_ЧекаTableAdapter = new Диплом.дипDataSetTableAdapters.Блюда_ЧекаTableAdapter();
            this.tableAdapterManager = new Диплом.дипDataSetTableAdapters.TableAdapterManager();
            this.блюда_ЧекаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.менюBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.блокАвторизацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.менюBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.менюTableAdapter = new Диплом.дипDataSetTableAdapters.менюTableAdapter();
            this.чекBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.чекTableAdapter = new Диплом.дипDataSetTableAdapters.ЧекTableAdapter();
            this.чекDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюда_ЧекаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюда_ЧекаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "меню";
            this.менюBindingSource.DataSource = this.дипDataSet;
            // 
            // дипDataSet
            // 
            this.дипDataSet.DataSetName = "дипDataSet";
            this.дипDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дипDataSet1
            // 
            this.дипDataSet1.DataSetName = "дипDataSet1";
            this.дипDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // блюда_ЧекаBindingSource
            // 
            this.блюда_ЧекаBindingSource.DataMember = "Блюда Чека";
            this.блюда_ЧекаBindingSource.DataSource = this.дипDataSet1;
            // 
            // блюда_ЧекаTableAdapter
            // 
            this.блюда_ЧекаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.дипDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксапта_ИВЛ_приходTableAdapter = null;
            this.tableAdapterManager.Блюда_ЧекаTableAdapter = this.блюда_ЧекаTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнвентаризацияTableAdapter = null;
            this.tableAdapterManager.менюTableAdapter = null;
            this.tableAdapterManager.Расход_списанногоTableAdapter = null;
            this.tableAdapterManager.Состав_по_чекуTableAdapter = null;
            this.tableAdapterManager.составTableAdapter = null;
            this.tableAdapterManager.список_продуктовTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            this.tableAdapterManager.шаблон_блюдаTableAdapter = null;
            // 
            // блюда_ЧекаDataGridView
            // 
            this.блюда_ЧекаDataGridView.AllowUserToOrderColumns = true;
            this.блюда_ЧекаDataGridView.AutoGenerateColumns = false;
            this.блюда_ЧекаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.блюда_ЧекаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.блюда_ЧекаDataGridView.DataSource = this.блюда_ЧекаBindingSource;
            this.блюда_ЧекаDataGridView.Location = new System.Drawing.Point(12, 46);
            this.блюда_ЧекаDataGridView.Name = "блюда_ЧекаDataGridView";
            this.блюда_ЧекаDataGridView.Size = new System.Drawing.Size(543, 286);
            this.блюда_ЧекаDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код блюда чека";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код блюда чека";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код чека";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код чека";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код блюда";
            this.dataGridViewTextBoxColumn3.DataSource = this.менюBindingSource2;
            this.dataGridViewTextBoxColumn3.DisplayMember = "наименование блюда";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код блюда";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код блюда";
            // 
            // менюBindingSource2
            // 
            this.менюBindingSource2.DataMember = "меню";
            this.менюBindingSource2.DataSource = this.дипDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Кол-во";
            this.dataGridViewTextBoxColumn4.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Изменено";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Изменено";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.блокАвторизацииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // блокАвторизацииToolStripMenuItem
            // 
            this.блокАвторизацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.блокАвторизацииToolStripMenuItem.Name = "блокАвторизацииToolStripMenuItem";
            this.блокАвторизацииToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.блокАвторизацииToolStripMenuItem.Text = "блок авторизации";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "сохранить изменение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // менюBindingSource1
            // 
            this.менюBindingSource1.DataMember = "меню";
            this.менюBindingSource1.DataSource = this.дипDataSet;
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
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
            // чекDataGridView
            // 
            this.чекDataGridView.AutoGenerateColumns = false;
            this.чекDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.чекDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn2});
            this.чекDataGridView.DataSource = this.чекBindingSource;
            this.чекDataGridView.Location = new System.Drawing.Point(574, 131);
            this.чекDataGridView.Name = "чекDataGridView";
            this.чекDataGridView.Size = new System.Drawing.Size(346, 220);
            this.чекDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код чека";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код чека";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Выполнен";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Выполнен";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // Касса
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.ControlBox = false;
            this.Controls.Add(this.чекDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.блюда_ЧекаDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Касса";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Касса_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюда_ЧекаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюда_ЧекаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.чекDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private дипDataSet дипDataSet;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private дипDataSet дипDataSet1;
        private System.Windows.Forms.BindingSource блюда_ЧекаBindingSource;
        private дипDataSetTableAdapters.Блюда_ЧекаTableAdapter блюда_ЧекаTableAdapter;
        private дипDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView блюда_ЧекаDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem блокАвторизацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource менюBindingSource1;
        private дипDataSetTableAdapters.менюTableAdapter менюTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource менюBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource чекBindingSource;
        private дипDataSetTableAdapters.ЧекTableAdapter чекTableAdapter;
        private System.Windows.Forms.DataGridView чекDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}