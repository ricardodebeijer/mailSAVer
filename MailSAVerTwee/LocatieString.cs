using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSaverTwee
{
   public class LocatieString : FolderString
    {
        public LocatieString(string pad) : base(pad)
        {
        }
        public override string ToString()
        {
            return base.Pad;
        }
    }
}
