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
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxCheck
            // 
            this.txtboxCheck.Enabled = false;
            this.txtboxCheck.Location = new System.Drawing.Point(34, 339);
            this.txtboxCheck.Multiline = true;
            this.txtboxCheck.Name = "txtboxCheck";
            this.txtboxCheck.Size = new System.Drawing.Size(798, 297);
            this.txtboxCheck.TabIndex = 0;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblResume.Font = new System.Drawing.Font("Docktrin", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResume.ForeColor = System.Drawing.Color.Thistle;
            this.lblResume.Location = new System.Drawing.Point(230, 18);
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
            this.lblCreate.Font = new System.Drawing.Font("Grand Aventure Text", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.ForeColor = System.Drawing.Color.Thistle;
            this.lblCreate.Location = new System.Drawing.Point(464, 112);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(125, 57);
            this.lblCreate.TabIndex = 3;
            this.lblCreate.Text = "CREATE";
            this.lblCreate.UseCompatibleTextRendering = true;
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(278, 217);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 51);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create my resume";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // formResumeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 663);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.txtboxCheck);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formResumeCreator";
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
        private Button btnCreate;
    }
}