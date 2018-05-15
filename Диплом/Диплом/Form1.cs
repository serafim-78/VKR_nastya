using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Диплом
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
      
        public class Connect
        {
            public static void Main()
            {
                String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=.\\Employee.mdb";
                OleDbConnection con = new OleDbConnection(connect);
                con.Open();
            }
        }
        public DataTable dataTable;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доступDataSet.Матрица_прав". При необходимости она может быть перемещена или удалена.
            this.матрица_правTableAdapter.Fill(this.доступDataSet.Матрица_прав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доступDataSet.Права". При необходимости она может быть перемещена или удалена.
            this.праваTableAdapter.Fill(this.доступDataSet.Права);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доступDataSet.Права". При необходимости она может быть перемещена или удалена.
            this.праваTableAdapter.Fill(this.доступDataSet.Права);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "доступDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.доступDataSet.пользователи);
            
        }
        

     
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.доступDataSet);

        }

        private void измененияПравДоступаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            праваDataGridView.Visible = true;
            пользователиDataGridView.Visible = false;
            матрица_правDataGridView.Visible = false;
            button1.Visible = true;
        }

        private void изменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            праваDataGridView.Visible = false;
            пользователиDataGridView.Visible = true;
            матрица_правDataGridView.Visible = false;
            button1.Visible = true;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            праваTableAdapter.Update(доступDataSet);
            матрица_правTableAdapter.Update(доступDataSet);
            пользователиTableAdapter.Update(доступDataSet);

        }

        private void матрицаПравToolStripMenuItem_Click(object sender, EventArgs e)
        {
             матрица_правDataGridView.Visible = true;
             праваDataGridView.Visible = false;
             пользователиDataGridView.Visible = false;
            button1.Visible = true;

        }
    }
}
