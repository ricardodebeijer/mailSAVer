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

namespace MailSaver.Views
{
    /// <summary>
    /// Interaction logic for SelectFolder.xaml
    /// </summary>
    public partial class SelectFolder : Window
    {
        public SelectFolder()
        {
            InitializeComponent();
            SettingsManager.Instance.SaveLocations.ForEach(location => cbFavorites.Items.Add(location));
            SearchProjectFoldersInLocation();
        }

        private void SearchProjectFoldersInLocation()
        {
           
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
