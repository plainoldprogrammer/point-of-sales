using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormConfigure : Form
    {
        public List<Product> Products { get; set; }

        public FormConfigure()
        {
            InitializeComponent();
        }

        public void ConfigureMenuEntries()
        {
            textBoxMenuItem001Name.Text = Products.ElementAt(0).Name;
            textBoxMenuItem001Price.Text = $"{Products.ElementAt(0).Price}";

            textBoxMenuItem002Name.Text = Products.ElementAt(1).Name;
            textBoxMenuItem002Price.Text = $"{Products.ElementAt(1).Price}";
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Products.ElementAt(0).Name = textBoxMenuItem001Name.Text;
            Products.ElementAt(0).Price = Int32.Parse(textBoxMenuItem001Price.Text);

            Products.ElementAt(1).Name = textBoxMenuItem002Name.Text;
            Products.ElementAt(1).Price = Int32.Parse(textBoxMenuItem002Price.Text);

            Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
