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
    public partial class CreateDeelnemerForm : Form
    {
        public CreateDeelnemerForm()
        {
            InitializeComponent();
        }

        private void CreateDeelnemerButton_Click(object sender, EventArgs e)
        {
            if (naamTextBox.Text != "" && GeboortedatumDateTimePicker.Text != null && woonplaatsTextBox.Text != "" && badgeNummerTexBox.Text != "")    
            {
                using (var context = new AanwezigheidslijstContext())
                {
                    var opleidingsInfo = context.Deelnemers.Add(new Deelnemers
                    {
                        Naam = naamTextBox.Text,
                        GeboorteDatum = GeboortedatumDateTimePicker.Value.Date,
                        Woonplaats = woonplaatsTextBox.Text,
                        BadgeNummer = int.Parse(badgeNummerTexBox.Text),

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
