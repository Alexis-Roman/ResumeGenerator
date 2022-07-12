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
            txtbxObjective.Text = resumedetails.Objective;
            lblCertification.Text = resumedetails.Certification;
        }
    }
}
