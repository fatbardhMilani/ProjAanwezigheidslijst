namespace ProjAanwezigheidslijst
{
    partial class CreateForm
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
            this.opleidingInfoButton = new System.Windows.Forms.Button();
            this.docentButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.deelnemersButton = new System.Windows.Forms.Button();
            this.feestdagenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opleidingInfoButton
            // 
            this.opleidingInfoButton.Location = new System.Drawing.Point(12, 12);
            this.opleidingInfoButton.Name = "opleidingInfoButton";
            this.opleidingInfoButton.Size = new System.Drawing.Size(138, 74);
            this.opleidingInfoButton.TabIndex = 0;
            this.opleidingInfoButton.Text = "Opleidings informatie";
            this.opleidingInfoButton.UseVisualStyleBackColor = true;
            this.opleidingInfoButton.Click += new System.EventHandler(this.OpleidingInfoButton_Click);
            // 
            // docentButton
            // 
            this.docentButton.Location = new System.Drawing.Point(156, 92);
            this.docentButton.Name = "docentButton";
            this.docentButton.Size = new System.Drawing.Size(138, 74);
            this.docentButton.TabIndex = 2;
            this.docentButton.Text = "Docenten";
            this.docentButton.UseVisualStyleBackColor = true;
            this.docentButton.Click += new System.EventHandler(this.DocentButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 74);
            this.button4.TabIndex = 2;
            this.button4.Text = "button3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // deelnemersButton
            // 
            this.deelnemersButton.Location = new System.Drawing.Point(156, 12);
            this.deelnemersButton.Name = "deelnemersButton";
            this.deelnemersButton.Size = new System.Drawing.Size(138, 74);
            this.deelnemersButton.TabIndex = 2;
            this.deelnemersButton.Text = "Deelnemers";
            this.deelnemersButton.UseVisualStyleBackColor = true;
            this.deelnemersButton.Click += new System.EventHandler(this.DeelnemersButton_Click);
            // 
            // feestdagenButton
            // 
            this.feestdagenButton.Location = new System.Drawing.Point(12, 92);
            this.feestdagenButton.Name = "feestdagenButton";
            this.feestdagenButton.Size = new System.Drawing.Size(138, 74);
            this.feestdagenButton.TabIndex = 2;
            this.feestdagenButton.Text = "Feestdagen";
            this.feestdagenButton.UseVisualStyleBackColor = true;
            this.feestdagenButton.Click += new System.EventHandler(this.FeestdagenButton_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 363);
            this.Controls.Add(this.feestdagenButton);
            this.Controls.Add(this.deelnemersButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.docentButton);
            this.Controls.Add(this.opleidingInfoButton);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opleidingInfoButton;
        private System.Windows.Forms.Button docentButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button deelnemersButton;
        private System.Windows.Forms.Button feestdagenButton;
    }
}