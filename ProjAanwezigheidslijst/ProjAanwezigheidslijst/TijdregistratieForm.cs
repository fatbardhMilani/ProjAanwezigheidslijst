using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aanwezigheidslijst;

namespace ProjAanwezigheidslijst
{
    public partial class TijdregistratieForm : Form
    {
        Timer timer1 = new Timer();
        public TijdregistratieForm()
        {
            
            InitializeComponent();

            this.timeLabel.Text = DateTime.Now.ToString();

            timer1.Tick += new EventHandler(timer1_Tick);

            this.timer1.Interval = 1000;

            this.timer1.Enabled = true;
        }

        private void TijdregistratieForm_Load(object sender, EventArgs e)
        {
            using (var context = new AanwezigheidslijstContext())
            {
                var oplId = context.Opleidingsinformaties.Select(opleiding => new { opleiding.Id, opleiding.Opleiding });

                foreach (var opl in oplId)
                {
                    KiesOplComboBox.Items.Add(opl.Id);   
                }
            }

            //var opleidingId = KiesOplComboBox.SelectedItem;

            //using (var context = new AanwezigheidslijstContext())
            //{
            //    var deelnemer = context.Deelnemers.Select(deelnemers => new { deelnemers.Naam});

            //    foreach (var dlnmr in deelnemer)
            //    {
            //        Button dynamicButton = new Button();

            //        dynamicButton.Text = dlnmr.Naam;
            //        dynamicButton.Location = new Point(20, 150);
            //        dynamicButton.Height = 40;
            //        dynamicButton.Width = 150;
            //        dynamicButton.BackColor = Color.Red;

            //        flowLayoutPanel1.Controls.Add(dynamicButton);
            //        dynamicButton.Click += new EventHandler(DynamicButtonClickEvent);
            //    }
            //}
        }


        DateTime beginTijd;
        DateTime eindTijd;
        
        private void DynamicButtonClickEvent(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            if (oplInfolistBox.Text!="")
            {

                if (btn.BackColor == Color.Red)
                {
                    btn.BackColor = Color.Green;
                    KiesOplComboBox.ResetText();
                }
                else if (btn.BackColor == Color.Green)
                {
                    btn.BackColor = Color.Red;
                }
                
            }
            else
            {
                MessageBox.Show("Selecteer een opleiding");
            }
            if (btn.BackColor == Color.Green)
            {
                beginTijd = DateTime.Now;
                MessageBox.Show(beginTijd.ToString());
                
            }
            else if (btn.BackColor == Color.Red)
            {
                eindTijd = DateTime.Now;
                MessageBox.Show(eindTijd.ToString());
            }

            if (beginTijd != default(DateTime) && eindTijd != default(DateTime))        ///////////////BUG eerste uitgebadged krijgt laatste tijd
            {
                TimeSpan tijdAanwzeig = eindTijd - beginTijd;
                
                MessageBox.Show(tijdAanwzeig.ToString());
                eindTijd = default(DateTime);

                DateTime today = DateTime.Now.Date;
                DateTime answer = today.Add(tijdAanwzeig);
                MessageBox.Show(answer.ToString());

                var opleidingId = KiesOplComboBox.SelectedItem;
                var deelnemerNaam = btn.Text;

                using (var context = new AanwezigheidslijstContext())                   /////////////BUG neemt laatst geselecteerde opleiding als opleiding ookal ervoor ingechecked en voor elke deelnemer///////////////
                {
                    var opleiding = context.Opleidingsinformaties.SingleOrDefault(a => a.Id == (int)opleidingId);
                    var deelnemer = context.Deelnemers.SingleOrDefault(d => d.Naam == deelnemerNaam);

                    var deelnmrOpl = context.Tijdsregistraties.Add(new Tijdsregistratie
                    {
                        DateTime = answer,
                        Opleiding = opleiding,
                        Deelnemer = deelnemer
                    });
                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = DateTime.Now.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int selectOpl = int.Parse(KiesOplComboBox.Text);



            //var opleidingId = KiesOplComboBox.SelectedItem;

            using (var context = new AanwezigheidslijstContext())
            {
                var dln = context.Opleidingsinformaties.SingleOrDefault(d => d.Id == selectOpl);


                var deelnemer = from d in context.Deelnemers /// join opl id op deelnemer id
                                join dopleiding in context.DeelnemersOpleidingens on d.Id equals dopleiding.Deelnemer.Id
                                where dopleiding.Opleiding.Id == dln.Id
                                select d;
                            

                    foreach (var dlnmr in deelnemer.Distinct())
                    {
                        if (dlnmr.Naam == null)
                        {
                            continue;
                        }
                        Button dynamicButton = new Button();

                        dynamicButton.Text = dlnmr.Naam;
                        dynamicButton.Location = new Point(20, 150);
                        dynamicButton.Height = 40;
                        dynamicButton.Width = 150;
                        dynamicButton.BackColor = Color.Red;

                        flowLayoutPanel1.Controls.Add(dynamicButton);
                        dynamicButton.Click += new EventHandler(DynamicButtonClickEvent);
                    }
                
                
            }




            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Opleidingsinformaties.SingleOrDefault(dlnmr => dlnmr.Id == selectOpl);
                oplInfolistBox.Items.Add(deelnemer.Id + " " + deelnemer.Opleidingsinstelling + " " + deelnemer.Opleiding);
            }
        }
    }
}
