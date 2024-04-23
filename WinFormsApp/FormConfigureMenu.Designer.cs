namespace WinFormsApp
{
    partial class FormConfigureMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMenuItem001Name = new System.Windows.Forms.TextBox();
            textBoxMenuItem001Price = new System.Windows.Forms.TextBox();
            textBoxMenuItem002Name = new System.Windows.Forms.TextBox();
            textBoxMenuItem002Price = new System.Windows.Forms.TextBox();
            buttonAccept = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxMenuItem001Name
            // 
            textBoxMenuItem001Name.Location = new System.Drawing.Point(12, 12);
            textBoxMenuItem001Name.Name = "textBoxMenuItem001Name";
            textBoxMenuItem001Name.Size = new System.Drawing.Size(125, 27);
            textBoxMenuItem001Name.TabIndex = 0;
            // 
            // textBoxMenuItem001Price
            // 
            textBoxMenuItem001Price.Location = new System.Drawing.Point(12, 45);
            textBoxMenuItem001Price.Name = "textBoxMenuItem001Price";
            textBoxMenuItem001Price.Size = new System.Drawing.Size(125, 27);
            textBoxMenuItem001Price.TabIndex = 1;
            // 
            // textBoxMenuItem002Name
            // 
            textBoxMenuItem002Name.Location = new System.Drawing.Point(163, 12);
            textBoxMenuItem002Name.Name = "textBoxMenuItem002Name";
            textBoxMenuItem002Name.Size = new System.Drawing.Size(125, 27);
            textBoxMenuItem002Name.TabIndex = 2;
            // 
            // textBoxMenuItem002Price
            // 
            textBoxMenuItem002Price.Location = new System.Drawing.Point(163, 45);
            textBoxMenuItem002Price.Name = "textBoxMenuItem002Price";
            textBoxMenuItem002Price.Size = new System.Drawing.Size(125, 27);
            textBoxMenuItem002Price.TabIndex = 3;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new System.Drawing.Point(590, 406);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new System.Drawing.Size(94, 29);
            buttonAccept.TabIndex = 4;
            buttonAccept.Text = "Accept";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(690, 406);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormConfigure
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(789, 447);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(textBoxMenuItem002Price);
            Controls.Add(textBoxMenuItem002Name);
            Controls.Add(textBoxMenuItem001Price);
            Controls.Add(textBoxMenuItem001Name);
            Name = "FormConfigure";
            Text = "Configure Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMenuItem001Name;
        private System.Windows.Forms.TextBox textBoxMenuItem001Price;
        private System.Windows.Forms.TextBox textBoxMenuItem002Name;
        private System.Windows.Forms.TextBox textBoxMenuItem002Price;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
    }
}