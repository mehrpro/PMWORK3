using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;

namespace PMWORK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new Container(new TypeRegistery());
            var frm = container.GetInstance<frmLogin2>();
            Application.Run(frm);
            if (frm.DialogResult == DialogResult.OK)
            {

                var frmMain = container.GetInstance<MainForm>();
                frmMain.ShowDialog();
            }
            else
                Environment.Exit(0);
        }
    }
}
