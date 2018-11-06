using MailSaver.Model;
using MailSaver.Views;
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
    public class SettingsManager
    {
        private static SettingsManager instance;

        public List<SaveLocation> SaveLocations { get; set; }
        public List<String> OutgoingEmails { get; set; }

        public SaveLocation LastUsedLocation { get; set; }

        public ProjectFolder LastUsedProject { get; set; }

        private SettingsManager()
        {
            SaveLocations = new List<SaveLocation>();
            OutgoingEmails = new List<String>();
        }

        public static SettingsManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsManager();
                }
                return instance;
            }
        }

        public void addSaveLocation(string path)
        {
            if (!this.hasLocation(path))
            {
                SaveLocation location = new SaveLocation(path);
                SaveLocations.Add(location);
            }
        }

        public void removeSaveLocation(SaveLocation location)
        {
            SaveLocations.Remove(location);
        }

        public bool hasLocation(string path)
        {
            return SaveLocations.Find(location => location.Path == path) != null;
        }

        public void addOutgoingEmail(string email)
        {
            if (!this.hasEmail(email))
            {
                OutgoingEmails.Add(email);
            }
        }

        public void removeOutgoingEmail(String email)
        {
            OutgoingEmails.Remove(email);
        }

        public bool hasEmail(string email)
        {
            return OutgoingEmails.Contains(email);
        }

        internal void setDefaultSaveLocation(SaveLocation selected)
        {
           
            SaveLocation oldDefault = this.getDefaultLocation();
            if (oldDefault != null)
            {
                oldDefault.IsDefaultLocation = false;
            }
          
            int newLocationIndex = SaveLocations.IndexOf(selected);
            SaveLocation newDefault = SaveLocations[newLocationIndex];
            newDefault.IsDefaultLocation = true;
        }

        public SaveLocation getDefaultLocation()
        {
            SaveLocation oldDefault = SaveLocations.Find(location => location.IsDefaultLocation);
            return oldDefault;
        }
    }
}
