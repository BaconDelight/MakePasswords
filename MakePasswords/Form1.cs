using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;


namespace MakePasswords
{
    public partial class Form1 : Form
    {
        private int iNumWords = 0;

        public Form1()
        {
            InitializeComponent();

            ddCVCLength.SelectedIndex = 0;
            this.Size = new Size(750, 500);

            PasswordFunctions classPasswordFunctions = new PasswordFunctions();
            iNumWords = classPasswordFunctions.NumWords;

            lblNumWords.Text = "(" + iNumWords.ToString("#,###") + " Words)";

            SetWordPasswordEntropy();
            SetMixedPasswordEntropy();
            SetCVCPasswordEntropy();
        }


        private void btnMake_Click(object sender, EventArgs e)
        {
            PasswordFunctions classPasswordFunctions = new PasswordFunctions();
            if (!rbMixedPasswords.Checked && !rbWordPasswords.Checked && !rbCVCPasswords.Checked)
            {
                MessageBox.Show("Please choose a type of Password","Selection Needed");
                return;
            }

            textPasswords.Text = "";
            int numPasswords = (int)numPasswordsToMake.Value;
            string strWordPasswordPattern = "";

            // Validate Parameters for Mixed Character Passwords
            if (rbMixedPasswords.Checked)
            {
                if (!cbUpperCase.Checked && !cbLowerCase.Checked && !cbDigits.Checked && !cbSpecial.Checked)
                {
                    MessageBox.Show("Please select at least one set of Characters to use","Selection Needed");
                    return;
                }

                int iNumCharsets = 0;
                if (cbUpperCase.Checked) iNumCharsets++;
                if (cbLowerCase.Checked) iNumCharsets++;
                if (cbDigits.Checked) iNumCharsets++;
                if (cbSpecial.Checked) iNumCharsets++;

                if (iNumCharsets > numMixedLength.Value)
                {
                    MessageBox.Show("" +
                        "The program ensures that there will be at least one character " +
                        "from each selected character set in each result. You have " +
                        "selected " + iNumCharsets.ToString() + " Character Sets which means that it " +
                        " is not possible to do this with a Password length of " + numMixedLength.Value.ToString() + ". " +
                        "Please either reduce the number of selected character sets or " +
                        "increase the password length", "Constraint Clash");
                    return;
                }
            }

            
            // Validate Parameters for Word Passwords
            if (rbWordPasswords.Checked)
            {
                strWordPasswordPattern = "".PadRight((int)numWords.Value, 'W');
                strWordPasswordPattern += "".PadRight((int)numDigits.Value, 'D');
                strWordPasswordPattern += "".PadRight((int)numSpecial.Value, 'S');

                if (strWordPasswordPattern.Length == 0)
                {
                    MessageBox.Show("Word Passwords must have at least\n\rone Word, Digit or Special Character","Invalid Selection");
                    return;
                }
            }


            // Make passwords of the requested type
            for (int i = 0; i < numPasswords; i++)
            {
                if (i != 0)
                    textPasswords.Text += "\r\n";

                if (rbMixedPasswords.Checked)
                    textPasswords.Text += classPasswordFunctions.MakePasswordMixed(cbUpperCase.Checked, cbLowerCase.Checked, cbDigits.Checked, cbSpecial.Checked, (int)numMixedLength.Value);

                if (rbWordPasswords.Checked)
                    textPasswords.Text += classPasswordFunctions.MakePasswordWord(strWordPasswordPattern, cbRandom.Checked);

                if (rbCVCPasswords.Checked)
                    textPasswords.Text += classPasswordFunctions.MakePasswordCVC(Int32.Parse(ddCVCLength.SelectedItem.ToString()));
            }
        }


        private void MixedPasswordEntropy(object sender, EventArgs e)
        {
            SetMixedPasswordEntropy();
            rbMixedPasswords.Checked = true;
        }


        private void WordPasswordEntropy(object sender, EventArgs e)
        {
            SetWordPasswordEntropy();
            rbWordPasswords.Checked = true;
        }


        private void CVCPasswordEntropy(object sender, EventArgs e)
        {
            SetCVCPasswordEntropy();
            rbCVCPasswords.Checked = true;
        }


        private void SetWordPasswordEntropy()
        {
            double dblCombinations = Math.Pow(iNumWords, (double)numWords.Value) * Math.Pow(10, (double)numDigits.Value) * Math.Pow(30, (double)numSpecial.Value);

            if (cbRandom.Checked)
                dblCombinations = dblCombinations * (double)numWords.Value * (double)numDigits.Value * (double)numSpecial.Value;

            double dblEntropy10 = Math.Round(Math.Log10(dblCombinations) * 10) / 10;
            double dblEntropy2 = Math.Round(Math.Log(dblCombinations));

            lblEntropyWord.Text = "Entropy ~10^" + dblEntropy10.ToString("#.#") + " or 2^" + dblEntropy2;
        }


