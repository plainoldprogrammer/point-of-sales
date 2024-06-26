using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppDatabaseAccess.Models;
using ConsoleAppDatabaseAccess.Persistence;

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        public Ticket TicketDraft { get; set; }
        public List<Ticket> Tickets { get; set; }
        public int CurrentTicketIndex { get; set; }
        public FormConfigureMenu FormConfigure { get; set; }
        public List<Product> Products { get; set; }
        public const String CURRENT_SOFTWARE_VERSION = "0.1 (Alpha)";
        public FormSettings FormSettings { get; set; }
        public FormAbout FormAbout { get; set; }

        public FormMain()
        {
            InitializeComponent();

            ConfigureTicket();
            ConfigureProducts();
            UpdateMenuBasedOnNewProductsConfiguration();

            FormConfigure = new FormConfigureMenu(Products!);
            FormSettings = new FormSettings();
            FormAbout = new FormAbout();

            Text = $"Point Of Sales v{CURRENT_SOFTWARE_VERSION}";
        }

        private void buttonRemoveItemFromTicket_Click(object sender, EventArgs e)
        {
            if ((listBoxTicket.Items.Count > 0) && (listBoxTicket.SelectedIndex >= 0))
            {
                int selectedIndex = listBoxTicket.SelectedIndex;

                listBoxTicket.Items.RemoveAt(selectedIndex);

                Ticket currentTicket;
                if (CurrentTicketIndex == (Tickets.Count + 1))
                {
                    currentTicket = TicketDraft;
                }
                else
                {
                    currentTicket = Tickets[CurrentTicketIndex - 1];
                }

                currentTicket.Products.RemoveAt(selectedIndex);

                if (selectedIndex == listBoxTicket.Items.Count)
                {
                    listBoxTicket.SelectedIndex = listBoxTicket.Items.Count - 1;
                }
                else
                {
                    listBoxTicket.SelectedIndex = selectedIndex;
                }

                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${currentTicket.Total}";
            }

            if (listBoxTicket.Items.Count == 0)
            {
                buttonRemoveItemFromTicket.Enabled = false;
            }
        }

        private void buttonSaveTicket_Click(object sender, EventArgs e)
        {
            Ticket ticketToSave = TicketDraft;
            Tickets.Add(ticketToSave);
            listBoxTicket.Items.Clear();
            TicketDraft = new Ticket();

            richTextBoxTicketAmount.Text = $"Items: {0}\nTotal: ${0}";
            CurrentTicketIndex++;
            textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
            textBoxTicketsCount.Text = $"{Tickets.Count + 1}";

            buttonPreviousTicket.Enabled = true;

            using (DbManager dbManager = new DbManager())
            {
                dbManager.SaveOrdersFromTicket(ticketToSave);
            }
        }

        private void buttonPreviousTicket_Click(object sender, EventArgs e)
        {
            if (CurrentTicketIndex >= 2)
            {
                CurrentTicketIndex--;
                Ticket currentTicket = Tickets[CurrentTicketIndex - 1];

                listBoxTicket.Items.Clear();
                foreach (Product product in currentTicket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${currentTicket.Total}";

                labelTicketStatus.Text = "Ticket status: Saved";

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
                foreach (Product product in currentTicket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${currentTicket.Total}";

                labelTicketStatus.Text = "Ticket status: Saved";

                if (CurrentTicketIndex == 2)
                {
                    buttonPreviousTicket.Enabled = true;
                }
            }
            else if (CurrentTicketIndex == Tickets.Count)
            {
                CurrentTicketIndex++;
                Ticket currentTicket = TicketDraft;

                listBoxTicket.Items.Clear();
                foreach (Product product in currentTicket.Products)
                {
                    listBoxTicket.Items.Add(product);
                }

                textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
                richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count}\nTotal: ${currentTicket.Total}";

                labelTicketStatus.Text = "Ticket status: Draft";

                buttonPreviousTicket.Enabled = true;
                buttonNextTicket.Enabled = false;
            }
        }

        private void buttonConfigure_Click(object sender, EventArgs e)
        {
            FormConfigure.ShowDialog();
            UpdateMenuBasedOnNewProductsConfiguration();
        }

        private void ConfigureTicket()
        {
            TicketDraft = new Ticket();
            Tickets = new List<Ticket>();

            CurrentTicketIndex = 1;
            textBoxCurrentTicketIndex.Text = $"{CurrentTicketIndex}";
            textBoxTicketsCount.Text = $"{CurrentTicketIndex}";

            buttonPreviousTicket.Enabled = false;
            buttonNextTicket.Enabled = false;
            textBoxTicketsCount.Enabled = false;
            buttonRemoveItemFromTicket.Enabled = false;

            labelTicketStatus.Text = "Ticket status: Draft";
        }

        private void ConfigureProducts()
        {
            Products = new List<Product>();

            Product product001 = new Product();
            product001.Name = "Soda";
            product001.Price = 24;

            Product product002 = new Product();
            product002.Name = "Taco";
            product002.Price = 15;

            Products.Add(product001);
            Products.Add(product002);
        }

        private void UpdateMenuBasedOnNewProductsConfiguration()
        {
            buttonMenuItem001.Text = $"{Products.ElementAt(0).Name} ${Products.ElementAt(0).Price}";
            buttonMenuItem002.Text = $"{Products.ElementAt(1).Name} ${Products.ElementAt(1).Price}";
        }

        private Ticket GetActiveTicket()
        {
            Ticket currentTicket;
            if (CurrentTicketIndex == (Tickets.Count + 1))
            {
                currentTicket = TicketDraft;
            }
            else
            {
                currentTicket = Tickets[CurrentTicketIndex - 1];
            }

            return currentTicket;
        }

        private void AddProductToTheTicket(Product product)
        {
            product.Name = product.Name;
            product.Price = product.Price;
            listBoxTicket.Items.Add(product);

            Ticket currentTicket = GetActiveTicket();
            currentTicket.Products.Add(product);

            richTextBoxTicketAmount.Text = $"Items: {listBoxTicket.Items.Count} {System.Environment.NewLine} Total: ${TicketDraft.Total}";

            buttonRemoveItemFromTicket.Enabled = Enabled;
        }

        private void buttonMenuItem001_Click(object sender, EventArgs e)
        {
            AddProductToTheTicket(Products.ElementAt(0));
        }

        private void buttonMenuItem002_Click(object sender, EventArgs e)
        {
            AddProductToTheTicket(Products.ElementAt(1));
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            FormSettings.ShowDialog();
        }
    }
}
