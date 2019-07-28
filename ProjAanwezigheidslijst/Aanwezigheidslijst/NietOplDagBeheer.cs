using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aanwezigheidslijst
{
    public class NietOplDagBeheer
    {
        public static NietOpleidingsDagen NietOplDagToev(ref DateTimePicker datum, ref CheckBox vrmdg, ref CheckBox nmdg, ref ComboBox opleiding)
        {
            var oplI = opleiding.SelectedItem as Opleidingsinformatie;
            using (var ctx = new AanwezigheidslijstContext())
            {
                var oplId = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Id == oplI.Id);
                var nietOplD = ctx.NietOpleidingsDagens.Add(new NietOpleidingsDagen
                {
                    Datum = datum.Value.Date,
                    Voormiddag = vrmdg.Checked,
                    Namiddag = nmdg.Checked,
                    Opleiding = oplId
                }) ;
                ctx.SaveChanges();
                return nietOplD;
            }
        }
        public static void NietOPlDagZoekUpdate(ref ComboBox zoekDag, ref DateTimePicker datum, ref CheckBox vrmdg, ref CheckBox nmdg)
        {
            //var zoekD = zoekDag.SelectedItem as NietOpleidingsDagen;
            //using (var ctx = new AanwezigheidslijstContext())
            //{
            //    var zoekOplDag = ctx.NietOpleidingsDagens.Include(x => x.Opleiding).SingleOrDefault(o => o.Id == zoekD.Id);

            //    datum.Text = zoekD.Datum.ToString();
            //    vrmdg.Checked = zoekD.Voormiddag;
            //    nmdg.Checked = zoekD.Namiddag;
            //}
        }
        public static void VrwdrNietOplDInput(ref DateTimePicker datum, ref CheckBox vrmdg, ref CheckBox nmdg, ref ComboBox opleiding)
        {
            datum.ResetText();
            vrmdg.ResetText();
            nmdg.ResetText();
            opleiding.ResetText();
        }
    }
}
