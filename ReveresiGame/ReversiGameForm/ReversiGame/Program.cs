using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AddNameForm AddName = new AddNameForm();
            if(AddName.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ReversiGameForm());
            }
        }
    }
}
