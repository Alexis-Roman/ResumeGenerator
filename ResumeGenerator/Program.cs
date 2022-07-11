using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ResumeGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            static void Main(string[] args)
            {
                string filepath = GlobalVariable.resume;
                var resumeJsonText = File.ReadAllText(filepath);
                var resumedetails = JsonConvert.DeserializeObject<ResumeDetails>(resumeJsonText);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formResumeCreator());
        }
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