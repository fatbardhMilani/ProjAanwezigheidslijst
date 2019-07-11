namespace ProjAanwezigheidslijst
{
    partial class ViewFom
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
            this.dlnmrButton = new System.Windows.Forms.Button();
            this.DlnmrOplButton = new System.Windows.Forms.Button();
            this.nietOplDagButton = new System.Windows.Forms.Button();
            this.tijdsRegButton = new System.Windows.Forms.Button();
            this.oplInfoButton = new System.Windows.Forms.Button();
            this.docOplButton = new System.Windows.Forms.Button();
            this.docButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlnmrButton
            // 
            this.dlnmrButton.Location = new System.Drawing.Point(13, 13);
            this.dlnmrButton.Name = "dlnmrButton";
            this.dlnmrButton.Size = new System.Drawing.Size(319, 94);
            this.dlnmrButton.TabIndex = 0;
            this.dlnmrButton.Text = "Deelnemers";
            this.dlnmrButton.UseVisualStyleBackColor = true;
            this.dlnmrButton.Click += new System.EventHandler(this.DlnmrButton_Click);
            // 
            // DlnmrOplButton
            // 
            this.DlnmrOplButton.Location = new System.Drawing.Point(338, 13);
            this.DlnmrOplButton.Name = "DlnmrOplButton";
            this.DlnmrOplButton.Size = new System.Drawing.Size(319, 94);
            this.DlnmrOplButton.TabIndex = 1;
            this.DlnmrOplButton.Text = "Deelnemers Opleidingen";
            this.DlnmrOplButton.UseVisualStyleBackColor = true;
            // 
            // nietOplDagButton
            // 
            this.nietOplDagButton.Location = new System.Drawing.Point(13, 113);
            this.nietOplDagButton.Name = "nietOplDagButton";
            this.nietOplDagButton.Size = new System.Drawing.Size(319, 94);
            this.nietOplDagButton.TabIndex = 2;
            this.nietOplDagButton.Text = "Niet Opleidings dagen";
            this.nietOplDagButton.UseVisualStyleBackColor = true;
            // 
            // tijdsRegButton
            // 
            this.tijdsRegButton.Location = new System.Drawing.Point(338, 113);
            this.tijdsRegButton.Name = "tijdsRegButton";
            this.tijdsRegButton.Size = new System.Drawing.Size(319, 94);
            this.tijdsRegButton.TabIndex = 3;
            this.tijdsRegButton.Text = "Tijdsregistratie";
            this.tijdsRegButton.UseVisualStyleBackColor = true;
            // 
            // oplInfoButton
            // 
            this.oplInfoButton.Location = new System.Drawing.Point(13, 213);
            this.oplInfoButton.Name = "oplInfoButton";
            this.oplInfoButton.Size = new System.Drawing.Size(319, 94);
            this.oplInfoButton.TabIndex = 4;
            this.oplInfoButton.Text = "Opleidingsinformatie";
            this.oplInfoButton.UseVisualStyleBackColor = true;
            // 
            // docOplButton
            // 
            this.docOplButton.Location = new System.Drawing.Point(338, 213);
            this.docOplButton.Name = "docOplButton";
            this.docOplButton.Size = new System.Drawing.Size(319, 94);
            this.docOplButton.TabIndex = 5;
            this.docOplButton.Text = "Docenten opleidingen";
            this.docOplButton.UseVisualStyleBackColor = true;
            // 
            // docButton
            // 
            this.docButton.Location = new System.Drawing.Point(13, 313);
            this.docButton.Name = "docButton";
            this.docButton.Size = new System.Drawing.Size(319, 94);
            this.docButton.TabIndex = 6;
            this.docButton.Text = "Docenten";
            this.docButton.UseVisualStyleBackColor = true;
            // 
            // ViewFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 435);
            this.Controls.Add(this.docButton);
            this.Controls.Add(this.docOplButton);
            this.Controls.Add(this.oplInfoButton);
            this.Controls.Add(this.tijdsRegButton);
            this.Controls.Add(this.nietOplDagButton);
            this.Controls.Add(this.DlnmrOplButton);
            this.Controls.Add(this.dlnmrButton);
            this.Name = "ViewFom";
            this.Text = "ViewFom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dlnmrButton;
        private System.Windows.Forms.Button DlnmrOplButton;
        private System.Windows.Forms.Button nietOplDagButton;
        private System.Windows.Forms.Button tijdsRegButton;
        private System.Windows.Forms.Button oplInfoButton;
        private System.Windows.Forms.Button docOplButton;
        private System.Windows.Forms.Button docButton;
    }
}