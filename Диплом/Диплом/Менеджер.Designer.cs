namespace Диплом
{
    partial class Менеджер
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
            this.расходСписанногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказНаСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дипDataSet = new Диплом.дипDataSet();
            this.инвентаризацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.инвентаризацияTableAdapter = new Диплом.дипDataSetTableAdapters.ИнвентаризацияTableAdapter();
            this.tableAdapterManager = new Диплом.дипDataSetTableAdapters.TableAdapterManager();
            this.заказTableAdapter = new Диплом.дипDataSetTableAdapters.ЗаказTableAdapter();
            this.инвентаризацияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.расход_списанногоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расход_списанногоTableAdapter = new Диплом.дипDataSetTableAdapters.Расход_списанногоTableAdapter();
            this.расход_списанногоDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_списанногоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расход_списанногоDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузкиToolStripMenuItem,
            this.таблицаИнвентаризацииToolStripMenuItem,
            this.расходСписанногоToolStripMenuItem,
            this.заказНаСкладToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 9;
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
            // расходСписанногоToolStripMenuItem
            // 
            this.расходСписанногоToolStripMenuItem.Name = "расходСписанногоToolStripMenuItem";
            this.расходСписанногоToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.расходСписанногоToolStripMenuItem.Text = "расход списанного";
            this.расходСписанногоToolStripMenuItem.Click += new System.EventHandler(this.расходСписанногоToolStripMenuItem_Click);
            // 
            // заказНаСкладToolStripMenuItem
            // 
            this.заказНаСкладToolStripMenuItem.Name = "заказНаСкладToolStripMenuItem";
            this.заказНаСкладToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.заказНаСкладToolStripMenuItem.Text = "Заказ на склад";
            this.заказНаСкладToolStripMenuItem.Click += new System.EventHandler(this.заказНаСкладToolStripMenuItem_Click);
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
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.ИнвентаризацияTableAdapter = this.инвентаризацияTableAdapter;
            this.tableAdapterManager.менюTableAdapter = null;
            this.tableAdapterManager.Расход_списанногоTableAdapter = null;
            this.tableAdapterManager.Состав_по_чекуTableAdapter = null;
            this.tableAdapterManager.составTableAdapter = null;
            this.tableAdapterManager.список_продуктовTableAdapter = null;
            this.tableAdapterManager.ЧекTableAdapter = null;
            this.tableAdapterManager.шаблон_блюдаTableAdapter = null;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
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
            this.инвентаризацияDataGridView.Location = new System.Drawing.Point(30, 48);
            this.инвентаризацияDataGridView.Name = "инвентаризацияDataGridView";
            this.инвентаризацияDataGridView.Size = new System.Drawing.Size(444, 228);
            this.инвентаризацияDataGridView.TabIndex = 10;
            this.инвентаризацияDataGridView.Visible = false;
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
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.дипDataSet;
            // 
            // заказDataGridView
            // 
            this.заказDataGridView.AutoGenerateColumns = false;
            this.заказDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заказDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.заказDataGridView.DataSource = this.заказBindingSource;
            this.заказDataGridView.Location = new System.Drawing.Point(30, 48);
            this.заказDataGridView.Name = "заказDataGridView";
            this.заказDataGridView.Size = new System.Drawing.Size(449, 220);
            this.заказDataGridView.TabIndex = 10;
            this.заказDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код заказа";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код заказа";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "код продукта";
            this.dataGridViewTextBoxColumn9.HeaderText = "код продукта";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "наименование продукта";
            this.dataGridViewTextBoxColumn10.HeaderText = "наименование продукта";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "кол-во заказа";
            this.dataGridViewTextBoxColumn11.HeaderText = "кол-во заказа";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
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
            // расход_списанногоDataGridView
            // 
            this.расход_списанногоDataGridView.AutoGenerateColumns = false;
            this.расход_списанногоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.расход_списанногоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.расход_списанногоDataGridView.DataSource = this.расход_списанногоBindingSource;
            this.расход_списанногоDataGridView.Location = new System.Drawing.Point(30, 48);
            this.расход_списанногоDataGridView.Name = "расход_списанногоDataGridView";
            this.расход_списанногоDataGridView.Size = new System.Drawing.Size(345, 220);
            this.расход_списанногоDataGridView.TabIndex = 11;
            this.расход_списанногоDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Код расхода";
            this.dataGridViewTextBoxColumn12.HeaderText = "Код расхода";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Код состава";
            this.dataGridViewTextBoxColumn13.HeaderText = "Код состава";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Расход";
            this.dataGridViewTextBoxColumn14.HeaderText = "Расход";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Менеджер
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(903, 496);
            this.ControlBox = false;
            this.Controls.Add(this.расход_списанногоDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.заказDataGridView);
            this.Controls.Add(this.инвентаризацияDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Менеджер";
            this.Text = "Менеджер";
            this.Load += new System.EventHandler(this.Менеджер_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.дипDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.инвентаризацияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem расходСписанногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказНаСкладToolStripMenuItem;
        private дипDataSet дипDataSet;
        private System.Windows.Forms.BindingSource инвентаризацияBindingSource;
        private дипDataSetTableAdapters.ИнвентаризацияTableAdapter инвентаризацияTableAdapter;
        private дипDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView инвентаризацияDataGridView;
        private дипDataSetTableAdapters.Расход_списанногоTableAdapter расход_по_категориямTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource расход_по_категориямBindingSource;
        private дипDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private System.Windows.Forms.DataGridView заказDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource расход_списанногоBindingSource;
        private дипDataSetTableAdapters.Расход_списанногоTableAdapter расход_списанногоTableAdapter;
        private System.Windows.Forms.DataGridView расход_списанногоDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}