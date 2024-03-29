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
                    //OplIdComboBox.ValueMember = opl.Id;
                    //OplIdComboBox.DisplayMember = opl.Opleiding;

                    KiesOplComboBox.Items.Add(opl.Id + " " + opl.Opleiding);
                    
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

                    BadgeFlowLayoutPanel.Controls.Add(dynamicButton);
                    //this.opleidingInfoButton.Click += new System.EventHandler(this.DynamicButton_Click);
                }
            }
            
            /// delenemers ophalen en forloop om voo elke deelnemer uit database een badge knop te maken/////
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

        private void BadgeFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

       

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oplInfolistBox.Items.Add(KiesOplComboBox.Text);
        }
    }
}
