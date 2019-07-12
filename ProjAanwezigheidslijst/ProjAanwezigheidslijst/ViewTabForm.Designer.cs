namespace ProjAanwezigheidslijst
{
    partial class ViewTabForm
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
            this.Control1 = new System.Windows.Forms.TabControl();
            this.DlnmrTabPage = new System.Windows.Forms.TabPage();
            this.ZoekListBox = new System.Windows.Forms.ListBox();
            this.ZoekButton = new System.Windows.Forms.Button();
            this.naamZoekTextBox = new System.Windows.Forms.TextBox();
            this.dlnmrListBox = new System.Windows.Forms.ListBox();
            this.dlnmrOplTabPage = new System.Windows.Forms.TabPage();
            this.dlnmrOplZoekListBox = new System.Windows.Forms.ListBox();
            this.dlnmrOplZoekButton = new System.Windows.Forms.Button();
            this.dlnmrOplZoekTextBox = new System.Windows.Forms.TextBox();
            this.dlnmrOplListBox = new System.Windows.Forms.ListBox();
            this.vakantieTabPage = new System.Windows.Forms.TabPage();
            this.vakDagZoekListBox = new System.Windows.Forms.ListBox();
            this.vakDagZoekButton = new System.Windows.Forms.Button();
            this.vakDagZoekTextBox = new System.Windows.Forms.TextBox();
            this.vakDagListBox = new System.Windows.Forms.ListBox();
            this.tijdsregTabPage = new System.Windows.Forms.TabPage();
            this.tijdRegZoekListBox = new System.Windows.Forms.ListBox();
            this.tijdsRegZoekButton = new System.Windows.Forms.Button();
            this.tijdsRegZoekTextBox = new System.Windows.Forms.TextBox();
            this.tijdsRegListBox = new System.Windows.Forms.ListBox();
            this.oplInfoTabPage = new System.Windows.Forms.TabPage();
            this.oplInfoZoekListBox = new System.Windows.Forms.ListBox();
            this.oplInfoZoekButton = new System.Windows.Forms.Button();
            this.oplInfoZoekTextBox = new System.Windows.Forms.TextBox();
            this.oplInfoListBox = new System.Windows.Forms.ListBox();
            this.docOplTabPage = new System.Windows.Forms.TabPage();
            this.docOplZoekListBox = new System.Windows.Forms.ListBox();
            this.docOplZoekButton = new System.Windows.Forms.Button();
            this.docOplZoekTextBox = new System.Windows.Forms.TextBox();
            this.docOplListBox = new System.Windows.Forms.ListBox();
            this.docTabPage = new System.Windows.Forms.TabPage();
            this.docZoekListBox = new System.Windows.Forms.ListBox();
            this.docZoekButton = new System.Windows.Forms.Button();
            this.docZoekTextBox = new System.Windows.Forms.TextBox();
            this.docListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.Control1.SuspendLayout();
            this.DlnmrTabPage.SuspendLayout();
            this.dlnmrOplTabPage.SuspendLayout();
            this.vakantieTabPage.SuspendLayout();
            this.tijdsregTabPage.SuspendLayout();
            this.oplInfoTabPage.SuspendLayout();
            this.docOplTabPage.SuspendLayout();
            this.docTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control1
            // 
            this.Control1.Controls.Add(this.DlnmrTabPage);
            this.Control1.Controls.Add(this.dlnmrOplTabPage);
            this.Control1.Controls.Add(this.vakantieTabPage);
            this.Control1.Controls.Add(this.tijdsregTabPage);
            this.Control1.Controls.Add(this.oplInfoTabPage);
            this.Control1.Controls.Add(this.docOplTabPage);
            this.Control1.Controls.Add(this.docTabPage);
            this.Control1.Location = new System.Drawing.Point(13, 13);
            this.Control1.Name = "Control1";
            this.Control1.SelectedIndex = 0;
            this.Control1.Size = new System.Drawing.Size(929, 475);
            this.Control1.TabIndex = 0;
            this.Control1.SelectedIndexChanged += new System.EventHandler(this.Control1_SelectedIndexChanged);
            // 
            // DlnmrTabPage
            // 
            this.DlnmrTabPage.BackColor = System.Drawing.Color.Silver;
            this.DlnmrTabPage.Controls.Add(this.ZoekListBox);
            this.DlnmrTabPage.Controls.Add(this.ZoekButton);
            this.DlnmrTabPage.Controls.Add(this.naamZoekTextBox);
            this.DlnmrTabPage.Controls.Add(this.dlnmrListBox);
            this.DlnmrTabPage.Location = new System.Drawing.Point(4, 29);
            this.DlnmrTabPage.Name = "DlnmrTabPage";
            this.DlnmrTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DlnmrTabPage.Size = new System.Drawing.Size(921, 442);
            this.DlnmrTabPage.TabIndex = 0;
            this.DlnmrTabPage.Text = "Deelnemers";
            // 
            // ZoekListBox
            // 
            this.ZoekListBox.FormattingEnabled = true;
            this.ZoekListBox.ItemHeight = 20;
            this.ZoekListBox.Location = new System.Drawing.Point(596, 6);
            this.ZoekListBox.Name = "ZoekListBox";
            this.ZoekListBox.Size = new System.Drawing.Size(319, 424);
            this.ZoekListBox.TabIndex = 4;
            // 
            // ZoekButton
            // 
            this.ZoekButton.Location = new System.Drawing.Point(331, 122);
            this.ZoekButton.Name = "ZoekButton";
            this.ZoekButton.Size = new System.Drawing.Size(128, 35);
            this.ZoekButton.TabIndex = 3;
            this.ZoekButton.Text = "Zoeken";
            this.ZoekButton.UseVisualStyleBackColor = true;
            this.ZoekButton.Click += new System.EventHandler(this.ZoekButton_Click);
            // 
            // naamZoekTextBox
            // 
            this.naamZoekTextBox.Location = new System.Drawing.Point(331, 90);
            this.naamZoekTextBox.Name = "naamZoekTextBox";
            this.naamZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.naamZoekTextBox.TabIndex = 2;
            this.naamZoekTextBox.Text = "Geef naam in";
            // 
            // dlnmrListBox
            // 
            this.dlnmrListBox.FormattingEnabled = true;
            this.dlnmrListBox.ItemHeight = 20;
            this.dlnmrListBox.Location = new System.Drawing.Point(6, 6);
            this.dlnmrListBox.Name = "dlnmrListBox";
            this.dlnmrListBox.Size = new System.Drawing.Size(319, 424);
            this.dlnmrListBox.TabIndex = 1;
            // 
            // dlnmrOplTabPage
            // 
            this.dlnmrOplTabPage.BackColor = System.Drawing.Color.Silver;
            this.dlnmrOplTabPage.Controls.Add(this.dlnmrOplZoekListBox);
            this.dlnmrOplTabPage.Controls.Add(this.dlnmrOplZoekButton);
            this.dlnmrOplTabPage.Controls.Add(this.dlnmrOplZoekTextBox);
            this.dlnmrOplTabPage.Controls.Add(this.dlnmrOplListBox);
            this.dlnmrOplTabPage.Location = new System.Drawing.Point(4, 29);
            this.dlnmrOplTabPage.Name = "dlnmrOplTabPage";
            this.dlnmrOplTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dlnmrOplTabPage.Size = new System.Drawing.Size(921, 442);
            this.dlnmrOplTabPage.TabIndex = 1;
            this.dlnmrOplTabPage.Text = "Deelnemers Opleidingen";
            // 
            // dlnmrOplZoekListBox
            // 
            this.dlnmrOplZoekListBox.FormattingEnabled = true;
            this.dlnmrOplZoekListBox.ItemHeight = 20;
            this.dlnmrOplZoekListBox.Location = new System.Drawing.Point(596, 9);
            this.dlnmrOplZoekListBox.Name = "dlnmrOplZoekListBox";
            this.dlnmrOplZoekListBox.Size = new System.Drawing.Size(319, 424);
            this.dlnmrOplZoekListBox.TabIndex = 8;
            // 
            // dlnmrOplZoekButton
            // 
            this.dlnmrOplZoekButton.Location = new System.Drawing.Point(331, 125);
            this.dlnmrOplZoekButton.Name = "dlnmrOplZoekButton";
            this.dlnmrOplZoekButton.Size = new System.Drawing.Size(128, 35);
            this.dlnmrOplZoekButton.TabIndex = 7;
            this.dlnmrOplZoekButton.Text = "Zoeken";
            this.dlnmrOplZoekButton.UseVisualStyleBackColor = true;
            // 
            // dlnmrOplZoekTextBox
            // 
            this.dlnmrOplZoekTextBox.Location = new System.Drawing.Point(331, 93);
            this.dlnmrOplZoekTextBox.Name = "dlnmrOplZoekTextBox";
            this.dlnmrOplZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.dlnmrOplZoekTextBox.TabIndex = 6;
            this.dlnmrOplZoekTextBox.Text = "Geef naam in";
            // 
            // dlnmrOplListBox
            // 
            this.dlnmrOplListBox.FormattingEnabled = true;
            this.dlnmrOplListBox.ItemHeight = 20;
            this.dlnmrOplListBox.Location = new System.Drawing.Point(6, 9);
            this.dlnmrOplListBox.Name = "dlnmrOplListBox";
            this.dlnmrOplListBox.Size = new System.Drawing.Size(319, 424);
            this.dlnmrOplListBox.TabIndex = 5;
            // 
            // vakantieTabPage
            // 
            this.vakantieTabPage.BackColor = System.Drawing.Color.Silver;
            this.vakantieTabPage.Controls.Add(this.vakDagZoekListBox);
            this.vakantieTabPage.Controls.Add(this.vakDagZoekButton);
            this.vakantieTabPage.Controls.Add(this.vakDagZoekTextBox);
            this.vakantieTabPage.Controls.Add(this.vakDagListBox);
            this.vakantieTabPage.Location = new System.Drawing.Point(4, 29);
            this.vakantieTabPage.Name = "vakantieTabPage";
            this.vakantieTabPage.Size = new System.Drawing.Size(921, 442);
            this.vakantieTabPage.TabIndex = 2;
            this.vakantieTabPage.Text = "Vakantiedagen";
            // 
            // vakDagZoekListBox
            // 
            this.vakDagZoekListBox.FormattingEnabled = true;
            this.vakDagZoekListBox.ItemHeight = 20;
            this.vakDagZoekListBox.Location = new System.Drawing.Point(596, 9);
            this.vakDagZoekListBox.Name = "vakDagZoekListBox";
            this.vakDagZoekListBox.Size = new System.Drawing.Size(319, 424);
            this.vakDagZoekListBox.TabIndex = 8;
            // 
            // vakDagZoekButton
            // 
            this.vakDagZoekButton.Location = new System.Drawing.Point(331, 125);
            this.vakDagZoekButton.Name = "vakDagZoekButton";
            this.vakDagZoekButton.Size = new System.Drawing.Size(128, 35);
            this.vakDagZoekButton.TabIndex = 7;
            this.vakDagZoekButton.Text = "Zoeken";
            this.vakDagZoekButton.UseVisualStyleBackColor = true;
            // 
            // vakDagZoekTextBox
            // 
            this.vakDagZoekTextBox.Location = new System.Drawing.Point(331, 93);
            this.vakDagZoekTextBox.Name = "vakDagZoekTextBox";
            this.vakDagZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.vakDagZoekTextBox.TabIndex = 6;
            this.vakDagZoekTextBox.Text = "Geef naam in";
            // 
            // vakDagListBox
            // 
            this.vakDagListBox.FormattingEnabled = true;
            this.vakDagListBox.ItemHeight = 20;
            this.vakDagListBox.Location = new System.Drawing.Point(6, 9);
            this.vakDagListBox.Name = "vakDagListBox";
            this.vakDagListBox.Size = new System.Drawing.Size(319, 424);
            this.vakDagListBox.TabIndex = 5;
            // 
            // tijdsregTabPage
            // 
            this.tijdsregTabPage.BackColor = System.Drawing.Color.Silver;
            this.tijdsregTabPage.Controls.Add(this.tijdRegZoekListBox);
            this.tijdsregTabPage.Controls.Add(this.tijdsRegZoekButton);
            this.tijdsregTabPage.Controls.Add(this.tijdsRegZoekTextBox);
            this.tijdsregTabPage.Controls.Add(this.tijdsRegListBox);
            this.tijdsregTabPage.Location = new System.Drawing.Point(4, 29);
            this.tijdsregTabPage.Name = "tijdsregTabPage";
            this.tijdsregTabPage.Size = new System.Drawing.Size(921, 442);
            this.tijdsregTabPage.TabIndex = 3;
            this.tijdsregTabPage.Text = "Tijdsregistratie";
            // 
            // tijdRegZoekListBox
            // 
            this.tijdRegZoekListBox.FormattingEnabled = true;
            this.tijdRegZoekListBox.ItemHeight = 20;
            this.tijdRegZoekListBox.Location = new System.Drawing.Point(596, 9);
            this.tijdRegZoekListBox.Name = "tijdRegZoekListBox";
            this.tijdRegZoekListBox.Size = new System.Drawing.Size(319, 424);
            this.tijdRegZoekListBox.TabIndex = 8;
            // 
            // tijdsRegZoekButton
            // 
            this.tijdsRegZoekButton.Location = new System.Drawing.Point(331, 125);
            this.tijdsRegZoekButton.Name = "tijdsRegZoekButton";
            this.tijdsRegZoekButton.Size = new System.Drawing.Size(128, 35);
            this.tijdsRegZoekButton.TabIndex = 7;
            this.tijdsRegZoekButton.Text = "Zoeken";
            this.tijdsRegZoekButton.UseVisualStyleBackColor = true;
            // 
            // tijdsRegZoekTextBox
            // 
            this.tijdsRegZoekTextBox.Location = new System.Drawing.Point(331, 93);
            this.tijdsRegZoekTextBox.Name = "tijdsRegZoekTextBox";
            this.tijdsRegZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.tijdsRegZoekTextBox.TabIndex = 6;
            this.tijdsRegZoekTextBox.Text = "Geef naam in";
            // 
            // tijdsRegListBox
            // 
            this.tijdsRegListBox.FormattingEnabled = true;
            this.tijdsRegListBox.ItemHeight = 20;
            this.tijdsRegListBox.Location = new System.Drawing.Point(6, 9);
            this.tijdsRegListBox.Name = "tijdsRegListBox";
            this.tijdsRegListBox.Size = new System.Drawing.Size(319, 424);
            this.tijdsRegListBox.TabIndex = 5;
            // 
            // oplInfoTabPage
            // 
            this.oplInfoTabPage.BackColor = System.Drawing.Color.Silver;
            this.oplInfoTabPage.Controls.Add(this.hScrollBar1);
            this.oplInfoTabPage.Controls.Add(this.oplInfoZoekListBox);
            this.oplInfoTabPage.Controls.Add(this.oplInfoZoekButton);
            this.oplInfoTabPage.Controls.Add(this.oplInfoZoekTextBox);
            this.oplInfoTabPage.Controls.Add(this.oplInfoListBox);
            this.oplInfoTabPage.Location = new System.Drawing.Point(4, 29);
            this.oplInfoTabPage.Name = "oplInfoTabPage";
            this.oplInfoTabPage.Size = new System.Drawing.Size(921, 442);
            this.oplInfoTabPage.TabIndex = 4;
            this.oplInfoTabPage.Text = "Opleidingsinformatie";
            // 
            // oplInfoZoekListBox
            // 
            this.oplInfoZoekListBox.FormattingEnabled = true;
            this.oplInfoZoekListBox.ItemHeight = 20;
            this.oplInfoZoekListBox.Location = new System.Drawing.Point(6, 300);
            this.oplInfoZoekListBox.Name = "oplInfoZoekListBox";
            this.oplInfoZoekListBox.Size = new System.Drawing.Size(909, 124);
            this.oplInfoZoekListBox.TabIndex = 8;
            // 
            // oplInfoZoekButton
            // 
            this.oplInfoZoekButton.Location = new System.Drawing.Point(6, 250);
            this.oplInfoZoekButton.Name = "oplInfoZoekButton";
            this.oplInfoZoekButton.Size = new System.Drawing.Size(128, 35);
            this.oplInfoZoekButton.TabIndex = 7;
            this.oplInfoZoekButton.Text = "Zoeken";
            this.oplInfoZoekButton.UseVisualStyleBackColor = true;
            // 
            // oplInfoZoekTextBox
            // 
            this.oplInfoZoekTextBox.Location = new System.Drawing.Point(3, 218);
            this.oplInfoZoekTextBox.Name = "oplInfoZoekTextBox";
            this.oplInfoZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.oplInfoZoekTextBox.TabIndex = 6;
            this.oplInfoZoekTextBox.Text = "Geef naam in";
            // 
            // oplInfoListBox
            // 
            this.oplInfoListBox.FormattingEnabled = true;
            this.oplInfoListBox.ItemHeight = 20;
            this.oplInfoListBox.Location = new System.Drawing.Point(6, 9);
            this.oplInfoListBox.Name = "oplInfoListBox";
            this.oplInfoListBox.Size = new System.Drawing.Size(909, 204);
            this.oplInfoListBox.TabIndex = 5;
            // 
            // docOplTabPage
            // 
            this.docOplTabPage.BackColor = System.Drawing.Color.Silver;
            this.docOplTabPage.Controls.Add(this.docOplZoekListBox);
            this.docOplTabPage.Controls.Add(this.docOplZoekButton);
            this.docOplTabPage.Controls.Add(this.docOplZoekTextBox);
            this.docOplTabPage.Controls.Add(this.docOplListBox);
            this.docOplTabPage.Location = new System.Drawing.Point(4, 29);
            this.docOplTabPage.Name = "docOplTabPage";
            this.docOplTabPage.Size = new System.Drawing.Size(921, 442);
            this.docOplTabPage.TabIndex = 5;
            this.docOplTabPage.Text = "Docenten Opleidingen";
            // 
            // docOplZoekListBox
            // 
            this.docOplZoekListBox.FormattingEnabled = true;
            this.docOplZoekListBox.ItemHeight = 20;
            this.docOplZoekListBox.Location = new System.Drawing.Point(596, 9);
            this.docOplZoekListBox.Name = "docOplZoekListBox";
            this.docOplZoekListBox.Size = new System.Drawing.Size(319, 424);
            this.docOplZoekListBox.TabIndex = 8;
            // 
            // docOplZoekButton
            // 
            this.docOplZoekButton.Location = new System.Drawing.Point(331, 125);
            this.docOplZoekButton.Name = "docOplZoekButton";
            this.docOplZoekButton.Size = new System.Drawing.Size(128, 35);
            this.docOplZoekButton.TabIndex = 7;
            this.docOplZoekButton.Text = "Zoeken";
            this.docOplZoekButton.UseVisualStyleBackColor = true;
            // 
            // docOplZoekTextBox
            // 
            this.docOplZoekTextBox.Location = new System.Drawing.Point(331, 93);
            this.docOplZoekTextBox.Name = "docOplZoekTextBox";
            this.docOplZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.docOplZoekTextBox.TabIndex = 6;
            this.docOplZoekTextBox.Text = "Geef naam in";
            // 
            // docOplListBox
            // 
            this.docOplListBox.FormattingEnabled = true;
            this.docOplListBox.ItemHeight = 20;
            this.docOplListBox.Location = new System.Drawing.Point(6, 9);
            this.docOplListBox.Name = "docOplListBox";
            this.docOplListBox.Size = new System.Drawing.Size(319, 424);
            this.docOplListBox.TabIndex = 5;
            // 
            // docTabPage
            // 
            this.docTabPage.BackColor = System.Drawing.Color.Silver;
            this.docTabPage.Controls.Add(this.docZoekListBox);
            this.docTabPage.Controls.Add(this.docZoekButton);
            this.docTabPage.Controls.Add(this.docZoekTextBox);
            this.docTabPage.Controls.Add(this.docListBox);
            this.docTabPage.Location = new System.Drawing.Point(4, 29);
            this.docTabPage.Name = "docTabPage";
            this.docTabPage.Size = new System.Drawing.Size(921, 442);
            this.docTabPage.TabIndex = 6;
            this.docTabPage.Text = "Docenten";
            // 
            // docZoekListBox
            // 
            this.docZoekListBox.FormattingEnabled = true;
            this.docZoekListBox.ItemHeight = 20;
            this.docZoekListBox.Location = new System.Drawing.Point(596, 9);
            this.docZoekListBox.Name = "docZoekListBox";
            this.docZoekListBox.Size = new System.Drawing.Size(319, 424);
            this.docZoekListBox.TabIndex = 8;
            // 
            // docZoekButton
            // 
            this.docZoekButton.Location = new System.Drawing.Point(331, 125);
            this.docZoekButton.Name = "docZoekButton";
            this.docZoekButton.Size = new System.Drawing.Size(128, 35);
            this.docZoekButton.TabIndex = 7;
            this.docZoekButton.Text = "Zoeken";
            this.docZoekButton.UseVisualStyleBackColor = true;
            // 
            // docZoekTextBox
            // 
            this.docZoekTextBox.Location = new System.Drawing.Point(331, 93);
            this.docZoekTextBox.Name = "docZoekTextBox";
            this.docZoekTextBox.Size = new System.Drawing.Size(259, 26);
            this.docZoekTextBox.TabIndex = 6;
            this.docZoekTextBox.Text = "Geef naam in";
            // 
            // docListBox
            // 
            this.docListBox.FormattingEnabled = true;
            this.docListBox.ItemHeight = 20;
            this.docListBox.Location = new System.Drawing.Point(6, 9);
            this.docListBox.Name = "docListBox";
            this.docListBox.Size = new System.Drawing.Size(319, 424);
            this.docListBox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(780, 566);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 54);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(7, 192);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(908, 21);
            this.hScrollBar1.TabIndex = 9;
            // 
            // ViewTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 632);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Control1);
            this.Name = "ViewTabForm";
            this.Text = "ViewTabForm";
            this.Load += new System.EventHandler(this.ViewTabForm_Load);
            this.Control1.ResumeLayout(false);
            this.DlnmrTabPage.ResumeLayout(false);
            this.DlnmrTabPage.PerformLayout();
            this.dlnmrOplTabPage.ResumeLayout(false);
            this.dlnmrOplTabPage.PerformLayout();
            this.vakantieTabPage.ResumeLayout(false);
            this.vakantieTabPage.PerformLayout();
            this.tijdsregTabPage.ResumeLayout(false);
            this.tijdsregTabPage.PerformLayout();
            this.oplInfoTabPage.ResumeLayout(false);
            this.oplInfoTabPage.PerformLayout();
            this.docOplTabPage.ResumeLayout(false);
            this.docOplTabPage.PerformLayout();
            this.docTabPage.ResumeLayout(false);
            this.docTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Control1;
        private System.Windows.Forms.TabPage DlnmrTabPage;
        private System.Windows.Forms.TabPage dlnmrOplTabPage;
        private System.Windows.Forms.TabPage vakantieTabPage;
        private System.Windows.Forms.TabPage tijdsregTabPage;
        private System.Windows.Forms.TabPage oplInfoTabPage;
        private System.Windows.Forms.TabPage docOplTabPage;
        private System.Windows.Forms.TabPage docTabPage;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox dlnmrListBox;
        private System.Windows.Forms.TextBox naamZoekTextBox;
        private System.Windows.Forms.ListBox ZoekListBox;
        private System.Windows.Forms.Button ZoekButton;
        private System.Windows.Forms.ListBox dlnmrOplZoekListBox;
        private System.Windows.Forms.Button dlnmrOplZoekButton;
        private System.Windows.Forms.TextBox dlnmrOplZoekTextBox;
        private System.Windows.Forms.ListBox dlnmrOplListBox;
        private System.Windows.Forms.ListBox vakDagZoekListBox;
        private System.Windows.Forms.Button vakDagZoekButton;
        private System.Windows.Forms.TextBox vakDagZoekTextBox;
        private System.Windows.Forms.ListBox vakDagListBox;
        private System.Windows.Forms.ListBox tijdRegZoekListBox;
        private System.Windows.Forms.Button tijdsRegZoekButton;
        private System.Windows.Forms.TextBox tijdsRegZoekTextBox;
        private System.Windows.Forms.ListBox tijdsRegListBox;
        private System.Windows.Forms.ListBox oplInfoZoekListBox;
        private System.Windows.Forms.Button oplInfoZoekButton;
        private System.Windows.Forms.TextBox oplInfoZoekTextBox;
        private System.Windows.Forms.ListBox oplInfoListBox;
        private System.Windows.Forms.ListBox docOplZoekListBox;
        private System.Windows.Forms.Button docOplZoekButton;
        private System.Windows.Forms.TextBox docOplZoekTextBox;
        private System.Windows.Forms.ListBox docOplListBox;
        private System.Windows.Forms.ListBox docZoekListBox;
        private System.Windows.Forms.Button docZoekButton;
        private System.Windows.Forms.TextBox docZoekTextBox;
        private System.Windows.Forms.ListBox docListBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}