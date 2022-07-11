using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

    internal class ReadResume
    {
        static void Main(string[] args)
        {
            string filepath = GlobalVariable.resume;
            //MessageBox.Show(filepath);
            var resumeJsonText = File.ReadAllText(filepath);
            var resumedetails = JsonConvert.DeserializeObject<sajfj>(resumeJsonText);
        }
    }

    public class ResumeDetails
    {

    }
}
