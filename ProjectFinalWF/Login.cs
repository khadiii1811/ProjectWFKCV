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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ucLogin1.SetParentForm(this);
        }
        public void CloseForm1()
        {
            this.Close();
        }
    }
}
