namespace Диплом
{
    partial class Доступ
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
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label логинLabel;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.логинComboBox = new System.Windows.Forms.ComboBox();
            this.доступDataSet = new Диплом.доступDataSet();
            this.доступDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new Диплом.доступDataSetTableAdapters.пользователиTableAdapter();
            парольLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.доступDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(74, 47);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(48, 13);
            парольLabel.TabIndex = 7;
            парольLabel.Text = "Пароль:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(81, 20);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(41, 13);
            логинLabel.TabIndex = 6;
            логинLabel.Text = "Логин:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // логинComboBox
            // 
            this.логинComboBox.DataSource = this.пользователиBindingSource;
            this.логинComboBox.DisplayMember = "Логин";
            this.логинComboBox.FormattingEnabled = true;
            this.логинComboBox.Location = new System.Drawing.Point(128, 17);
            this.логинComboBox.Name = "логинComboBox";
            this.логинComboBox.Size = new System.Drawing.Size(121, 21);
            this.логинComboBox.TabIndex = 8;
            // 
            // доступDataSet
            // 
            this.доступDataSet.DataSetName = "доступDataSet";
            this.доступDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доступDataSetBindingSource
            // 
            this.доступDataSetBindingSource.DataSource = this.доступDataSet;
            this.доступDataSetBindingSource.Position = 0;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "пользователи";
            this.пользователиBindingSource.DataSource = this.доступDataSetBindingSource;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // Доступ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 119);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(парольLabel);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинComboBox);
            this.Name = "Доступ";
            this.Text = "Доступ";
            this.Load += new System.EventHandler(this.Доступ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.доступDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox логинComboBox;
        private System.Windows.Forms.BindingSource доступDataSetBindingSource;
        private доступDataSet доступDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private доступDataSetTableAdapters.пользователиTableAdapter пользователиTableAdapter;
    }
}