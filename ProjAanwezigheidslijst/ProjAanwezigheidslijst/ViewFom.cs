using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjAanwezigheidslijst
{
    public partial class ViewFom : Form
    {
        public ViewFom()
        {
            InitializeComponent();
        }

        


        private void DlnmrButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new ViewDeelnemerForm())
            {
                var result = dlg.ShowDialog();
            }
        }
    }
}
