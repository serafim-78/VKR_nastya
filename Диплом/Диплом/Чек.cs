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
    public partial class Чек : Form
    {
        public Чек()
        {
            InitializeComponent();
        }

        private void чекBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.чекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.дипDataSet1);

        }

        private void Чек_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet1.Чек". При необходимости она может быть перемещена или удалена.
            this.чекTableAdapter.Fill(this.дипDataSet1.Чек);

        }
    }
}
