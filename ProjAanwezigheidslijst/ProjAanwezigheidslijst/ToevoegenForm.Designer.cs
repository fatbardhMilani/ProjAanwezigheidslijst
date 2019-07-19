namespace ProjAanwezigheidslijst
{
    partial class ToevoegenForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CreateOpleidingsInfoButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eindDatDtP = new System.Windows.Forms.DateTimePicker();
            this.startDatDtP = new System.Windows.Forms.DateTimePicker();
            this.oplCdTB = new System.Windows.Forms.TextBox();
            this.OeNumTB = new System.Windows.Forms.TextBox();
            this.refOplTB = new System.Windows.Forms.TextBox();
            this.oplPlTB = new System.Windows.Forms.TextBox();
            this.cntcpTB = new System.Windows.Forms.TextBox();
            this.oplTB = new System.Windows.Forms.TextBox();
            this.oplInstTB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createDeelnemerButton = new System.Windows.Forms.Button();
            this.geboorteDatDtP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bdgNumTB = new System.Windows.Forms.TextBox();
            this.wnpltsTB = new System.Windows.Forms.TextBox();
            this.dlnmrNaamTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.vakdagOplIdComB = new System.Windows.Forms.ComboBox();
            this.nmdgCB = new System.Windows.Forms.CheckBox();
            this.vmdgCB = new System.Windows.Forms.CheckBox();
            this.vakDagDtP = new System.Windows.Forms.DateTimePicker();
            this.createNietOplDagButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.createDocentButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.docBedrijfTB = new System.Windows.Forms.TextBox();
            this.docNaamTB = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dlnmrOplNaamComB = new System.Windows.Forms.ComboBox();
            this.dlnmrOplOplComB = new System.Windows.Forms.ComboBox();
            this.createDlnmrOplButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dlnmOplOplIdTextBox = new System.Windows.Forms.TextBox();
            this.dlnmrOplIdTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.DocErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.oplInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlnmrErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DocOpltabPage = new System.Windows.Forms.TabPage();
            this.docNaamComB = new System.Windows.Forms.ComboBox();
            this.docOplComB = new System.Windows.Forms.ComboBox();
            this.docOplCreateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplInfoErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlnmrErrorProvider)).BeginInit();
            this.DocOpltabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.DocOpltabPage);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 635);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.CreateOpleidingsInfoButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.eindDatDtP);
            this.tabPage1.Controls.Add(this.startDatDtP);
            this.tabPage1.Controls.Add(this.oplCdTB);
            this.tabPage1.Controls.Add(this.OeNumTB);
            this.tabPage1.Controls.Add(this.refOplTB);
            this.tabPage1.Controls.Add(this.oplPlTB);
            this.tabPage1.Controls.Add(this.cntcpTB);
            this.tabPage1.Controls.Add(this.oplTB);
            this.tabPage1.Controls.Add(this.oplInstTB);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1087, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opleiding Informatie";
            // 
            // CreateOpleidingsInfoButton
            // 
            this.CreateOpleidingsInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOpleidingsInfoButton.Location = new System.Drawing.Point(31, 512);
            this.CreateOpleidingsInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOpleidingsInfoButton.Name = "CreateOpleidingsInfoButton";
            this.CreateOpleidingsInfoButton.Size = new System.Drawing.Size(211, 68);
            this.CreateOpleidingsInfoButton.TabIndex = 38;
            this.CreateOpleidingsInfoButton.Text = "Create";
            this.CreateOpleidingsInfoButton.UseVisualStyleBackColor = true;
            this.CreateOpleidingsInfoButton.Click += new System.EventHandler(this.CreateOpleidingsInfoButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(577, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 26);
            this.label9.TabIndex = 37;
            this.label9.Text = "Eind datum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Start datum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "Opleidingscode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Oe-Nummer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Referentie Opleidingsplaats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Opleidingsplaats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Contactpersoon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Opleiding";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Opleidingsinstelling";
            // 
            // eindDatDtP
            // 
            this.eindDatDtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eindDatDtP.Location = new System.Drawing.Point(31, 455);
            this.eindDatDtP.Margin = new System.Windows.Forms.Padding(4);
            this.eindDatDtP.Name = "eindDatDtP";
            this.eindDatDtP.Size = new System.Drawing.Size(507, 32);
            this.eindDatDtP.TabIndex = 28;
            this.eindDatDtP.Validating += new System.ComponentModel.CancelEventHandler(this.EindDatDtP_Validating);
            // 
            // startDatDtP
            // 
            this.startDatDtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatDtP.Location = new System.Drawing.Point(31, 401);
            this.startDatDtP.Margin = new System.Windows.Forms.Padding(4);
            this.startDatDtP.Name = "startDatDtP";
            this.startDatDtP.Size = new System.Drawing.Size(507, 32);
            this.startDatDtP.TabIndex = 27;
            this.startDatDtP.Validating += new System.ComponentModel.CancelEventHandler(this.StartDatDtP_Validating);
            // 
            // oplCdTB
            // 
            this.oplCdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplCdTB.Location = new System.Drawing.Point(31, 348);
            this.oplCdTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplCdTB.Name = "oplCdTB";
            this.oplCdTB.Size = new System.Drawing.Size(507, 32);
            this.oplCdTB.TabIndex = 26;
            this.oplCdTB.Validating += new System.ComponentModel.CancelEventHandler(this.OeNumTB_Validating);
            // 
            // OeNumTB
            // 
            this.OeNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OeNumTB.Location = new System.Drawing.Point(31, 294);
            this.OeNumTB.Margin = new System.Windows.Forms.Padding(4);
            this.OeNumTB.Name = "OeNumTB";
            this.OeNumTB.Size = new System.Drawing.Size(507, 32);
            this.OeNumTB.TabIndex = 25;
            this.OeNumTB.Validating += new System.ComponentModel.CancelEventHandler(this.OeNumTB_Validating);
            // 
            // refOplTB
            // 
            this.refOplTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refOplTB.Location = new System.Drawing.Point(31, 238);
            this.refOplTB.Margin = new System.Windows.Forms.Padding(4);
            this.refOplTB.Name = "refOplTB";
            this.refOplTB.Size = new System.Drawing.Size(507, 32);
            this.refOplTB.TabIndex = 24;
            this.refOplTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplPlTB_Validating);
            // 
            // oplPlTB
            // 
            this.oplPlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplPlTB.Location = new System.Drawing.Point(31, 185);
            this.oplPlTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplPlTB.Name = "oplPlTB";
            this.oplPlTB.Size = new System.Drawing.Size(507, 32);
            this.oplPlTB.TabIndex = 23;
            this.oplPlTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplPlTB_Validating);
            // 
            // cntcpTB
            // 
            this.cntcpTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntcpTB.Location = new System.Drawing.Point(31, 129);
            this.cntcpTB.Margin = new System.Windows.Forms.Padding(4);
            this.cntcpTB.Name = "cntcpTB";
            this.cntcpTB.Size = new System.Drawing.Size(507, 32);
            this.cntcpTB.TabIndex = 22;
            this.cntcpTB.Validating += new System.ComponentModel.CancelEventHandler(this.CntcpTB_Validating);
            // 
            // oplTB
            // 
            this.oplTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplTB.Location = new System.Drawing.Point(31, 75);
            this.oplTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplTB.Name = "oplTB";
            this.oplTB.Size = new System.Drawing.Size(507, 32);
            this.oplTB.TabIndex = 21;
            this.oplTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplTB_Validating);
            // 
            // oplInstTB
            // 
            this.oplInstTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplInstTB.Location = new System.Drawing.Point(31, 19);
            this.oplInstTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplInstTB.Name = "oplInstTB";
            this.oplInstTB.Size = new System.Drawing.Size(507, 32);
            this.oplInstTB.TabIndex = 20;
            this.oplInstTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplInstTB_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.createDeelnemerButton);
            this.tabPage2.Controls.Add(this.geboorteDatDtP);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.bdgNumTB);
            this.tabPage2.Controls.Add(this.wnpltsTB);
            this.tabPage2.Controls.Add(this.dlnmrNaamTB);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1087, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deelnemers";
            // 
            // createDeelnemerButton
            // 
            this.createDeelnemerButton.Location = new System.Drawing.Point(31, 512);
            this.createDeelnemerButton.Margin = new System.Windows.Forms.Padding(4);
            this.createDeelnemerButton.Name = "createDeelnemerButton";
            this.createDeelnemerButton.Size = new System.Drawing.Size(211, 68);
            this.createDeelnemerButton.TabIndex = 32;
            this.createDeelnemerButton.Text = "Create";
            this.createDeelnemerButton.UseVisualStyleBackColor = true;
            this.createDeelnemerButton.Click += new System.EventHandler(this.CreateDeelnemerButton_Click);
            // 
            // geboorteDatDtP
            // 
            this.geboorteDatDtP.Location = new System.Drawing.Point(31, 75);
            this.geboorteDatDtP.Margin = new System.Windows.Forms.Padding(4);
            this.geboorteDatDtP.Name = "geboorteDatDtP";
            this.geboorteDatDtP.Size = new System.Drawing.Size(505, 31);
            this.geboorteDatDtP.TabIndex = 31;
            this.geboorteDatDtP.Validating += new System.ComponentModel.CancelEventHandler(this.GeboorteDatDtP_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Badge nummer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Woonplaats";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Geboortedatum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Naam";
            // 
            // bdgNumTB
            // 
            this.bdgNumTB.Location = new System.Drawing.Point(31, 185);
            this.bdgNumTB.Margin = new System.Windows.Forms.Padding(4);
            this.bdgNumTB.Name = "bdgNumTB";
            this.bdgNumTB.Size = new System.Drawing.Size(507, 31);
            this.bdgNumTB.TabIndex = 26;
            this.bdgNumTB.Validating += new System.ComponentModel.CancelEventHandler(this.BdgNumTB_Validating);
            // 
            // wnpltsTB
            // 
            this.wnpltsTB.Location = new System.Drawing.Point(31, 129);
            this.wnpltsTB.Margin = new System.Windows.Forms.Padding(4);
            this.wnpltsTB.Name = "wnpltsTB";
            this.wnpltsTB.Size = new System.Drawing.Size(507, 31);
            this.wnpltsTB.TabIndex = 25;
            this.wnpltsTB.Validating += new System.ComponentModel.CancelEventHandler(this.WnpltsTB_Validating);
            // 
            // dlnmrNaamTB
            // 
            this.dlnmrNaamTB.Location = new System.Drawing.Point(31, 19);
            this.dlnmrNaamTB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrNaamTB.Name = "dlnmrNaamTB";
            this.dlnmrNaamTB.Size = new System.Drawing.Size(507, 31);
            this.dlnmrNaamTB.TabIndex = 24;
            this.dlnmrNaamTB.Validating += new System.ComponentModel.CancelEventHandler(this.DlnmrNaamTB_Validating);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.vakdagOplIdComB);
            this.tabPage3.Controls.Add(this.nmdgCB);
            this.tabPage3.Controls.Add(this.vmdgCB);
            this.tabPage3.Controls.Add(this.vakDagDtP);
            this.tabPage3.Controls.Add(this.createNietOplDagButton);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1087, 588);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vakantiedagen";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(191, 126);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(319, 25);
            this.label14.TabIndex = 51;
            this.label14.Text = "Vink aan indien geen opleiding :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 72);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(319, 25);
            this.label15.TabIndex = 50;
            this.label15.Text = "Vink aan indien geen opleiding :";
            // 
            // vakdagOplIdComB
            // 
            this.vakdagOplIdComB.FormattingEnabled = true;
            this.vakdagOplIdComB.Location = new System.Drawing.Point(31, 185);
            this.vakdagOplIdComB.Margin = new System.Windows.Forms.Padding(4);
            this.vakdagOplIdComB.Name = "vakdagOplIdComB";
            this.vakdagOplIdComB.Size = new System.Drawing.Size(505, 33);
            this.vakdagOplIdComB.TabIndex = 49;
            // 
            // nmdgCB
            // 
            this.nmdgCB.AutoSize = true;
            this.nmdgCB.Location = new System.Drawing.Point(508, 128);
            this.nmdgCB.Margin = new System.Windows.Forms.Padding(4);
            this.nmdgCB.Name = "nmdgCB";
            this.nmdgCB.Size = new System.Drawing.Size(28, 27);
            this.nmdgCB.TabIndex = 48;
            this.nmdgCB.UseVisualStyleBackColor = true;
            // 
            // vmdgCB
            // 
            this.vmdgCB.AutoSize = true;
            this.vmdgCB.Location = new System.Drawing.Point(508, 72);
            this.vmdgCB.Margin = new System.Windows.Forms.Padding(4);
            this.vmdgCB.Name = "vmdgCB";
            this.vmdgCB.Size = new System.Drawing.Size(28, 27);
            this.vmdgCB.TabIndex = 47;
            this.vmdgCB.UseVisualStyleBackColor = true;
            // 
            // vakDagDtP
            // 
            this.vakDagDtP.Location = new System.Drawing.Point(31, 19);
            this.vakDagDtP.Margin = new System.Windows.Forms.Padding(4);
            this.vakDagDtP.Name = "vakDagDtP";
            this.vakDagDtP.Size = new System.Drawing.Size(505, 31);
            this.vakDagDtP.TabIndex = 46;
            // 
            // createNietOplDagButton
            // 
            this.createNietOplDagButton.Location = new System.Drawing.Point(31, 512);
            this.createNietOplDagButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNietOplDagButton.Name = "createNietOplDagButton";
            this.createNietOplDagButton.Size = new System.Drawing.Size(211, 68);
            this.createNietOplDagButton.TabIndex = 44;
            this.createNietOplDagButton.Text = "Create";
            this.createNietOplDagButton.UseVisualStyleBackColor = true;
            this.createNietOplDagButton.Click += new System.EventHandler(this.CreateNietOplDagButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(577, 185);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "opleidingsId";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(577, 129);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 25);
            this.label17.TabIndex = 42;
            this.label17.Text = "Namiddag";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(577, 75);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 25);
            this.label18.TabIndex = 41;
            this.label18.Text = "Voormiddag";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(577, 19);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 25);
            this.label19.TabIndex = 40;
            this.label19.Text = "Datum";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.createDocentButton);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.docBedrijfTB);
            this.tabPage4.Controls.Add(this.docNaamTB);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1087, 588);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Doceneten";
            // 
            // createDocentButton
            // 
            this.createDocentButton.Location = new System.Drawing.Point(31, 512);
            this.createDocentButton.Margin = new System.Windows.Forms.Padding(4);
            this.createDocentButton.Name = "createDocentButton";
            this.createDocentButton.Size = new System.Drawing.Size(211, 68);
            this.createDocentButton.TabIndex = 34;
            this.createDocentButton.Text = "Create";
            this.createDocentButton.UseVisualStyleBackColor = true;
            this.createDocentButton.Click += new System.EventHandler(this.CreateDocentButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(577, 75);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 25);
            this.label20.TabIndex = 33;
            this.label20.Text = "Bedrijf";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(577, 19);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 25);
            this.label21.TabIndex = 32;
            this.label21.Text = "Naam";
            // 
            // docBedrijfTB
            // 
            this.docBedrijfTB.Location = new System.Drawing.Point(31, 75);
            this.docBedrijfTB.Margin = new System.Windows.Forms.Padding(4);
            this.docBedrijfTB.Name = "docBedrijfTB";
            this.docBedrijfTB.Size = new System.Drawing.Size(507, 31);
            this.docBedrijfTB.TabIndex = 31;
            this.docBedrijfTB.Validating += new System.ComponentModel.CancelEventHandler(this.DocBedrijfTB_Validating);
            // 
            // docNaamTB
            // 
            this.docNaamTB.Location = new System.Drawing.Point(31, 19);
            this.docNaamTB.Margin = new System.Windows.Forms.Padding(4);
            this.docNaamTB.Name = "docNaamTB";
            this.docNaamTB.Size = new System.Drawing.Size(507, 31);
            this.docNaamTB.TabIndex = 30;
            this.docNaamTB.Validating += new System.ComponentModel.CancelEventHandler(this.DocNaamTB_Validating);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Controls.Add(this.dlnmrOplNaamComB);
            this.tabPage5.Controls.Add(this.dlnmrOplOplComB);
            this.tabPage5.Controls.Add(this.createDlnmrOplButton);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.dlnmOplOplIdTextBox);
            this.tabPage5.Controls.Add(this.dlnmrOplIdTextBox);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1087, 588);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Deelnemer opleidingen";
            // 
            // dlnmrOplNaamComB
            // 
            this.dlnmrOplNaamComB.FormattingEnabled = true;
            this.dlnmrOplNaamComB.Location = new System.Drawing.Point(31, 19);
            this.dlnmrOplNaamComB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplNaamComB.Name = "dlnmrOplNaamComB";
            this.dlnmrOplNaamComB.Size = new System.Drawing.Size(507, 33);
            this.dlnmrOplNaamComB.TabIndex = 41;
            // 
            // dlnmrOplOplComB
            // 
            this.dlnmrOplOplComB.FormattingEnabled = true;
            this.dlnmrOplOplComB.Location = new System.Drawing.Point(31, 75);
            this.dlnmrOplOplComB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplOplComB.Name = "dlnmrOplOplComB";
            this.dlnmrOplOplComB.Size = new System.Drawing.Size(507, 33);
            this.dlnmrOplOplComB.TabIndex = 40;
            // 
            // createDlnmrOplButton
            // 
            this.createDlnmrOplButton.Location = new System.Drawing.Point(31, 512);
            this.createDlnmrOplButton.Margin = new System.Windows.Forms.Padding(4);
            this.createDlnmrOplButton.Name = "createDlnmrOplButton";
            this.createDlnmrOplButton.Size = new System.Drawing.Size(211, 68);
            this.createDlnmrOplButton.TabIndex = 39;
            this.createDlnmrOplButton.Text = "Create";
            this.createDlnmrOplButton.UseVisualStyleBackColor = true;
            this.createDlnmrOplButton.Click += new System.EventHandler(this.CreateDlnmrOplButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(577, 75);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 25);
            this.label22.TabIndex = 38;
            this.label22.Text = "Opleiding";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(577, 19);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 25);
            this.label23.TabIndex = 37;
            this.label23.Text = "Naam";
            // 
            // dlnmOplOplIdTextBox
            // 
            this.dlnmOplOplIdTextBox.Location = new System.Drawing.Point(31, 199);
            this.dlnmOplOplIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmOplOplIdTextBox.Name = "dlnmOplOplIdTextBox";
            this.dlnmOplOplIdTextBox.Size = new System.Drawing.Size(507, 31);
            this.dlnmOplOplIdTextBox.TabIndex = 36;
            // 
            // dlnmrOplIdTextBox
            // 
            this.dlnmrOplIdTextBox.Location = new System.Drawing.Point(31, 159);
            this.dlnmrOplIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplIdTextBox.Name = "dlnmrOplIdTextBox";
            this.dlnmrOplIdTextBox.Size = new System.Drawing.Size(507, 31);
            this.dlnmrOplIdTextBox.TabIndex = 35;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(904, 708);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(211, 68);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DocErrorProvider
            // 
            this.DocErrorProvider.ContainerControl = this;
            // 
            // oplInfoErrorProvider
            // 
            this.oplInfoErrorProvider.ContainerControl = this;
            // 
            // dlnmrErrorProvider
            // 
            this.dlnmrErrorProvider.ContainerControl = this;
            // 
            // DocOpltabPage
            // 
            this.DocOpltabPage.BackColor = System.Drawing.Color.Silver;
            this.DocOpltabPage.Controls.Add(this.docNaamComB);
            this.DocOpltabPage.Controls.Add(this.docOplComB);
            this.DocOpltabPage.Controls.Add(this.docOplCreateButton);
            this.DocOpltabPage.Controls.Add(this.textBox1);
            this.DocOpltabPage.Controls.Add(this.textBox2);
            this.DocOpltabPage.Location = new System.Drawing.Point(8, 39);
            this.DocOpltabPage.Name = "DocOpltabPage";
            this.DocOpltabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DocOpltabPage.Size = new System.Drawing.Size(1087, 588);
            this.DocOpltabPage.TabIndex = 5;
            this.DocOpltabPage.Text = "Docenten opleidingen";
            // 
            // docNaamComB
            // 
            this.docNaamComB.FormattingEnabled = true;
            this.docNaamComB.Location = new System.Drawing.Point(31, 19);
            this.docNaamComB.Margin = new System.Windows.Forms.Padding(4);
            this.docNaamComB.Name = "docNaamComB";
            this.docNaamComB.Size = new System.Drawing.Size(507, 33);
            this.docNaamComB.TabIndex = 46;
            // 
            // docOplComB
            // 
            this.docOplComB.FormattingEnabled = true;
            this.docOplComB.Location = new System.Drawing.Point(31, 75);
            this.docOplComB.Margin = new System.Windows.Forms.Padding(4);
            this.docOplComB.Name = "docOplComB";
            this.docOplComB.Size = new System.Drawing.Size(507, 33);
            this.docOplComB.TabIndex = 45;
            // 
            // docOplCreateButton
            // 
            this.docOplCreateButton.Location = new System.Drawing.Point(31, 512);
            this.docOplCreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.docOplCreateButton.Name = "docOplCreateButton";
            this.docOplCreateButton.Size = new System.Drawing.Size(211, 68);
            this.docOplCreateButton.TabIndex = 44;
            this.docOplCreateButton.Text = "Create";
            this.docOplCreateButton.UseVisualStyleBackColor = true;
            this.docOplCreateButton.Click += new System.EventHandler(this.DocOplCreateButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 31);
            this.textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(507, 31);
            this.textBox2.TabIndex = 42;
            // 
            // ToevoegenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1137, 790);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToevoegenForm";
            this.Text = "Toevoegen";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplInfoErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlnmrErrorProvider)).EndInit();
            this.DocOpltabPage.ResumeLayout(false);
            this.DocOpltabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button CreateOpleidingsInfoButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker eindDatDtP;
        private System.Windows.Forms.DateTimePicker startDatDtP;
        private System.Windows.Forms.TextBox oplCdTB;
        private System.Windows.Forms.TextBox OeNumTB;
        private System.Windows.Forms.TextBox refOplTB;
        private System.Windows.Forms.TextBox oplPlTB;
        private System.Windows.Forms.TextBox cntcpTB;
        private System.Windows.Forms.TextBox oplTB;
        private System.Windows.Forms.TextBox oplInstTB;
        private System.Windows.Forms.Button createDeelnemerButton;
        private System.Windows.Forms.DateTimePicker geboorteDatDtP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bdgNumTB;
        private System.Windows.Forms.TextBox wnpltsTB;
        private System.Windows.Forms.TextBox dlnmrNaamTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox vakdagOplIdComB;
        private System.Windows.Forms.CheckBox nmdgCB;
        private System.Windows.Forms.CheckBox vmdgCB;
        private System.Windows.Forms.DateTimePicker vakDagDtP;
        private System.Windows.Forms.Button createNietOplDagButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button createDocentButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox docBedrijfTB;
        private System.Windows.Forms.TextBox docNaamTB;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button createDlnmrOplButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox dlnmOplOplIdTextBox;
        private System.Windows.Forms.TextBox dlnmrOplIdTextBox;
        private System.Windows.Forms.ComboBox dlnmrOplOplComB;
        private System.Windows.Forms.ComboBox dlnmrOplNaamComB;
        private System.Windows.Forms.ErrorProvider DocErrorProvider;
        private System.Windows.Forms.ErrorProvider oplInfoErrorProvider;
        private System.Windows.Forms.ErrorProvider dlnmrErrorProvider;
        private System.Windows.Forms.TabPage DocOpltabPage;
        private System.Windows.Forms.ComboBox docNaamComB;
        private System.Windows.Forms.ComboBox docOplComB;
        private System.Windows.Forms.Button docOplCreateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}