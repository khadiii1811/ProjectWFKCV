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
    public partial class UCNavigator : UserControl
    {
        bool navigationExpand;
        private Form parentForm;
        public UCNavigator()
        {
            InitializeComponent();
        }
        private Form GetParentForm()
        {
            // Lặp qua tất cả các control cha cho đến khi tìm thấy một Form
            Control parent = this.Parent;
            while (parent != null && !(parent is Form))
            {
                parent = parent.Parent;
            }

            return parent as Form;
        }
        private void flpNavigation_Tick(object sender, EventArgs e)
        {
            if (navigationExpand)
            {
                flpNavigation.Width -= 10;
                if (flpNavigation.Width == flpNavigation.MinimumSize.Width)
                {
                    navigationExpand = false;
                    navigationtimer.Stop();
                }

            }
            else
            {
                flpNavigation.Width += 10;
                if (flpNavigation.Width == flpNavigation.MaximumSize.Width)
                {
                    navigationExpand = true;
                    navigationtimer.Stop();
                }
            }
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form parentForm = GetParentForm();
            if (parentForm != null)
            {
                parentForm.Hide();
                Login loginForm = new Login();
                loginForm.ShowDialog(parentForm);
                parentForm.Close();
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }

        }

       

        private void PcbMenu_Click_1(object sender, EventArgs e)
        {
            navigationtimer.Start();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Form parentForm = GetParentForm();
            if (parentForm != null)
            {
                parentForm.Hide();
                Home homeForm = new Home();
                homeForm.ShowDialog();
                parentForm.Close();
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }
        }
    }
}
