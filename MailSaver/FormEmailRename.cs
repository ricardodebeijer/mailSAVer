using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSaver
{
    public partial class FormEmailRename : Form
    {
        private String Pad;
        private String EmailNaam;
        private String Extensie;
        private String VolledigPad;
        public FormEmailRename()
        {
            InitializeComponent();
            lblMelding.Text = "";
        }

        public void SetMelding(String melding)
        {
            lblMelding.Text = melding;
        }


        public void SetEmail(String pad)
        {
            ZetEmailNaamEnDirectory(pad);
        }

        private void ZetEmailNaamEnDirectory(string pad)
        {
            int index1 = pad.LastIndexOf("\\");
            index1++;
            Pad = pad.Substring(0, index1);
            String naam = pad.Substring(index1);
            int index2 = naam.LastIndexOf(Properties.Settings.Default.Extensie);
            Extensie = naam.Substring(index2);
            EmailNaam = naam.Substring(0, index2);
            SetExtensie(Extensie);
            SetEmailNaam(EmailNaam);
            SetDirectory(Pad);
        }

        private void SetExtensie(string extensie)
        {
            lblExtensie.Text = extensie;
        }

        private void SetEmailNaam(string emailnaam)
        {
            tbEmailNaam.Text = emailnaam;
        }

        private void SetDirectory(string directory)
        {
            linkLabelDirectory.Text = directory;
        }


        public String GetVolledigPad()
        {
            return VolledigPad;
        }

        private void linkLabelDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Directory.Exists(linkLabelDirectory.Text))
            {
                Process.Start("explorer.exe", linkLabelDirectory.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Opschonen eventuele \ | :  etc
            EmailNaam = SaveManager.Instance.StripString(tbEmailNaam.Text);
            VolledigPad = Pad + EmailNaam + Properties.Settings.Default.Extensie;
            if (File.Exists(VolledigPad))
            {
                DialogResult result = MessageBox.Show("Deze mail overschrijven?", "MailSAVer: Melding", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    ConfirmAndClose();
                }
            }else
            {
                ConfirmAndClose();
            }
        }

        private void ConfirmAndClose()
        {
            lblMelding.Text = "Y";
            Close();
        }

        public string GetConfirmation()
        {
            return lblMelding.Text;
        }
    }
}
