using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aanwezigheidslijst
{
    public class OpleidingsInfoBeheer
    {
        public static Opleidingsinformatie OplInfoToev(string oplInst, string opl, string cntctPrsn, string oplPlts, string refOpl, int oeNmr, int oplCd, DateTime strtDat, DateTime eindDat )
        {
            using (var ctx = new AanwezigheidslijstContext())
            {
                var oplInfoT = ctx.Opleidingsinformaties.Add(new Opleidingsinformatie
                {
                    Opleidingsinstelling = oplInst,
                    Opleiding = opl,
                    Contactpersoon = cntctPrsn,
                    Opleidingsplaats = oplPlts,
                    ReferentieOpleidingsplaats = refOpl,
                    OeNummer = oeNmr,
                    Opleidingscode = oplCd,
                    StartDatum = strtDat,
                    EindDatume = eindDat,
                });
                ctx.SaveChanges();
                return oplInfoT;
            }
        }

        public static void OplInfoZoekUpdate(ref ComboBox zoekOplInfo, ref TextBox oplInst, ref TextBox opl, ref TextBox cntctPrsn, ref TextBox oplPlts, ref TextBox refOpl,
            ref TextBox oeNmr, ref TextBox oplCd, ref DateTimePicker strtDat, ref DateTimePicker eindDat)
        {
            var zoekOplI = zoekOplInfo.SelectedItem as Opleidingsinformatie;

            using (var ctx = new AanwezigheidslijstContext())
            {
                var opleindingInfo = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Id == zoekOplI.Id);
                oplInst.Text = zoekOplI.Opleidingsinstelling;
                opl.Text = zoekOplI.Opleiding;
                cntctPrsn.Text = zoekOplI.Contactpersoon;
                oplPlts.Text = zoekOplI.Opleidingsplaats;
                refOpl.Text = zoekOplI.ReferentieOpleidingsplaats;
                oeNmr.Text = zoekOplI.OeNummer.ToString();
                oplCd.Text = zoekOplI.Opleidingscode.ToString();
                strtDat.Value = zoekOplI.StartDatum.Date;
                eindDat.Value = zoekOplI.EindDatume.Date;
            }
        }
        public static void WijzigenOplInfoSave(ref ComboBox zoekOplInfo, ref TextBox oplInst, ref TextBox opl, ref TextBox cntctPrsn, ref TextBox oplPlts, ref TextBox refOpl,
            ref TextBox oeNmr, ref TextBox oplCd, ref DateTimePicker strtDat, ref DateTimePicker eindDat)
        {
            var zoekOplId = zoekOplInfo.SelectedItem as Opleidingsinformatie;

            using (var ctx = new AanwezigheidslijstContext())
            {
                var oplInfo = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Id == zoekOplId.Id);

                oplInfo.Opleidingsinstelling = oplInst.Text;
                oplInfo.Opleiding = opl.Text;
                oplInfo.Contactpersoon = cntctPrsn.Text;
                oplInfo.Opleidingsplaats = oplPlts.Text;
                oplInfo.ReferentieOpleidingsplaats = refOpl.Text;
                oplInfo.OeNummer = int.Parse(oeNmr.Text);
                oplInfo.Opleidingscode = int.Parse(oplCd.Text);
                oplInfo.StartDatum = strtDat.Value.Date;
                oplInfo.EindDatume = eindDat.Value.Date;

                ctx.SaveChanges();
            };
        }
        public static void DeleteOplInfo(ref ComboBox vrwdrOplInfo)
        {
            var zoekOpl = vrwdrOplInfo.SelectedItem as Opleidingsinformatie;

            using (var ctx = new AanwezigheidslijstContext())
            {
                var opl = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Id == zoekOpl.Id);
                ctx.Opleidingsinformaties.Remove(opl);
                ctx.SaveChanges();
            }
        }
        public static void VrwdrOplInfoInput(ref TextBox oplInst, ref TextBox opl, ref TextBox cntctPrsn, ref TextBox oplPlts, ref TextBox refOpl, 
            ref TextBox oeNmr, ref TextBox oplCd, ref DateTimePicker strtDat, ref DateTimePicker eindDat)
        {
            oplInst.Clear();
            opl.Clear();
            cntctPrsn.Clear();
            oplPlts.Clear();
            refOpl.Clear();
            oeNmr.Clear();
            oplCd.Clear();
            strtDat.ResetText();
            eindDat.ResetText();
        }
    }
}
