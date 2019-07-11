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
    public partial class CreateOpleidingsInfo : Form
    {
        public CreateOpleidingsInfo()
        {
            InitializeComponent();
        }

        private void CreateOpleidingsInfoButton_Click(object sender, EventArgs e)
        {

            if (opleidingsInstellingTextBox.Text != "" && opleidingTextBox.Text !=""  && contactpersoonTextBox.Text != "" && OpleidingsplaatsTextBox.Text != "" 
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