        private void SetMixedPasswordEntropy()
        {
            int iCharactersetSize = 0;

            if (cbUpperCase.Checked) iCharactersetSize += 26;
            if (cbLowerCase.Checked) iCharactersetSize += 26;
            if (cbDigits.Checked) iCharactersetSize += 10;
            if (cbSpecial.Checked) iCharactersetSize += 30;

            if (iCharactersetSize == 0)
                lblEntropyMixed.Text = "";
            else
            {
                double dblCombinations = Math.Pow(iCharactersetSize, (double)numMixedLength.Value);

                double dblEntropy10 = Math.Round(Math.Log10(dblCombinations) * 10) / 10;
                double dblEntropy2 = Math.Round(Math.Log(dblCombinations));

                lblEntropyMixed.Text = "Entropy ~10^" + dblEntropy10.ToString("#.#") + " or 2^" + dblEntropy2;
            }
        }


        private void SetCVCPasswordEntropy()
        {
            double dblCombinations = Math.Pow(21 * 5 * 21, double.Parse(ddCVCLength.SelectedItem.ToString()) / 3);

            double dblEntropy10 = Math.Round(Math.Log10(dblCombinations) * 10) / 10;
            double dblEntropy2 = Math.Round(Math.Log(dblCombinations));

            lblEntropyCVC.Text = "Entropy ~10^" + dblEntropy10.ToString("#.#") + " or 2^" + dblEntropy2;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the passwords
            if (textPasswords.Text.Trim().Length == 0)
            {
                MessageBox.Show("No Passwords to Save","No Paswords Made");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save Passwords to a File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Save Data
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                writer.Write(textPasswords.Text);
                writer.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\BaconDelight\MakePasswords");
            if (key != null)
            {
                int width = int.Parse(key.GetValue("Width").ToString());
                int height = int.Parse(key.GetValue("Height").ToString());
                this.Size = new Size(width, height);

                cbUpperCase.Checked = key.GetValue("UpperCase").ToString() == "True";
                cbLowerCase.Checked = key.GetValue("LowerCase").ToString() == "True";
                cbDigits.Checked = key.GetValue("Digits").ToString() == "True";
                cbSpecial.Checked = key.GetValue("Special").ToString() == "True";
                cbRandom.Checked = key.GetValue("Random").ToString() == "True";

                numMixedLength.Value = int.Parse(key.GetValue("PasswordLength").ToString());
                numWords.Value = int.Parse(key.GetValue("numWords").ToString());
                numDigits.Value = int.Parse(key.GetValue("numDigits").ToString());
                numSpecial.Value = int.Parse(key.GetValue("numSpecials").ToString());
                numPasswordsToMake.Value = int.Parse(key.GetValue("numPasswords").ToString());

                ddCVCLength.SelectedIndex = int.Parse(key.GetValue("CVCLengthIndex").ToString());

                int iPasswordType = int.Parse(key.GetValue("PasswordType").ToString());

                if (iPasswordType == 1) rbMixedPasswords.Checked = true;
                if (iPasswordType == 2) rbWordPasswords.Checked = true;
                if (iPasswordType == 3) rbCVCPasswords.Checked = true;
            }
        }


        private void Form1_FormClosing(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BaconDelight\MakePasswords");
            key.SetValue("Width", this.Width);
            key.SetValue("Height", this.Height);

            int iPasswordType = 0;

            if (rbMixedPasswords.Checked) iPasswordType = 1;
            if (rbWordPasswords.Checked) iPasswordType = 2;
            if (rbCVCPasswords.Checked) iPasswordType = 3;

            key.SetValue("PasswordType", iPasswordType);

            key.SetValue("UpperCase", cbUpperCase.Checked);
            key.SetValue("LowerCase", cbLowerCase.Checked);
            key.SetValue("Digits", cbDigits.Checked);
            key.SetValue("Special", cbSpecial.Checked);

            key.SetValue("Random", cbRandom.Checked);

            key.SetValue("PasswordLength", numMixedLength.Value);
            key.SetValue("numWords", numWords.Value);
            key.SetValue("numDigits", numDigits.Value);
            key.SetValue("numSpecials", numSpecial.Value);
            key.SetValue("numPasswords", numPasswordsToMake.Value);

            key.SetValue("CVCLengthIndex", ddCVCLength.SelectedIndex);

            key.Close();
        }


        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
    }
}
