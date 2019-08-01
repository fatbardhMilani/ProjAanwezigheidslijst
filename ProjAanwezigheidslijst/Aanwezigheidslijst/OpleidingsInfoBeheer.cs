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
        public static void OplInfoComBFill(ref ComboBox oplNaam)
        {
            using (var ctx = new AanwezigheidslijstContext())
            {
                var oplInfo = ctx.Opleidingsinformaties;

                foreach (var opl in oplInfo)
                {
                    oplNaam.Items.Add(opl);
                }
            }
        }

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
            ref MaskedTextBox oeNmr, ref MaskedTextBox oplCd, ref DateTimePicker strtDat, ref DateTimePicker eindDat)
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
            ref MaskedTextBox oeNmr, ref MaskedTextBox oplCd, ref DateTimePicker strtDat, ref DateTimePicker eindDat)
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
        public static void DeleteOplInfo(ref TextBox vrwdrOplInfo)
        {
            var zoekOpl = vrwdrOplInfo.Text;

            using (var ctx = new AanwezigheidslijstContext())
            {
                var opl = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Opleiding == zoekOpl);
                ctx.Opleidingsinformaties.Remove(opl);

                var tijreg = ctx.Tijdsregistraties.Where(t => t.Id == opl.Id);
                var tijregOplId = ctx.Tijdsregistraties.Where(t => t.Opleiding.Id == opl.Id);


                var nietOpld = ctx.NietOpleidingsDagens.Where(n => n.Opleiding.Id == opl.Id);

                var dlnmrOpl = ctx.DeelnemersOpleidingens.Where(o => o.Opleiding.Id == opl.Id);
                var dlnmrIdOpl = ctx.DeelnemersOpleidingens.Where(o => o.Deelnemer.Id == opl.Id);
                var dlnmr = ctx.Deelnemers.Where(d => d.Id == opl.Id);

                var docOpl = ctx.DocetenOpleidingens.Where(o => o.Opleiding.Id == opl.Id);
                var docIdOpl = ctx.DocetenOpleidingens.Where(o => o.Docent.Id == opl.Id);
                var doc = ctx.Docentens.Where(d => d.Id == opl.Id);

                foreach (var item in tijreg)
                {
                    ctx.Tijdsregistraties.Remove(item);
                }
                foreach (var item in tijregOplId)
                {
                    ctx.Tijdsregistraties.Remove(item);
                }

                foreach (var item in nietOpld)
                {
                    ctx.NietOpleidingsDagens.Remove(item);
                }
                foreach (var item in dlnmr)
                {
                    ctx.Deelnemers.Remove(item);
                }
                foreach (var item in dlnmrOpl)
                {
                    ctx.DeelnemersOpleidingens.Remove(item);
                }
                foreach (var item in dlnmrIdOpl)
                {
                    ctx.DeelnemersOpleidingens.Remove(item);
                }
                foreach (var item in doc)
                {
                    ctx.Docentens.Remove(item);
                }
                foreach (var item in docOpl)
                {
                    ctx.DocetenOpleidingens.Remove(item);
                }
                foreach (var item in docIdOpl)
                {
                    ctx.DocetenOpleidingens.Remove(item);
                }
                ctx.SaveChanges();
            }
        }
        public static void VrwdrOplInfoInput(ref TextBox oplInst, ref TextBox opl, ref TextBox cntctPrsn, ref TextBox oplPlts, ref TextBox refOpl, 
            ref MaskedTextBox oeNmr, ref MaskedTextBox oplCd, ref DateTimePicker strtDat, ref DateTimePicker eindDat)
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
