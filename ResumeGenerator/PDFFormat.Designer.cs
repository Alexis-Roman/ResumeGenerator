namespace ResumeGenerator
{
    partial class PDFFormat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblCertification = new System.Windows.Forms.Label();
            this.txtbxObjective = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(502, 757);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Location = new System.Drawing.Point(29, 130);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(70, 20);
            this.lblObjective.TabIndex = 2;
            this.lblObjective.Text = "objective";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(23, 254);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(75, 20);
            this.lblEducation.TabIndex = 3;
            this.lblEducation.Text = "education";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(23, 446);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(81, 20);
            this.lblExperience.TabIndex = 4;
            this.lblExperience.Text = "experience";
            // 
            // lblCertification
            // 
            this.lblCertification.AutoSize = true;
            this.lblCertification.Location = new System.Drawing.Point(23, 692);
            this.lblCertification.Name = "lblCertification";
            this.lblCertification.Size = new System.Drawing.Size(90, 20);
            this.lblCertification.TabIndex = 5;
            this.lblCertification.Text = "Certification";
            // 
            // txtbxObjective
            // 
            this.txtbxObjective.Location = new System.Drawing.Point(254, 107);
            this.txtbxObjective.Multiline = true;
            this.txtbxObjective.Name = "txtbxObjective";
            this.txtbxObjective.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxObjective.Size = new System.Drawing.Size(221, 240);
            this.txtbxObjective.TabIndex = 6;
            // 
            // PDFFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 798);
            this.Controls.Add(this.txtbxObjective);
            this.Controls.Add(this.lblCertification);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblName);
            this.Name = "PDFFormat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF Format";
            this.Load += new System.EventHandler(this.PDFFormat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Button btnCreate;
        private Label lblObjective;
        private Label lblEducation;
        private Label lblExperience;
        private Label lblCertification;
        private TextBox txtbxObjective;
    }
}