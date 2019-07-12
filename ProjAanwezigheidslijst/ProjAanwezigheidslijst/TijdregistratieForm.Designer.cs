namespace ProjAanwezigheidslijst
{
    partial class TijdregistratieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.KiesOplComboBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.oplInfolistBox = new System.Windows.Forms.ListBox();
            this.selectOplButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kies opleiding :";
            // 
            // KiesOplComboBox
            // 
            this.KiesOplComboBox.FormattingEnabled = true;
            this.KiesOplComboBox.Location = new System.Drawing.Point(17, 37);
            this.KiesOplComboBox.Name = "KiesOplComboBox";
            this.KiesOplComboBox.Size = new System.Drawing.Size(335, 28);
            this.KiesOplComboBox.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(1237, 13);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 20);
            this.timeLabel.TabIndex = 3;
            // 
            // oplInfolistBox
            // 
            this.oplInfolistBox.FormattingEnabled = true;
            this.oplInfolistBox.ItemHeight = 20;
            this.oplInfolistBox.Location = new System.Drawing.Point(17, 88);
            this.oplInfolistBox.Name = "oplInfolistBox";
            this.oplInfolistBox.Size = new System.Drawing.Size(1481, 84);
            this.oplInfolistBox.TabIndex = 5;
            // 
            // selectOplButton
            // 
            this.selectOplButton.Location = new System.Drawing.Point(359, 37);
            this.selectOplButton.Name = "selectOplButton";
            this.selectOplButton.Size = new System.Drawing.Size(105, 45);
            this.selectOplButton.TabIndex = 6;
            this.selectOplButton.Text = "Select";
            this.selectOplButton.UseVisualStyleBackColor = true;
            this.selectOplButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1481, 321);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // TijdregistratieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 512);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.selectOplButton);
            this.Controls.Add(this.oplInfolistBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.KiesOplComboBox);
            this.Controls.Add(this.label1);
            this.Name = "TijdregistratieForm";
            this.Text = "TijdregistratieForm";
            this.Load += new System.EventHandler(this.TijdregistratieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KiesOplComboBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ListBox oplInfolistBox;
        private System.Windows.Forms.Button selectOplButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}