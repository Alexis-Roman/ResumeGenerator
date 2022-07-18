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
        public SeniorProjectManager_details senior_project_manager { get; set; }
        public SoftwareEngineer_details software_engineer { get; set; }
        public SoftwareEngineeringIntern_details software_engineering_intern { get; set; }
        public CertificationDetails Certification { get; set; }
        
        
        public class EducationDetails
        {
            public string course { get; set; }
            public string university { get; set; }
            public string yeargraduated { get; set; }
        }

        
        public class SeniorProjectManager_details
        {
                public string dtls1 { get; set; }
                public string dtls2 { get; set; }
                public string dtls3 { get; set; }
                public string dtls4 { get; set; }

        }
        public class SoftwareEngineer_details
        {
                public string dtls1 { get; set; }
                public string dtls2 { get; set; }
                public string dtls3 { get; set; }
        }
        public class SoftwareEngineeringIntern_details
        {
                public string dtls1 { get; set; }
                public string dtls2 { get; set; }
                public string dtls3 { get; set; }
        }
    
        public class CertificationDetails
        {
            public string cert1 { get; set; }
            public string cert2 { get; set; }
            public string cert3 { get; set; }
        }
    }
}
