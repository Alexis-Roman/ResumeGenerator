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
    static void ReadJSON(string[] args)
        {
            string filepath = GlobalVariable.resume;
            var resumeJsonText = File.ReadAllText(filepath);
            var resumedetails = JsonConvert.DeserializeObject<ResumeDetails>(resumeJsonText);
        }
    }

    public class ResumeDetails
    {
        public string name { get; set; }
        public string location_contact_email { get; set; }
        public string objective { get; set; }
        public string education { get; set; }
        public string experience { get; set; }
        public string certification { get; set; }
    }
}
