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
    /*
    public class ReadResume
    {
    public static void ReadJSON(string[] args)
        {
            string filepath = GlobalVariable.resume;
            var resumeJsonText = File.ReadAllText(filepath);
            var resumedetails = JsonConvert.DeserializeObject<ResumeDetails>(resumeJsonText);
        }
    }
    */
    public class ResumeDetails
    {

        public string Name { get; set; }
        public string Location_contact_email { get; set; }
        public string Objective { get; set; }
        public EducationDetails Education { get; set; }

        public class EducationDetails
        {
            public string course { get; set; }
            public string university { get; set; }
            public string yeargraduated { get; set; }
        }

    
    }
}
