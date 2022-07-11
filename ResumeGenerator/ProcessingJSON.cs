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
    internal class ReadResume
    {
        /*
         static void Main(string[] args)
        {
            string filepath = GlobalVariable.resume;
            var resumeJsonText = File.ReadAllText(filepath);
            var resumedetails = JsonConvert.DeserializeObject<ResumeDetails>(resumeJsonText);
        }
         */

    }

    public class ResumeDetails
    {
        public string Name { get; set; }
        public string LocationContactEmail { get; set; }
        public string Objective { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Certification { get; set; }
    }
}
