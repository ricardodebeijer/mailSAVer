using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSAVerAddin
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
