namespace ResumeGenerator
{
    public partial class formResumeCreator : Form
    {
        public formResumeCreator()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string resume;

            opnFileDlg.Filter = "JSON files|*.json";
            opnFileDlg.Title = "Open .json file";
            opnFileDlg.ShowDialog();

            resume = opnFileDlg.FileName;
            
        }
    }
} 