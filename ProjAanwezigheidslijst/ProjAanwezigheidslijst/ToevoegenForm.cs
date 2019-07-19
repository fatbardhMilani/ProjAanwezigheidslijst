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
    public partial class ToevoegenForm : Form
    {
        public ToevoegenForm()
        {
            InitializeComponent();
            FillComboBox();
        }
        private void CreateDocentButton_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                using (var ctx = new AanwezigheidslijstContext())
                {
                    var doc = ctx.Docentens.Add(new Docenten
                    {
                        Naam = docNaamTB.Text,
                        Bedrijf = docBedrijfTB.Text,
                    });
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void FillComboBox()
        {
            using (var ctx = new AanwezigheidslijstContext())
            {
                var oplId = ctx.Opleidingsinformaties.Select(opl => new { opl.Id, opl.Opleiding });

                foreach (var opl in oplId)
                {
                    //OplIdComboBox.ValueMember = opl.Id;
                    //OplIdComboBox.DisplayMember = opl.Opleiding;

                    vakdagOplIdComB.Items.Add(opl.Id );
                }
            }
        }

        private void CreateNietOplDagButton_Click(object sender, EventArgs e)
        {
            if (vakDagDtP.Text != null && vakdagOplIdComB.Text != "")
            {
                var oplId = vakdagOplIdComB.SelectedItem;

                using (var ctx = new AanwezigheidslijstContext())
                {
                    var opl = ctx.Opleidingsinformaties.SingleOrDefault(a => a.Id == (int)oplId);

                    var nietoplDg = ctx.NietOpleidingsDagens.Add(new NietOpleidingsDagen
                    {
                        Datum = vakDagDtP.Value.Date,
                        Voormiddag = vmdgCB.Checked,
                        Namiddag = nmdgCB.Checked,
                        Opleiding = opl,
                    });
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("alle velden moeten ingevuld zijn");
            }
        }

        private void CreateDeelnemerButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                using (var ctx = new AanwezigheidslijstContext())
                {
                    var dlnmr = ctx.Deelnemers.Add(new Deelnemers
                    {
                        Naam = dlnmrNaamTB.Text,
                        GeboorteDatum = geboorteDatDtP.Value.Date,
                        Woonplaats = wnpltsTB.Text,
                        BadgeNummer = int.Parse(bdgNumTB.Text),
                    });
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private void CreateOpleidingsInfoButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                using (var ctx = new AanwezigheidslijstContext())
                {
                    var oplInfo = ctx.Opleidingsinformaties.Add(new Opleidingsinformatie
                    {
                        Opleidingsinstelling = oplInstTB.Text,
                        Opleiding = oplTB.Text,
                        Contactpersoon = cntcpTB.Text,
                        Opleidingsplaats = oplPlTB.Text,
                        ReferentieOpleidingsplaats = refOplTB.Text,
                        OeNummer = int.Parse(OeNumTB.Text),
                        Opleidingscode = int.Parse(oplCdTB.Text),
                        StartDatum = startDatDtP.Value.Date,
                        EindDatume = eindDatDtP.Value.Date
                    });
                    ctx.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void DocOplCreateButton_Click(object sender, EventArgs e)
        {
            var docNaam = docNaamComB.SelectedItem as Docenten;
            var docOpl = docOplComB.SelectedItem as Opleidingsinformatie;
            var docId = docNaam.Id;
            var docOplId = docOpl.Id;

            using(var ctx = new AanwezigheidslijstContext())
            {
                var doc = ctx.Docentens.SingleOrDefault(d => d.Id == docId);
                var opl = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Id == docOplId);

                var docOplToev = ctx.DocetenOpleidingens.Add(new DocetenOpleidingen
                {
                    Docent =doc,
                    Opleiding = opl,
                });
                ctx.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void CreateDlnmrOplButton_Click(object sender, EventArgs e)
        {
             ///// OP OUDE MANIER KON JE ENKEL MET ID WERKEN!!////
            
            var dn = dlnmrOplNaamComB.SelectedItem as Deelnemers;
            var op = dlnmrOplOplComB.SelectedItem as Opleidingsinformatie;
            var oplId = op.Id;
            var dlnmrId = dn.Id;

            using (var ctx = new AanwezigheidslijstContext())
            {
                var opl = ctx.Opleidingsinformaties.SingleOrDefault(a => a.Id == oplId);
                var dlnmr = ctx.Deelnemers.SingleOrDefault(d => d.Id == dlnmrId);

                var dlnmrOpl = ctx.DeelnemersOpleidingens.Add(new DeelnemersOpleidingen
                {
                    Opleiding = opl,
                    Deelnemer = dlnmr,
                });
                ctx.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 4:

                    dlnmrOplOplComB.Items.Clear();
                    dlnmrOplNaamComB.Items.Clear();

                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var dlnmr = ctx.Deelnemers;

                        foreach (var dn in dlnmr)
                        {
                            dlnmrOplNaamComB.Items.Add(dn);
                        }
                    }
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var oplInfo = ctx.Opleidingsinformaties;

                        foreach (var opl in oplInfo)
                        {
                            dlnmrOplOplComB.Items.Add(opl);
                        }

                    }
                    break;
                //dlnmrOplListBox.Items.Clear(); ///////OUDE MANIER VAN TONEN HIERBOVEN VEEL KORTER EN MAKKELIJKER WERKEN VIA NAAM EN ID ACHTERLIGGGEND

                //using (var context = new AanwezigheidslijstContext())
                //{
                //    var deelnemer = context.DeelnemersOpleidingens.Select(dlnmr => new
                //    {
                //        dlnmr.Id,
                //        dlnmr.Deelnemer.Naam,
                //        dlnmr.Opleiding.Opleiding,

                //    });

                //    foreach (var dn in deelnemer)
                //    {
                //        dlnmrOplListBox.Items.Add(dn.Id + " " + dn.Naam + " " + dn.Opleiding);
                //    }
                //}
                case 5:
                    docNaamComB.Items.Clear();
                    docOplComB.Items.Clear();
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var doc = ctx.Docentens;
                        foreach (var dc in doc)
                        {
                            docNaamComB.Items.Add(dc);
                        }
                    }
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var opl = ctx.Opleidingsinformaties;
                        foreach (var ol in opl)
                        {
                            docOplComB.Items.Add(ol);
                        }
                    }
                    break;
            }
        }
        ////////////VALIDATIE OPLINFO/////////////////
        private void EindDatDtP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var eindDgeErrors = new List<string>();
                //if (eindDatDtP.Value == "")
                //{
                //    eindDgeErrors.Add("eind datum kan niet leeg zijn");
                //}
                //else
                //{
                    if (eindDatDtP.Value < startDatDtP.Value)
                    {
                        eindDgeErrors.Add("eind datum kan niet kleiner dan start datum zijn");
                    }
                //}
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = eindDgeErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }

        }
        private void StartDatDtP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var strtDgErrors = new List<string>();

                //if (startDatDtP.Value == null)
                //{
                //    strtDgErrors.Add("Start datum mag niet leeg zijn");
                //}
                //else
                //{
                    if (startDatDtP.Value < DateTime.Now.Date)
                    {
                        strtDgErrors.Add("Start dag kan niet in het verleden liggen");
                    }
                //}
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = strtDgErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }

        }
        private void OeNumTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var oeNumErrors = new List<string>();
                if (OeNumTB.Text.Length == 0)
                {
                    oeNumErrors.Add("Oe-nummer veld mag niet leeg zijn");
                }
                else
                {
                    if (OeNumTB.Text.Substring(0).All(c => char.IsLetter(c)))
                    {
                        oeNumErrors.Add("Oe-nummer veld mag enkel cijfers bevatten");
                    }
                }
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = oeNumErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }

        }
        private void OplPlTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var oplPltsErrors = new List<string>();
                if (oplPlTB.Text.Length == 0)
                {
                    oplPltsErrors.Add("Opleidingsplaats veld mag niet leeg zijn");
                }
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = oplPltsErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }

        }
        private void CntcpTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var CntctPErrors = new List<string>();

                if (cntcpTB.Text.Length == 0)
                {
                    CntctPErrors.Add("Contactpersoon veld mag niet leeg zijn");
                }
                else
                {
                    if (!cntcpTB.Text.Substring(0).All(c => char.IsLetter(c)))
                    {
                        CntctPErrors.Add("Contactpersoon mag enkel letters bevatten");
                    }
                }
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = CntctPErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }

        }
        private void OplTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var oplErrors = new List<string>();

                if (oplTB.Text.Length == 0)
                {
                    oplErrors.Add("Opleiding veld mag niet leeg zijn");
                }
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = oplErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }

        }
        private void OplInstTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex ==0)
            {
                var oplInstErrors = new List<string>();

                if (oplInstTB.Text.Length == 0)
                {
                    oplInstErrors.Add("Opleidings Instelling veld mag niet leeg zijn");
                }
                string errorMsg = "";
                if (oplInstErrors.Any())
                {
                    e.Cancel = true;
                    errorMsg = oplInstErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                oplInfoErrorProvider.SetError((Control)sender, errorMsg);
            }
            
        }
        ////////////VALIDATIES DOCENT////////////////
        private void DocNaamTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex ==3)
            {
                var docErrors = new List<string>();
                if (docNaamTB.Text.Length == 0)
                {
                    docErrors.Add("Naamveld mag niet leeg zijn");
                }
                else
                {
                    if (docNaamTB.Text.Length < 2)
                    {
                        docErrors.Add("Naam moet minstens 2 letters bevatten");
                    }
                    if (!char.IsUpper(docNaamTB.Text[0]))
                    {
                        docErrors.Add("Naam moet met hoofdletter beginnen");
                    }
                    if (!docNaamTB.Text.Substring(0).All(c => char.IsLetter(c)))
                    {
                        docErrors.Add("Naam mag enkel letters bevatten");
                    }
                    if (!docNaamTB.Text.Substring(1).All(c => char.IsLower(c)))
                    {
                        docErrors.Add("Enkel de eerste letter van naam mag een hoofdletter zijn");
                    }

                }

                string errorMsg = "";

                if (docErrors.Any())
                {
                    e.Cancel = true;
                    errorMsg = docErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                DocErrorProvider.SetError((Control)sender, errorMsg);
            }
        }

        private void DocBedrijfTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex==3)
            {
                var docErrors = new List<string>();

                if (docBedrijfTB.Text.Length == 0)
                {
                    docErrors.Add("Bedrijfveld mag niet leeg zijn");
                }
                string errorMsg = "";
                if (docErrors.Any())
                {
                    e.Cancel = true;
                    errorMsg = docErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                DocErrorProvider.SetError((Control)sender, errorMsg);
            }
        }

        ///////////VALIDATIE DEELNEMERS////////////

        private void DlnmrNaamTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                var dlnmrErrors = new List<string>();

                if (dlnmrNaamTB.Text.Length == 0)
                {
                    dlnmrErrors.Add("Naam veld mag niet leeg zijn");
                }
                else
                {
                    if (dlnmrNaamTB.Text.Length < 2)
                    {
                        dlnmrErrors.Add("Naam moet minstens 2 letters bevatten");
                    }
                    if (!char.IsUpper(dlnmrNaamTB.Text[0]))
                    {
                        dlnmrErrors.Add("Naam moet met hoofdletter beginnen");
                    }
                    if (!dlnmrNaamTB.Text.Substring(0).All(c => char.IsLetter(c)))
                    {
                        dlnmrErrors.Add("Naam mag enkel letters bevatten");
                    }
                    if (!dlnmrNaamTB.Text.Substring(1).All(c => char.IsLower(c)))
                    {
                        dlnmrErrors.Add("Enkel de eerste letter van naam mag een hoofdletter zijn");
                    }
                }
                string errorMsg = "";
                if (dlnmrErrors.Any())
                {
                    e.Cancel = true;
                    errorMsg = dlnmrErrors.Aggregate((a, b) => $"{a}\r\n{b}");
                }
                dlnmrErrorProvider.SetError((Control)sender, errorMsg);
            }

        }

        private void GeboorteDatDtP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                var dlnmrErrors = new List<string>();

                if (geboorteDatDtP.Value >= DateTime.Now.Date)
                {
                    dlnmrErrors.Add("Geboorte datum moet in het verleden liggen");
                }

                string errorMsg = "";
                if (dlnmrErrors.Any())
                {
                    e.Cancel = true;
                    errorMsg = dlnmrErrors.Aggregate((a, b) => $"{a}\r\n{b}");
                }
                dlnmrErrorProvider.SetError((Control)sender, errorMsg);
            }
        }

        private void WnpltsTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                var dlnmrErrors = new List<string>();

                if (dlnmrNaamTB.Text.Length == 0)
                {
                    dlnmrErrors.Add("Woonplaats mag niet leeg zijn");
                }
                string errorMsg = "";
                if (dlnmrErrors.Any())
                {
                    e.Cancel = true;
                    errorMsg = dlnmrErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                dlnmrErrorProvider.SetError((Control)sender, errorMsg);
            }
        }
        private void BdgNumTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                var bdgnumErrors = new List<string>();
                if (bdgNumTB.Text.Length == 0)
                {
                    bdgnumErrors.Add("Oe-nummer veld mag niet leeg zijn");
                }
                else
                {
                    if (bdgNumTB.Text.Substring(0).All(c => char.IsLetter(c)))
                    {
                        bdgnumErrors.Add("Oe-nummer veld mag enkel cijfers bevatten");
                    }
                }
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = bdgnumErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                dlnmrErrorProvider.SetError((Control)sender, errorMsg);
            }
        }

        
    }
}
