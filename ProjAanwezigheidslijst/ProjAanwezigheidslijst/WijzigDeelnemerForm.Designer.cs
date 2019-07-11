namespace ProjAanwezigheidslijst
{
    partial class WijzigDeelnemerForm
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
            this.saveWijzigDlnmrButton = new System.Windows.Forms.Button();
            this.GeboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.badgeNummerTexBox = new System.Windows.Forms.TextBox();
            this.woonplaatsTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.dlnmrComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(462, 369);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 54);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveWijzigDlnmrButton
            // 
            this.saveWijzigDlnmrButton.Location = new System.Drawing.Point(11, 369);
            this.saveWijzigDlnmrButton.Name = "saveWijzigDlnmrButton";
            this.saveWijzigDlnmrButton.Size = new System.Drawing.Size(158, 54);
            this.saveWijzigDlnmrButton.TabIndex = 32;
            this.saveWijzigDlnmrButton.Text = "Save";
            this.saveWijzigDlnmrButton.UseVisualStyleBackColor = true;
            // 
            // GeboortedatumDateTimePicker
            // 
            this.GeboortedatumDateTimePicker.Location = new System.Drawing.Point(11, 221);
            this.GeboortedatumDateTimePicker.Name = "GeboortedatumDateTimePicker";
            this.GeboortedatumDateTimePicker.Size = new System.Drawing.Size(380, 26);
            this.GeboortedatumDateTimePicker.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Badge nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Woonplaats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Geboortedatum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Naam";
            // 
            // badgeNummerTexBox
            // 
            this.badgeNummerTexBox.Location = new System.Drawing.Point(10, 309);
            this.badgeNummerTexBox.Name = "badgeNummerTexBox";
            this.badgeNummerTexBox.Size = new System.Drawing.Size(381, 26);
            this.badgeNummerTexBox.TabIndex = 26;
            // 
            // woonplaatsTextBox
            // 
            this.woonplaatsTextBox.Location = new System.Drawing.Point(10, 264);
            this.woonplaatsTextBox.Name = "woonplaatsTextBox";
            this.woonplaatsTextBox.Size = new System.Drawing.Size(381, 26);
            this.woonplaatsTextBox.TabIndex = 25;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(10, 176);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(381, 26);
            this.naamTextBox.TabIndex = 24;
            // 
            // dlnmrComboBox
            // 
            this.dlnmrComboBox.FormattingEnabled = true;
            this.dlnmrComboBox.Location = new System.Drawing.Point(0, 39);
            this.dlnmrComboBox.Name = "dlnmrComboBox";
            this.dlnmrComboBox.Size = new System.Drawing.Size(391, 28);
            this.dlnmrComboBox.TabIndex = 34;
            // 
            // WijzigDeelnemerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 435);
            this.Controls.Add(this.dlnmrComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveWijzigDlnmrButton);
            this.Controls.Add(this.GeboortedatumDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.badgeNummerTexBox);
            this.Controls.Add(this.woonplaatsTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Name = "WijzigDeelnemerForm";
            this.Text = "WijzigDeelnemer";
            this.Load += new System.EventHandler(this.WijzigDeelnemerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveWijzigDlnmrButton;
        private System.Windows.Forms.DateTimePicker GeboortedatumDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox badgeNummerTexBox;
        private System.Windows.Forms.TextBox woonplaatsTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.ComboBox dlnmrComboBox;
    }
}