using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Ticket Ticket { get; set; }
        public List<Ticket> Tickets { get; set; }
        public int CurrentTicketIndex { get; set; }

        public Form1()
        {
            InitializeComponent();
            Ticket = new Ticket();
            Tickets = new List<Ticket>();
            CurrentTicketIndex = 1;
            textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
            textBoxTicketsCount.Text = $"{CurrentTicketIndex}";
        }

        private void menuItemButton01_Click(object sender, EventArgs e)
        {
            listBoxTicket.Items.Add("Quesadilla");
            Ticket.Products.Add("Quesadilla");

            richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${Ticket.Total}";
        }

        private void buttonRemoveItemFromTicket_Click(object sender, EventArgs e)
        {
            if ((listBoxTicket.Items.Count > 0) && (listBoxTicket.SelectedIndex >= 0))
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

                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${Ticket.Total}";
            }
        }

        private void buttonSaveTicket_Click(object sender, EventArgs e)
        {
            Tickets.Add(Ticket);
            listBoxTicket.Items.Clear();
            Ticket = new Ticket();

            richTextBoxTicketAmount.Text = $"Items: {0}\nTotal: ${0}";
            CurrentTicketIndex++;
            textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
            textBoxTicketsCount.Text = $"{Tickets.Count + 1}";
        }

        private void buttonPreviousTicket_Click(object sender, EventArgs e)
        {
            if (CurrentTicketIndex >= 2)
            {
                CurrentTicketIndex--;
                Ticket ticket = Tickets[CurrentTicketIndex - 1];

                listBoxTicket.Items.Clear();
                foreach (string product in ticket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${ticket.Total}";
            }
        }

        private void buttonNextTicket_Click(object sender, EventArgs e)
        {
            if (CurrentTicketIndex < Tickets.Count)
            {
                CurrentTicketIndex++;
                Ticket ticket = Tickets[CurrentTicketIndex - 1];

                listBoxTicket.Items.Clear();
                foreach (string product in ticket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${ticket.Total}";
            }
            else if (CurrentTicketIndex == Tickets.Count)
            {
                CurrentTicketIndex++;

                listBoxTicket.Items.Clear();
                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: $0";
            }
        }
    }
}
