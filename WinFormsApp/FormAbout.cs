using System.Windows.Forms;
using System;

namespace WinFormsApp
{
    public partial class FormAbout : Form
    {
        private String Message { get; set; }
        private String Author { get; set; }
        private String ReleaseDate { get; set; }
        private String ReleaseVersion { get; set; }

        public FormAbout()
        {
            InitializeComponent();

            Text = "About";
        }
    }
}
