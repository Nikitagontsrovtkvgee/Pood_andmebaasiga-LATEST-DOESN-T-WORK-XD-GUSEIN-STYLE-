using System;
using System.Windows.Forms;

namespace Pood_andmebaasiga
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаем форму товаров с правами админа
            Application.Run(new Tooded("Admin"));
        }
    }
}