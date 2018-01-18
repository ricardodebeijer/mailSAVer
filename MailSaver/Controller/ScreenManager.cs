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
    public class ScreenManager
    {
        private static ScreenManager instance;

        private ScreenManager() { }

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
            }
        }

        public void showSaveEmail(Outlook.MailItem mailItem)
        {
            if (mailItem != null)
            {
                SelectFolder screen = new SelectFolder();
                screen.ShowDialog();
            }
        }

        public void showSaveEmailOther(Outlook.MailItem mailItem)
        {
            if (mailItem != null)
            {
                SelectFolder screen = new SelectFolder();
                screen.ShowDialog();
            }
        }

        public void showAddProject(Outlook.MailItem mailItem)
        {
            if (mailItem != null)
            {
                AddProject screen = new AddProject();
                screen.ShowDialog();
            }
        }

        public void showSettings()
        {
            Settings screen = new Settings();
            screen.ShowDialog();
        }


    }
}
