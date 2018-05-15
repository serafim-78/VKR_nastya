using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Доступ dlg = new Доступ();
            Form1 form1 = new Form1();
            Директор form2 = new Директор();
            Менеджер form3 = new Менеджер();
            Касса form4 = new Касса();
            while (dlg.DialogResult != DialogResult.Cancel)
            {
                dlg.ShowDialog();
                if (dlg.DialogResult == DialogResult.Yes)
                {
                    switch (dlg.User)
                    {
                        case "Администратор":
                            {
                                form1.ShowDialog();
                                break;
                            }
                        case "Директор":
                            {
                                form2.ShowDialog();
                                break;
                            }
                        case "Менеджер":
                            {
                                form3.ShowDialog();
                                break;
                            }
                        case "Кассир":
                            {
                                form4.ShowDialog();
                                break;
                            }
                    }
                }
            }
        }
    }
}
