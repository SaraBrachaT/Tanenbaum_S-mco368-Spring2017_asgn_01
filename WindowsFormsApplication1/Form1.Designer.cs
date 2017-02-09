namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.naturalBornChkbx = new System.Windows.Forms.CheckBox();
            this.birthdayLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.residentYearsLbl1 = new System.Windows.Forms.Label();
            this.residentYearsLbl2 = new System.Windows.Forms.Label();
            this.termsNumLbl1 = new System.Windows.Forms.Label();
            this.termsNumLbl2 = new System.Windows.Forms.Label();
            this.residentYrsTxtbx = new System.Windows.Forms.TextBox();
            this.numTermsTxtbx = new System.Windows.Forms.TextBox();
            this.impeachedChkbx = new System.Windows.Forms.CheckBox();
            this.rebelliousChkbx = new System.Windows.Forms.CheckBox();
            this.impeachmentNoticeLbl = new System.Windows.Forms.Label();
            this.eligibilityCheckerBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(26, 14);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(236, 13);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to the Presidential Eligibility Application";
            // 
            // naturalBornChkbx
            // 
            this.naturalBornChkbx.AutoSize = true;
            this.naturalBornChkbx.Location = new System.Drawing.Point(14, 38);
            this.naturalBornChkbx.Name = "naturalBornChkbx";
            this.naturalBornChkbx.Size = new System.Drawing.Size(147, 17);
            this.naturalBornChkbx.TabIndex = 1;
            this.naturalBornChkbx.Text = "I am a natural born citizen";
            this.naturalBornChkbx.UseVisualStyleBackColor = true;
            this.naturalBornChkbx.CheckedChanged += new System.EventHandler(this.naturalBornChkbx_CheckedChanged);
            // 
            // birthdayLbl
            // 
            this.birthdayLbl.AutoSize = true;
            this.birthdayLbl.Location = new System.Drawing.Point(9, 64);
            this.birthdayLbl.Name = "birthdayLbl";
            this.birthdayLbl.Size = new System.Drawing.Size(71, 13);
            this.birthdayLbl.TabIndex = 2;
            this.birthdayLbl.Text = "My birthday is";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // residentYearsLbl1
            // 
            this.residentYearsLbl1.AutoSize = true;
            this.residentYearsLbl1.Location = new System.Drawing.Point(9, 91);
            this.residentYearsLbl1.Name = "residentYearsLbl1";
            this.residentYearsLbl1.Size = new System.Drawing.Size(109, 13);
            this.residentYearsLbl1.TabIndex = 4;
            this.residentYearsLbl1.Text = "I resided in the US for";
            // 
            // residentYearsLbl2
            // 
            this.residentYearsLbl2.AutoSize = true;
            this.residentYearsLbl2.Location = new System.Drawing.Point(205, 91);
            this.residentYearsLbl2.Name = "residentYearsLbl2";
            this.residentYearsLbl2.Size = new System.Drawing.Size(32, 13);
            this.residentYearsLbl2.TabIndex = 5;
            this.residentYearsLbl2.Text = "years";
            // 
            // termsNumLbl1
            // 
            this.termsNumLbl1.AutoSize = true;
            this.termsNumLbl1.Location = new System.Drawing.Point(9, 117);
            this.termsNumLbl1.Name = "termsNumLbl1";
            this.termsNumLbl1.Size = new System.Drawing.Size(120, 13);
            this.termsNumLbl1.TabIndex = 6;
            this.termsNumLbl1.Text = "I served as president for";
            // 
            // termsNumLbl2
            // 
            this.termsNumLbl2.AutoSize = true;
            this.termsNumLbl2.Location = new System.Drawing.Point(216, 117);
            this.termsNumLbl2.Name = "termsNumLbl2";
            this.termsNumLbl2.Size = new System.Drawing.Size(32, 13);
            this.termsNumLbl2.TabIndex = 7;
            this.termsNumLbl2.Text = "terms";
            // 
            // residentYrsTxtbx
            // 
            this.residentYrsTxtbx.Location = new System.Drawing.Point(124, 88);
            this.residentYrsTxtbx.MaxLength = 3;
            this.residentYrsTxtbx.Name = "residentYrsTxtbx";
            this.residentYrsTxtbx.Size = new System.Drawing.Size(75, 20);
            this.residentYrsTxtbx.TabIndex = 8;
            this.residentYrsTxtbx.TextChanged += new System.EventHandler(this.residentYrsTxtbx_TextChanged);
            // 
            // numTermsTxtbx
            // 
            this.numTermsTxtbx.Location = new System.Drawing.Point(135, 114);
            this.numTermsTxtbx.Name = "numTermsTxtbx";
            this.numTermsTxtbx.Size = new System.Drawing.Size(75, 20);
            this.numTermsTxtbx.TabIndex = 9;
            this.numTermsTxtbx.TextChanged += new System.EventHandler(this.numTermsTxtbx_TextChanged);
            // 
            // impeachedChkbx
            // 
            this.impeachedChkbx.AutoSize = true;
            this.impeachedChkbx.Location = new System.Drawing.Point(12, 139);
            this.impeachedChkbx.Name = "impeachedChkbx";
            this.impeachedChkbx.Size = new System.Drawing.Size(106, 17);
            this.impeachedChkbx.TabIndex = 10;
            this.impeachedChkbx.Text = "I was impeached";
            this.impeachedChkbx.UseVisualStyleBackColor = true;
            this.impeachedChkbx.CheckedChanged += new System.EventHandler(this.impeachedChkbx_CheckedChanged);
            // 
            // rebelliousChkbx
            // 
            this.rebelliousChkbx.AutoSize = true;
            this.rebelliousChkbx.Location = new System.Drawing.Point(12, 201);
            this.rebelliousChkbx.Name = "rebelliousChkbx";
            this.rebelliousChkbx.Size = new System.Drawing.Size(201, 17);
            this.rebelliousChkbx.TabIndex = 11;
            this.rebelliousChkbx.Text = "I rebelled against the US government";
            this.rebelliousChkbx.UseVisualStyleBackColor = true;
            this.rebelliousChkbx.CheckedChanged += new System.EventHandler(this.rebelliousChkbx_CheckedChanged);
            // 
            // impeachmentNoticeLbl
            // 
            this.impeachmentNoticeLbl.AutoSize = true;
            this.impeachmentNoticeLbl.Location = new System.Drawing.Point(26, 159);
            this.impeachmentNoticeLbl.Name = "impeachmentNoticeLbl";
            this.impeachmentNoticeLbl.Size = new System.Drawing.Size(206, 39);
            this.impeachmentNoticeLbl.TabIndex = 12;
            this.impeachmentNoticeLbl.Text = "Notice: Although impeachment does not \r\nnecessarily disqualify one from presidenc" +
    "y,\r\nit can. Therefore, in this application, it will.";
            // 
            // eligibilityCheckerBtn
            // 
            this.eligibilityCheckerBtn.Location = new System.Drawing.Point(78, 226);
            this.eligibilityCheckerBtn.Name = "eligibilityCheckerBtn";
            this.eligibilityCheckerBtn.Size = new System.Drawing.Size(121, 23);
            this.eligibilityCheckerBtn.TabIndex = 13;
            this.eligibilityCheckerBtn.Text = "Check if I am Eligible!";
            this.eligibilityCheckerBtn.UseVisualStyleBackColor = true;
            this.eligibilityCheckerBtn.Click += new System.EventHandler(this.eligibilityCheckerBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(8, 226);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 18);
            this.resultLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.eligibilityCheckerBtn);
            this.Controls.Add(this.impeachmentNoticeLbl);
            this.Controls.Add(this.rebelliousChkbx);
            this.Controls.Add(this.impeachedChkbx);
            this.Controls.Add(this.numTermsTxtbx);
            this.Controls.Add(this.residentYrsTxtbx);
            this.Controls.Add(this.termsNumLbl2);
            this.Controls.Add(this.termsNumLbl1);
            this.Controls.Add(this.residentYearsLbl2);
            this.Controls.Add(this.residentYearsLbl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.birthdayLbl);
            this.Controls.Add(this.naturalBornChkbx);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Presidential Eligibility Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.CheckBox naturalBornChkbx;
        private System.Windows.Forms.Label birthdayLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label residentYearsLbl1;
        private System.Windows.Forms.Label residentYearsLbl2;
        private System.Windows.Forms.Label termsNumLbl1;
        private System.Windows.Forms.Label termsNumLbl2;
        private System.Windows.Forms.TextBox residentYrsTxtbx;
        private System.Windows.Forms.TextBox numTermsTxtbx;
        private System.Windows.Forms.CheckBox impeachedChkbx;
        private System.Windows.Forms.CheckBox rebelliousChkbx;
        private System.Windows.Forms.Label impeachmentNoticeLbl;
        private System.Windows.Forms.Button eligibilityCheckerBtn;
        private System.Windows.Forms.Label resultLabel;
    }
}

