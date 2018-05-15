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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void чекBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.чекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.дипDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.дипDataSet.меню);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Чек". При необходимости она может быть перемещена или удалена.
            this.чекTableAdapter.Fill(this.дипDataSet.Чек);

        }
    }
}
