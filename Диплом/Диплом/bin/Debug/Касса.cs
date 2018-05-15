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
    public partial class Касса : Form
    {
        public Касса()
        {
            InitializeComponent();
        }


        private void Касса_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Чек". При необходимости она может быть перемещена или удалена.
            this.чекTableAdapter.Fill(this.дипDataSet.Чек);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.дипDataSet.меню);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet1.Блюда_Чека". При необходимости она может быть перемещена или удалена.
            this.блюда_ЧекаTableAdapter.Fill(this.дипDataSet.Блюда_Чека);
            
        }

      
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            блюда_ЧекаTableAdapter.Update(дипDataSet);
            чекTableAdapter.Update(дипDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Чек frm= new Чек();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string str = "[наименование блюда]='" + comboBox1.Text + "'";
            
          //  DataRow[] dr = дипDataSet.меню.Select(str);
          //  MessageBox.Show(dr.ToString());
          //  блюда_ЧекаDataGridView.Rows.Add(dr);

        }
    }
}
