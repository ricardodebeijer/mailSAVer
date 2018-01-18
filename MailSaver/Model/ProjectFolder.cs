using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSaver.Model
{
    public class ProjectFolder
    {
        public string Path { get; set; }
        public string Name { get; set; }

        public ProjectFolder(String path)
        {
            this.Path = path;
            int index = this.Path.LastIndexOf(@"\");
            this.Name = this.Path.Substring(index + 1);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
