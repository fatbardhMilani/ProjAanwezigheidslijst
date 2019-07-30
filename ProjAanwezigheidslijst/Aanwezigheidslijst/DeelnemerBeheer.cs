using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aanwezigheidslijst
{
    public class DeelnemerBeheer
    {
        public static void DlnmrWnplTBVal(ref TextBox woonplaatst)
        {

        }
        public static void DlnmrGebrtDTPVal(ref DateTimePicker gebrteDat)
        {
            if (gebrteDat.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Geboorte datum moet in het verleden liggen");
            }
        }
        public static void DlnmrNaamTBVal(ref TextBox naam)
        {
            if (naam.Text.Length == 0)
            {
                MessageBox.Show("Naam veld mag niet leeg zijn");
            }
            else
            {
                if (naam.Text.Length < 2)
                {
                    MessageBox.Show("Naam moet minstens 2 letters bevatten");
                }
                if (!char.IsUpper(naam.Text[0]))
                {
                    MessageBox.Show("Naam moet met hoofdletter beginnen");
                }
                if (!naam.Text.Substring(0).All(c => char.IsLetter(c)))
                {
                    MessageBox.Show("Naam mag enkel letters bevatten");
                }
                if (!naam.Text.Substring(1).All(c => char.IsLower(c)))
                {
                    MessageBox.Show("Enkel de eerste letter van naam mag een hoofdletter zijn");
                }
            }
        }
        public static void DlnmrZoekComBUpdate(ref ComboBox naam)
        {
            using (var ctx = new AanwezigheidslijstContext())
            {
                var zoekdlnmr = ctx.Deelnemers;
                foreach (var dlnmr in zoekdlnmr)
                {
                    naam.Items.Add(dlnmr);
                }
            }
        }
        public static Deelnemers ToevoegenDlnmr(ref TextBox naam, ref DateTimePicker geboorteDatum, ref TextBox woonplaats, ref TextBox badgeNmr)
        {
            var deelnemer = new Deelnemers()
            {
                Naam = naam.Text,
                GeboorteDatum = geboorteDatum.Value.Date,
                Woonplaats = woonplaats.Text,
                BadgeNummer = int.Parse(badgeNmr.Text),
            };
            return deelnemer;
        }
        public static void UpdateZoekDlnmr(ref ComboBox zoekComB, ref TextBox naam, ref DateTimePicker geboorteDatum, ref TextBox woonplaats, ref TextBox badgeNmr)
        {
            var dlnmrComB = zoekComB.SelectedItem as Deelnemers;
            naam.Text = dlnmrComB.Naam;
            geboorteDatum.Value = dlnmrComB.GeboorteDatum;
            woonplaats.Text = dlnmrComB.Woonplaats;
            badgeNmr.Text = dlnmrComB.BadgeNummer.ToString();
        }
        public static void WijzigenDlnmrSave(ref Deelnemers deelnemer,ref TextBox naam, ref DateTimePicker geboorteDatum, ref TextBox woonplaats, ref TextBox badgeNmr)
        {

            deelnemer.Naam = naam.Text;
            deelnemer.GeboorteDatum = geboorteDatum.Value.Date;
            deelnemer.Woonplaats = woonplaats.Text;
            deelnemer.BadgeNummer= int.Parse(badgeNmr.Text);

        }
        public static void ClearDlnmrInput(ref TextBox naam, ref DateTimePicker geboorteDatum, ref TextBox woonplaats, ref TextBox badgeNmr)
        {
            naam.Clear();
            geboorteDatum.ResetText();
            woonplaats.Clear();
            badgeNmr.Clear();
        }
    }
}
