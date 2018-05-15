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
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void инвентаризацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.инвентаризацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.дипDataSet);

        }

        private void Менеджер_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Расход_списанного". При необходимости она может быть перемещена или удалена.
            this.расход_списанногоTableAdapter.Fill(this.дипDataSet.Расход_списанного);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.дипDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Расход_по_категориям". При необходимости она может быть перемещена или удалена.
            this.расход_по_категориямTableAdapter.Fill(this.дипDataSet.Расход_списанного);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Расход_по_категориям". При необходимости она может быть перемещена или удалена.
            this.расход_по_категориямTableAdapter.Fill(this.дипDataSet.Расход_списанного);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Инвентаризация". При необходимости она может быть перемещена или удалена.
            this.инвентаризацияTableAdapter.Fill(this.дипDataSet.Инвентаризация);

        }

        private void таблицаИнвентаризацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            инвентаризацияDataGridView.Visible = true;
            расход_списанногоDataGridView.Visible = false;
            заказDataGridView.Visible = false;
            button1.Visible = true;

        }

        private void расходСписанногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            инвентаризацияDataGridView.Visible =false ;
            расход_списанногоDataGridView.Visible = true;
            заказDataGridView.Visible = false;
            button1.Visible = true;
        }

        private void заказНаСкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            инвентаризацияDataGridView.Visible = false;
            расход_списанногоDataGridView.Visible =false ;
            заказDataGridView.Visible = true;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            инвентаризацияTableAdapter.Update(дипDataSet);
            расход_списанногоTableAdapter.Update(дипDataSet);
            заказTableAdapter.Update(дипDataSet);
        }
    }
}
