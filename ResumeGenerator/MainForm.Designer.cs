namespace ResumeGenerator
{
    partial class formResumeCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxCheck = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCreate = new System.Windows.Forms.Label();
            this.btnCreateResume = new System.Windows.Forms.Button();
            this.opnFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Enabled = false;
            this.txtboxCheck.Location = new System.Drawing.Point(34, 339);
            this.txtboxCheck.Multiline = true;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxCheck.Size = new System.Drawing.Size(798, 297);
            this.txtboxCheck.TabIndex = 0;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblResume.Font = new System.Drawing.Font("Docktrin", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResume.ForeColor = System.Drawing.Color.Thistle;
            this.lblResume.Location = new System.Drawing.Point(244, 9);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(370, 164);
            this.lblResume.TabIndex = 1;
            this.lblResume.Text = "RESUME";
            this.lblResume.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 313);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblCreate.Font = new System.Drawing.Font("Grand Aventure Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.ForeColor = System.Drawing.Color.Thistle;
            this.lblCreate.Location = new System.Drawing.Point(477, 99);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(122, 56);
            this.lblCreate.TabIndex = 3;
            this.lblCreate.Text = "CREATE";
            this.lblCreate.UseCompatibleTextRendering = true;
            // 
            // btnCreateResume
            // 
            this.btnCreateResume.FlatAppearance.BorderSize = 0;
            this.btnCreateResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateResume.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateResume.ForeColor = System.Drawing.Color.White;
            this.btnCreateResume.Location = new System.Drawing.Point(450, 242);
            this.btnCreateResume.Name = "btnCreateResume";
            this.btnCreateResume.Size = new System.Drawing.Size(280, 51);
            this.btnCreateResume.TabIndex = 4;
            this.btnCreateResume.Text = "Create my resume";
            this.btnCreateResume.UseVisualStyleBackColor = true;
            this.btnCreateResume.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // opnFileDlg
            // 
            this.opnFileDlg.FileName = "opnFileDlg";
            this.opnFileDlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblDescription.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(181, 173);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(539, 40);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Welcome to Resume Create! Please choose a .json file \r\n      to generate your res" +
    "ume in .pdf format";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(143, 242);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(280, 51);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "SELECT FILE";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // formResumeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 663);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCreateResume);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.txtboxCheck);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formResumeCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtboxCheck;
        private Label lblResume;
        private PictureBox pictureBox1;
        private Label lblCreate;
        private Button btnCreateResume;
        private OpenFileDialog opnFileDlg;
        private Label lblDescription;
        private Button btnSelectFile;
    }
}