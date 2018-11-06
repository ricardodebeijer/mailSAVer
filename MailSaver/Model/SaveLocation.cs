using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSaver.Model
{
    public class SaveLocation : ProjectFolder
    {

        public bool IsDefaultLocation { get; set; }


        public SaveLocation(String path) : this(path, false) { }


        public SaveLocation(String path, bool defaultLocation) : base(path)
        {
            this.IsDefaultLocation = defaultLocation;
        }

        public override string ToString()
        {
            return base.ToString() + (IsDefaultLocation ? " - " + "Standaardlocatie" : null);
        }
    }
}
