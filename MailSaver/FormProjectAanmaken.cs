using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSaver
{
    public partial class FormProjectAanmaken : System.Windows.Forms.Form
    {
        public FormProjectAanmaken()
        {
            InitializeComponent();
            lblMelding.Text = "";
            lblLocatieWaarde.Text = SaveManager.Instance.GetDefaultPad().Pad;
        }

        public String GetProjectnummer()
        {
            return tbProjectnummer.Text;
        }

        public String GetOmschrijving()
        {
            return tbOmschrijving.Text;
        }
        public String GetKlant()
        {
            return tbKlant.Text;
        }

        internal bool GetBevestiging()
        {
            if (lblMelding.Text == "Y")
            {
                return true;
            }
            return false;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbProjectnummer.Text != "")
            {
                lblKlant.Text = SaveManager.Instance.StripString(lblKlant.Text);
                lblMelding.Text = "Y";
                Close();
            }else
            {
                lblMelding.Text = "Projectnummer ontbreekt!";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMelding.Text = "N";
            Close();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
