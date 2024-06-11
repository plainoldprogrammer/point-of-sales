using System.Windows.Forms;
using System;

namespace WinFormsApp
{
    public partial class FormAbout : Form
    {
        private String Message { get; set; }

        public FormAbout()
        {
            InitializeComponent();

            Text = "About";
        }
    }
}
