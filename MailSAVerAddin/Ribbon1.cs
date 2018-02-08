﻿using MailSAVerAddin.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new Ribbon1();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace MailSAVerAddin
{
    [ComVisible(true)]
    public class Ribbon1 : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public Ribbon1()
        {
            
        }


        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("MailSAVerAddin.Ribbon1.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit http://go.microsoft.com/fwlink/?LinkID=271226

        public void btnSlaOpClick(Office.IRibbonControl control)
        {
            Outlook.MailItem mailItem = GetMailItem();
            if (mailItem != null)
            {
                SaveManager.Instance.SlaOp(mailItem);
            }
        }


        public void btnSlaOpAndersClick(Office.IRibbonControl control)
        {
            Outlook.MailItem mailItem = GetMailItem();
            if (mailItem != null)
            {
                SaveManager.Instance.SlaOpAnders(mailItem);
            }
        }

        public void btnNieuwProjectClick(Office.IRibbonControl control)
        {
            Outlook.MailItem mailItem = GetMailItem();
            if (mailItem != null)
            {
                SaveManager.Instance.MaakProjectAan(mailItem);
            }
        }

        public void btnInstellingenClick(Office.IRibbonControl control)
        {
            SaveManager.Instance.Instellingen();
        }


        public Bitmap GetGroupImage(Office.IRibbonControl control)
        {
            return Resources.MailSAVerIcon1.ToBitmap();
        }

        private Outlook.MailItem GetMailItem()
        {
            Outlook.Explorer explorer = Globals.MailSAVer.Application.ActiveExplorer();
            if (explorer != null && explorer.Selection != null && explorer.Selection.Count > 0)
            {
                object item = explorer.Selection[1];
                if (item is Outlook.MailItem)
                {
                    Outlook.MailItem mailItem = item as Outlook.MailItem;

                    return mailItem;
                }
            }

            return null;

        }


        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
