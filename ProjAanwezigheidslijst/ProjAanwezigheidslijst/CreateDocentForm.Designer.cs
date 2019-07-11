namespace ProjAanwezigheidslijst
{
    partial class CreateDocentForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.createDocentButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bedrijfDocentTextBox = new System.Windows.Forms.TextBox();
            this.naamDocentTexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(467, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 54);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createDocentButton
            // 
            this.createDocentButton.Location = new System.Drawing.Point(16, 115);
            this.createDocentButton.Name = "createDocentButton";
            this.createDocentButton.Size = new System.Drawing.Size(158, 54);
            this.createDocentButton.TabIndex = 28;
            this.createDocentButton.Text = "Create";
            this.createDocentButton.UseVisualStyleBackColor = true;
            this.createDocentButton.Click += new System.EventHandler(this.CreateDocentButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Bedrijf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Naam";
            // 
            // bedrijfDocentTextBox
            // 
            this.bedrijfDocentTextBox.Location = new System.Drawing.Point(15, 55);
            this.bedrijfDocentTextBox.Name = "bedrijfDocentTextBox";
            this.bedrijfDocentTextBox.Size = new System.Drawing.Size(381, 26);
            this.bedrijfDocentTextBox.TabIndex = 25;
            // 
            // naamDocentTexBox
            // 
            this.naamDocentTexBox.Location = new System.Drawing.Point(15, 10);
            this.naamDocentTexBox.Name = "naamDocentTexBox";
            this.naamDocentTexBox.Size = new System.Drawing.Size(381, 26);
            this.naamDocentTexBox.TabIndex = 24;
            // 
            // CreateDocentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 182);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createDocentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bedrijfDocentTextBox);
            this.Controls.Add(this.naamDocentTexBox);
            this.Name = "CreateDocentForm";
            this.Text = "CreateDocent";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createDocentButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bedrijfDocentTextBox;
        private System.Windows.Forms.TextBox naamDocentTexBox;
    }
}