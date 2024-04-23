using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Ticket Ticket { get; set; }

        public Form1()
        {
            InitializeComponent();
            Ticket = new Ticket();
        }

        private void menuItemButton01_Click(object sender, EventArgs e)
        {
            listBoxTicket.Items.Add("Quesadilla");
            Ticket.Products.Add("Quesadilla");
        }

        private void buttonRemoveItemFromTicket_Click(object sender, EventArgs e)
        {
            if (listBoxTicket.Items.Count > 0)
            {
                int selectedIndex = listBoxTicket.SelectedIndex;

                listBoxTicket.Items.RemoveAt(selectedIndex);
                Ticket.Products.RemoveAt(selectedIndex);

                if (selectedIndex == listBoxTicket.Items.Count)
                {
                    listBoxTicket.SelectedIndex = listBoxTicket.Items.Count - 1;
                    
                }
                else
                {
                    listBoxTicket.SelectedIndex = selectedIndex;
                    
                }
            }
        }
    }
}
