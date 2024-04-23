using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTicket = new ListBox();
            buttonMenuItem001 = new Button();
            buttonRemoveItemFromTicket = new Button();
            buttonSaveTicket = new Button();
            richTextBoxTicketAmount = new RichTextBox();
            textBoxCurrentTicketIndex = new TextBox();
            textBoxTicketsCount = new TextBox();
            buttonPreviousTicket = new Button();
            SuspendLayout();
            // 
            // listBoxTicket
            // 
            listBoxTicket.FormattingEnabled = true;
            listBoxTicket.Location = new Point(12, 12);
            listBoxTicket.Name = "listBoxTicket";
            listBoxTicket.Size = new Size(217, 344);
            listBoxTicket.TabIndex = 0;
            // 
            // buttonMenuItem001
            // 
            buttonMenuItem001.Location = new Point(235, 12);
            buttonMenuItem001.Name = "buttonMenuItem001";
            buttonMenuItem001.Size = new Size(90, 90);
            buttonMenuItem001.TabIndex = 1;
            buttonMenuItem001.Text = "Quesadilla";
            buttonMenuItem001.UseVisualStyleBackColor = true;
            buttonMenuItem001.Click += menuItemButton01_Click;
            // 
            // buttonRemoveItemFromTicket
            // 
            buttonRemoveItemFromTicket.Location = new Point(12, 442);
            buttonRemoveItemFromTicket.Name = "buttonRemoveItemFromTicket";
            buttonRemoveItemFromTicket.Size = new Size(117, 29);
            buttonRemoveItemFromTicket.TabIndex = 2;
            buttonRemoveItemFromTicket.Text = "Remove Item";
            buttonRemoveItemFromTicket.UseVisualStyleBackColor = true;
            buttonRemoveItemFromTicket.Click += buttonRemoveItemFromTicket_Click;
            // 
            // buttonSaveTicket
            // 
            buttonSaveTicket.Location = new Point(135, 442);
            buttonSaveTicket.Name = "buttonSaveTicket";
            buttonSaveTicket.Size = new Size(94, 29);
            buttonSaveTicket.TabIndex = 3;
            buttonSaveTicket.Text = "Save Ticket";
            buttonSaveTicket.UseVisualStyleBackColor = true;
            buttonSaveTicket.Click += buttonSaveTicket_Click;
            // 
            // richTextBoxTicketAmount
            // 
            richTextBoxTicketAmount.Location = new Point(12, 362);
            richTextBoxTicketAmount.Name = "richTextBoxTicketAmount";
            richTextBoxTicketAmount.Size = new Size(217, 74);
            richTextBoxTicketAmount.TabIndex = 4;
            richTextBoxTicketAmount.Text = "";
            // 
            // textBoxCurrentTicketIndex
            // 
            textBoxCurrentTicketIndex.Location = new Point(12, 477);
            textBoxCurrentTicketIndex.Name = "textBoxCurrentTicketIndex";
            textBoxCurrentTicketIndex.Size = new Size(49, 27);
            textBoxCurrentTicketIndex.TabIndex = 5;
            // 
            // textBoxTicketsCount
            // 
            textBoxTicketsCount.Location = new Point(67, 477);
            textBoxTicketsCount.Name = "textBoxTicketsCount";
            textBoxTicketsCount.Size = new Size(49, 27);
            textBoxTicketsCount.TabIndex = 6;
            // 
            // buttonPreviousTicket
            // 
            buttonPreviousTicket.Location = new Point(135, 475);
            buttonPreviousTicket.Name = "buttonPreviousTicket";
            buttonPreviousTicket.Size = new Size(49, 29);
            buttonPreviousTicket.TabIndex = 7;
            buttonPreviousTicket.Text = "<";
            buttonPreviousTicket.UseVisualStyleBackColor = true;
            buttonPreviousTicket.Click += buttonPreviousTicket_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(buttonPreviousTicket);
            Controls.Add(textBoxTicketsCount);
            Controls.Add(textBoxCurrentTicketIndex);
            Controls.Add(richTextBoxTicketAmount);
            Controls.Add(buttonSaveTicket);
            Controls.Add(buttonRemoveItemFromTicket);
            Controls.Add(buttonMenuItem001);
            Controls.Add(listBoxTicket);
            Name = "Form1";
            Text = "Point Of Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTicket;
        private Button buttonMenuItem001;
        private Button buttonRemoveItemFromTicket;
        private Button buttonSaveTicket;
        private RichTextBox richTextBoxTicketAmount;
        private TextBox textBoxCurrentTicketIndex;
        private TextBox textBoxTicketsCount;
        private Button buttonPreviousTicket;
    }
}
