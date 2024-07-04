namespace WinFormsApp
{
    partial class FormAbout
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
            buttonOk = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new System.Drawing.Point(171, 318);
            buttonOk.Margin = new System.Windows.Forms.Padding(4);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new System.Drawing.Size(141, 44);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 408);
            Controls.Add(buttonOk);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
    }
}