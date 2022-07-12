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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formResumeCreator());
            
        }
    }

    public class ResumeDetails
    {

        public string Name { get; set; }
        public string Location_contact_email { get; set; }
        public string Objective { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Certification { get; set; }

    }
}