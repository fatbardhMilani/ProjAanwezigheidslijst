using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aanwezigheidslijst;

namespace ProjAanwezigheidslijst
{
    public partial class BeheerForm : Form
    {
        public BeheerForm()
        {
            InitializeComponent();
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            using (var dlg = new ToevoegenForm())
            {
                var result = dlg.ShowDialog();
            }
        }

        private void VieuwButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new ViewTabForm())
            {
                var result = dlg.ShowDialog();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new WijzigenForm())
            {
                var result = dlg.ShowDialog();
            }
        }
    }
}
