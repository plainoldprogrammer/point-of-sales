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
            // buttonMenuItem001
            // 
            buttonMenuItem001.Location = new Point(235, 12);
            buttonMenuItem001.Name = "buttonMenuItem001";
            buttonMenuItem001.Size = new Size(94, 29);
            buttonMenuItem001.TabIndex = 1;
            buttonMenuItem001.Text = "Quesadilla";
            buttonMenuItem001.UseVisualStyleBackColor = true;
            buttonMenuItem001.Click += menuItemButton01_Click;
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
            Controls.Add(buttonMenuItem001);
            Controls.Add(listBoxTicket);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTicket;
        private Button buttonMenuItem001;
        private Button removeItemFromTicketButtom;
    }
}
