namespace ProjAanwezigheidslijst
{
    partial class CreateFeestdagenForm
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
            this.createNietOplDagButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nietOplDagDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.voormiddagCheckBox = new System.Windows.Forms.CheckBox();
            this.namiddagCheckBox = new System.Windows.Forms.CheckBox();
            this.OplIdComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(464, 204);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 54);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createNietOplDagButton
            // 
            this.createNietOplDagButton.Location = new System.Drawing.Point(13, 204);
            this.createNietOplDagButton.Name = "createNietOplDagButton";
            this.createNietOplDagButton.Size = new System.Drawing.Size(158, 54);
            this.createNietOplDagButton.TabIndex = 32;
            this.createNietOplDagButton.Text = "Create";
            this.createNietOplDagButton.UseVisualStyleBackColor = true;
            this.createNietOplDagButton.Click += new System.EventHandler(this.CreateNietOplDagButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "opleidingsId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Namiddag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Voormiddag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Datum";
            // 
            // nietOplDagDateTimePicker
            // 
            this.nietOplDagDateTimePicker.Location = new System.Drawing.Point(13, 11);
            this.nietOplDagDateTimePicker.Name = "nietOplDagDateTimePicker";
            this.nietOplDagDateTimePicker.Size = new System.Drawing.Size(380, 26);
            this.nietOplDagDateTimePicker.TabIndex = 34;
            // 
            // voormiddagCheckBox
            // 
            this.voormiddagCheckBox.AutoSize = true;
            this.voormiddagCheckBox.Location = new System.Drawing.Point(371, 56);
            this.voormiddagCheckBox.Name = "voormiddagCheckBox";
            this.voormiddagCheckBox.Size = new System.Drawing.Size(22, 21);
            this.voormiddagCheckBox.TabIndex = 35;
            this.voormiddagCheckBox.UseVisualStyleBackColor = true;
            // 
            // namiddagCheckBox
            // 
            this.namiddagCheckBox.AutoSize = true;
            this.namiddagCheckBox.Location = new System.Drawing.Point(371, 99);
            this.namiddagCheckBox.Name = "namiddagCheckBox";
            this.namiddagCheckBox.Size = new System.Drawing.Size(22, 21);
            this.namiddagCheckBox.TabIndex = 36;
            this.namiddagCheckBox.UseVisualStyleBackColor = true;
            // 
            // OplIdComboBox
            // 
            this.OplIdComboBox.FormattingEnabled = true;
            this.OplIdComboBox.Location = new System.Drawing.Point(13, 144);
            this.OplIdComboBox.Name = "OplIdComboBox";
            this.OplIdComboBox.Size = new System.Drawing.Size(380, 28);
            this.OplIdComboBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vink aan indien geen opleiding :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Vink aan indien geen opleiding :";
            // 
            // CreateFeestdagenForm
            // 
            this.AcceptButton = this.createNietOplDagButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(651, 273);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OplIdComboBox);
            this.Controls.Add(this.namiddagCheckBox);
            this.Controls.Add(this.voormiddagCheckBox);
            this.Controls.Add(this.nietOplDagDateTimePicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createNietOplDagButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateFeestdagenForm";
            this.Text = "CreateFeestdagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createNietOplDagButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker nietOplDagDateTimePicker;
        private System.Windows.Forms.CheckBox voormiddagCheckBox;
        private System.Windows.Forms.CheckBox namiddagCheckBox;
        private System.Windows.Forms.ComboBox OplIdComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}