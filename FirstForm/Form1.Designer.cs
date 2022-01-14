
namespace FirstForm
{
    partial class Form1
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
            this.Lfname = new System.Windows.Forms.Label();
            this.llname = new System.Windows.Forms.Label();
            this.lage = new System.Windows.Forms.Label();
            this.lgender = new System.Windows.Forms.Label();
            this.ladresse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CBcountry = new System.Windows.Forms.ComboBox();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.lpersonnalinfo = new System.Windows.Forms.Label();
            this.Lprogramming = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lcountry = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lfname
            // 
            this.Lfname.AutoSize = true;
            this.Lfname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lfname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lfname.Location = new System.Drawing.Point(43, 66);
            this.Lfname.Name = "Lfname";
            this.Lfname.Size = new System.Drawing.Size(103, 17);
            this.Lfname.TabIndex = 1;
            this.Lfname.Text = "Your first name";
            // 
            // llname
            // 
            this.llname.AutoSize = true;
            this.llname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llname.Location = new System.Drawing.Point(43, 97);
            this.llname.Name = "llname";
            this.llname.Size = new System.Drawing.Size(105, 17);
            this.llname.TabIndex = 3;
            this.llname.Text = "Your Last Name";
            // 
            // lage
            // 
            this.lage.AutoSize = true;
            this.lage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lage.Location = new System.Drawing.Point(43, 129);
            this.lage.Name = "lage";
            this.lage.Size = new System.Drawing.Size(64, 17);
            this.lage.TabIndex = 4;
            this.lage.Text = "Your Age";
            // 
            // lgender
            // 
            this.lgender.AutoSize = true;
            this.lgender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lgender.Location = new System.Drawing.Point(43, 168);
            this.lgender.Name = "lgender";
            this.lgender.Size = new System.Drawing.Size(123, 17);
            this.lgender.TabIndex = 5;
            this.lgender.Text = "Select your gender";
            // 
            // ladresse
            // 
            this.ladresse.AutoSize = true;
            this.ladresse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ladresse.Location = new System.Drawing.Point(43, 230);
            this.ladresse.Name = "ladresse";
            this.ladresse.Size = new System.Drawing.Size(86, 17);
            this.ladresse.TabIndex = 6;
            this.ladresse.Text = "Your adresse";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(194, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(194, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 23);
            this.textBox4.TabIndex = 10;
            // 
            // CBcountry
            // 
            this.CBcountry.FormattingEnabled = true;
            this.CBcountry.Items.AddRange(new object[] {
            "Casablanca",
            "Mohammedia",
            "Rabat",
            "Fes",
            "Meknes",
            "Merrakech"});
            this.CBcountry.Location = new System.Drawing.Point(194, 270);
            this.CBcountry.Name = "CBcountry";
            this.CBcountry.Size = new System.Drawing.Size(165, 23);
            this.CBcountry.TabIndex = 11;
            this.CBcountry.Text = "-select your city-";
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(194, 168);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(51, 19);
            this.radioBtnMale.TabIndex = 12;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(194, 194);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(63, 19);
            this.radioBtnFemale.TabIndex = 13;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // lpersonnalinfo
            // 
            this.lpersonnalinfo.AutoSize = true;
            this.lpersonnalinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lpersonnalinfo.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lpersonnalinfo.ForeColor = System.Drawing.Color.Red;
            this.lpersonnalinfo.Location = new System.Drawing.Point(42, 9);
            this.lpersonnalinfo.Name = "lpersonnalinfo";
            this.lpersonnalinfo.Size = new System.Drawing.Size(262, 27);
            this.lpersonnalinfo.TabIndex = 15;
            this.lpersonnalinfo.Text = "Personnal Informations";
            // 
            // Lprogramming
            // 
            this.Lprogramming.AutoSize = true;
            this.Lprogramming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Lprogramming.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Lprogramming.ForeColor = System.Drawing.Color.Red;
            this.Lprogramming.Location = new System.Drawing.Point(498, 9);
            this.Lprogramming.Name = "Lprogramming";
            this.Lprogramming.Size = new System.Drawing.Size(220, 27);
            this.Lprogramming.TabIndex = 17;
            this.Lprogramming.Text = "About programming";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(498, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 19);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = ".NET C++\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(498, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 19);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = ".NET C#";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(498, 117);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 19);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = ".NET VS";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // lcountry
            // 
            this.lcountry.AutoSize = true;
            this.lcountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lcountry.Location = new System.Drawing.Point(43, 270);
            this.lcountry.Name = "lcountry";
            this.lcountry.Size = new System.Drawing.Size(62, 17);
            this.lcountry.TabIndex = 14;
            this.lcountry.Text = "Your city";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(498, 142);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 19);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = ".NET R";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Yellow;
            this.submit.Font = new System.Drawing.Font("Andalus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(358, 330);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(118, 47);
            this.submit.TabIndex = 23;
            this.submit.Tag = "";
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Lprogramming);
            this.Controls.Add(this.lpersonnalinfo);
            this.Controls.Add(this.lcountry);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.CBcountry);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ladresse);
            this.Controls.Add(this.lgender);
            this.Controls.Add(this.lage);
            this.Controls.Add(this.llname);
            this.Controls.Add(this.Lfname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lfname;
        private System.Windows.Forms.Label llname;
        private System.Windows.Forms.Label lage;
        private System.Windows.Forms.Label lgender;
        private System.Windows.Forms.Label ladresse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox CBcountry;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.Label lpersonnalinfo;
        private System.Windows.Forms.Label Lprogramming;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label lcountry;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button submit;
    }
}

