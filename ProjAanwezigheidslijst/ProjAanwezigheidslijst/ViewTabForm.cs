﻿using System;
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
    public partial class ViewTabForm : Form
    {
        public ViewTabForm()
        {
            InitializeComponent();
        }

        private void ViewTabForm_Load(object sender, EventArgs e)
        {
            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.Select(dlnmr => new {
                    dlnmr.Id,
                    dlnmr.Naam,
                    dlnmr.GeboorteDatum,
                    dlnmr.Woonplaats,
                    dlnmr.BadgeNummer
                });

                foreach (var dn in deelnemer)
                {
                    dlnmrListBox.Items.Add(dn.Naam + " " + dn.GeboorteDatum + " " + dn.Woonplaats + " " + dn.BadgeNummer);
                }
            }
        }

        private void ZoekButton_Click(object sender, EventArgs e)
        {
            string zoekNaam = naamZoekTextBox.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == zoekNaam);
                if (deelnemer != null)
                {
                    ZoekListBox.Items.Add(deelnemer.Id + " " + deelnemer.Naam + " " + deelnemer.GeboorteDatum + " " + deelnemer.Woonplaats + " " + deelnemer.BadgeNummer);
                }
                else
                {
                    MessageBox.Show("Geen resultaat gevonden");
                }
            }
        }
        private void Control1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Control1.SelectedIndex)
            {
                case 0:
                    
                    dlnmrListBox.Items.Clear();
                    
                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.Deelnemers.Select(dlnmr => new
                        {
                            dlnmr.Id,
                            dlnmr.Naam,
                            dlnmr.GeboorteDatum,
                            dlnmr.Woonplaats,
                            dlnmr.BadgeNummer
                        });

                        foreach (var dn in deelnemer)
                        {
                            dlnmrListBox.Items.Add(dn.Naam + " " + dn.GeboorteDatum + " " + dn.Woonplaats + " " + dn.BadgeNummer);
                        }
                    }
                    break;

                case 1:

                    dlnmrOplListBox.Items.Clear();

                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.DeelnemersOpleidingens.Select(dlnmr => new
                        {
                            dlnmr.Deelnemer.Naam,
                            dlnmr.Opleiding.Opleiding,
                            dlnmr.Id,
                        });

                        foreach (var dn in deelnemer)
                        {
                            dlnmrOplListBox.Items.Add(dn.Id + " " + dn.Naam + " " + dn.Opleiding);
                        }
                    }
                    break;

                case 2:

                    vakDagListBox.Items.Clear();

                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.NietOpleidingsDagens.Select(dlnmr => new
                        {
                            dlnmr.Id,
                            dlnmr.Datum,
                            dlnmr.Voormiddag,
                            dlnmr.Namiddag,
                            dlnmr.Opleiding.Opleiding

                        });

                        foreach (var dn in deelnemer)
                        {
                            vakDagListBox.Items.Add(dn.Id + " " + dn.Datum + " " + dn.Voormiddag+" "+dn.Namiddag+" "+dn.Opleiding);
                        }
                    }
                    break;

                case 3:

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

                case 4:

                    oplInfoListBox.Items.Clear();

                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.Opleidingsinformaties.Select(dlnmr => new
                        {
                            dlnmr.Id,
                            dlnmr.Opleidingsinstelling,
                            dlnmr.Opleiding,
                            dlnmr.Opleidingsplaats,
                            dlnmr.ReferentieOpleidingsplaats,
                            dlnmr.OeNummer,
                            dlnmr.Opleidingscode,
                            dlnmr.StartDatum,
                            dlnmr.EindDatume
                        });

                        foreach (var dn in deelnemer)
                        {
                            oplInfoListBox.Items.Add(dn.Id + " " + dn.Opleidingsinstelling + " " + dn.Opleiding + " " + dn.Opleidingsplaats+" "+
                                dn.ReferentieOpleidingsplaats + " " + dn.OeNummer + " " + dn.Opleidingscode + " " + dn.StartDatum+" "+dn.EindDatume);
                        }
                    }
                    break;

                case 5:

                    docOplListBox.Items.Clear();

                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.DocetenOpleidingens.Select(dlnmr => new {
                            dlnmr.Id,
                            dlnmr.Docent.Naam,
                            dlnmr.Opleiding.Opleiding,
                        });

                        foreach (var dn in deelnemer)
                        {
                            docOplListBox.Items.Add(dn.Id + " " + dn.Naam + " " + dn.Opleiding);
                        }
                    }
                    break;

                case 6:

                    docListBox.Items.Clear();

                    using (var context = new AanwezigheidslijstContext())
                    {
                        var deelnemer = context.Docentens.Select(dlnmr => new {
                            dlnmr.Id,
                            dlnmr.Naam,
                            dlnmr.Bedrijf,
                        });

                        foreach (var dn in deelnemer)
                        {
                            docListBox.Items.Add(dn.Id + " " + dn.Naam + " " + dn.Bedrijf);
                        }
                    }
                    break;
            }
        }

        //////////////////WIJZIGEN///////////////

        private void WijzigZoekButton_Click(object sender, EventArgs e)
        {
            string zoekNaam = wijzigNaamTextBox.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == zoekNaam);

                naamTextBox.Text = deelnemer.Naam;
                GeboortedatumDateTimePicker.Value = deelnemer.GeboorteDatum;
                woonplaatsTextBox.Text = deelnemer.Woonplaats;
                badgeNummerTexBox.Text = deelnemer.BadgeNummer.ToString();
            }
        }

        private void ZoekListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void SaveChangeDeelnemerButton_Click_1(object sender, EventArgs e)
        {
            string zoekNaam = wijzigNaamTextBox.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == zoekNaam);

                deelnemer.Naam = naamTextBox.Text;
                deelnemer.GeboorteDatum = GeboortedatumDateTimePicker.Value;
                deelnemer.Woonplaats = woonplaatsTextBox.Text;
                deelnemer.BadgeNummer = int.Parse(badgeNummerTexBox.Text);

                context.SaveChanges();
                MessageBox.Show("Deelnemer gewijzigd");
                naamTextBox.Clear();
                GeboortedatumDateTimePicker.ResetText();
                woonplaatsTextBox.Clear();
                badgeNummerTexBox.Clear();
            }
        }

        private void DeleteDeelnemerButton_Click(object sender, EventArgs e)
        {
            string verwijderNaam = wijzigNaamTextBox.Text;

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.SingleOrDefault(dlnmr => dlnmr.Naam == verwijderNaam);
                context.Deelnemers.Remove(deelnemer);

                context.SaveChanges();
                MessageBox.Show("Deelnemer verwijderd");
            }
        }
    }
}
