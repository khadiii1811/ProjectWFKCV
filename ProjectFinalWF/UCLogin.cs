using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalWF
{
    public partial class UCLogin : UserControl
    {
        private Form parentForm;
        public UCLogin()
        {
            InitializeComponent();
        
        }
        

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }
        public void SetParentForm(Form form)
        {
            parentForm = form;
        }
        private void linklblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            parentForm.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
            parentForm.Close();
        }
    }
}
