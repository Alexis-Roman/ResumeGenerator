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
using iTextSharp.text;
using iTextSharp.text.pdf;

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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //create PDF
            Document pdfDoc = new Document(PageSize.A4, 50f, 50f, 60f, 60f);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, new FileStream
                (@"C:\Users\Nicole\Documents\ROMAN_ALEXIS NICOLE.pdf", FileMode.Create));
            pdfDoc.Open();

            //Fonts
            iTextSharp.text.Font nameFont = FontFactory.GetFont
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 28, iTextSharp.text.Font.BOLD,
                iTextSharp.text.BaseColor.BLACK);

            iTextSharp.text.Font contactFont = FontFactory.GetFont
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.BOLD, 
                iTextSharp.text.BaseColor.LIGHT_GRAY);

            iTextSharp.text.Font lbltitle = FontFactory.GetFont
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 13, iTextSharp.text.Font.BOLD,
                iTextSharp.text.BaseColor.BLACK);

            iTextSharp.text.Font lblexperience = FontFactory.GetFont
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.BOLD,
                iTextSharp.text.BaseColor.DARK_GRAY);

            iTextSharp.text.Font lblcourse = FontFactory.GetFont
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 13, iTextSharp.text.Font.BOLD,
                iTextSharp.text.BaseColor.BLACK);


            //Image
            System.Drawing.Image imgLinebar = System.Drawing.Image.FromFile
                (@"C:\Users\Nicole\Documents\linebar.png");
            iTextSharp.text.Image linebar = iTextSharp.text.Image.GetInstance
                (imgLinebar, System.Drawing.Imaging.ImageFormat.Png);

            //Add something to PDF
            Paragraph linebreak = new Paragraph(" ");
            //Name & contact info
            Paragraph name = new Paragraph(lblName.Text, nameFont);
            Paragraph location_contact_email = new Paragraph(lblLocationContactEmail.Text, contactFont);

            //Objective
            Paragraph lbl_objective = new Paragraph("Objective", lbltitle);
            Paragraph objective = new Paragraph(txtbxObjective.Text);

            //Experience
            Paragraph lbl_experience = new Paragraph("Experience", lbltitle);
                //SenProjMan
                Paragraph lbl_senprojman = new Paragraph("   Senior Project Manager", lblexperience);
                Paragraph lbl_SPM1 = new Paragraph("         "+lblSPM1.Text);
                Paragraph lbl_SPM2 = new Paragraph("         " + lblSPM2.Text);
                Paragraph lbl_SPM3 = new Paragraph("         " + lblSPM3.Text);
                Paragraph lbl_SPM4 = new Paragraph("         " + lblSPM4.Text);

                //SoftEngi
                Paragraph lbl_softengi = new Paragraph("   Software Engineer", lblexperience);
                Paragraph lbl_SE1 = new Paragraph("         " + lblSE1.Text);
                Paragraph lbl_SE2 = new Paragraph("         " + lblSE2.Text);
                Paragraph lbl_SE3 = new Paragraph("         " + lblSE3.Text);

                //SoftEngiInt
                Paragraph lbl_softengiint = new Paragraph("   Software Engineer Intern", lblexperience);
                Paragraph lbl_SEI1 = new Paragraph("         " + lblSEI1.Text);
                Paragraph lbl_SEI2 = new Paragraph("         " + lblSEI2.Text);
                Paragraph lbl_SEI3 = new Paragraph("         " + lblSEI3.Text);

            //Education
            Paragraph lbl_education = new Paragraph("Education", lbltitle);
            Paragraph course = new Paragraph("        " + lblCourse.Text, lblcourse);
            Paragraph university = new Paragraph("         " + lblUniversity.Text);
            Paragraph yeargraduated = new Paragraph("         " + lblYearGraduated.Text);

            //Certification
            Paragraph lbl_certification = new Paragraph("Certification", lbltitle);
            Paragraph cert1 = new Paragraph("     "+lblCert1.Text);
            Paragraph cert2 = new Paragraph("     " + lblCert2.Text);
            Paragraph cert3 = new Paragraph("     " + lblCert3.Text);

            //PDF LINES:
            pdfDoc.Add(name);
            pdfDoc.Add(location_contact_email);
            pdfDoc.Add(linebreak);
            //objective
            pdfDoc.Add(lbl_objective);
            pdfDoc.Add(linebar);
            pdfDoc.Add(linebreak);
            pdfDoc.Add(objective);
            pdfDoc.Add(linebreak);
            //experience
            pdfDoc.Add(lbl_experience);
            pdfDoc.Add(linebar);
            pdfDoc.Add(linebreak);
                pdfDoc.Add(lbl_senprojman);
                    pdfDoc.Add(lbl_SPM1);
                    pdfDoc.Add(lbl_SPM2);
                    pdfDoc.Add(lbl_SPM3);
                    pdfDoc.Add(lbl_SPM4);
                pdfDoc.Add(lbl_softengi);
                    pdfDoc.Add(lbl_SE1);
                    pdfDoc.Add(lbl_SE2);
                    pdfDoc.Add(lbl_SE3);
                pdfDoc.Add(lbl_softengiint);
                     pdfDoc.Add(lbl_SEI1);
                     pdfDoc.Add(lbl_SEI2);
                     pdfDoc.Add(lbl_SEI3);
            pdfDoc.Add(linebreak);
            //education
            pdfDoc.Add(lbl_education);
            pdfDoc.Add(linebar);
            pdfDoc.Add(course);
            pdfDoc.Add(university);
            pdfDoc.Add(yeargraduated);

            //certification
            pdfDoc.Add(lbl_certification);
            pdfDoc.Add(linebar);
            pdfDoc.Add(cert1);
            pdfDoc.Add(cert2);
            pdfDoc.Add(cert3);
            pdfDoc.Close();
        }
    }
}
