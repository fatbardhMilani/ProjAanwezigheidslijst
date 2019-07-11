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
    public partial class WijzigDeelnemerForm : Form
    {
        public WijzigDeelnemerForm()
        {
            InitializeComponent();
        }

        private void WijzigDeelnemerForm_Load(object sender, EventArgs e)
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
                    //OplIdComboBox.ValueMember = opl.Id;
                    //OplIdComboBox.DisplayMember = opl.Opleiding;

                    dlnmrComboBox.Items.Add(dn.Id +" "+dn.Naam + " " + dn.GeboorteDatum + " " + dn.Woonplaats + " " + dn.BadgeNummer);

                }

               

            }
        }

        private void WijzigDeelnemerForm_Click(object sender, EventArgs e)
        {

            int gekozenId = int.Parse(IdTextBox.Text);



            using (var ctx = new AanwezigheidslijstContext())
            {
                Deelnemers deelnemers = ctx.Deelnemers.FirstOrDefault(a => a.Id == gekozenId);
                var deelnemer = ctx.Deelnemers.Select(dlnmr => new {
                    dlnmr.Id,
                    dlnmr.Naam,
                    dlnmr.GeboorteDatum,
                    dlnmr.Woonplaats,
                    dlnmr.BadgeNummer
                    
                });

            }
        }
    }
}
