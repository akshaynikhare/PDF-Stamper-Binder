using System;
using System.Windows.Forms;

namespace PDFStamperBinder
{
    public partial class inputBox : Form
    {
        internal string input = "";

        public inputBox(string inputlabel = "Enter someting")
        {
            InitializeComponent();
            label1.Text = inputlabel;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            input = inputtb.Text;
            this.Close();
        }
    }
}