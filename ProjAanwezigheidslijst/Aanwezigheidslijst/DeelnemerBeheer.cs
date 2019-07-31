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
        public static void DlnmrOplLBFill(ref ListBox naam)
        {
            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.DeelnemersOpleidingens.Select(dlnmr => new
                {
                    dlnmr.Deelnemer.Naam,
                    dlnmr.Opleiding.Opleiding,
                });
                foreach (var dn in deelnemer.OrderBy(x => x.Opleiding).ThenBy(x=>x.Naam))
                {
                    naam.Items.Add(dn.Opleiding + " - " + dn.Naam );
                }
            }
        }
        public static void VrwdrDeelnemer(ref TextBox naam)
        {
            string verwijderNaam = naam.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == verwijderNaam);
                context.Deelnemers.Remove(deelnemer);
                var opl = context.DeelnemersOpleidingens.Where(dlnmr => dlnmr.Deelnemer.Id == deelnemer.Id);
                foreach (var dlnmrOplId in opl)
                {
                    context.DeelnemersOpleidingens.Remove(dlnmrOplId);
                }
                var dlnrTijdreg = context.Tijdsregistraties.Where(d => d.Deelnemer.Id == deelnemer.Id);
                foreach (var item in dlnrTijdreg)
                {
                    context.Tijdsregistraties.Remove(item);
                }
                context.SaveChanges();
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
