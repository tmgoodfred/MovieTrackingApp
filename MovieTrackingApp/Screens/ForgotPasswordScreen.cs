using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTrackingApp
{
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            codeLbl.Visible = true;
            codeTxt.Visible = true;
            sendEmailBtn.Text = "Submit";
        }
    }
}
