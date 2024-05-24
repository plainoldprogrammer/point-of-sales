using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    partial class FormMain
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
            buttonNextTicket = new Button();
            labelTicketStatus = new Label();
            buttonMenuItem002 = new Button();
            buttonConfigureMenu = new Button();
            settingsButton = new Button();
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
            buttonMenuItem001.UseVisualStyleBackColor = true;
            buttonMenuItem001.Click += buttonMenuItem001_Click;
            // 
            // buttonRemoveItemFromTicket
            // 
            buttonRemoveItemFromTicket.Location = new Point(12, 497);
            buttonRemoveItemFromTicket.Name = "buttonRemoveItemFromTicket";
            buttonRemoveItemFromTicket.Size = new Size(117, 29);
            buttonRemoveItemFromTicket.TabIndex = 2;
            buttonRemoveItemFromTicket.Text = "Remove Item";
            buttonRemoveItemFromTicket.UseVisualStyleBackColor = true;
            buttonRemoveItemFromTicket.Click += buttonRemoveItemFromTicket_Click;
            // 
            // buttonSaveTicket
            // 
            buttonSaveTicket.Location = new Point(135, 497);
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
            textBoxCurrentTicketIndex.Location = new Point(67, 532);
            textBoxCurrentTicketIndex.Name = "textBoxCurrentTicketIndex";
            textBoxCurrentTicketIndex.Size = new Size(49, 27);
            textBoxCurrentTicketIndex.TabIndex = 5;
            // 
            // textBoxTicketsCount
            // 
            textBoxTicketsCount.Location = new Point(122, 532);
            textBoxTicketsCount.Name = "textBoxTicketsCount";
            textBoxTicketsCount.Size = new Size(49, 27);
            textBoxTicketsCount.TabIndex = 6;
            // 
            // buttonPreviousTicket
            // 
            buttonPreviousTicket.Location = new Point(12, 532);
            buttonPreviousTicket.Name = "buttonPreviousTicket";
            buttonPreviousTicket.Size = new Size(49, 27);
            buttonPreviousTicket.TabIndex = 7;
            buttonPreviousTicket.Text = "<";
            buttonPreviousTicket.UseVisualStyleBackColor = true;
            buttonPreviousTicket.Click += buttonPreviousTicket_Click;
            // 
            // buttonNextTicket
            // 
            buttonNextTicket.Location = new Point(180, 532);
            buttonNextTicket.Name = "buttonNextTicket";
            buttonNextTicket.Size = new Size(49, 27);
            buttonNextTicket.TabIndex = 8;
            buttonNextTicket.Text = ">";
            buttonNextTicket.UseVisualStyleBackColor = true;
            buttonNextTicket.Click += buttonNextTicket_Click;
            // 
            // labelTicketStatus
            // 
            labelTicketStatus.AutoSize = true;
            labelTicketStatus.Location = new Point(12, 439);
            labelTicketStatus.Name = "labelTicketStatus";
            labelTicketStatus.Size = new Size(93, 20);
            labelTicketStatus.TabIndex = 9;
            labelTicketStatus.Text = "Ticket status:";
            // 
            // buttonMenuItem002
            // 
            buttonMenuItem002.Location = new Point(331, 12);
            buttonMenuItem002.Name = "buttonMenuItem002";
            buttonMenuItem002.Size = new Size(90, 90);
            buttonMenuItem002.TabIndex = 10;
            buttonMenuItem002.UseVisualStyleBackColor = true;
            buttonMenuItem002.Click += buttonMenuItem002_Click;
            // 
            // buttonConfigureMenu
            // 
            buttonConfigureMenu.Location = new Point(562, 532);
            buttonConfigureMenu.Name = "buttonConfigureMenu";
            buttonConfigureMenu.Size = new Size(126, 29);
            buttonConfigureMenu.TabIndex = 11;
            buttonConfigureMenu.Text = "Configure Menu";
            buttonConfigureMenu.UseVisualStyleBackColor = true;
            buttonConfigureMenu.Click += buttonConfigure_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(694, 532);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(94, 29);
            settingsButton.TabIndex = 12;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(settingsButton);
            Controls.Add(buttonConfigureMenu);
            Controls.Add(buttonMenuItem002);
            Controls.Add(labelTicketStatus);
            Controls.Add(buttonNextTicket);
            Controls.Add(buttonPreviousTicket);
            Controls.Add(textBoxTicketsCount);
            Controls.Add(textBoxCurrentTicketIndex);
            Controls.Add(richTextBoxTicketAmount);
            Controls.Add(buttonSaveTicket);
            Controls.Add(buttonRemoveItemFromTicket);
            Controls.Add(buttonMenuItem001);
            Controls.Add(listBoxTicket);
            Name = "FormMain";
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
        private Button buttonNextTicket;
        private Label labelTicketStatus;
        private Button buttonMenuItem002;
        private Button buttonConfigureMenu;
        private Button settingsButton;
    }
}
