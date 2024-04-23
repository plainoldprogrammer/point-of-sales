using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Ticket TicketDraft { get; set; }
        public List<Ticket> Tickets { get; set; }
        public int CurrentTicketIndex { get; set; }

        public Form1()
        {
            InitializeComponent();
            TicketDraft = new Ticket();
            Tickets = new List<Ticket>();
            CurrentTicketIndex = 1;
            textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
            textBoxTicketsCount.Text = $"{CurrentTicketIndex}";

            buttonPreviousTicket.Enabled = false;
            buttonNextTicket.Enabled = false;
        }

        private void menuItemButton01_Click(object sender, EventArgs e)
        {
            listBoxTicket.Items.Add("Quesadilla");
            TicketDraft.Products.Add("Quesadilla");

            richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${TicketDraft.Total}";
        }

        private void buttonRemoveItemFromTicket_Click(object sender, EventArgs e)
        {
            if ((listBoxTicket.Items.Count > 0) && (listBoxTicket.SelectedIndex >= 0))
            {
                int selectedIndex = listBoxTicket.SelectedIndex;

                listBoxTicket.Items.RemoveAt(selectedIndex);
                TicketDraft.Products.RemoveAt(selectedIndex);

                if (selectedIndex == listBoxTicket.Items.Count)
                {
                    listBoxTicket.SelectedIndex = listBoxTicket.Items.Count - 1;

                }
                else
                {
                    listBoxTicket.SelectedIndex = selectedIndex;
                }

                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${TicketDraft.Total}";
            }
        }

        private void buttonSaveTicket_Click(object sender, EventArgs e)
        {
            Tickets.Add(TicketDraft);
            listBoxTicket.Items.Clear();
            TicketDraft = new Ticket();

            richTextBoxTicketAmount.Text = $"Items: {0}\nTotal: ${0}";
            CurrentTicketIndex++;
            textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
            textBoxTicketsCount.Text = $"{Tickets.Count + 1}";

            buttonPreviousTicket.Enabled = true;
        }

        private void buttonPreviousTicket_Click(object sender, EventArgs e)
        {
            if (CurrentTicketIndex >= 2)
            {
                CurrentTicketIndex--;
                Ticket currentTicket = Tickets[CurrentTicketIndex - 1];

                listBoxTicket.Items.Clear();
                foreach (string product in currentTicket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${currentTicket.Total}";

                if (CurrentTicketIndex == 1)
                {
                    buttonPreviousTicket.Enabled = false;
                }

                if (CurrentTicketIndex == Tickets.Count)
                {
                    buttonNextTicket.Enabled = true;
                }
            }
        }

        private void buttonNextTicket_Click(object sender, EventArgs e)
        {
            if (CurrentTicketIndex < Tickets.Count)
            {
                CurrentTicketIndex++;
                Ticket currentTicket = Tickets[CurrentTicketIndex - 1];

                listBoxTicket.Items.Clear();
                foreach (string product in currentTicket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${currentTicket.Total}";

                if (CurrentTicketIndex == 2)
                {
                    buttonPreviousTicket.Enabled = true;
                }
            }
            else if (CurrentTicketIndex == Tickets.Count)
            {
                CurrentTicketIndex++;

                listBoxTicket.Items.Clear();
                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: $0";

                buttonNextTicket.Enabled = false;
            }
        }
    }
}
