﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MailSAVerTwee.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>+H:\MH\projecten afgesloten\</string>
  <string>+G:\MH\OFFERTES\offerte MH 2018\</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Locaties {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Locaties"]));
            }
            set {
                this["Locaties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>michel.debeijer</string>
  <string>gerne.vandencorput</string>
  <string>nelis.luijten</string>
  <string>marcel.keus</string>
  <string>toos.hoezen</string>
  <string>henk.dehollander</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection EmailUitgaand {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["EmailUitgaand"]));
            }
            set {
                this["EmailUitgaand"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+H:\\MH\\projecten actueel\\")]
        public string LocatieStandaard {
            get {
                return ((string)(this["LocatieStandaard"]));
            }
            set {
                this["LocatieStandaard"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+C:\\Windows\\")]
        public string LocatieAnders {
            get {
                return ((string)(this["LocatieAnders"]));
            }
            set {
                this["LocatieAnders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".msg")]
        public string Extensie {
            get {
                return ((string)(this["Extensie"]));
            }
            set {
                this["Extensie"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0")]
        public global::System.Drawing.Size FormSize {
            get {
                return ((global::System.Drawing.Size)(this["FormSize"]));
            }
            set {
                this["FormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LaatstGekozenFolder {
            get {
                return ((string)(this["LaatstGekozenFolder"]));
            }
            set {
                this["LaatstGekozenFolder"] = value;
            }
        }
    }
}
