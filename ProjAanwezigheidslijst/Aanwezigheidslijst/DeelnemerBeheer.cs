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
        public static Deelnemers ToevoegenDlnmr(ref TextBox naam, ref DateTimePicker geboorteDatum, ref TextBox woonplaats, ref TextBox badgeNmr)
        {
            var deelnemer = new Deelnemers()
            {
                Naam = naam.Text,
                GeboorteDatum = geboorteDatum.Value,
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
