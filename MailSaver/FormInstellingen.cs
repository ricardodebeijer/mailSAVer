using System;
using System.Collections.Specialized;
using System.IO;
using System.Windows.Forms;

namespace MailSaver
{
    public partial class FormInstellingen : Form
    {
        public FormInstellingen()
        {
            InitializeComponent();
        }

        private void FormInstellingen_Load(object sender, EventArgs e)
        {
            VulInformatieVanuitSettings();
        }

        private void VulInformatieVanuitSettings()
        {
            VulLocaties();
            VulNamenEmailUitgaand();
        }

        private void VulLocaties()
        {
            lbLocaties.Items.Clear();
            //Standaard locatie
            InstellingString standaard = new InstellingString(SaveManager.Instance.GetDefaultPad());
            standaard.Standaard = true;
            lbLocaties.Items.Add(standaard);
            //Overige locaties oplopend
            foreach (LocatieString locatie in SaveManager.Instance.GetLocaties())
            {
                InstellingString favoriet = new InstellingString(locatie);
                lbLocaties.Items.Add(favoriet);
            }
            //Anders locatie
            InstellingString anders = new InstellingString(SaveManager.Instance.GetAndersPad());
            anders.Anders = true;
            lbLocaties.Items.Add(anders);
        }

        private void VulNamenEmailUitgaand()
        {
            lbNamen.Items.Clear();
            foreach (String naam in Properties.Settings.Default.EmailUitgaand)
            {
                lbNamen.Items.Add(naam);
            }
        }

