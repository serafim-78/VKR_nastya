namespace Диплом
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.измененияПравДоступаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаПравToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доступDataSet = new Диплом.доступDataSet();
            this.праваDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.праваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new Диплом.доступDataSetTableAdapters.пользователиTableAdapter();
            this.tableAdapterManager = new Диплом.доступDataSetTableAdapters.TableAdapterManager();
            this.праваTableAdapter = new Диплом.доступDataSetTableAdapters.ПраваTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.матрица_правBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.матрица_правTableAdapter = new Диплом.доступDataSetTableAdapters.Матрица_правTableAdapter();
            this.матрица_правDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.праваDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.праваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_правBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_правDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузкиToolStripMenuItem,
            this.измененияПравДоступаToolStripMenuItem,
            this.изменитьПарольToolStripMenuItem,
            this.матрицаПравToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 7;
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
            // измененияПравДоступаToolStripMenuItem
            // 
            this.измененияПравДоступаToolStripMenuItem.Name = "измененияПравДоступаToolStripMenuItem";
            this.измененияПравДоступаToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.измененияПравДоступаToolStripMenuItem.Text = "Изменения Прав Доступа";
            this.измененияПравДоступаToolStripMenuItem.Click += new System.EventHandler(this.измененияПравДоступаToolStripMenuItem_Click);
            // 
            // изменитьПарольToolStripMenuItem
            // 
            this.изменитьПарольToolStripMenuItem.Name = "изменитьПарольToolStripMenuItem";
            this.изменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.изменитьПарольToolStripMenuItem.Text = "Пользователь";
            this.изменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.изменитьПарольToolStripMenuItem_Click);
            // 
            // матрицаПравToolStripMenuItem
            // 
            this.матрицаПравToolStripMenuItem.Name = "матрицаПравToolStripMenuItem";
            this.матрицаПравToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.матрицаПравToolStripMenuItem.Text = "Матрица прав";
            this.матрицаПравToolStripMenuItem.Click += new System.EventHandler(this.матрицаПравToolStripMenuItem_Click);
            // 
            // пользователиDataGridView
            // 
            this.пользователиDataGridView.AutoGenerateColumns = false;
            this.пользователиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пользователиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.пользователиDataGridView.DataSource = this.пользователиBindingSource;
            this.пользователиDataGridView.Location = new System.Drawing.Point(12, 36);
            this.пользователиDataGridView.Name = "пользователиDataGridView";
            this.пользователиDataGridView.Size = new System.Drawing.Size(347, 242);
            this.пользователиDataGridView.TabIndex = 8;
            this.пользователиDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_пользователя";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_пользователя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn3.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "пользователи";
            this.пользователиBindingSource.DataSource = this.доступDataSet;
            // 
            // доступDataSet
            // 
            this.доступDataSet.DataSetName = "доступDataSet";
            this.доступDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // праваDataGridView
            // 
            this.праваDataGridView.AutoGenerateColumns = false;
            this.праваDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.праваDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.праваDataGridView.DataSource = this.праваBindingSource;
            this.праваDataGridView.Location = new System.Drawing.Point(12, 36);
            this.праваDataGridView.Name = "праваDataGridView";
            this.праваDataGridView.Size = new System.Drawing.Size(245, 220);
            this.праваDataGridView.TabIndex = 8;
            this.праваDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_права";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_права";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn5.HeaderText = "Название";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // праваBindingSource
            // 
            this.праваBindingSource.DataMember = "Права";
            this.праваBindingSource.DataSource = this.доступDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Диплом.доступDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Матрица_правTableAdapter = null;
            this.tableAdapterManager.пользователиTableAdapter = this.пользователиTableAdapter;
            this.tableAdapterManager.ПраваTableAdapter = this.праваTableAdapter;
            // 
            // праваTableAdapter
            // 
            this.праваTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // матрица_правBindingSource
            // 
            this.матрица_правBindingSource.DataMember = "Матрица прав";
            this.матрица_правBindingSource.DataSource = this.доступDataSet;
            // 
            // матрица_правTableAdapter
            // 
            this.матрица_правTableAdapter.ClearBeforeFill = true;
            // 
            // матрица_правDataGridView
            // 
            this.матрица_правDataGridView.AutoGenerateColumns = false;
            this.матрица_правDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.матрица_правDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.матрица_правDataGridView.DataSource = this.матрица_правBindingSource;
            this.матрица_правDataGridView.Location = new System.Drawing.Point(12, 36);
            this.матрица_правDataGridView.Name = "матрица_правDataGridView";
            this.матрица_правDataGridView.Size = new System.Drawing.Size(343, 220);
            this.матрица_правDataGridView.TabIndex = 9;
            this.матрица_правDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "пользователь";
            this.dataGridViewTextBoxColumn7.HeaderText = "пользователь";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "право";
            this.dataGridViewTextBoxColumn8.HeaderText = "право";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(616, 441);
            this.ControlBox = false;
            this.Controls.Add(this.матрица_правDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.праваDataGridView);
            this.Controls.Add(this.пользователиDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.праваDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.праваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_правBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.матрица_правDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem измененияПравДоступаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьПарольToolStripMenuItem;
        private доступDataSet доступDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private доступDataSetTableAdapters.пользователиTableAdapter пользователиTableAdapter;
        private доступDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView пользователиDataGridView;
        private доступDataSetTableAdapters.ПраваTableAdapter праваTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource праваBindingSource;
        private System.Windows.Forms.DataGridView праваDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem матрицаПравToolStripMenuItem;
        private System.Windows.Forms.BindingSource матрица_правBindingSource;
        private доступDataSetTableAdapters.Матрица_правTableAdapter матрица_правTableAdapter;
        private System.Windows.Forms.DataGridView матрица_правDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

