using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version
{
    public class Version
    {
        public int Major = 1;
        public int Minor = 0;
        public string build = "beta";

        public string getVersion()
        {
            string ret = this.Major.ToString() + "," + this.Minor.ToString();
            return ret;
        }
    }
}
