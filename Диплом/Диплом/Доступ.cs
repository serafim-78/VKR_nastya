using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    public partial class Доступ : Form
    {
        string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public Доступ()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Логин='" + логинComboBox.Text + "' and Пароль='" + textBox1.Text + "'";
            DataRow[] dr = доступDataSet.пользователи.Select(str);
            if (dr.Length == 1)
            {
                User = логинComboBox.Text;
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }

        private void Доступ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доступDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.доступDataSet.пользователи);

        }
    }
}
