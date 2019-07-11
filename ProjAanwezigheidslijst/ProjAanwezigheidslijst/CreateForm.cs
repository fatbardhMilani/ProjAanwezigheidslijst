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
    public partial class CreateForm : Form
    {
        
        public CreateForm()
        {
            InitializeComponent();
        }
        
        private void OpleidingInfoButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new CreateOpleidingsInfo())
            {
                var result = dlg.ShowDialog();

                switch (result)
                {
                    case DialogResult.OK:
                        
                        break;
                  
                }
            }
        }

        private void DeelnemersButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new CreateDeelnemerForm())
            {
                var result = dlg.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:

                        break;

                }
            }
        }

        private void DocentButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new CreateDocentForm())
            {
                var result = dlg.ShowDialog();
                switch (result)
                {
                    case DialogResult.OK:

                        break;

                }
            }
        }

        private void FeestdagenButton_Click(object sender, EventArgs e)
        {
            using (var dlg = new CreateFeestdagenForm())
            {
                var result = dlg.ShowDialog();
                switch (result)
                {
                   
                    case DialogResult.OK:
                        break;
                    
                }
            }
        }
    }
}
