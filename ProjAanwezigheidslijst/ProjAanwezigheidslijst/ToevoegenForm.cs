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

        private void ToevoegenForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateDocentButton_Click(object sender, EventArgs e)
        {
            
                if (naamDocentTexBox.Text != "" && bedrijfDocentTextBox.Text != "")
                {
                    using (var context = new AanwezigheidslijstContext())
                    {
                        var opleidingsInfo = context.Docentens.Add(new Docenten
                        {
                            Naam = naamDocentTexBox.Text,
                            Bedrijf = bedrijfDocentTextBox.Text,
                        });
                        context.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }

                }
                else
                {
                    MessageBox.Show("alle velden moeten ingevuld zijn");
                }
            
        }

        private void FillComboBox()
        {
            using (var context = new AanwezigheidslijstContext())
            {
                var oplId = context.Opleidingsinformaties.Select(opleiding => new { opleiding.Id, opleiding.Opleiding });

                foreach (var opl in oplId)
                {
                    //OplIdComboBox.ValueMember = opl.Id;
                    //OplIdComboBox.DisplayMember = opl.Opleiding;

                    OplIdComboBox.Items.Add(opl.Id );

                }
            }
        }

        private void CreateNietOplDagButton_Click(object sender, EventArgs e)
        {
            if (nietOplDagDateTimePicker.Text != null && OplIdComboBox.Text != "")
            {
                var opleidingId = OplIdComboBox.SelectedItem;

                using (var context = new AanwezigheidslijstContext())
                {
                    var opleiding = context.Opleidingsinformaties.SingleOrDefault(a => a.Id == (int)opleidingId);

                    var opleidingsInfo = context.NietOpleidingsDagens.Add(new NietOpleidingsDagen
                    {


                        Datum = nietOplDagDateTimePicker.Value.Date,
                        Voormiddag = voormiddagCheckBox.Checked,
                        Namiddag = namiddagCheckBox.Checked,
                        Opleiding = opleiding,

                    });
                    context.SaveChanges();
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
            if (naamTextBox.Text != "" && GeboortedatumDateTimePicker.Text != null && woonplaatsTextBox.Text != "" && badgeNummerTexBox.Text != "")
            {
                using (var context = new AanwezigheidslijstContext())
                {
                    var opleidingsInfo = context.Deelnemers.Add(new Deelnemers
                    {
                        Naam = naamTextBox.Text,
                        GeboorteDatum = GeboortedatumDateTimePicker.Value.Date,
                        Woonplaats = woonplaatsTextBox.Text,
                        BadgeNummer = int.Parse(badgeNummerTexBox.Text),

                    });
                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("alle velden moeten ingevuld zijn");
            }
        }

        private void CreateOpleidingsInfoButton_Click(object sender, EventArgs e)
        {

            if (opleidingsInstellingTextBox.Text != "" && opleidingTextBox.Text != "" && contactpersoonTextBox.Text != "" && OpleidingsplaatsTextBox.Text != ""
                && referentieOpleidingsTextBox.Text != "" && OeNummerTextBox.Text != "" && OpleidingsCodeTextBox.Text != "" && StartDateTimePicker.Text != "" && EindDateTimePicker2.Text != "")
            {

                string opleidingsInstelling = opleidingsInstellingTextBox.Text;
                string opleiding = opleidingTextBox.Text;
                string contactpersoon = contactpersoonTextBox.Text;
                string opleidingsplaats = OpleidingsplaatsTextBox.Text;
                string referentieOpleiding = referentieOpleidingsTextBox.Text;
                int oeNummer = int.Parse(OeNummerTextBox.Text);
                int opleidingsCode = int.Parse(OpleidingsCodeTextBox.Text);
                DateTime startDatum = StartDateTimePicker.Value.Date;
                DateTime eindDatum = EindDateTimePicker2.Value.Date;

                using (var context = new AanwezigheidslijstContext())
                {
                    var opleidingsInfo = context.Opleidingsinformaties.Add(new Opleidingsinformatie
                    {
                        Opleidingsinstelling = opleidingsInstelling,
                        Opleiding = opleiding,
                        Contactpersoon = contactpersoon,
                        Opleidingsplaats = opleidingsplaats,
                        ReferentieOpleidingsplaats = referentieOpleiding,
                        OeNummer = oeNummer,
                        Opleidingscode = opleidingsCode,
                        StartDatum = startDatum,
                        EindDatume = eindDatum
                    });
                    context.SaveChanges();
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("alle velden moeten ingevuld zijn");
            }
        }

        private void CreateDlnmrOplButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "") ///// OP OUDE MANIER KON JE ENKEL MET ID WERKEN!!////
            {
                var dn = comboBox2.SelectedItem as Deelnemers;
                var op = comboBox1.SelectedItem as Opleidingsinformatie;
                var opleidingNaam = op.Id;
                var deelnemerNaam = dn.Id;

                using (var context = new AanwezigheidslijstContext())
                {
                    var opleiding = context.Opleidingsinformaties.SingleOrDefault(a => a.Id == opleidingNaam);
                    var deelnemer = context.Deelnemers.SingleOrDefault(d => d.Id == deelnemerNaam);

                    var opleidingsInfo = context.DeelnemersOpleidingens.Add(new DeelnemersOpleidingen
                    {
                        Opleiding = opleiding,
                        Deelnemer = deelnemer,

                    });
                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("alle velden moeten ingevuld zijn");
            }
        }



        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 4:

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();

                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.Deelnemers;

                        foreach (var dn in deelnemer)
                        {
                            comboBox2.Items.Add(dn);
                        }
                    }
                    using (var ctx = new AanwezigheidslijstContext())
                    {
                        var opleiding = ctx.Opleidingsinformaties;

                        foreach (var opl in opleiding)
                        {
                            comboBox1.Items.Add(opl);
                        }

                    }

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

                    break;
            }
        }
    }
}
