using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ResumeGenerator
{
    public partial class PDFFormat : Form
    {
            
        public PDFFormat()
        {
            InitializeComponent();
        }

        private void PDFFormat_Load(object sender, EventArgs e)
        {
            
            string filepath = GlobalVariable.resume;
            var resumeJsonText = File.ReadAllText(filepath);
            //WORKING EHEHEHE
            //Newtonsoft.Json.JsonReaderException: 'Unexpected character encountered
            //while parsing value: [. Path 'education', line 5, position 22.'

            var resumedetails = JsonConvert.DeserializeObject<ResumeDetails>(resumeJsonText);
            lblName.Text = resumedetails.Name;
            lblLocationContactEmail.Text = resumedetails.Location_contact_email;

            txtbxObjective.Text = resumedetails.Objective;
            lblSPM1.Text = "• " + resumedetails.senior_project_manager.dtls1;
            lblSPM2.Text = "• " + resumedetails.senior_project_manager.dtls2;
            lblSPM3.Text = "• " + resumedetails.senior_project_manager.dtls3;
            lblSPM4.Text = "• " + resumedetails.senior_project_manager.dtls4;
            
            lblSE1.Text = "• " + resumedetails.software_engineer.dtls1;
            lblSE2.Text = "• " + resumedetails.software_engineer.dtls2;
            lblSE3.Text = "• " + resumedetails.software_engineer.dtls3;

            lblSEI1.Text = "• " + resumedetails.software_engineering_intern.dtls1;
            lblSEI2.Text = "• " + resumedetails.software_engineering_intern.dtls2;
            lblSEI3.Text = "• " + resumedetails.software_engineering_intern.dtls3;

            lblCourse.Text = resumedetails.Education.course;
            lblUniversity.Text = resumedetails.Education.university;
            lblYearGraduated.Text = resumedetails.Education.yeargraduated;

            lblCert1.Text = "• " + resumedetails.Certification.cert1;
            lblCert2.Text = "• " + resumedetails.Certification.cert2;
            lblCert3.Text = "• " + resumedetails.Certification.cert3;
            //lblEducation.Text = resumedetails.Education.course;
            //lblExperience.Text = resumedetails.senior_project_manager.dtls1;
            //MessageBox.Show(resumedetails.Education.ToString());
            //lblEducation.Text = resumedetails.Education.course;
        }

        private void lblCert2_Click(object sender, EventArgs e)
        {

        }
    }
}
