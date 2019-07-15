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
    public  class TijdAanwezig
    {
        public DateTime BeginTijd { get; set; }
        public DateTime EindTIjd { get; set; }
        public TimeSpan TotaalTijd { get; set; }

        public TijdAanwezig(DateTime beginTijd, DateTime eindTijd, TimeSpan totaalTijd)
        {
            BeginTijd = beginTijd;
            EindTIjd = eindTijd;
            TotaalTijd = totaalTijd;
        }
    }

    public partial class TijdregistratieForm : Form
    {
        Stopwatch Stopwatch = new Stopwatch();
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
                    //OplIdComboBox.ValueMember = opl.Id;
                    //OplIdComboBox.DisplayMember = opl.Opleiding;

                    KiesOplComboBox.Items.Add(opl.Id);
                    
                }
            }


            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Deelnemers.Select(deelnemers => new { deelnemers.Naam});

                foreach (var dlnmr in deelnemer)
                {
                    Button dynamicButton = new Button();

                    dynamicButton.Text = dlnmr.Naam;
                    dynamicButton.Location = new Point(20, 150);
                    dynamicButton.Height = 40;
                    dynamicButton.Width = 150;
                    dynamicButton.BackColor = Color.Red;

                    flowLayoutPanel1.Controls.Add(dynamicButton);
                    dynamicButton.Click += new EventHandler(DynamicButtonClickEvent); // eigen event gemaakt

                }
            }
            
            /// delenemers ophalen en forloop om voo elke deelnemer uit database een badge knop te maken/////
        }

        private void DynamicButtonClickEvent(object sender, EventArgs e)// eigen event maken
        {
            Button btn = sender as Button;
            DateTime beginTijd;
            DateTime eindTijd;
            TimeSpan tijdAanwezig;

            if (oplInfolistBox.Text!="")
            {
                
                if (btn.BackColor == Color.Red)
                {
                    btn.BackColor = Color.Green;
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
                DateTime beginTijda = DateTime.Now;
                MessageBox.Show(beginTijda.ToString());
                beginTijd = beginTijda;
            }
            else if (btn.BackColor == Color.Red)
            {
                eindTijd = DateTime.Now;
                MessageBox.Show(eindTijd.ToString());


            }
            //if (beginTijd != null && eindTijd != null)
            {
               // TimeSpan tijdAanwzeig = eindTijd - beginTijd;
                //MessageBox.Show(tijdAanwzeig.ToString());
            }


            //TijdAanwezig totTijdAanwezig = new TijdAanwezig(beginTijd, eindTijd, tijdAanwezig);

        }


        private void timer1_Tick(object sender, EventArgs e)

        {
            this.timeLabel.Text = DateTime.Now.ToString();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int selectOpl = int.Parse(KiesOplComboBox.Text);

            using (var context = new AanwezigheidslijstContext())
            {
                var deelnemer = context.Opleidingsinformaties.SingleOrDefault(dlnmr => dlnmr.Id == selectOpl);
                oplInfolistBox.Items.Add(deelnemer.Id + " " + deelnemer.Opleidingsinstelling + " " + deelnemer.Opleiding);
            }
        }
    }
}