        private void SaveAndReload()
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void btnNaamToevoegen_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text != "")
            {
                if (!Properties.Settings.Default.EmailUitgaand.Contains(tbNaam.Text))
                {
                    Properties.Settings.Default.EmailUitgaand.Add(tbNaam.Text);
                    SaveAndReload();
                }
                else
                {
                    MessageBox.Show("Ingevoerd persoon: '" + tbNaam.Text + "' staat al in de lijst!", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                VulNamenEmailUitgaand();
                tbNaam.Text = "";
            }
        }


        private void btnNaamVerwijder_Click(object sender, EventArgs e)
        {
            if (lbNamen.SelectedItem != null)
            {
                Properties.Settings.Default.EmailUitgaand.Remove(lbNamen.SelectedItem.ToString());
                SaveAndReload();
                VulNamenEmailUitgaand();
            }
        }

        private void btnLocatieVerwijder_Click(object sender, EventArgs e)
        {
            if (lbLocaties.SelectedItem != null)
            {
                InstellingString selected = (InstellingString)lbLocaties.SelectedItem;
                Properties.Settings.Default.Locaties.Remove(selected.SorteringMetPad());
                SaveAndReload();
                VulLocaties();
            }
        }

        private void btnZetAflopend_Click(object sender, EventArgs e)
        {
            if (lbLocaties.SelectedItem != null)
            {
                InstellingString selected = (InstellingString)lbLocaties.SelectedItem;
                if (selected.Standaard)
                {
                    selected.Sortering = SORTERING.AFLOPEND;
                    Properties.Settings.Default.LocatieStandaard = selected.SorteringMetPad();
                }
                else if (selected.Anders)
                {
                    selected.Sortering = SORTERING.AFLOPEND;
                    Properties.Settings.Default.LocatieAnders = selected.SorteringMetPad();
                }
                else
                {
                    Properties.Settings.Default.Locaties.Remove(selected.SorteringMetPad());
                    selected.Sortering = SORTERING.AFLOPEND;
                    Properties.Settings.Default.Locaties.Add(selected.SorteringMetPad());
                }

                SaveAndReload();
                VulLocaties();
            }
        }

        private void btnZetOplopend_Click(object sender, EventArgs e)
        {
            if (lbLocaties.SelectedItem != null)
            {
                InstellingString selected = (InstellingString)lbLocaties.SelectedItem;
                if (selected.Standaard)
                {
                    selected.Sortering = SORTERING.OPLOPEND;
                    Properties.Settings.Default.LocatieStandaard = selected.SorteringMetPad();
                }
                else if (selected.Anders)
                {
                    selected.Sortering = SORTERING.OPLOPEND;
                    Properties.Settings.Default.LocatieAnders = selected.SorteringMetPad();
                }
                else
                {
                    Properties.Settings.Default.Locaties.Remove(selected.SorteringMetPad());
                    selected.Sortering = SORTERING.OPLOPEND;
                    Properties.Settings.Default.Locaties.Add(selected.SorteringMetPad());
                }
                SaveAndReload();
                VulLocaties();
            }
        }
       

        private InstellingString getObjectVanPad(string pad)
        {
            string orderchar = pad.Substring(0, 1);
            if (orderchar != "+" &&
                orderchar != "-")
            {
                MessageBox.Show("Fout in pad");
            }
            string orderremoved = pad.Substring(1);
            InstellingString locatie = new InstellingString(orderremoved);
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

        private void VoegLocatieToe(String pad)
        {
            if (pad != null)
            {
                //default is oplopend +
                InstellingString locatie = getObjectVanPad("+" + pad);
                //Als het ingevoerde pad niet bestaat, melding geven
                if (Directory.Exists(locatie.Pad))
                {
                    if (locatie.Pad != "")
                    {
                        //Als er nog geen \ achter staat, voeg die toe
                        if (!locatie.Pad.EndsWith(@"\"))
                        {
                            locatie.Pad = locatie.Pad + @"\";
                        }
                        //Ingevoerde pad moet niet al voorkomen
                        bool staatInLijst = false;

                        //Als het pad gelijk is aan de standaard
                        if (Properties.Settings.Default.LocatieStandaard == pad)
                        {
                            staatInLijst = true;
                        }
                        //Als het pad gelijk is aan de Anders
                        else if (Properties.Settings.Default.LocatieAnders == pad)
                        {
                            staatInLijst = true;
                        }
                        //Als het pad gelijk is aan een van de locaties
                        foreach (String gelijk in Properties.Settings.Default.Locaties)
                        {
                            if (gelijk == locatie.Pad)
                            {
                                staatInLijst = true;
                            }
                        }
                        //Als hij nog niet in de lijst staat, voeg hem dan toe
                        if (!staatInLijst)
                        {
                            Properties.Settings.Default.Locaties.Add(locatie.SorteringMetPad());
                            SaveAndReload();
                            VulLocaties();

                        }
                        else
                        {
                            MessageBox.Show("Ingevoerd pad: '" + pad + "' staat al in de lijst!", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingevoerd pad: '" + pad + "' is niet correct!", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.RootFolder = Environment.SpecialFolder.MyComputer;
            browser.ShowDialog();
            if (browser.SelectedPath != "")
            {
                VoegLocatieToe(browser.SelectedPath);
            }
        }

        private void btnLocatieZetStandaard_Click(object sender, EventArgs e)
        {
            if (lbLocaties.SelectedItem != null)
            {
                InstellingString selected = (InstellingString)lbLocaties.SelectedItem;
                String padoudestandaard = Properties.Settings.Default.LocatieStandaard;

                Properties.Settings.Default.LocatieStandaard = selected.SorteringMetPad();
                Properties.Settings.Default.Locaties.Remove(selected.SorteringMetPad());
                VoegLocatieToe(SaveManager.Instance.getPadZonderSortering(padoudestandaard));
                SaveAndReload();
                VulLocaties();
            }
        }

        private void btnLocatieZetAnders_Click(object sender, EventArgs e)
        {
            if (lbLocaties.SelectedItem != null)
            {
                InstellingString selected = (InstellingString)lbLocaties.SelectedItem;
                String padoudeanders = Properties.Settings.Default.LocatieAnders;

                Properties.Settings.Default.LocatieAnders = selected.SorteringMetPad();
                Properties.Settings.Default.Locaties.Remove(selected.SorteringMetPad());
                VoegLocatieToe(SaveManager.Instance.getPadZonderSortering(padoudeanders));
                SaveAndReload();
                VulLocaties();
            }
        }


    }
}
