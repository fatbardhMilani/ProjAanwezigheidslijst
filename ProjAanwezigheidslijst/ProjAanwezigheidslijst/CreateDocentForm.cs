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
    public partial class CreateDocentForm : Form
    {
        public CreateDocentForm()
        {
            InitializeComponent();
        }

        private void CreateDocentButton_Click(object sender, EventArgs e)
        {
            if (naamDocentTexBox.Text != "" && bedrijfDocentTextBox.Text !="")
            {
                using (var context = new AanwezigheidslijstContext())
                {
                    var opleidingsInfo = context.Docentens.Add(new Docenten
                    {
                        Naam = naamDocentTexBox.Text,
                        Bedrijf = bedrijfDocentTextBox.Text,
                    });
                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                MessageBox.Show("alle velden moeten ingevuld zijn");
            }
        }

        
    }
}
