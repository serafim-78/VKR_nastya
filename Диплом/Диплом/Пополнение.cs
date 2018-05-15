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
    public partial class инвент : Form
    {
        public инвент()
        {
            InitializeComponent();
        }

        private void инвентаризацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.инвентаризацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.дипDataSet);

        }

        private void Пополнение_склада_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дипDataSet.Инвентаризация". При необходимости она может быть перемещена или удалена.
            this.инвентаризацияTableAdapter.Fill(this.дипDataSet.Инвентаризация);

        }
    }
}
