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
                //int intOeNummer = int.Parse(oeNummer);
                int opleidingsCode = int.Parse(OpleidingsCodeTextBox.Text);
                //int intOpleidingsCode = int.Parse(opleidingsCode);
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
    }
}
