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
            menuItemButton01 = new Button();
            removeItemFromTicketButtom = new Button();
            SuspendLayout();
            // 
            // listBoxTicket
            // 
            listBoxTicket.FormattingEnabled = true;
            listBoxTicket.Location = new Point(12, 12);
            listBoxTicket.Name = "listBoxTicket";
            listBoxTicket.Size = new Size(217, 424);
            listBoxTicket.TabIndex = 0;
            // 
            // menuItemButton01
            // 
            menuItemButton01.Location = new Point(235, 12);
            menuItemButton01.Name = "menuItemButton01";
            menuItemButton01.Size = new Size(94, 29);
            menuItemButton01.TabIndex = 1;
            menuItemButton01.Text = "Quesadilla";
            menuItemButton01.UseVisualStyleBackColor = true;
            menuItemButton01.Click += menuItemButton01_Click;
            // 
            // removeItemFromTicketButtom
            // 
            removeItemFromTicketButtom.Location = new Point(135, 442);
            removeItemFromTicketButtom.Name = "removeItemFromTicketButtom";
            removeItemFromTicketButtom.Size = new Size(94, 29);
            removeItemFromTicketButtom.TabIndex = 2;
            removeItemFromTicketButtom.Text = "Remove";
            removeItemFromTicketButtom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(removeItemFromTicketButtom);
            Controls.Add(menuItemButton01);
            Controls.Add(listBoxTicket);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTicket;
        private Button menuItemButton01;
        private Button removeItemFromTicketButtom;
    }
}
