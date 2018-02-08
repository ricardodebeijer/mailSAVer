using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSAVerAddin
{
    public partial class FormProjectKiezen : Form
    {

        private String gekozenpad;
        public FormProjectKiezen()
        {
            InitializeComponent();
            lblMelding.Text = "";
            VulComboBoxMetOpties();
            LocatieString standaard = (LocatieString)cbLocaties.Items[0];
            VulLijstMetFoldersVanPad(standaard, null);
            try
            {
                cbLocaties.SelectedIndex = 0;
                lbProjecten.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            //Zet de laatste gekozen project folder alvast geselecteerd mits mogelijk
            ZetLaatstGekozenProjectFolderGeselecteerd();
            //lbProjecten.Focus();
            //cbLocaties.Focus();

            tbZoekbalk.GotFocus += RemoveTempText;
            tbZoekbalk.LostFocus += AddTempText;


            this.Size = Properties.Settings.Default.FormSize;


        }

        private void ZetLaatstGekozenProjectFolderGeselecteerd()
        {
            string folder = Properties.Settings.Default.LaatstGekozenFolder;
            FolderString found = null;
            foreach (FolderString item in lbProjecten.Items)
            {
                if (folder == item.Pad)
                {
                    found = item;
                }
            }

            if (found != null)
            {
                lbProjecten.SelectedItem = found;
            }
        }

        private void AddTempText(object sender, EventArgs e)
        {
            //tbZoekbalk.Text = "zoeken...";
        }

        private void RemoveTempText(object sender, EventArgs e)
        {
            tbZoekbalk.Text = "";
        }

        private void VulComboBoxMetOpties()
        {
            cbLocaties.Items.Add(SaveManager.Instance.GetDefaultPad());
            foreach (String pad in Properties.Settings.Default.Locaties)
            {
                cbLocaties.Items.Add(getObjectVanPad(pad));
            }
            cbLocaties.Items.Add(SaveManager.Instance.GetAndersPad());
        }

        private LocatieString getObjectVanPad(string pad)
        {
            string orderremoved = pad.Substring(1);
            string orderchar = pad.Substring(0, 1);
            LocatieString locatie = new LocatieString(orderremoved);
            if (orderchar == "+")
            {
                locatie.Sortering = SORTERING.OPLOPEND;
            }
            else if (orderchar == "-")
            {
                locatie.Sortering = SORTERING.AFLOPEND;
            }
            return locatie;
        }
        private void cbLocaties_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderString item = (FolderString)cbLocaties.SelectedItem;
            VulLijstMetFoldersVanPad(item, null);
            ZetLaatstGekozenProjectFolderGeselecteerd();
            lbProjecten.Focus();
        }

        private void VulLijstMetFoldersVanPad(FolderString pad, String search)
        {
            if (pad != null)
            {
                lbProjecten.Items.Clear();

                //Zet op aflopende volgorde als dat nodig is
                string[] folders;
                folders = Directory.GetDirectories(pad.Pad);
                if (pad.Sortering == SORTERING.AFLOPEND)
                {
                    Array.Reverse(folders);
                }

                foreach (String folder in folders)
                {
                    FolderString map = new FolderString(folder);
                    if (search != null)
                    {
                        if (map.Naam.ToLower().Contains(search.ToLower()))
                        {
                            lbProjecten.Items.Add(map);
                        }
                    }
                    else
                    {
                        lbProjecten.Items.Add(map);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Ingevoerd pad: '" + pad + "' niet gevonden!", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKies_Click(object sender, EventArgs e)
        {
            FolderString map = (FolderString)lbProjecten.SelectedItem;
            try
            {
                this.gekozenpad = map.Pad;
                lblMelding.Text = "Y";
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Geen folder geselecteerd!", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMelding.Text = "N";
            Close();
        }
        public String GetGekozenPad()
        {
            if (lblMelding.Text == "Y")
            {
                return gekozenpad;
            }
            return null;

        }

        private void tbZoekbalk_TextChanged(object sender, EventArgs e)
        {
            String pattern = tbZoekbalk.Text;
            LocatieString item = (LocatieString)cbLocaties.SelectedItem;
            if (item != null)
            {
                VulLijstMetFoldersVanPad(item, pattern);
            }
        }

        private void FormProjectKiezen_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormSize = this.Size;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }
    }
}
