namespace ProjAanwezigheidslijst
{
    partial class BeheerForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.vieuwButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(179, 78);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // vieuwButton
            // 
            this.vieuwButton.Location = new System.Drawing.Point(197, 12);
            this.vieuwButton.Name = "vieuwButton";
            this.vieuwButton.Size = new System.Drawing.Size(179, 78);
            this.vieuwButton.TabIndex = 1;
            this.vieuwButton.Text = "View";
            this.vieuwButton.UseVisualStyleBackColor = true;
            this.vieuwButton.Click += new System.EventHandler(this.VieuwButton_Click);
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 496);
            this.Controls.Add(this.vieuwButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "BeheerForm";
            this.Text = "Beheer";
            this.Load += new System.EventHandler(this.BeheerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button vieuwButton;
    }
}

