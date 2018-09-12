using System;
using System.Windows.Forms;

namespace MakePasswords
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Label2.Text = "MakePasswords " + Program.strVersion;
        }

        private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.\r\n\"" + ex.Message + "\"");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            LinkLabel1.LinkVisited = true;

            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("https://github.com/BaconDelight/MakePasswords");
        }
    }
}
