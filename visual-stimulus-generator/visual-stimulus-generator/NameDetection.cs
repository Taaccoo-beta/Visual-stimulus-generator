using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_stimulus_generator
{
    class NameDetection
    {
        private string path;
        private string name;

        public NameDetection(string path,string name)
        {
            this.path = path;
            this.name = name;
        }

        public bool NameSearch()
        {
            
            DirectoryInfo folder = new DirectoryInfo(path);
            string expFileName = this.name+ ".avi";
            if (folder.GetFiles("*.avi").Length == 0)
            {
                return false;
            }
            else
            {
                foreach (FileInfo file in folder.GetFiles("*.avi"))
                {
                    if (expFileName.Equals(file.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        
                        return true;
                    }
                }
                
            }
            return false;
        }
    }
}
