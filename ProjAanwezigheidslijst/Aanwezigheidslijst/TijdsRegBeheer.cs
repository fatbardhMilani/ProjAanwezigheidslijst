using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aanwezigheidslijst
{
    public class TijdsRegBeheer
    {
        public static void TijdRegLBFill(ref ListBox tijdReg)
        {
            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Tijdsregistraties.Select(dlnmr => new
                {
                    dlnmr.Id,
                    dlnmr.DateTime,
                    dlnmr.Opleiding.Opleiding,
                    dlnmr.Deelnemer.Naam,
                });
                foreach (var dn in deelnemer)
                {
                    tijdReg.Items.Add(dn.Id + " " + dn.DateTime + " " + dn.Opleiding + " " + dn.Naam);
                }
            }
        }
    }
}
