using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDB
{
    internal static class Program
    {
        public static Search search;
        public static AddAndEdit addAndEdit;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            search = new Search();
            addAndEdit = new AddAndEdit();
            Application.Run(search);
            
        }
    }
}
