namespace ProjAanwezigheidslijst
{
    partial class ViewDeelnemerForm
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
            this.dlnmrListBox = new System.Windows.Forms.ListBox();
            this.wijzigButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlnmrListBox
            // 
            this.dlnmrListBox.FormattingEnabled = true;
            this.dlnmrListBox.ItemHeight = 20;
            this.dlnmrListBox.Location = new System.Drawing.Point(13, 13);
            this.dlnmrListBox.Name = "dlnmrListBox";
            this.dlnmrListBox.Size = new System.Drawing.Size(775, 284);
            this.dlnmrListBox.TabIndex = 0;
            // 
            // wijzigButton
            // 
            this.wijzigButton.Location = new System.Drawing.Point(12, 303);
            this.wijzigButton.Name = "wijzigButton";
            this.wijzigButton.Size = new System.Drawing.Size(190, 46);
            this.wijzigButton.TabIndex = 1;
            this.wijzigButton.Text = "wijzigen";
            this.wijzigButton.UseVisualStyleBackColor = true;
            this.wijzigButton.Click += new System.EventHandler(this.WijzigButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(598, 303);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 46);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // ViewDeelnemerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.wijzigButton);
            this.Controls.Add(this.dlnmrListBox);
            this.Name = "ViewDeelnemerForm";
            this.Text = "ViewDeelnemer";
            this.Load += new System.EventHandler(this.ViewDeelnemerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dlnmrListBox;
        private System.Windows.Forms.Button wijzigButton;
        private System.Windows.Forms.Button deleteButton;
    }
}