using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjAanwezigheidslijst
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*new BeheerAllesForm() new BeheerForm()*/ new TijdregistratieForm());
            Application.Run(new BeheerAllesForm());
        }
    }
}
