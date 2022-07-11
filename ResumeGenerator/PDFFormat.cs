using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
