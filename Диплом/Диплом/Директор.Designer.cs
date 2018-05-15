namespace Диплом
{
    partial class Директор
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаИнвентаризацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходСписанногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходПоЧекуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дипDataSet = new Диплом.дипDataSet();
            this.инвентаризацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.инвентаризацияTableAdapter = new Диплом.дипDataSetTableAdapters.ИнвентаризацияTableAdapter();
            this.tableAdapterManager = new Диплом.дипDataSetTableAdapters.TableAdapterManager();
            this.менюTableAdapter = new Диплом.дипDataSetTableAdapters.менюTableAdapter();
            this.инвентаризацияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менюDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.расход_списанногоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расход_списанногоTableAdapter = new Диплом.дипDataSetTableAdapters.Расход_списанногоTableAdapter();
            this.кодРасходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСоставаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расходDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расход_списанногоDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_списанногоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_списанногоDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузкиToolStripMenuItem,
            this.таблицаИнвентаризацииToolStripMenuItem,
            this.менюToolStripMenuItem,
            this.расходСписанногоToolStripMenuItem,
            this.расходПоЧекуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузкиToolStripMenuItem
            // 
            this.загрузкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.загрузкиToolStripMenuItem.Name = "загрузкиToolStripMenuItem";
            this.загрузкиToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.загрузкиToolStripMenuItem.Text = "Загрузки";
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
            // таблицаИнвентаризацииToolStripMenuItem
            // 
            this.таблицаИнвентаризацииToolStripMenuItem.Name = "таблицаИнвентаризацииToolStripMenuItem";
            this.таблицаИнвентаризацииToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.таблицаИнвентаризацииToolStripMenuItem.Text = "Таблица Инвентаризации";
            this.таблицаИнвентаризацииToolStripMenuItem.Click += new System.EventHandler(this.таблицаИнвентаризацииToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // расходСписанногоToolStripMenuItem
            // 
            this.расходСписанногоToolStripMenuItem.Name = "расходСписанногоToolStripMenuItem";
            this.расходСписанногоToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.расходСписанногоToolStripMenuItem.Text = "расход списанного";
            this.расходСписанногоToolStripMenuItem.Click += new System.EventHandler(this.расходСписанногоToolStripMenuItem_Click);
            // 
            // расходПоЧекуToolStripMenuItem
            // 
            this.расходПоЧекуToolStripMenuItem.Name = "расходПоЧекуToolStripMenuItem";
            this.расходПоЧекуToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.расходПоЧекуToolStripMenuItem.Text = "расход по чеку";
            // 
            // дипDataSet
            // 
            this.дипDataSet.DataSetName = "дипDataSet";
            this.дипDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // инвентаризацияBindingSource
            // 
            this.инвентаризацияBindingSource.DataMember = "Инвентаризация";
            this.инвентаризацияBindingSource.DataSource = this.дипDataSet;
            // 
            // инвентаризацияTableAdapter
            // 
            this.инвентаризацияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.дипDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксапта_ИВЛ_приходTableAdapter = null;
            this.tableAdapterManager.Блюда_ЧекаTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнвентаризацияTableAdapter = this.инвентаризацияTableAdapter;
            this.tableAdapterManager.менюTableAdapter = this.менюTableAdapter;
            this.tableAdapterManager.Состав_по_чекуTableAdapter = null;
            this.tableAdapterManager.составTableAdapter = null;
            this.tableAdapterManager.список_продуктовTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            this.tableAdapterManager.шаблон_блюдаTableAdapter = null;
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
            // 
            // инвентаризацияDataGridView
            // 
            this.инвентаризацияDataGridView.AutoGenerateColumns = false;
            this.инвентаризацияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.инвентаризацияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.инвентаризацияDataGridView.DataSource = this.инвентаризацияBindingSource;
            this.инвентаризацияDataGridView.Location = new System.Drawing.Point(12, 27);
            this.инвентаризацияDataGridView.Name = "инвентаризацияDataGridView";
            this.инвентаризацияDataGridView.Size = new System.Drawing.Size(452, 227);
            this.инвентаризацияDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "код инвент";
            this.dataGridViewTextBoxColumn1.HeaderText = "код инвент";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "итог штук";
            this.dataGridViewTextBoxColumn3.HeaderText = "итог штук";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "итог коробок";
            this.dataGridViewTextBoxColumn4.HeaderText = "итог коробок";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "меню";
            this.менюBindingSource.DataSource = this.дипDataSet;
            // 
            // менюDataGridView
            // 
            this.менюDataGridView.AutoGenerateColumns = false;
            this.менюDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.менюDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодРасходаDataGridViewTextBoxColumn,
            this.кодСоставаDataGridViewTextBoxColumn,
            this.расходDataGridViewTextBoxColumn});
            this.менюDataGridView.DataSource = this.расход_списанногоBindingSource;
            this.менюDataGridView.Location = new System.Drawing.Point(66, 49);
            this.менюDataGridView.Name = "менюDataGridView";
            this.менюDataGridView.Size = new System.Drawing.Size(346, 220);
            this.менюDataGridView.TabIndex = 9;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // расход_списанногоBindingSource
            // 
            this.расход_списанногоBindingSource.DataMember = "Расход списанного";
            this.расход_списанногоBindingSource.DataSource = this.дипDataSet;
            // 
            // расход_списанногоTableAdapter
            // 
            this.расход_списанногоTableAdapter.ClearBeforeFill = true;
            // 
            // кодРасходаDataGridViewTextBoxColumn
            // 
            this.кодРасходаDataGridViewTextBoxColumn.DataPropertyName = "Код расхода";
            this.кодРасходаDataGridViewTextBoxColumn.HeaderText = "Код расхода";
            this.кодРасходаDataGridViewTextBoxColumn.Name = "кодРасходаDataGridViewTextBoxColumn";
            // 
            // кодСоставаDataGridViewTextBoxColumn
            // 
            this.кодСоставаDataGridViewTextBoxColumn.DataPropertyName = "Код состава";
            this.кодСоставаDataGridViewTextBoxColumn.HeaderText = "Код состава";
            this.кодСоставаDataGridViewTextBoxColumn.Name = "кодСоставаDataGridViewTextBoxColumn";
            // 
            // расходDataGridViewTextBoxColumn
            // 
            this.расходDataGridViewTextBoxColumn.DataPropertyName = "Расход";
            this.расходDataGridViewTextBoxColumn.HeaderText = "Расход";
            this.расходDataGridViewTextBoxColumn.Name = "расходDataGridViewTextBoxColumn";
            // 
            // расход_списанногоDataGridView
            // 
            this.расход_списанногоDataGridView.AutoGenerateColumns = false;
            this.расход_списанногоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.расход_списанногоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.расход_списанногоDataGridView.DataSource = this.расход_списанногоBindingSource;
            this.расход_списанногоDataGridView.Location = new System.Drawing.Point(87, 61);
            this.расход_списанногоDataGridView.Name = "расход_списанногоDataGridView";
            this.расход_списанногоDataGridView.Size = new System.Drawing.Size(343, 220);
            this.расход_списанногоDataGridView.TabIndex = 10;
            this.расход_списанногоDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код расхода";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код расхода";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код состава";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код состава";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Расход";
            this.dataGridViewTextBoxColumn8.HeaderText = "Расход";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Директор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(841, 458);
            this.ControlBox = false;
            this.Controls.Add(this.расход_списанногоDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.менюDataGridView);
            this.Controls.Add(this.инвентаризацияDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Директор";
            this.Text = "Директор";
            this.Load += new System.EventHandler(this.Директор_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_списанногоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_списанногоDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаИнвентаризацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходСписанногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходПоЧекуToolStripMenuItem;
        private дипDataSet дипDataSet;
        private System.Windows.Forms.BindingSource инвентаризацияBindingSource;
        private дипDataSetTableAdapters.ИнвентаризацияTableAdapter инвентаризацияTableAdapter;
        private дипDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView инвентаризацияDataGridView;
        private дипDataSetTableAdapters.менюTableAdapter менюTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private System.Windows.Forms.DataGridView менюDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource расход_списанногоBindingSource;
        private дипDataSetTableAdapters.Расход_списанногоTableAdapter расход_списанногоTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРасходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСоставаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расходDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView расход_списанногоDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}