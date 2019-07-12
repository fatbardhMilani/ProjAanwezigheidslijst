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

            //foreach (Button button in flowLayoutPanel1)
            //{

            //}
            if (btn.BackColor == Color.Green)
            {
                Stopwatch.Start();
            }
            else if (btn.BackColor == Color.Red)
            {
                Stopwatch.Stop();
                var timespan = Stopwatch.Elapsed;
                string strTimeSpan = timespan.ToString();
                MessageBox.Show(strTimeSpan);
            }

            //DateTime dt = new DateTime();


            ////dt = dt.TimeOfDay + Stopwatch.Elapsed;

            //int selectOpl = int.Parse(KiesOplComboBox.Text);

            //using (var context = new AanwezigheidslijstContext())
            //{
            //    var opleidingsInfo = context.Tijdsregistraties.Add(new Tijdsregistratie
            //    {
            //        //DateTime = Stopwatch.Elapsed.TotalSeconds,
            //        //Opleiding = KiesOplComboBox.SelectedItem,
            //    });
            //    context.SaveChanges();
            //    this.DialogResult = DialogResult.OK;
            //}

        }

        //private void DynamicButton_Click(object sender, EventArgs e)
        //{
        //    Button dynamicButton = sender as Button;
        //    this.dynamicButton.Click += new System.EventHandler(this.DynamicButton_Click);
        //}

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
