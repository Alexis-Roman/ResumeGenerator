using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeGenerator
{
    class GlobalVariable
    {
        private static string resumevar = "";
        public static string resume
        {
            get { return resumevar; }
            set { resumevar = value; }
        }
    }
}
