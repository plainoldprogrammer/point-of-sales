using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            Text = "Settings";
        }

        private void buttonOk_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
