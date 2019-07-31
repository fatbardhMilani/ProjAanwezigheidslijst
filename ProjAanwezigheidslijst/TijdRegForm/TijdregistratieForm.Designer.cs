namespace TijdRegForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectOplButton = new System.Windows.Forms.Button();
            this.oplInfolistBox = new System.Windows.Forms.ListBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.KiesOplComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 224);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1975, 401);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // selectOplButton
            // 
            this.selectOplButton.Location = new System.Drawing.Point(471, 46);
            this.selectOplButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectOplButton.Name = "selectOplButton";
            this.selectOplButton.Size = new System.Drawing.Size(140, 56);
            this.selectOplButton.TabIndex = 12;
            this.selectOplButton.Text = "Select";
            this.selectOplButton.UseVisualStyleBackColor = true;
            // 
            // oplInfolistBox
            // 
            this.oplInfolistBox.FormattingEnabled = true;
            this.oplInfolistBox.ItemHeight = 25;
            this.oplInfolistBox.Location = new System.Drawing.Point(15, 110);
            this.oplInfolistBox.Margin = new System.Windows.Forms.Padding(4);
            this.oplInfolistBox.Name = "oplInfolistBox";
            this.oplInfolistBox.Size = new System.Drawing.Size(1973, 104);
            this.oplInfolistBox.TabIndex = 11;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(1641, 16);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 25);
            this.timeLabel.TabIndex = 10;
            // 
            // KiesOplComboBox
            // 
            this.KiesOplComboBox.FormattingEnabled = true;
            this.KiesOplComboBox.Location = new System.Drawing.Point(15, 46);
            this.KiesOplComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.KiesOplComboBox.Name = "KiesOplComboBox";
            this.KiesOplComboBox.Size = new System.Drawing.Size(445, 33);
            this.KiesOplComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kies opleiding :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1029);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.selectOplButton);
            this.Controls.Add(this.oplInfolistBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.KiesOplComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button selectOplButton;
        private System.Windows.Forms.ListBox oplInfolistBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox KiesOplComboBox;
        private System.Windows.Forms.Label label1;
    }
}

