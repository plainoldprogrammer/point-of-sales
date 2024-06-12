using System.Windows.Forms;
using System;

namespace WinFormsApp
{
    public partial class FormAbout : Form
    {
        private String Message { get; set; }
        private String Author { get; set; }

        public FormAbout()
        {
            InitializeComponent();

            Text = "About";
        }
    }
}
