﻿using System;
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
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 25, iTextSharp.text.Font.BOLD);

            iTextSharp.text.Font contactFont = FontFactory.GetFont
                (iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.BOLD, 
                iTextSharp.text.BaseColor.DARK_GRAY);

            //Image
            System.Drawing.Image imgLinebar = System.Drawing.Image.FromFile
                (@"C:\Users\Nicole\Documents\linebar.png");
            iTextSharp.text.Image linebar = iTextSharp.text.Image.GetInstance
                (imgLinebar, System.Drawing.Imaging.ImageFormat.Png);
            
            //linebar.Alignment = Element.ALIGN_CENTER;

            //Add something to PDF
            Paragraph linebreak = new Paragraph(" ");
            //Name & contact info
            Paragraph name = new Paragraph(lblName.Text, nameFont);
            Paragraph location_contact_email = new Paragraph(lblLocationContactEmail.Text, contactFont);

            //Objective
            Paragraph lbl_objective = new Paragraph("Objective");
            Paragraph objective = new Paragraph(txtbxObjective.Text);
            //Experience
            //SenProjMan

            //SoftEngi

            //SoftEngiInt

            //Education

            //Certification

            //PDF LINES:
            pdfDoc.Add(name);
            pdfDoc.Add(location_contact_email);
            pdfDoc.Add(linebreak);
            
            pdfDoc.Add(lbl_objective);
            pdfDoc.Add(linebar);
            pdfDoc.Add(objective);
            pdfDoc.Close();
        }
    }
}
