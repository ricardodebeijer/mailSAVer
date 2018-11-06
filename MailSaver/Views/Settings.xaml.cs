using MailSaver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinForms = System.Windows.Forms;

namespace MailSaver.Views
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            AddSaveLocationsToList();
            AddOutgoingEmailsToList();
        }

        private void AddSaveLocationsToList()
        {
            lvLocations.Items.Clear();
            SettingsManager.Instance.SaveLocations.ForEach(location => lvLocations.Items.Add(location));
        }

        private void AddOutgoingEmailsToList()
        {
            lvPersons.Items.Clear();
            SettingsManager.Instance.OutgoingEmails.ForEach(email => lvPersons.Items.Add(email));
        }
       
        private void btnAddLocation_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.ShowDialog();
            string path = dialog.SelectedPath;
            if (path != null)
            {
                SettingsManager.Instance.addSaveLocation(path);
                AddSaveLocationsToList();
            }
        }

        private void btnRemoveLocation_Click(object sender, RoutedEventArgs e)
        {
            SaveLocation selected = (SaveLocation)lvLocations.SelectedItem;
            SettingsManager.Instance.removeSaveLocation(selected);
            AddSaveLocationsToList();
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            string email = tbAddPerson.Text;
            SettingsManager.Instance.addOutgoingEmail(email);
            AddOutgoingEmailsToList();
        }

        private void btnRemovePerson_Click(object sender, RoutedEventArgs e)
        {
            string selected = (String)lvPersons.SelectedItem;
            SettingsManager.Instance.removeOutgoingEmail(selected);
            AddOutgoingEmailsToList();
        }

        private void btnSetDefault_Click(object sender, RoutedEventArgs e)
        {
            SaveLocation selected = (SaveLocation)lvLocations.SelectedItem;
            SettingsManager.Instance.setDefaultSaveLocation(selected);
            AddSaveLocationsToList();
        }
    }
}
