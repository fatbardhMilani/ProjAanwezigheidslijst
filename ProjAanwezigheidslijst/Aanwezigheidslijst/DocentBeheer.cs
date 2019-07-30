using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aanwezigheidslijst
{
    public class DocentBeheer
    {
        public static void DocNaamComBFill(ref ComboBox naam)
        {
            using (var ctx = new AanwezigheidslijstContext())
            {
                var zoekDoc = ctx.Docentens;
                foreach (var doc in zoekDoc)
                {
                    naam.Items.Add(doc);
                }
            }
        }
        public static Docenten DocToev(string naam, string bedrijf)
        {
            var docent = new Docenten()
            {
                Naam = naam,
                Bedrijf = bedrijf,
            };
            return docent;
        }
        public static void UpdateZoekDoc (ref ComboBox zoekDocent, ref TextBox naam, ref TextBox bedrijf)
        {
            var zoekDoc = zoekDocent.SelectedItem as Docenten;
            naam.Text = zoekDoc.Naam;
            bedrijf.Text = zoekDoc.Bedrijf;
        }

        public static void WijzigDocSave(ref Docenten docent, ref TextBox naam, ref TextBox bedrijf)
        {
            docent.Naam = naam.Text;
            docent.Bedrijf = bedrijf.Text;
        }
        public static void VrwdrDocInput(ref TextBox naam, ref TextBox bedrijf)
        {
            naam.Clear();
            bedrijf.Clear();
        }
        
    }
}
