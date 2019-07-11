namespace ProjAanwezigheidslijst
{
    partial class CreateDeelnemerForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.badgeNummerTexBox = new System.Windows.Forms.TextBox();
            this.woonplaatsTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.GeboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createDeelnemerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Badge nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Woonplaats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Geboortedatum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Naam";
            // 
            // badgeNummerTexBox
            // 
            this.badgeNummerTexBox.Location = new System.Drawing.Point(12, 145);
            this.badgeNummerTexBox.Name = "badgeNummerTexBox";
            this.badgeNummerTexBox.Size = new System.Drawing.Size(381, 26);
            this.badgeNummerTexBox.TabIndex = 16;
            // 
            // woonplaatsTextBox
            // 
            this.woonplaatsTextBox.Location = new System.Drawing.Point(12, 100);
            this.woonplaatsTextBox.Name = "woonplaatsTextBox";
            this.woonplaatsTextBox.Size = new System.Drawing.Size(381, 26);
            this.woonplaatsTextBox.TabIndex = 15;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(12, 12);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(381, 26);
            this.naamTextBox.TabIndex = 13;
            // 
            // GeboortedatumDateTimePicker
            // 
            this.GeboortedatumDateTimePicker.Location = new System.Drawing.Point(13, 57);
            this.GeboortedatumDateTimePicker.Name = "GeboortedatumDateTimePicker";
            this.GeboortedatumDateTimePicker.Size = new System.Drawing.Size(380, 26);
            this.GeboortedatumDateTimePicker.TabIndex = 21;
            // 
            // createDeelnemerButton
            // 
            this.createDeelnemerButton.Location = new System.Drawing.Point(13, 205);
            this.createDeelnemerButton.Name = "createDeelnemerButton";
            this.createDeelnemerButton.Size = new System.Drawing.Size(158, 54);
            this.createDeelnemerButton.TabIndex = 22;
            this.createDeelnemerButton.Text = "Create";
            this.createDeelnemerButton.UseVisualStyleBackColor = true;
            this.createDeelnemerButton.Click += new System.EventHandler(this.CreateDeelnemerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(464, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 54);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CreateDeelnemerForm
            // 
            this.AcceptButton = this.createDeelnemerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(634, 271);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createDeelnemerButton);
            this.Controls.Add(this.GeboortedatumDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.badgeNummerTexBox);
            this.Controls.Add(this.woonplaatsTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Name = "CreateDeelnemerForm";
            this.Text = "CreateDeelnemer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox badgeNummerTexBox;
        private System.Windows.Forms.TextBox woonplaatsTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.DateTimePicker GeboortedatumDateTimePicker;
        private System.Windows.Forms.Button createDeelnemerButton;
        private System.Windows.Forms.Button cancelButton;
    }
}