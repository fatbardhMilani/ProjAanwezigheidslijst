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
using System.Data.Entity;

namespace ProjAanwezigheidslijst
{
    public partial class BeheerAllesForm : Form
    {
        public BeheerAllesForm()
        {
            InitializeComponent();
        }

        public Deelnemers Deelnemer { get; private set; }
        public Docenten Docent { get; private set; }
        public Opleidingsinformatie OplInfo { get; private set; }
        public NietOpleidingsDagen NietOpleidingsDag { get; private set; }

        private void BeheerAllesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet1.Deelnemers' table. You can move, or remove it, as needed.
            this.deelnemersTableAdapter.Fill(this.aanwezigheidslijstDataSet1.Deelnemers);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.Tijdsregistraties' table. You can move, or remove it, as needed.
            this.tijdsregistratiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Tijdsregistraties);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.DocetenOpleidingens' table. You can move, or remove it, as needed.
            this.docetenOpleidingensTableAdapter.Fill(this.aanwezigheidslijstDataSet.DocetenOpleidingens);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.DeelnemersOpleidingens' table. You can move, or remove it, as needed.
            this.deelnemersOpleidingensTableAdapter.Fill(this.aanwezigheidslijstDataSet.DeelnemersOpleidingens);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.NietOpleidingsDagens' table. You can move, or remove it, as needed.
            this.nietOpleidingsDagensTableAdapter.Fill(this.aanwezigheidslijstDataSet.NietOpleidingsDagens);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.Opleidingsinformaties' table. You can move, or remove it, as needed.
            this.opleidingsinformatiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Opleidingsinformaties);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.Docentens' table. You can move, or remove it, as needed.
            this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.Docentens' table. You can move, or remove it, as needed.
            this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
            // TODO: This line of code loads data into the 'aanwezigheidslijstDataSet.Deelnemers' table. You can move, or remove it, as needed.
            this.deelnemersTableAdapter.Fill(this.aanwezigheidslijstDataSet.Deelnemers);
            using (var ctx = new AanwezigheidslijstContext())
            {
                var oplInfo = ctx.Opleidingsinformaties;

                foreach (var opl in oplInfo)
                {
                    dlnmrOplComB.Items.Add(opl);
                }
            }
            using (var ctx = new AanwezigheidslijstContext())
            {
                var zoekdlnmr = ctx.Deelnemers;
                foreach (var dlnmr in zoekdlnmr)
                {
                    comboBox1.Items.Add(dlnmr);
                }
            }
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void BeheerTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BeheerTabControl.SelectedIndex)
            {
                case 0:
                    this.deelnemersTableAdapter.Fill(this.aanwezigheidslijstDataSet.Deelnemers);
                    dlnmrOplComB.Items.Clear();
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var oplInfo = ctx.Opleidingsinformaties;

                        foreach (var opl in oplInfo)
                        {
                            dlnmrOplComB.Items.Add(opl);
                        }
                    }

                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var zoekdlnmr = ctx.Deelnemers;
                        foreach(var dlnmr in zoekdlnmr)
                        {
                            comboBox1.Items.Add(dlnmr);
                        }
                    }
                    
                    break;
                case 1:
                    this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
                    docOplComB.Items.Clear();
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var oplInfo = ctx.Opleidingsinformaties;

                        foreach (var opl in oplInfo)
                        {
                            docOplComB.Items.Add(opl);
                        }
                    }
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var zoekDoc = ctx.Docentens;
                        foreach (var doc in zoekDoc)
                        {
                            docZoekComB.Items.Add(doc);
                        }
                    }
                    docZoekComB.AutoCompleteMode = AutoCompleteMode.Suggest;
                    docZoekComB.AutoCompleteSource = AutoCompleteSource.ListItems;
                    break;
                case 2:
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var zoekOpl = ctx.Opleidingsinformaties;
                        foreach (var opl in zoekOpl)
                        {
                            oplInfoComB.Items.Add(opl);
                        }
                    }
                    oplInfoComB.AutoCompleteMode = AutoCompleteMode.Suggest;
                    oplInfoComB.AutoCompleteSource = AutoCompleteSource.ListItems;
                    this.opleidingsinformatiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Opleidingsinformaties);
                    break;
                case 3:
                    this.nietOpleidingsDagensTableAdapter.Fill(this.aanwezigheidslijstDataSet.NietOpleidingsDagens);
                    vakdagOplIdComB.Items.Clear();
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var oplId = ctx.Opleidingsinformaties;

                        foreach (var opl in oplId)
                        {
                            vakdagOplIdComB.Items.Add(opl);
                        }
                    }
                    break;
                case 4:
                    this.tijdsregistratiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Tijdsregistraties);
                    tijdsRegListBox.Items.Clear();
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
                            tijdsRegListBox.Items.Add(dn.Id + " " + dn.DateTime + " " + dn.Opleiding + " " + dn.Naam);
                        }
                    }
                    break;
            }
        }

        ////////DEELNEMER BEHEER///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateDeelnemerButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var dlnmrOp = dlnmrOplComB.SelectedItem as Opleidingsinformatie;
                var dlnmrOplId = dlnmrOp.Id;

                using (var ctx = new AanwezigheidslijstContext())
                {
                    Deelnemer = DeelnemerBeheer.ToevoegenDlnmr(ref dlnmrNaamTB, ref geboorteDatDtP, ref wnpltsTB, ref bdgNumTB);

                    var opl = ctx.Opleidingsinformaties.SingleOrDefault(a => a.Id == dlnmrOplId);
                    var deelnemerOpl = ctx.DeelnemersOpleidingens.Add(new DeelnemersOpleidingen
                    {
                        Deelnemer = Deelnemer,
                        Opleiding = opl,
                    });

                    ctx.SaveChanges();
                    MessageBox.Show("Deelnemer toegevoegd");

                    DeelnemerBeheer.ClearDlnmrInput(ref dlnmrNaamTB,ref geboorteDatDtP,ref wnpltsTB,ref bdgNumTB);
                    dlnmrOplComB.ResetText();
                    this.deelnemersTableAdapter.Fill(this.aanwezigheidslijstDataSet1.Deelnemers);
                }
            }
        }
        private void WijzigZoekButton_Click(object sender, EventArgs e)
        {
            dlnmrNaamTB.Enabled = true;
            geboorteDatDtP.Enabled = true;
            wnpltsTB.Enabled = true;
            bdgNumTB.Enabled = true;

            if (WijzigRadioB.Checked == true)
            {
                Deelnemers dl = comboBox1.SelectedItem as Deelnemers;

                using (var context = new AanwezigheidslijstContext())
                {
                    var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Id == dl.Id);

                    DeelnemerBeheer.UpdateZoekDlnmr(ref comboBox1, ref dlnmrNaamTB, ref geboorteDatDtP, ref wnpltsTB, ref bdgNumTB);
                }
            }
        }
        private void SaveChangeDeelnemerButton_Click(object sender, EventArgs e)
        {
            if (WijzigRadioB.Checked == true)
            {
                var dl = comboBox1.SelectedItem as Deelnemers;

                using (var context = new AanwezigheidslijstContext())
                {
                    var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == dl.Naam);
                    DeelnemerBeheer.WijzigenDlnmrSave(ref deelnemer, ref dlnmrNaamTB, ref geboorteDatDtP, ref wnpltsTB, ref bdgNumTB);

                    context.SaveChanges();
                    MessageBox.Show("Deelnemer gewijzigd");
                    DeelnemerBeheer.ClearDlnmrInput(ref dlnmrNaamTB, ref geboorteDatDtP, ref wnpltsTB, ref bdgNumTB);

                    wijzigNaamTextBox.Clear();
                    this.deelnemersTableAdapter.Fill(this.aanwezigheidslijstDataSet1.Deelnemers);
                }
            }
        }
        private void DeleteDeelnemerButton_Click(object sender, EventArgs e)
        {   
            string verwijderNaam = deleteDlnmrTB.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == verwijderNaam);
                context.Deelnemers.Remove(deelnemer);
                var opl = context.DeelnemersOpleidingens.Where(dlnmr => dlnmr.Deelnemer.Id == deelnemer.Id);
                foreach (var dlnmrOplId in opl)
                {
                    context.DeelnemersOpleidingens.Remove(dlnmrOplId);
                }
                context.SaveChanges();
                MessageBox.Show("Deelnemer verwijderd");
                wijzigNaamTextBox.Clear();
                this.deelnemersTableAdapter.Fill(this.aanwezigheidslijstDataSet1.Deelnemers);
            }
        }

        //////DEELNEMER VALIDATIE//////
        private void DlnmrNaamTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 0)
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

        private void GeboorteDatDtP_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 0)
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
        private void WnpltsTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 0)
            {
                var dlnmrErrors = new List<string>();

                if (wnpltsTB.Text.Length == 0)
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
        private void BdgNumTB_Validating(object sender, CancelEventArgs e)/////werkt niet////
        {
            if (BeheerTabControl.SelectedIndex == 0)
            {
                var dlnmrErrors = new List<string>();
                if (bdgNumTB.Text.Length == 0)
                {
                    dlnmrErrors.Add("Badge nummer veld mag niet leeg zijn");
                }
                else
                {
                    if (bdgNumTB.Text.Substring(0).All(c => char.IsLetter(c)))
                    {
                        dlnmrErrors.Add("Badge nummer veld mag enkel cijfers bevatten");
                    }
                }
                string errorMsg = "";
                if (errorMsg.Any())
                {
                    e.Cancel = true;
                    errorMsg = dlnmrErrors.Aggregate((a, b) => $"{a},\r\n{b}");
                }
                dlnmrErrorProvider.SetError((Control)sender, errorMsg);
            }
        }
        ////////DOCENTEN BEHEER///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateDocentButton_Click(object sender, EventArgs e)
        {
            var docOp = docOplComB.SelectedItem as Opleidingsinformatie;
            var docOpId = docOp.Id;

            using (var ctx = new AanwezigheidslijstContext())
            {

                Docent = DocentBeheer.DocToev( docNaamTB.Text,  docBedrijfTB.Text);

                var docO = ctx.Opleidingsinformaties.SingleOrDefault(o => o.Id == docOpId);
                var docOpl = ctx.DocetenOpleidingens.Add(new DocetenOpleidingen
                {
                    Docent = Docent,
                    Opleiding =docO
                });
                ctx.SaveChanges();
                MessageBox.Show("Docent toegevoegd");
                DocentBeheer.VrwdrDocInput(ref docNaamTB,ref docBedrijfTB);
                docOplComB.ResetText();
            }
            this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
        }
        private void WijzigDocButton_Click(object sender, EventArgs e)
        {
            docNaamTB.Enabled = true;
            docBedrijfTB.Enabled = true;

            Docenten zoekDoc = docZoekComB.SelectedItem as Docenten;

            using (var context = new AanwezigheidslijstContext())
            {
                var docent = context.Docentens.SingleOrDefault(doc => doc.Id == zoekDoc.Id);
                DocentBeheer.UpdateZoekDoc(ref docZoekComB ,ref docNaamTB, ref docBedrijfTB);
            }
            this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
        }
        private void SaveChangeDocButton_Click(object sender, EventArgs e)
        {
            Docenten zoekDocent = docZoekComB.SelectedItem as Docenten;


            using (var context = new AanwezigheidslijstContext())
            {
                var docent = context.Docentens.SingleOrDefault(doc => doc.Id == zoekDocent.Id);
                DocentBeheer.WijzigDocSave(ref docent, ref docNaamTB, ref docBedrijfTB);

                context.SaveChanges();
                MessageBox.Show("Docent gewijzigd");
                DocentBeheer.VrwdrDocInput(ref docNaamTB, ref docBedrijfTB);
                docZoekComB.ResetText();
            }
            this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
        }
        private void DeleteDocButton_Click(object sender, EventArgs e)
        {
            if (vrwdrDocRB.Checked== true)
            {
                string zoekDoc = vrwdrDocTB.Text;

                using (var context = new AanwezigheidslijstContext())
                {
                    var docent = context.Docentens.SingleOrDefault(doc => doc.Naam == zoekDoc);
                    context.Docentens.Remove(docent);
                    var docOpl = context.DocetenOpleidingens.Where(doc => doc.Docent.Id == docent.Id);

                    foreach (var docOp in docOpl)
                    {
                        context.DocetenOpleidingens.Remove(docOp);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Docent verwijderd");
                    vrwdrDocTB.Clear();
                }
                this.docentensTableAdapter.Fill(this.aanwezigheidslijstDataSet.Docentens);
            }
            
        }
        ////DOC VALIDATIE//////
        private void DocNaamTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 1)
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
        private void DocBedrijfTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 1)
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

        ////////OPLEIDINGINFO BEHEER///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateOpleidingsInfoButton_Click_1(object sender, EventArgs e)
        {
            OplInfo = OpleidingsInfoBeheer.OplInfoToev(oplInstTB.Text,oplTB.Text,cntcpTB.Text,oplPlTB.Text,refOplTB.Text,int.Parse(OeNumTB.Text),int.Parse(oplCdTB.Text),
                startDatDtP.Value.Date,eindDatDtP.Value.Date) ;
               
            MessageBox.Show("Opleidingsinformatie toegevoegd");

            OpleidingsInfoBeheer.VrwdrOplInfoInput(ref oplInstTB,ref oplTB,ref cntcpTB,ref oplPlTB,ref refOplTB,
                ref OeNumTB, ref oplCdTB, ref startDatDtP, ref eindDatDtP);

            this.opleidingsinformatiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Opleidingsinformaties);
        }
        private void WijzigOplInfobutton_Click(object sender, EventArgs e)
        {
            oplInstTB.Enabled = true;
            oplTB.Enabled = true;
            cntcpTB.Enabled = true;
            oplPlTB.Enabled = true;
            refOplTB.Enabled = true;
            OeNumTB.Enabled = true;
            oplCdTB.Enabled = true;
            startDatDtP.Enabled = true;
            eindDatDtP.Enabled = true;
            saveChangeOplInfoButton.Visible = true;

            OpleidingsInfoBeheer.OplInfoZoekUpdate(ref oplInfoComB,ref oplInstTB, ref oplTB,ref cntcpTB, ref oplPlTB, ref refOplTB,ref OeNumTB,ref oplCdTB,
                ref startDatDtP, ref eindDatDtP);
        }
        private void SaveChangeOplInfoButton_Click(object sender, EventArgs e)
        {
            OpleidingsInfoBeheer.WijzigenOplInfoSave(ref oplInfoComB, ref oplInstTB, ref oplTB, ref cntcpTB, ref oplPlTB, ref refOplTB, ref OeNumTB,
                ref oplCdTB, ref startDatDtP, ref eindDatDtP);
            MessageBox.Show("Opleidingsinformatie gewijzigd");

            OpleidingsInfoBeheer.VrwdrOplInfoInput(ref oplInstTB, ref oplTB, ref cntcpTB, ref oplPlTB, ref refOplTB, ref OeNumTB,
                ref oplCdTB, ref startDatDtP, ref eindDatDtP);
            oplInfoComB.ResetText();

            this.opleidingsinformatiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Opleidingsinformaties);
        }
        private void DeleteOplInfoButton_Click(object sender, EventArgs e)
        {
            OpleidingsInfoBeheer.DeleteOplInfo(ref oplInfoComB);
            MessageBox.Show("Opleidingsinformatie verwijderd");
            oplInfoComB.ResetText();

            this.opleidingsinformatiesTableAdapter.Fill(this.aanwezigheidslijstDataSet.Opleidingsinformaties);
        }
        //// OPLINFO VALIDATIES ////////
        private void OplInstTB_Validating(object sender, CancelEventArgs e)//ENKEL DIT WERKT REST NIET////////////////
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        private void OplTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        private void CntcpTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        private void OplPlTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        private void OeNumTB_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        private void StartDatDtP_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        private void EindDatDtP_Validating(object sender, CancelEventArgs e)
        {
            if (BeheerTabControl.SelectedIndex == 2)
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
        ////////NIETOPLDAG BEHEER///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateNietOplDagButton_Click(object sender, EventArgs e)
        {
            NietOpleidingsDag = NietOplDagBeheer.NietOplDagToev(ref vakDagDtP, ref vmdgCB, ref nmdgCB, ref vakdagOplIdComB);
            MessageBox.Show("Niet opleidingsdag toegevoegd");

            NietOplDagBeheer.VrwdrNietOplDInput(ref vakDagDtP, ref vmdgCB, ref nmdgCB, ref vakdagOplIdComB);

            this.nietOpleidingsDagensTableAdapter.Fill(this.aanwezigheidslijstDataSet.NietOpleidingsDagens);
        }

        private void WijzigVakDagZoekButton_Click(object sender, EventArgs e)
        {
            vakDagDtP.Enabled = true;
            vmdgCB.Enabled = true;
            nmdgCB.Enabled = true;
            vakdagOplIdComB.Enabled = true;
            saveChangeVakDagButton.Visible = true;
            
            //DateTime zoekVakDag = WijzigZoekdateTimePicker.Value.Date;

            //using (var context = new AanwezigheidslijstContext())
            //{
            //    var vakdag = context.NietOpleidingsDagens.SingleOrDefault(vd => vd.Datum == zoekVakDag);// Include gebruiken omdat we met klassen werken en daar de klasses meegeven// in namespace using.data.entity

            //    vakDagZoekDTP.Value = vakdag.Datum;
            //    vmdgCB.Checked = vakdag.Voormiddag;
            //    nmdgCB.Checked = vakdag.Namiddag;
            //}
            NietOplDagBeheer.NietOPlDagZoekUpdate(ref vakdagOplIdComB, ref vakDagDtP, ref vmdgCB, ref nmdgCB);

            using (var context = new AanwezigheidslijstContext())
            {
                var opl = context.Opleidingsinformaties;
                foreach (var op in opl)
                {
                    vakdagOplIdComB.Items.Add(op.Opleiding);
                }
            }
        }

        private void SaveChangeVakDagButton_Click(object sender, EventArgs e)
        {
            DateTime zoekVakDag = WijzigZoekdateTimePicker.Value.Date;          //OPLID veranderd niet maar wijzigd naam in OPLINFO BUG//////

            using (var context = new AanwezigheidslijstContext())
            {
                var vakDag = context.NietOpleidingsDagens.Include(x => x.Opleiding).SingleOrDefault(vd => vd.Datum == zoekVakDag);

                vakDag.Datum = vakDagDtP.Value;
                vakDag.Voormiddag = vmdgCB.Checked;
                vakDag.Namiddag = vmdgCB.Checked;
                vakDag.Opleiding.Opleiding = vakdagOplIdComB.Text;


                context.SaveChanges();
                MessageBox.Show("Deelnemer opleiding gewijzigd");
                WijzigZoekdateTimePicker.ResetText();
                vmdgCB.ResetText();
                nmdgCB.ResetText();
                vakdagOplIdComB.Items.Clear();
            }
            this.nietOpleidingsDagensTableAdapter.Fill(this.aanwezigheidslijstDataSet.NietOpleidingsDagens);
        }
        private void DeleteVakDagButton_Click(object sender, EventArgs e)
        {
            DateTime zoekVakDag = vakDagVrwdrDTP.Value.Date;       

            using(var ctx = new AanwezigheidslijstContext())
            {
                var vakDag = ctx.NietOpleidingsDagens.SingleOrDefault(vd => vd.Datum == zoekVakDag);
                ctx.NietOpleidingsDagens.Remove(vakDag);
                ctx.SaveChanges();
                MessageBox.Show("Niet opleidingsdag verwijdered");
                vakDagVrwdrDTP.ResetText();
            }
            this.nietOpleidingsDagensTableAdapter.Fill(this.aanwezigheidslijstDataSet.NietOpleidingsDagens);
        }
        ////////RADIOBUTTON CHECKS///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void WijzigRadioB_CheckedChanged(object sender, EventArgs e)
        {
            if (WijzigRadioB.Checked == true)
            {
                label21.Visible = true;
                wijzigNaamTextBox.Visible = true;
                WijzigZoekButton.Visible = true;
                ToevoegenGrpB.Text = WijzigRadioB.Text;
                saveChangeDeelnemerButton.Visible = true;

            }
            else if (WijzigRadioB.Checked == false)
            {
                label21.Visible = false;
                wijzigNaamTextBox.Visible = false;
                WijzigZoekButton.Visible = false;
                saveChangeDeelnemerButton.Visible = false;
            }
                   
        }
        private void ToevRadioB_CheckedChanged(object sender, EventArgs e)
        {
            if (ToevRadioB.Checked == true)
            {
                ToevoegenGrpB.Text = ToevRadioB.Text;
                dlnmrNaamTB.Enabled = true;
                geboorteDatDtP.Enabled = true;
                wnpltsTB.Enabled = true;
                bdgNumTB.Enabled = true;
                dlnmrOplComB.Enabled = true;
                createDeelnemerButton.Visible = true;
            }
            else if (ToevRadioB.Checked == false)
            {
                createDeelnemerButton.Visible = false;

                dlnmrNaamTB.Enabled = false;
                geboorteDatDtP.Enabled = false;
                wnpltsTB.Enabled = false;
                bdgNumTB.Enabled = false;
                dlnmrOplComB.Enabled = false;
            }
        }
        private void DeleteRadioB_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteRadioB.Checked == true)
            {
                dlnmrNaamTB.Enabled = false;
                geboorteDatDtP.Enabled = false;
                wnpltsTB.Enabled = false;
                bdgNumTB.Enabled = false;
                dlnmrOplComB.Enabled = false;

                ToevoegenGrpB.Text = DeleteRadioB.Text;
                deleteDlnmrTB.Visible = true;
                deleteDeelnemerButton.Visible = true;
                label56.Visible = true;
            }
            else if (DeleteRadioB.Checked == false)
            {
                deleteDlnmrTB.Visible = false;
                deleteDeelnemerButton.Visible = false;
                label56.Visible = false;
            }
        }
        ////DOC RB////
        private void ToevDocRB_CheckedChanged(object sender, EventArgs e)
        {
            if (toevDocRB.Checked== true)
            {
                docToevGrpB.Text = toevDocRB.Text;
                createDocentButton.Visible = true;

                docNaamTB.Enabled = true;
                docBedrijfTB.Enabled = true;
            }
            else if (toevDocRB.Checked == false)
            {
                createDocentButton.Visible = false;

                docNaamTB.Enabled = false;
                docBedrijfTB.Enabled = false;
                docOplComB.Enabled = false;
            }
        }
        private void WijzDocRB_CheckedChanged(object sender, EventArgs e)
        {
            if (wijzDocRB.Checked == true)
            {
                label27.Visible = true;
                wijzDocTB.Visible = true;
                wijzigDocButton.Visible = true;
                docToevGrpB.Text = wijzDocRB.Text;
                saveChangeDocButton.Visible = true;

            }
            else if (wijzDocRB.Checked == false)
            {
                label27.Visible = false;
                wijzDocTB.Visible = false;
                wijzigDocButton.Visible = false;
                saveChangeDocButton.Visible = false;
            }
        }
        private void VrwdrDocRB_CheckedChanged(object sender, EventArgs e)
        {
            if (vrwdrDocRB.Checked == true)
            {
                docToevGrpB.Text = vrwdrDocRB.Text;
                vrwdrDocTB.Visible = true;
                deleteDocButton.Visible = true;
                label10.Visible = true;
                docOplComB.Enabled = false;

            }
            else if (vrwdrDocRB.Checked == false)
            {
                vrwdrDocTB.Visible = false;
                deleteDocButton.Visible = false;
                label10.Visible = false;
            }
        }
        ////OPL RB////
        private void OplToevRB_CheckedChanged(object sender, EventArgs e)
        {
            if (oplToevRB.Checked == true)
            {
                toevOplInfoGrpB.Text = toevDocRB.Text;
                CreateOpleidingsInfoButton.Visible = true;

                oplInstTB.Enabled = true;
                oplTB.Enabled = true;
                cntcpTB.Enabled = true;
                oplPlTB.Enabled = true;
                refOplTB.Enabled = true;
                OeNumTB.Enabled = true;
                oplCdTB.Enabled = true;
                startDatDtP.Enabled = true;
                eindDatDtP.Enabled = true;
            }
            else if (oplToevRB.Checked == false)
            {
                oplInstTB.Enabled = false;
                oplTB.Enabled = false;
                cntcpTB.Enabled = false;
                oplPlTB.Enabled = false;
                refOplTB.Enabled = false;
                OeNumTB.Enabled = false;
                oplCdTB.Enabled = false;
                startDatDtP.Enabled = false;
                eindDatDtP.Enabled = false;
                CreateOpleidingsInfoButton.Visible = false;
            }
        }
        private void OplWijzRB_CheckedChanged(object sender, EventArgs e)
        {
            if (oplWijzRB.Checked == true)
            {
                toevOplInfoGrpB.Text = oplWijzRB.Text;
                label25.Visible = true;
                wijzigOplInfoTextBox.Visible = true;
                wijzigOplInfobutton.Visible = true;
                saveChangeOplInfoButton.Visible = true;
            }
            else if (oplWijzRB.Checked == false)
            {
                label25.Visible = false;
                wijzigOplInfoTextBox.Visible = false;
                wijzigOplInfobutton.Visible = false;
                saveChangeOplInfoButton.Visible = false;
            }
        }
        private void OplVrwdrRB_CheckedChanged(object sender, EventArgs e)
        {
            if (oplVrwdrRB.Checked == true)
            {
                label12.Visible = true;
                oplVrwdrTB.Visible = true;
                deleteOplInfoButton.Visible = true;
            }
            else if (oplVrwdrRB.Checked == false)
            {
                label12.Visible = false;
                oplVrwdrTB.Visible = false;
                deleteOplInfoButton.Visible = false;
            }
        }
        ////VAKDAG RB////
        private void VakDagToevRB_CheckedChanged(object sender, EventArgs e)
        {
            if (vakDagToevRB.Checked == true)
            {
                vakDagGrpB.Text = vakDagToevRB.Text;
                vakDagDtP.Enabled = true;
                vmdgCB.Enabled = true;
                nmdgCB.Enabled = true;
                vakdagOplIdComB.Enabled = true;
                createNietOplDagButton.Visible = true;
            }
            else if (vakDagToevRB.Checked == false)
            {
                
                vakDagDtP.Enabled = false;
                vmdgCB.Enabled = false;
                nmdgCB.Enabled = false;
                vakdagOplIdComB.Enabled = false;
                createNietOplDagButton.Visible = false;
            }
        }
        private void VakDagWijzRB_CheckedChanged(object sender, EventArgs e)
        {
            if (VakDagWijzRB.Checked == true)
            {
                vakDagGrpB.Text = VakDagWijzRB.Text;
                WijzigZoekdateTimePicker.Visible = true;
                label46.Visible = true;
                wijzigVakDagZoekButton.Visible = true;
                vakdagOplIdComB.Enabled = true;
                saveChangeVakDagButton.Visible = false;

            }
            else if (VakDagWijzRB.Checked == false)
            {
                saveChangeVakDagButton.Visible = false;
                WijzigZoekdateTimePicker.Visible = false;
                label46.Visible = false;
                wijzigVakDagZoekButton.Visible = false;
            }
        }
        
        private void VakDagVrwdrRB_CheckedChanged(object sender, EventArgs e)
        {
            if (vakDagVrwdrRB.Checked == true)
            {
                vakDagVrwdrDTP.Visible = true;
                deleteVakDagButton.Visible = true;
                label9.Visible = true;
            }
            else if (vakDagVrwdrRB.Checked == false)
            {
                vakDagVrwdrDTP.Visible = false;
                deleteVakDagButton.Visible = false;
                label9.Visible = false;
            }
        }
        ////////SEARCH OPTIONS///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataView dv = aanwezigheidslijstDataSet1.Deelnemers.DefaultView;
            dv.RowFilter = string.Format("Naam like '%{0}%'", searchTB.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
        private void DocZoekBT_Click(object sender, EventArgs e)
        {
            DataView dv = aanwezigheidslijstDataSet.Docentens.DefaultView;
            dv.RowFilter = string.Format("Naam like '%{0}%'", DocZoekTB.Text);
            dataGridView2.DataSource = dv.ToTable();
        }

        private void OplInfoZoekBT_Click(object sender, EventArgs e)
        {
            DataView dv = aanwezigheidslijstDataSet.Opleidingsinformaties.DefaultView;
            dv.RowFilter = string.Format("Opleiding like '%{0}%'", oplInfoZoekTB.Text);
            dataGridView3.DataSource = dv.ToTable();
        }

        private void RefOplTB_Validating(object sender, CancelEventArgs e)
        {

        }

        private void OplCdTB_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
