using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSAVerAddin
{
   public class InstellingString : FolderString
    {
        public InstellingString(LocatieString locatieString)
            : base(locatieString.Pad)
        {
            this.Naam = locatieString.Naam;
            this.Standaard = locatieString.Standaard;
            this.Anders = locatieString.Anders;
            this.Sortering = locatieString.Sortering;
        }

        public InstellingString(string pad) : base(pad)
        {
        }

        public override string ToString()
        {
            String result = base.Pad;
            if (this.Standaard)
            {
                result += "   : Standaard,";
            }
            else if(this.Anders)
            {
                result += "   : Anders,";
            }
            else
            {
                result += "   : ";
            }

            if (this.Sortering == SORTERING.OPLOPEND)
            {
                result += "Oplopend";
            }else if (this.Sortering == SORTERING.AFLOPEND)
            {
                result += "Aflopend";
            }

            return result;
        }
    }
}
