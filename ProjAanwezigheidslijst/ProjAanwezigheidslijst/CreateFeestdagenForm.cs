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
    public partial class CreateFeestdagenForm : Form
    {
        public CreateFeestdagenForm() //////FillComboBox() nog aanpassen naar displaymember//////////
        {
            InitializeComponent();
            FillComboBox();
        }

        private void CreateNietOplDagButton_Click(object sender, EventArgs e)
        {
            if (nietOplDagDateTimePicker.Text != null && OplIdComboBox.Text != "" )
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
                        Opleiding =  opleiding,

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
                    
                    OplIdComboBox.Items.Add(opl.Id + " " + opl.Opleiding);
                   
                }
            }
        }
    }
}
