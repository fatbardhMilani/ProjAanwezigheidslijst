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
    public partial class WijzigenForm : Form
    {
        public WijzigenForm()
        {
            InitializeComponent();
        }

        private void ZoekenButton_Click(object sender, EventArgs e)
        {
            string zoekNaam = naamZoekTextBox.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == zoekNaam);
                naamTextBox.Text = deelnemer.Naam;
                GeboortedatumDateTimePicker.Value = deelnemer.GeboorteDatum;
                woonplaatsTextBox.Text = deelnemer.Woonplaats;
                badgeNummerTexBox.Text = deelnemer.BadgeNummer.ToString();
               

            }
        }

        private void SaveChangeDeelnemerButton_Click(object sender, EventArgs e)
        {
            string zoekNaam = naamZoekTextBox.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == zoekNaam);
                deelnemer.Naam =naamTextBox.Text;
                deelnemer.GeboorteDatum = GeboortedatumDateTimePicker.Value;
                deelnemer.Woonplaats = woonplaatsTextBox.Text;
                deelnemer.BadgeNummer = int.Parse(badgeNummerTexBox.Text);
                
                context.SaveChanges();
            }
        }
    }
}
