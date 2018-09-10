namespace MakePasswords
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
            this.btnMake = new System.Windows.Forms.Button();
            this.textPasswords = new System.Windows.Forms.TextBox();
            this.rbMixedPasswords = new System.Windows.Forms.RadioButton();
            this.rbWordPasswords = new System.Windows.Forms.RadioButton();
            this.rbCVCPasswords = new System.Windows.Forms.RadioButton();
            this.cbUpperCase = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.cbDigits = new System.Windows.Forms.CheckBox();
            this.cbLowerCase = new System.Windows.Forms.CheckBox();
            this.numMixedLength = new System.Windows.Forms.NumericUpDown();
            this.numSpecial = new System.Windows.Forms.NumericUpDown();
            this.numDigits = new System.Windows.Forms.NumericUpDown();
            this.numWords = new System.Windows.Forms.NumericUpDown();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.ddCVCLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numPasswordsToMake = new System.Windows.Forms.NumericUpDown();
            this.lblEntropyMixed = new System.Windows.Forms.Label();
            this.lblNumWords = new System.Windows.Forms.Label();
            this.lblEntropyWord = new System.Windows.Forms.Label();
            this.lblEntropyCVC = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numMixedLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordsToMake)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMake.Location = new System.Drawing.Point(1442, 112);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(199, 108);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // textPasswords
            // 
            this.textPasswords.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswords.Location = new System.Drawing.Point(80, 48);
            this.textPasswords.Multiline = true;
            this.textPasswords.Name = "textPasswords";
            this.textPasswords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPasswords.Size = new System.Drawing.Size(1173, 457);
            this.textPasswords.TabIndex = 1;
            // 
            // rbMixedPasswords
            // 
            this.rbMixedPasswords.AutoSize = true;
            this.rbMixedPasswords.Location = new System.Drawing.Point(86, 565);
            this.rbMixedPasswords.Name = "rbMixedPasswords";
            this.rbMixedPasswords.Size = new System.Drawing.Size(418, 36);
            this.rbMixedPasswords.TabIndex = 3;
            this.rbMixedPasswords.TabStop = true;
            this.rbMixedPasswords.Text = "Mixed Characters Passwords";
            this.rbMixedPasswords.UseVisualStyleBackColor = true;
            // 
            // rbWordPasswords
            // 
            this.rbWordPasswords.AutoSize = true;
            this.rbWordPasswords.Checked = true;
            this.rbWordPasswords.Location = new System.Drawing.Point(1001, 563);
            this.rbWordPasswords.Name = "rbWordPasswords";
            this.rbWordPasswords.Size = new System.Drawing.Size(264, 36);
            this.rbWordPasswords.TabIndex = 4;
            this.rbWordPasswords.TabStop = true;
            this.rbWordPasswords.Text = "Word Passwords";
            this.rbWordPasswords.UseVisualStyleBackColor = true;
            // 
            // rbCVCPasswords
            // 
            this.rbCVCPasswords.AutoSize = true;
            this.rbCVCPasswords.Location = new System.Drawing.Point(1009, 920);
            this.rbCVCPasswords.Name = "rbCVCPasswords";
            this.rbCVCPasswords.Size = new System.Drawing.Size(256, 36);
            this.rbCVCPasswords.TabIndex = 5;
            this.rbCVCPasswords.TabStop = true;
            this.rbCVCPasswords.Text = "CVC Passwords";
            this.rbCVCPasswords.UseVisualStyleBackColor = true;
            // 
            // cbUpperCase
            // 
            this.cbUpperCase.AutoSize = true;
            this.cbUpperCase.Checked = true;
            this.cbUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperCase.Location = new System.Drawing.Point(135, 629);
            this.cbUpperCase.Name = "cbUpperCase";
            this.cbUpperCase.Size = new System.Drawing.Size(377, 36);
            this.cbUpperCase.TabIndex = 6;
            this.cbUpperCase.Text = "Upper Case Letters     A-Z";
            this.cbUpperCase.UseVisualStyleBackColor = true;
            this.cbUpperCase.CheckedChanged += new System.EventHandler(this.MixedPasswordEntropy);
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Checked = true;
            this.cbSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecial.Location = new System.Drawing.Point(135, 795);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(679, 36);
            this.cbSpecial.TabIndex = 7;
            this.cbSpecial.Text = "Special Characters     !\"#$%&\'()*+,-.:;<=>?@[\\]^_{|}~";
            this.cbSpecial.UseVisualStyleBackColor = true;
            this.cbSpecial.CheckedChanged += new System.EventHandler(this.MixedPasswordEntropy);
            // 
            // cbDigits
            // 
            this.cbDigits.AutoSize = true;
            this.cbDigits.Checked = true;
            this.cbDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDigits.Location = new System.Drawing.Point(135, 738);
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.Size = new System.Drawing.Size(201, 36);
            this.cbDigits.TabIndex = 8;
            this.cbDigits.Text = "Digits     0-9";
            this.cbDigits.UseVisualStyleBackColor = true;
            this.cbDigits.CheckedChanged += new System.EventHandler(this.MixedPasswordEntropy);
            // 
            // cbLowerCase
            // 
            this.cbLowerCase.AutoSize = true;
            this.cbLowerCase.Checked = true;
            this.cbLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowerCase.Location = new System.Drawing.Point(135, 687);
            this.cbLowerCase.Name = "cbLowerCase";
            this.cbLowerCase.Size = new System.Drawing.Size(363, 38);
            this.cbLowerCase.TabIndex = 9;
            this.cbLowerCase.Text = "Lower Case Letters     a-z";
            this.cbLowerCase.UseCompatibleTextRendering = true;
            this.cbLowerCase.UseVisualStyleBackColor = true;
            this.cbLowerCase.CheckedChanged += new System.EventHandler(this.MixedPasswordEntropy);
            // 
            // numMixedLength
            // 
            this.numMixedLength.Location = new System.Drawing.Point(135, 859);
            this.numMixedLength.Name = "numMixedLength";
            this.numMixedLength.Size = new System.Drawing.Size(148, 38);
            this.numMixedLength.TabIndex = 10;
            this.numMixedLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMixedLength.ValueChanged += new System.EventHandler(this.MixedPasswordEntropy);
            // 
            // numSpecial
            // 
            this.numSpecial.Location = new System.Drawing.Point(1058, 747);
            this.numSpecial.Name = "numSpecial";
            this.numSpecial.Size = new System.Drawing.Size(150, 38);
            this.numSpecial.TabIndex = 11;
            this.numSpecial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpecial.ValueChanged += new System.EventHandler(this.WordPasswordEntropy);
            // 
            // numDigits
            // 
            this.numDigits.Location = new System.Drawing.Point(1058, 688);
            this.numDigits.Name = "numDigits";
            this.numDigits.Size = new System.Drawing.Size(148, 38);
            this.numDigits.TabIndex = 12;
            this.numDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDigits.ValueChanged += new System.EventHandler(this.WordPasswordEntropy);
            // 
            // numWords
            // 
            this.numWords.Location = new System.Drawing.Point(1058, 627);
            this.numWords.Name = "numWords";
            this.numWords.Size = new System.Drawing.Size(148, 38);
            this.numWords.TabIndex = 13;
            this.numWords.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWords.ValueChanged += new System.EventHandler(this.WordPasswordEntropy);
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(1058, 812);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(239, 36);
            this.cbRandom.TabIndex = 14;
            this.cbRandom.Text = "Random Order";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.WordPasswordEntropy);
            // 
            // ddCVCLength
            // 
            this.ddCVCLength.FormattingEnabled = true;
            this.ddCVCLength.Items.AddRange(new object[] {
            "9",
            "12",
            "15",
            "18"});
            this.ddCVCLength.Location = new System.Drawing.Point(1058, 983);
            this.ddCVCLength.Name = "ddCVCLength";
            this.ddCVCLength.Size = new System.Drawing.Size(181, 39);
            this.ddCVCLength.TabIndex = 15;
            this.ddCVCLength.SelectedIndexChanged += new System.EventHandler(this.CVCPasswordEntropy);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1284, 983);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 859);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1284, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Number of Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1284, 694);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Number of Digits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1284, 753);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Number of Special Characters";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1442, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 108);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 995);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number of Passwords to Make";
            // 
            // numPasswordsToMake
            // 
            this.numPasswordsToMake.Location = new System.Drawing.Point(78, 989);
            this.numPasswordsToMake.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPasswordsToMake.Name = "numPasswordsToMake";
            this.numPasswordsToMake.Size = new System.Drawing.Size(150, 38);
            this.numPasswordsToMake.TabIndex = 22;
            this.numPasswordsToMake.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblEntropyMixed
            // 
            this.lblEntropyMixed.AutoSize = true;
            this.lblEntropyMixed.Location = new System.Drawing.Point(535, 569);
            this.lblEntropyMixed.Name = "lblEntropyMixed";
            this.lblEntropyMixed.Size = new System.Drawing.Size(93, 32);
            this.lblEntropyMixed.TabIndex = 24;
            this.lblEntropyMixed.Text = "label7";
            // 
            // lblNumWords
            // 
            this.lblNumWords.AutoSize = true;
            this.lblNumWords.Location = new System.Drawing.Point(1274, 566);
            this.lblNumWords.Name = "lblNumWords";
            this.lblNumWords.Size = new System.Drawing.Size(93, 32);
            this.lblNumWords.TabIndex = 25;
            this.lblNumWords.Text = "label8";
            // 
            // lblEntropyWord
            // 
            this.lblEntropyWord.AutoSize = true;
            this.lblEntropyWord.Location = new System.Drawing.Point(1500, 567);
            this.lblEntropyWord.Name = "lblEntropyWord";
            this.lblEntropyWord.Size = new System.Drawing.Size(93, 32);
            this.lblEntropyWord.TabIndex = 26;
            this.lblEntropyWord.Text = "label9";
            // 
            // lblEntropyCVC
            // 
            this.lblEntropyCVC.AutoSize = true;
            this.lblEntropyCVC.Location = new System.Drawing.Point(1306, 924);
            this.lblEntropyCVC.Name = "lblEntropyCVC";
            this.lblEntropyCVC.Size = new System.Drawing.Size(109, 32);
            this.lblEntropyCVC.TabIndex = 27;
            this.lblEntropyCVC.Text = "label10";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1852, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAbout.Location = new System.Drawing.Point(1488, 420);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(102, 39);
            this.lnkAbout.TabIndex = 29;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "about";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 1112);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.lblEntropyCVC);
            this.Controls.Add(this.lblEntropyWord);
            this.Controls.Add(this.lblNumWords);
            this.Controls.Add(this.lblEntropyMixed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPasswordsToMake);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddCVCLength);
            this.Controls.Add(this.cbRandom);
            this.Controls.Add(this.numWords);
            this.Controls.Add(this.numDigits);
            this.Controls.Add(this.numSpecial);
            this.Controls.Add(this.numMixedLength);
            this.Controls.Add(this.cbLowerCase);
            this.Controls.Add(this.cbDigits);
            this.Controls.Add(this.cbSpecial);
            this.Controls.Add(this.cbUpperCase);
            this.Controls.Add(this.rbCVCPasswords);
            this.Controls.Add(this.rbWordPasswords);
            this.Controls.Add(this.rbMixedPasswords);
            this.Controls.Add(this.textPasswords);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 1200);
            this.Name = "Form1";
            this.Text = "Make Passwords v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMixedLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpecial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordsToMake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox textPasswords;
        private System.Windows.Forms.RadioButton rbMixedPasswords;
        private System.Windows.Forms.RadioButton rbWordPasswords;
        private System.Windows.Forms.RadioButton rbCVCPasswords;
        private System.Windows.Forms.CheckBox cbUpperCase;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbDigits;
        private System.Windows.Forms.CheckBox cbLowerCase;
        private System.Windows.Forms.NumericUpDown numMixedLength;
        private System.Windows.Forms.NumericUpDown numSpecial;
        private System.Windows.Forms.NumericUpDown numDigits;
        private System.Windows.Forms.NumericUpDown numWords;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.ComboBox ddCVCLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPasswordsToMake;
        private System.Windows.Forms.Label lblEntropyMixed;
        private System.Windows.Forms.Label lblNumWords;
        private System.Windows.Forms.Label lblEntropyWord;
        private System.Windows.Forms.Label lblEntropyCVC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.LinkLabel lnkAbout;
    }
}

