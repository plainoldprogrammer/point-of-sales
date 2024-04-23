using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Ticket Ticket { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Form1()
        {
            InitializeComponent();
            Ticket = new Ticket();
            Tickets = new List<Ticket>();
        }

        private void menuItemButton01_Click(object sender, EventArgs e)
        {
            listBoxTicket.Items.Add("Quesadilla");
            Ticket.Products.Add("Quesadilla");

            richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}";
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

                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}";
            }
        }

        private void buttonSaveTicket_Click(object sender, EventArgs e)
        {
            Tickets.Add(Ticket);
            listBoxTicket.Items.Clear();
            Ticket = new Ticket();
            richTextBoxTicketAmount.Text = "Items: 0";
        }
    }
}
