using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace MailSaver
{
    public class SaveManager
    {
        private static SaveManager instance;

        private SaveManager() { }

        public static SaveManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SaveManager();
                }
                return instance;
            }
        }


        internal void SlaOp(Outlook.MailItem email)
        {
            String pad = GetPad(true);
            if (pad != null)
            {
                pad = pad + "/";
                bool bestaat = false;
                if (Directory.Exists(pad + "email/"))
                {
                    pad = pad + "email/";
                    bestaat = true;
                }
                else if (Directory.Exists(pad))
                {
                    bestaat = true;
                }
                //Sla de geselecteerde Folder op
                SlaGeselecteerdeFolderOp(pad);

                if (bestaat)
                {
                    //Krijg een bestandsnaam volgens wens
                    pad = GetFormattedString(pad, email);

                    //Sla de mail op
                    SaveEmail(email, pad);
                }
            }
        }



        private void SlaGeselecteerdeFolderOp(string pad)
        {
            string folder = pad.Substring(0, pad.Length - 1);
            Properties.Settings.Default.LaatstGekozenFolder = folder;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        internal void SlaOpAnders(Outlook.MailItem email)
        {
            String pad = GetPad(false);
            if (pad != null)
            {      //Blijkbaar een \ te weinig,dus 
                pad = pad + @"\";
                //Krijg een bestandsnaam volgens wens
                pad = GetFormattedString(pad, email);
                //Voeg de extensie er aan toe
                pad = AddExtensie(pad);
                //Pas eventuele / aan in \
                pad = SetPadMetGoedeSlashes(pad);
                //Eventuele naamswijzigingen:
                FormEmailRename form = new FormEmailRename();
                if (File.Exists(pad))
                {
                    form.SetMelding("Anders opslaan: De gekozen email komt al voor in deze directory:");
                }
                else
                {
                    form.SetMelding("Anders opslaan: kies eventueel een andere naam:");
                }
                form.SetEmail(pad);
                form.ShowDialog();
                if (form.GetConfirmation() == "Y")
                {
                    email.SaveAs(form.GetVolledigPad());
                }

                //if (pad != null)
                //{
                //    //Sla de mail op
                //    SaveEmail(email, pad);
                //}
            }
        }

        private void SaveEmail(Outlook.MailItem email, string pad)
        {
            pad = AddExtensie(pad);
            pad = SetPadMetGoedeSlashes(pad);
            if (File.Exists(pad))
            {
                //Email bestaat al in deze directory
                FormEmailRename form = new FormEmailRename();
                form.SetMelding("De gekozen email komt al voor in deze directory:");
                form.SetEmail(pad);
                form.ShowDialog();
                if (form.GetConfirmation() == "Y")
                {
                    email.SaveAs(form.GetVolledigPad());
                }
            }
            else
            {
                //Bestaat nog niet, save hem maar
                try
                {
                    email.SaveAs(pad);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Het opslaan van de mail op: '" + pad + "' is niet gelukt!", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private string AddExtensie(string pad)
        {
            return pad += Properties.Settings.Default.Extensie;
        }

        private string SetPadMetGoedeSlashes(string pad)
        {
            return pad.Replace("/", "\\");
        }

        private String GetFormattedString(String pad, Outlook.MailItem email)
        {
            //Standaard/normaal is inkomed
            String inofuitgaand = "";
            //Haal naam zender uit email
            String persoon = email.SenderName;
            foreach (String adres in Properties.Settings.Default.EmailUitgaand)
            {
                if (email.SenderEmailAddress.Contains(adres))
                {
                    //Dan is het verstuurd vanuit een email adres uit de lijst, dus uitgaand
                    inofuitgaand = " .u. ";
                    //Dan moet de opgeslagen persoon de ontvanger zijn
                    if (email.Recipients.Count > 0)
                    {
                        bool gevonden = false;
                        foreach (Outlook.Recipient ontvanger in email.Recipients)
                        {
                            if (!gevonden)
                            {
                                persoon = ontvanger.Name; //Naam haalt ie uit contacten, anders email
                                gevonden = true;
                            }
                        }
                    }
                }
            }
            if (inofuitgaand == "")
            {
                inofuitgaand = " .i. ";
            }



            //Datum tijd notering   20160617 12.43
            String datumTijd = email.ReceivedTime.ToString("yyyyMMdd HH.mm");


            //Haal rare tekens uit de persoon 
            persoon = StripString(persoon);

            //Haal het onderwerp op, en schoon die op (: in filename mag niet etc)
            String onderwerp = " " + StripString(email.Subject);

            //Format de mail zoals gewenst
            //20160416 18.32 .i Ricardo de Beijer Onderwerp
            pad += datumTijd + inofuitgaand + persoon + onderwerp;

            return pad;
        }

        internal void Instellingen()
        {
            FormInstellingen form = new FormInstellingen();
            form.ShowDialog();
        }

        public string StripString(String text)
        {
            String onderwerp = text;
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            //Haal alle : * / \ etc eruit, mag niet in filenames staan
            onderwerp = r.Replace(onderwerp, "");
            return onderwerp;
        }

        internal void MaakProjectAan(Outlook.MailItem mailItem)
        {
            String pad = GetDefaultPad().Pad;
            if (pad != null)
            {
                //Maak Form voor extra input
                FormProjectAanmaken form = new FormProjectAanmaken();
                //Dialog: laat maar bevestigen
                form.ShowDialog();

                //Haal projectnummer en klant uit form
                String projectnummer = form.GetProjectnummer();
                String klantnaam = form.GetKlant(); //Input window
                String omschrijving = form.GetOmschrijving(); //Input window
                bool bevestigd = form.GetBevestiging();

                if (bevestigd)
                {
                    pad += klantnaam + " - " + projectnummer + " - " + omschrijving + @"\email\";
                    Directory.CreateDirectory(pad);
                    pad = GetFormattedString(pad, mailItem);
                    SaveEmail(mailItem, pad);
                }
            }
            else
            {
                //Pad in settings verkeerd
                MessageBox.Show("Ingevoerd pad: '" + pad + "' niet gevonden! \nOpen het instellingsvenster en pas dit aan", "MailSAVer: Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public LocatieString GetDefaultPad()
        {
            string standaardpad = Properties.Settings.Default.LocatieStandaard;
            LocatieString standaard = getObjectVanPad(standaardpad);
            if (Directory.Exists(standaard.Pad))
            {
                return standaard;
            }
            return null;
        }
        public LocatieString GetAndersPad()
        {
            string anderspad = Properties.Settings.Default.LocatieAnders;
            LocatieString anders = getObjectVanPad(anderspad);
            if (Directory.Exists(anders.Pad))
            {
                return anders;
            }
            return null;
        }

        public List<LocatieString> GetLocaties()
        {
            List<LocatieString> locaties = new List<LocatieString>();
            foreach (string locatie in Properties.Settings.Default.Locaties)
            {
                locaties.Add(getObjectVanPad(locatie));
            }
            return locaties;
        }

        private LocatieString getObjectVanPad(string pad)
        {
            string orderchar = pad.Substring(0, 1);
            if (orderchar != "+" &&
                orderchar != "-")
            {
                MessageBox.Show("Fout in pad");
            }
            string orderremoved = pad.Substring(1);
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

        public string getPadZonderSortering(string pad)
        {
            string orderchar = pad.Substring(0, 1);
            if (orderchar != "+" &&
                orderchar != "-")
            {
                MessageBox.Show("Fout in pad");
            }
            string orderremoved = pad.Substring(1);

            return orderremoved;
        }

        private String GetPad(bool standaard)
        {
            String pad;
            if (standaard)//Dus in projecten actueel
            {
                //Toon form
                FormProjectKiezen form = new FormProjectKiezen();
                //Toon dialog
                form.ShowDialog();
                //Haal het geselecteerde pad op
                pad = form.GetGekozenPad();

                return pad;
            }
            else //Anders:
            {
                //toon een folder dialog, start op andere locatie
                FolderBrowserDialog folder = new FolderBrowserDialog();
                pad = Properties.Settings.Default.LocatieAnders;
                folder.SelectedPath = getPadZonderSortering(pad);
                folder.ShowDialog();
                //Als er een pad gekozen is, pak dat
                if (folder.SelectedPath != pad) //Dus een folder gekozen
                {
                    return folder.SelectedPath;
                }
                else
                {
                    return null;
                }
            }

        }

    }
}
