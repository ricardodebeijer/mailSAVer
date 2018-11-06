using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSaverTwee
{
    public enum SORTERING
    {
        OPLOPEND,
        AFLOPEND
    }
    public class FolderString
    {
        public string Pad { get; set; }
        public string Naam { get; set; }

        public bool Standaard { get; set; }
        public bool Anders { get; set; }

        public SORTERING Sortering { get; set; }


        public string SorteringMetPad()
        {
            string result = "";
            if (this.Sortering == SORTERING.OPLOPEND)
            {
                result += "+";
            }
            else if (this.Sortering == SORTERING.AFLOPEND)
            {
                result += "-";
            }
            result += Pad;

            return result;
        }
        public FolderString(String pad)
        {
            this.Pad = pad;
            int index = this.Pad.LastIndexOf(@"\");
            this.Naam = this.Pad.Substring(index + 1);
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
