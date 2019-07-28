namespace ProjAanwezigheidslijst
{
    partial class BeheerAllesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeheerAllesForm));
            this.deelnemersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aanwezigheidslijstDataSet1 = new ProjAanwezigheidslijst.AanwezigheidslijstDataSet();
            this.docentensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aanwezigheidslijstDataSet = new ProjAanwezigheidslijst.AanwezigheidslijstDataSet();
            this.opleidingsinformatiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nietOpleidingsDagensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deelnemersOpleidingensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docetenOpleidingensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tijdsregistratiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dlnmrErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.deelnemersTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.DeelnemersTableAdapter();
            this.docentensTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.DocentensTableAdapter();
            this.opleidingsinformatiesTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.OpleidingsinformatiesTableAdapter();
            this.nietOpleidingsDagensTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.NietOpleidingsDagensTableAdapter();
            this.deelnemersOpleidingensTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.DeelnemersOpleidingensTableAdapter();
            this.docetenOpleidingensTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.DocetenOpleidingensTableAdapter();
            this.tijdsregistratiesTableAdapter = new ProjAanwezigheidslijst.AanwezigheidslijstDataSetTableAdapters.TijdsregistratiesTableAdapter();
            this.DocErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.oplInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExtraTabP = new System.Windows.Forms.TabPage();
            this.tijdRegTabP = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.tijdsRegListBox = new System.Windows.Forms.ListBox();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deelnemerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntOplDgTabP = new System.Windows.Forms.TabPage();
            this.vakDagVrwdrRB = new System.Windows.Forms.RadioButton();
            this.VakDagWijzRB = new System.Windows.Forms.RadioButton();
            this.vakDagToevRB = new System.Windows.Forms.RadioButton();
            this.vakDagZoekGrpB = new System.Windows.Forms.GroupBox();
            this.vakDagZoekBT = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.vakDagZoekDTP = new System.Windows.Forms.DateTimePicker();
            this.vakDagGrpB = new System.Windows.Forms.GroupBox();
            this.vakDagVrwdrDTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.WijzigZoekdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveChangeVakDagButton = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.vakdagOplIdComB = new System.Windows.Forms.ComboBox();
            this.nmdgCB = new System.Windows.Forms.CheckBox();
            this.vmdgCB = new System.Windows.Forms.CheckBox();
            this.vakDagDtP = new System.Windows.Forms.DateTimePicker();
            this.createNietOplDagButton = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.deleteVakDagButton = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.wijzigVakDagZoekButton = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voormiddagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.namiddagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.opleidingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oplInfoTabP = new System.Windows.Forms.TabPage();
            this.oplVrwdrRB = new System.Windows.Forms.RadioButton();
            this.oplWijzRB = new System.Windows.Forms.RadioButton();
            this.oplToevRB = new System.Windows.Forms.RadioButton();
            this.WijzOplInfoGrpB = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.oplInfoZoekBT = new System.Windows.Forms.Button();
            this.oplInfoZoekTB = new System.Windows.Forms.TextBox();
            this.toevOplInfoGrpB = new System.Windows.Forms.GroupBox();
            this.saveChangeOplInfoButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.oplVrwdrTB = new System.Windows.Forms.TextBox();
            this.deleteOplInfoButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.CreateOpleidingsInfoButton = new System.Windows.Forms.Button();
            this.wijzigOplInfobutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.wijzigOplInfoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.eindDatDtP = new System.Windows.Forms.DateTimePicker();
            this.startDatDtP = new System.Windows.Forms.DateTimePicker();
            this.oplCdTB = new System.Windows.Forms.TextBox();
            this.OeNumTB = new System.Windows.Forms.TextBox();
            this.refOplTB = new System.Windows.Forms.TextBox();
            this.oplPlTB = new System.Windows.Forms.TextBox();
            this.cntcpTB = new System.Windows.Forms.TextBox();
            this.oplTB = new System.Windows.Forms.TextBox();
            this.oplInstTB = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingsinstellingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersoonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingsplaatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oeNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingscodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eindDatumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocTabP = new System.Windows.Forms.TabPage();
            this.vrwdrDocRB = new System.Windows.Forms.RadioButton();
            this.wijzDocRB = new System.Windows.Forms.RadioButton();
            this.toevDocRB = new System.Windows.Forms.RadioButton();
            this.docZoekGrpB = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.docZoekBT = new System.Windows.Forms.Button();
            this.DocZoekTB = new System.Windows.Forms.TextBox();
            this.docToevGrpB = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.docOplComB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vrwdrDocTB = new System.Windows.Forms.TextBox();
            this.saveChangeDocButton = new System.Windows.Forms.Button();
            this.createDocentButton = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.docBedrijfTB = new System.Windows.Forms.TextBox();
            this.docNaamTB = new System.Windows.Forms.TextBox();
            this.deleteDocButton = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.wijzDocTB = new System.Windows.Forms.TextBox();
            this.wijzigDocButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opleiding_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlnmrTabP = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geboorteDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woonplaatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.badgeNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingIdDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRadioB = new System.Windows.Forms.RadioButton();
            this.WijzigRadioB = new System.Windows.Forms.RadioButton();
            this.ToevRadioB = new System.Windows.Forms.RadioButton();
            this.WijzigenGrpB = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.ToevoegenGrpB = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.dlnmrOplComB = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.deleteDlnmrTB = new System.Windows.Forms.TextBox();
            this.saveChangeDeelnemerButton = new System.Windows.Forms.Button();
            this.deleteDeelnemerButton = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.createDeelnemerButton = new System.Windows.Forms.Button();
            this.WijzigZoekButton = new System.Windows.Forms.Button();
            this.geboorteDatDtP = new System.Windows.Forms.DateTimePicker();
            this.wijzigNaamTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bdgNumTB = new System.Windows.Forms.TextBox();
            this.wnpltsTB = new System.Windows.Forms.TextBox();
            this.dlnmrNaamTB = new System.Windows.Forms.TextBox();
            this.BeheerTabControl = new System.Windows.Forms.TabControl();
            this.opleidingIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docOplCreateButton = new System.Windows.Forms.Button();
            this.docOpl1ComB = new System.Windows.Forms.ComboBox();
            this.docNaamComB = new System.Windows.Forms.ComboBox();
            this.saveChangeDocOplButton = new System.Windows.Forms.Button();
            this.docOplWijzTB = new System.Windows.Forms.TextBox();
            this.docOplWijzBT = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.docOplVrwdrBT = new System.Windows.Forms.Button();
            this.docOplvrwdrTb = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.docOplZoekTB = new System.Windows.Forms.TextBox();
            this.docOplZoekBT = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.deelnemerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opleidingIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wijzigDlnmrOplZoekTextBox = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.wijzigDlnmrOplZoekButton = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.deleteDlnmrOplButton = new System.Windows.Forms.Button();
            this.createDlnmrOplButton = new System.Windows.Forms.Button();
            this.saveChangeDlnmrOplButton = new System.Windows.Forms.Button();
            this.dlnmrOplOplComB = new System.Windows.Forms.ComboBox();
            this.dlnmrOplNaamComB = new System.Windows.Forms.ComboBox();
            this.dlnmrOplVrwdrTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dlnmrOplZoekTB = new System.Windows.Forms.TextBox();
            this.dlnmrOplZoekBT = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.docZoekComB = new System.Windows.Forms.ComboBox();
            this.oplInfoComB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.deelnemersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aanwezigheidslijstDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aanwezigheidslijstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opleidingsinformatiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nietOpleidingsDagensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deelnemersOpleidingensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docetenOpleidingensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tijdsregistratiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlnmrErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplInfoErrorProvider)).BeginInit();
            this.tijdRegTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.ntOplDgTabP.SuspendLayout();
            this.vakDagZoekGrpB.SuspendLayout();
            this.vakDagGrpB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.oplInfoTabP.SuspendLayout();
            this.WijzOplInfoGrpB.SuspendLayout();
            this.toevOplInfoGrpB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.DocTabP.SuspendLayout();
            this.docZoekGrpB.SuspendLayout();
            this.docToevGrpB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.dlnmrTabP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.WijzigenGrpB.SuspendLayout();
            this.ToevoegenGrpB.SuspendLayout();
            this.BeheerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // deelnemersBindingSource
            // 
            this.deelnemersBindingSource.DataMember = "Deelnemers";
            this.deelnemersBindingSource.DataSource = this.aanwezigheidslijstDataSet1;
            // 
            // aanwezigheidslijstDataSet1
            // 
            this.aanwezigheidslijstDataSet1.DataSetName = "AanwezigheidslijstDataSet";
            this.aanwezigheidslijstDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docentensBindingSource
            // 
            this.docentensBindingSource.DataMember = "Docentens";
            this.docentensBindingSource.DataSource = this.aanwezigheidslijstDataSet;
            // 
            // aanwezigheidslijstDataSet
            // 
            this.aanwezigheidslijstDataSet.DataSetName = "AanwezigheidslijstDataSet";
            this.aanwezigheidslijstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opleidingsinformatiesBindingSource
            // 
            this.opleidingsinformatiesBindingSource.DataMember = "Opleidingsinformaties";
            this.opleidingsinformatiesBindingSource.DataSource = this.aanwezigheidslijstDataSet;
            // 
            // nietOpleidingsDagensBindingSource
            // 
            this.nietOpleidingsDagensBindingSource.DataMember = "NietOpleidingsDagens";
            this.nietOpleidingsDagensBindingSource.DataSource = this.aanwezigheidslijstDataSet;
            // 
            // deelnemersOpleidingensBindingSource
            // 
            this.deelnemersOpleidingensBindingSource.DataMember = "DeelnemersOpleidingens";
            this.deelnemersOpleidingensBindingSource.DataSource = this.aanwezigheidslijstDataSet;
            // 
            // docetenOpleidingensBindingSource
            // 
            this.docetenOpleidingensBindingSource.DataMember = "DocetenOpleidingens";
            this.docetenOpleidingensBindingSource.DataSource = this.aanwezigheidslijstDataSet;
            // 
            // tijdsregistratiesBindingSource
            // 
            this.tijdsregistratiesBindingSource.DataMember = "Tijdsregistraties";
            this.tijdsregistratiesBindingSource.DataSource = this.aanwezigheidslijstDataSet;
            // 
            // dlnmrErrorProvider
            // 
            this.dlnmrErrorProvider.ContainerControl = this;
            // 
            // deelnemersTableAdapter
            // 
            this.deelnemersTableAdapter.ClearBeforeFill = true;
            // 
            // docentensTableAdapter
            // 
            this.docentensTableAdapter.ClearBeforeFill = true;
            // 
            // opleidingsinformatiesTableAdapter
            // 
            this.opleidingsinformatiesTableAdapter.ClearBeforeFill = true;
            // 
            // nietOpleidingsDagensTableAdapter
            // 
            this.nietOpleidingsDagensTableAdapter.ClearBeforeFill = true;
            // 
            // deelnemersOpleidingensTableAdapter
            // 
            this.deelnemersOpleidingensTableAdapter.ClearBeforeFill = true;
            // 
            // docetenOpleidingensTableAdapter
            // 
            this.docetenOpleidingensTableAdapter.ClearBeforeFill = true;
            // 
            // tijdsregistratiesTableAdapter
            // 
            this.tijdsregistratiesTableAdapter.ClearBeforeFill = true;
            // 
            // DocErrorProvider
            // 
            this.DocErrorProvider.ContainerControl = this;
            // 
            // oplInfoErrorProvider
            // 
            this.oplInfoErrorProvider.ContainerControl = this;
            // 
            // ExtraTabP
            // 
            this.ExtraTabP.BackColor = System.Drawing.Color.Silver;
            this.ExtraTabP.Location = new System.Drawing.Point(8, 39);
            this.ExtraTabP.Name = "ExtraTabP";
            this.ExtraTabP.Padding = new System.Windows.Forms.Padding(3);
            this.ExtraTabP.Size = new System.Drawing.Size(1944, 1190);
            this.ExtraTabP.TabIndex = 7;
            this.ExtraTabP.Text = "Extra";
            // 
            // tijdRegTabP
            // 
            this.tijdRegTabP.BackColor = System.Drawing.Color.Silver;
            this.tijdRegTabP.Controls.Add(this.label31);
            this.tijdRegTabP.Controls.Add(this.tijdsRegListBox);
            this.tijdRegTabP.Controls.Add(this.dataGridView7);
            this.tijdRegTabP.Location = new System.Drawing.Point(8, 39);
            this.tijdRegTabP.Name = "tijdRegTabP";
            this.tijdRegTabP.Padding = new System.Windows.Forms.Padding(3);
            this.tijdRegTabP.Size = new System.Drawing.Size(1944, 1190);
            this.tijdRegTabP.TabIndex = 6;
            this.tijdRegTabP.Text = "Tijdsregistratie";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 452);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(191, 25);
            this.label31.TabIndex = 11;
            this.label31.Text = "Tijdsregistratie lijst";
            // 
            // tijdsRegListBox
            // 
            this.tijdsRegListBox.FormattingEnabled = true;
            this.tijdsRegListBox.ItemHeight = 25;
            this.tijdsRegListBox.Location = new System.Drawing.Point(7, 481);
            this.tijdsRegListBox.Margin = new System.Windows.Forms.Padding(4);
            this.tijdsRegListBox.Name = "tijdsRegListBox";
            this.tijdsRegListBox.Size = new System.Drawing.Size(1532, 604);
            this.tijdsRegListBox.TabIndex = 10;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn6,
            this.dateTimeDataGridViewTextBoxColumn,
            this.deelnemerIdDataGridViewTextBoxColumn1,
            this.opleidingIdDataGridViewTextBoxColumn3});
            this.dataGridView7.DataSource = this.tijdsregistratiesBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(7, 7);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 82;
            this.dataGridView7.RowTemplate.Height = 33;
            this.dataGridView7.Size = new System.Drawing.Size(1934, 412);
            this.dataGridView7.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn6
            // 
            this.idDataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn6.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn6.Name = "idDataGridViewTextBoxColumn6";
            this.idDataGridViewTextBoxColumn6.ReadOnly = true;
            this.idDataGridViewTextBoxColumn6.Width = 200;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // deelnemerIdDataGridViewTextBoxColumn1
            // 
            this.deelnemerIdDataGridViewTextBoxColumn1.DataPropertyName = "Deelnemer_Id";
            this.deelnemerIdDataGridViewTextBoxColumn1.HeaderText = "Deelnemer_Id";
            this.deelnemerIdDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.deelnemerIdDataGridViewTextBoxColumn1.Name = "deelnemerIdDataGridViewTextBoxColumn1";
            this.deelnemerIdDataGridViewTextBoxColumn1.Width = 200;
            // 
            // opleidingIdDataGridViewTextBoxColumn3
            // 
            this.opleidingIdDataGridViewTextBoxColumn3.DataPropertyName = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn3.HeaderText = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.opleidingIdDataGridViewTextBoxColumn3.Name = "opleidingIdDataGridViewTextBoxColumn3";
            this.opleidingIdDataGridViewTextBoxColumn3.Width = 200;
            // 
            // ntOplDgTabP
            // 
            this.ntOplDgTabP.BackColor = System.Drawing.Color.Silver;
            this.ntOplDgTabP.Controls.Add(this.vakDagVrwdrRB);
            this.ntOplDgTabP.Controls.Add(this.VakDagWijzRB);
            this.ntOplDgTabP.Controls.Add(this.vakDagToevRB);
            this.ntOplDgTabP.Controls.Add(this.vakDagZoekGrpB);
            this.ntOplDgTabP.Controls.Add(this.vakDagGrpB);
            this.ntOplDgTabP.Controls.Add(this.dataGridView4);
            this.ntOplDgTabP.Location = new System.Drawing.Point(8, 39);
            this.ntOplDgTabP.Name = "ntOplDgTabP";
            this.ntOplDgTabP.Padding = new System.Windows.Forms.Padding(3);
            this.ntOplDgTabP.Size = new System.Drawing.Size(1944, 1190);
            this.ntOplDgTabP.TabIndex = 3;
            this.ntOplDgTabP.Text = "Niet opleidingsdagen";
            // 
            // vakDagVrwdrRB
            // 
            this.vakDagVrwdrRB.AutoSize = true;
            this.vakDagVrwdrRB.Location = new System.Drawing.Point(894, 888);
            this.vakDagVrwdrRB.Name = "vakDagVrwdrRB";
            this.vakDagVrwdrRB.Size = new System.Drawing.Size(156, 29);
            this.vakDagVrwdrRB.TabIndex = 22;
            this.vakDagVrwdrRB.Text = "Verwijderen";
            this.vakDagVrwdrRB.UseVisualStyleBackColor = true;
            this.vakDagVrwdrRB.CheckedChanged += new System.EventHandler(this.VakDagVrwdrRB_CheckedChanged);
            // 
            // VakDagWijzRB
            // 
            this.VakDagWijzRB.AutoSize = true;
            this.VakDagWijzRB.Location = new System.Drawing.Point(894, 785);
            this.VakDagWijzRB.Name = "VakDagWijzRB";
            this.VakDagWijzRB.Size = new System.Drawing.Size(125, 29);
            this.VakDagWijzRB.TabIndex = 21;
            this.VakDagWijzRB.Text = "Wijzigen";
            this.VakDagWijzRB.UseVisualStyleBackColor = true;
            this.VakDagWijzRB.CheckedChanged += new System.EventHandler(this.VakDagWijzRB_CheckedChanged);
            // 
            // vakDagToevRB
            // 
            this.vakDagToevRB.AutoSize = true;
            this.vakDagToevRB.Checked = true;
            this.vakDagToevRB.Location = new System.Drawing.Point(894, 688);
            this.vakDagToevRB.Name = "vakDagToevRB";
            this.vakDagToevRB.Size = new System.Drawing.Size(151, 29);
            this.vakDagToevRB.TabIndex = 20;
            this.vakDagToevRB.TabStop = true;
            this.vakDagToevRB.Text = "Toevoegen";
            this.vakDagToevRB.UseVisualStyleBackColor = true;
            this.vakDagToevRB.CheckedChanged += new System.EventHandler(this.VakDagToevRB_CheckedChanged);
            // 
            // vakDagZoekGrpB
            // 
            this.vakDagZoekGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.vakDagZoekGrpB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vakDagZoekGrpB.BackgroundImage")));
            this.vakDagZoekGrpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vakDagZoekGrpB.Controls.Add(this.vakDagZoekBT);
            this.vakDagZoekGrpB.Controls.Add(this.label41);
            this.vakDagZoekGrpB.Controls.Add(this.vakDagZoekDTP);
            this.vakDagZoekGrpB.Location = new System.Drawing.Point(1081, 425);
            this.vakDagZoekGrpB.Name = "vakDagZoekGrpB";
            this.vakDagZoekGrpB.Size = new System.Drawing.Size(857, 759);
            this.vakDagZoekGrpB.TabIndex = 5;
            this.vakDagZoekGrpB.TabStop = false;
            this.vakDagZoekGrpB.Text = "Zoeken";
            // 
            // vakDagZoekBT
            // 
            this.vakDagZoekBT.Location = new System.Drawing.Point(537, 97);
            this.vakDagZoekBT.Name = "vakDagZoekBT";
            this.vakDagZoekBT.Size = new System.Drawing.Size(177, 39);
            this.vakDagZoekBT.TabIndex = 77;
            this.vakDagZoekBT.Text = "Zoek";
            this.vakDagZoekBT.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(21, 70);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(319, 25);
            this.label41.TabIndex = 75;
            this.label41.Text = "Vink aan indien geen opleiding :";
            // 
            // vakDagZoekDTP
            // 
            this.vakDagZoekDTP.Location = new System.Drawing.Point(21, 101);
            this.vakDagZoekDTP.Margin = new System.Windows.Forms.Padding(4);
            this.vakDagZoekDTP.Name = "vakDagZoekDTP";
            this.vakDagZoekDTP.Size = new System.Drawing.Size(505, 31);
            this.vakDagZoekDTP.TabIndex = 70;
            // 
            // vakDagGrpB
            // 
            this.vakDagGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.vakDagGrpB.Controls.Add(this.vakDagVrwdrDTP);
            this.vakDagGrpB.Controls.Add(this.label9);
            this.vakDagGrpB.Controls.Add(this.label32);
            this.vakDagGrpB.Controls.Add(this.WijzigZoekdateTimePicker);
            this.vakDagGrpB.Controls.Add(this.saveChangeVakDagButton);
            this.vakDagGrpB.Controls.Add(this.label33);
            this.vakDagGrpB.Controls.Add(this.vakdagOplIdComB);
            this.vakDagGrpB.Controls.Add(this.nmdgCB);
            this.vakDagGrpB.Controls.Add(this.vmdgCB);
            this.vakDagGrpB.Controls.Add(this.vakDagDtP);
            this.vakDagGrpB.Controls.Add(this.createNietOplDagButton);
            this.vakDagGrpB.Controls.Add(this.label34);
            this.vakDagGrpB.Controls.Add(this.label35);
            this.vakDagGrpB.Controls.Add(this.label36);
            this.vakDagGrpB.Controls.Add(this.deleteVakDagButton);
            this.vakDagGrpB.Controls.Add(this.label37);
            this.vakDagGrpB.Controls.Add(this.label46);
            this.vakDagGrpB.Controls.Add(this.wijzigVakDagZoekButton);
            this.vakDagGrpB.Location = new System.Drawing.Point(7, 425);
            this.vakDagGrpB.Name = "vakDagGrpB";
            this.vakDagGrpB.Size = new System.Drawing.Size(857, 759);
            this.vakDagGrpB.TabIndex = 4;
            this.vakDagGrpB.TabStop = false;
            this.vakDagGrpB.Text = "Toevoegen";
            // 
            // vakDagVrwdrDTP
            // 
            this.vakDagVrwdrDTP.Location = new System.Drawing.Point(12, 182);
            this.vakDagVrwdrDTP.Margin = new System.Windows.Forms.Padding(4);
            this.vakDagVrwdrDTP.Name = "vakDagVrwdrDTP";
            this.vakDagVrwdrDTP.Size = new System.Drawing.Size(505, 31);
            this.vakDagVrwdrDTP.TabIndex = 81;
            this.vakDagVrwdrDTP.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Geef datum in om te verwijderen";
            this.label9.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(162, 419);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(319, 25);
            this.label32.TabIndex = 62;
            this.label32.Text = "Vink aan indien geen opleiding :";
            // 
            // WijzigZoekdateTimePicker
            // 
            this.WijzigZoekdateTimePicker.Location = new System.Drawing.Point(12, 101);
            this.WijzigZoekdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.WijzigZoekdateTimePicker.Name = "WijzigZoekdateTimePicker";
            this.WijzigZoekdateTimePicker.Size = new System.Drawing.Size(505, 31);
            this.WijzigZoekdateTimePicker.TabIndex = 77;
            this.WijzigZoekdateTimePicker.Visible = false;
            // 
            // saveChangeVakDagButton
            // 
            this.saveChangeVakDagButton.Location = new System.Drawing.Point(12, 511);
            this.saveChangeVakDagButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangeVakDagButton.Name = "saveChangeVakDagButton";
            this.saveChangeVakDagButton.Size = new System.Drawing.Size(211, 68);
            this.saveChangeVakDagButton.TabIndex = 78;
            this.saveChangeVakDagButton.Text = "Save changes";
            this.saveChangeVakDagButton.UseVisualStyleBackColor = true;
            this.saveChangeVakDagButton.Visible = false;
            this.saveChangeVakDagButton.Click += new System.EventHandler(this.SaveChangeVakDagButton_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(162, 367);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(319, 25);
            this.label33.TabIndex = 61;
            this.label33.Text = "Vink aan indien geen opleiding :";
            // 
            // vakdagOplIdComB
            // 
            this.vakdagOplIdComB.FormattingEnabled = true;
            this.vakdagOplIdComB.Location = new System.Drawing.Point(12, 472);
            this.vakdagOplIdComB.Margin = new System.Windows.Forms.Padding(4);
            this.vakdagOplIdComB.Name = "vakdagOplIdComB";
            this.vakdagOplIdComB.Size = new System.Drawing.Size(505, 33);
            this.vakdagOplIdComB.TabIndex = 60;
            // 
            // nmdgCB
            // 
            this.nmdgCB.AutoSize = true;
            this.nmdgCB.Location = new System.Drawing.Point(489, 419);
            this.nmdgCB.Margin = new System.Windows.Forms.Padding(4);
            this.nmdgCB.Name = "nmdgCB";
            this.nmdgCB.Size = new System.Drawing.Size(28, 27);
            this.nmdgCB.TabIndex = 59;
            this.nmdgCB.UseVisualStyleBackColor = true;
            // 
            // vmdgCB
            // 
            this.vmdgCB.AutoSize = true;
            this.vmdgCB.Location = new System.Drawing.Point(489, 367);
            this.vmdgCB.Margin = new System.Windows.Forms.Padding(4);
            this.vmdgCB.Name = "vmdgCB";
            this.vmdgCB.Size = new System.Drawing.Size(28, 27);
            this.vmdgCB.TabIndex = 58;
            this.vmdgCB.UseVisualStyleBackColor = true;
            // 
            // vakDagDtP
            // 
            this.vakDagDtP.Location = new System.Drawing.Point(12, 306);
            this.vakDagDtP.Margin = new System.Windows.Forms.Padding(4);
            this.vakDagDtP.Name = "vakDagDtP";
            this.vakDagDtP.Size = new System.Drawing.Size(505, 31);
            this.vakDagDtP.TabIndex = 57;
            // 
            // createNietOplDagButton
            // 
            this.createNietOplDagButton.Location = new System.Drawing.Point(12, 684);
            this.createNietOplDagButton.Margin = new System.Windows.Forms.Padding(4);
            this.createNietOplDagButton.Name = "createNietOplDagButton";
            this.createNietOplDagButton.Size = new System.Drawing.Size(211, 68);
            this.createNietOplDagButton.TabIndex = 56;
            this.createNietOplDagButton.Text = "Create";
            this.createNietOplDagButton.UseVisualStyleBackColor = true;
            this.createNietOplDagButton.Click += new System.EventHandler(this.CreateNietOplDagButton_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(557, 475);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(127, 25);
            this.label34.TabIndex = 55;
            this.label34.Text = "opleidingsId";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(557, 419);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(109, 25);
            this.label35.TabIndex = 54;
            this.label35.Text = "Namiddag";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(557, 367);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(127, 25);
            this.label36.TabIndex = 53;
            this.label36.Text = "Voormiddag";
            // 
            // deleteVakDagButton
            // 
            this.deleteVakDagButton.Location = new System.Drawing.Point(557, 177);
            this.deleteVakDagButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteVakDagButton.Name = "deleteVakDagButton";
            this.deleteVakDagButton.Size = new System.Drawing.Size(171, 44);
            this.deleteVakDagButton.TabIndex = 67;
            this.deleteVakDagButton.Text = "Verwijderen";
            this.deleteVakDagButton.UseVisualStyleBackColor = true;
            this.deleteVakDagButton.Visible = false;
            this.deleteVakDagButton.Click += new System.EventHandler(this.DeleteVakDagButton_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(557, 309);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(74, 25);
            this.label37.TabIndex = 52;
            this.label37.Text = "Datum";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(12, 72);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(310, 25);
            this.label46.TabIndex = 66;
            this.label46.Text = "Geef datum in van vakantiedag";
            this.label46.Visible = false;
            // 
            // wijzigVakDagZoekButton
            // 
            this.wijzigVakDagZoekButton.Location = new System.Drawing.Point(557, 96);
            this.wijzigVakDagZoekButton.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigVakDagZoekButton.Name = "wijzigVakDagZoekButton";
            this.wijzigVakDagZoekButton.Size = new System.Drawing.Size(171, 44);
            this.wijzigVakDagZoekButton.TabIndex = 65;
            this.wijzigVakDagZoekButton.Text = "Wijzigen";
            this.wijzigVakDagZoekButton.UseVisualStyleBackColor = true;
            this.wijzigVakDagZoekButton.Visible = false;
            this.wijzigVakDagZoekButton.Click += new System.EventHandler(this.WijzigVakDagZoekButton_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.datumDataGridViewTextBoxColumn,
            this.voormiddagDataGridViewCheckBoxColumn,
            this.namiddagDataGridViewCheckBoxColumn,
            this.opleidingIdDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.nietOpleidingsDagensBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(7, 7);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 33;
            this.dataGridView4.Size = new System.Drawing.Size(1934, 412);
            this.dataGridView4.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Width = 200;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 200;
            // 
            // voormiddagDataGridViewCheckBoxColumn
            // 
            this.voormiddagDataGridViewCheckBoxColumn.DataPropertyName = "Voormiddag";
            this.voormiddagDataGridViewCheckBoxColumn.HeaderText = "Voormiddag";
            this.voormiddagDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.voormiddagDataGridViewCheckBoxColumn.Name = "voormiddagDataGridViewCheckBoxColumn";
            this.voormiddagDataGridViewCheckBoxColumn.Width = 200;
            // 
            // namiddagDataGridViewCheckBoxColumn
            // 
            this.namiddagDataGridViewCheckBoxColumn.DataPropertyName = "Namiddag";
            this.namiddagDataGridViewCheckBoxColumn.HeaderText = "Namiddag";
            this.namiddagDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.namiddagDataGridViewCheckBoxColumn.Name = "namiddagDataGridViewCheckBoxColumn";
            this.namiddagDataGridViewCheckBoxColumn.Width = 200;
            // 
            // opleidingIdDataGridViewTextBoxColumn
            // 
            this.opleidingIdDataGridViewTextBoxColumn.DataPropertyName = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn.HeaderText = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opleidingIdDataGridViewTextBoxColumn.Name = "opleidingIdDataGridViewTextBoxColumn";
            this.opleidingIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // oplInfoTabP
            // 
            this.oplInfoTabP.BackColor = System.Drawing.Color.Silver;
            this.oplInfoTabP.Controls.Add(this.oplVrwdrRB);
            this.oplInfoTabP.Controls.Add(this.oplWijzRB);
            this.oplInfoTabP.Controls.Add(this.oplToevRB);
            this.oplInfoTabP.Controls.Add(this.WijzOplInfoGrpB);
            this.oplInfoTabP.Controls.Add(this.toevOplInfoGrpB);
            this.oplInfoTabP.Controls.Add(this.dataGridView3);
            this.oplInfoTabP.Location = new System.Drawing.Point(8, 39);
            this.oplInfoTabP.Name = "oplInfoTabP";
            this.oplInfoTabP.Padding = new System.Windows.Forms.Padding(3);
            this.oplInfoTabP.Size = new System.Drawing.Size(1944, 1190);
            this.oplInfoTabP.TabIndex = 2;
            this.oplInfoTabP.Text = "Opleidingsinformatie";
            // 
            // oplVrwdrRB
            // 
            this.oplVrwdrRB.AutoSize = true;
            this.oplVrwdrRB.Location = new System.Drawing.Point(894, 888);
            this.oplVrwdrRB.Name = "oplVrwdrRB";
            this.oplVrwdrRB.Size = new System.Drawing.Size(156, 29);
            this.oplVrwdrRB.TabIndex = 19;
            this.oplVrwdrRB.Text = "Verwijderen";
            this.oplVrwdrRB.UseVisualStyleBackColor = true;
            this.oplVrwdrRB.CheckedChanged += new System.EventHandler(this.OplVrwdrRB_CheckedChanged);
            // 
            // oplWijzRB
            // 
            this.oplWijzRB.AutoSize = true;
            this.oplWijzRB.Location = new System.Drawing.Point(894, 785);
            this.oplWijzRB.Name = "oplWijzRB";
            this.oplWijzRB.Size = new System.Drawing.Size(125, 29);
            this.oplWijzRB.TabIndex = 18;
            this.oplWijzRB.Text = "Wijzigen";
            this.oplWijzRB.UseVisualStyleBackColor = true;
            this.oplWijzRB.CheckedChanged += new System.EventHandler(this.OplWijzRB_CheckedChanged);
            // 
            // oplToevRB
            // 
            this.oplToevRB.AutoSize = true;
            this.oplToevRB.Checked = true;
            this.oplToevRB.Location = new System.Drawing.Point(894, 688);
            this.oplToevRB.Name = "oplToevRB";
            this.oplToevRB.Size = new System.Drawing.Size(151, 29);
            this.oplToevRB.TabIndex = 17;
            this.oplToevRB.TabStop = true;
            this.oplToevRB.Text = "Toevoegen";
            this.oplToevRB.UseVisualStyleBackColor = true;
            this.oplToevRB.CheckedChanged += new System.EventHandler(this.OplToevRB_CheckedChanged);
            // 
            // WijzOplInfoGrpB
            // 
            this.WijzOplInfoGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.WijzOplInfoGrpB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WijzOplInfoGrpB.BackgroundImage")));
            this.WijzOplInfoGrpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WijzOplInfoGrpB.Controls.Add(this.oplInfoComB);
            this.WijzOplInfoGrpB.Controls.Add(this.label8);
            this.WijzOplInfoGrpB.Controls.Add(this.oplInfoZoekBT);
            this.WijzOplInfoGrpB.Controls.Add(this.oplInfoZoekTB);
            this.WijzOplInfoGrpB.Location = new System.Drawing.Point(1081, 425);
            this.WijzOplInfoGrpB.Name = "WijzOplInfoGrpB";
            this.WijzOplInfoGrpB.Size = new System.Drawing.Size(857, 759);
            this.WijzOplInfoGrpB.TabIndex = 4;
            this.WijzOplInfoGrpB.TabStop = false;
            this.WijzOplInfoGrpB.Text = "Zoeken";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Geef opleiding in";
            // 
            // oplInfoZoekBT
            // 
            this.oplInfoZoekBT.Location = new System.Drawing.Point(537, 97);
            this.oplInfoZoekBT.Name = "oplInfoZoekBT";
            this.oplInfoZoekBT.Size = new System.Drawing.Size(177, 39);
            this.oplInfoZoekBT.TabIndex = 58;
            this.oplInfoZoekBT.Text = "Zoek";
            this.oplInfoZoekBT.UseVisualStyleBackColor = true;
            this.oplInfoZoekBT.Click += new System.EventHandler(this.OplInfoZoekBT_Click);
            // 
            // oplInfoZoekTB
            // 
            this.oplInfoZoekTB.Location = new System.Drawing.Point(21, 101);
            this.oplInfoZoekTB.Name = "oplInfoZoekTB";
            this.oplInfoZoekTB.Size = new System.Drawing.Size(495, 31);
            this.oplInfoZoekTB.TabIndex = 57;
            // 
            // toevOplInfoGrpB
            // 
            this.toevOplInfoGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.toevOplInfoGrpB.Controls.Add(this.saveChangeOplInfoButton);
            this.toevOplInfoGrpB.Controls.Add(this.label12);
            this.toevOplInfoGrpB.Controls.Add(this.oplVrwdrTB);
            this.toevOplInfoGrpB.Controls.Add(this.deleteOplInfoButton);
            this.toevOplInfoGrpB.Controls.Add(this.label25);
            this.toevOplInfoGrpB.Controls.Add(this.CreateOpleidingsInfoButton);
            this.toevOplInfoGrpB.Controls.Add(this.wijzigOplInfobutton);
            this.toevOplInfoGrpB.Controls.Add(this.label6);
            this.toevOplInfoGrpB.Controls.Add(this.wijzigOplInfoTextBox);
            this.toevOplInfoGrpB.Controls.Add(this.label7);
            this.toevOplInfoGrpB.Controls.Add(this.label15);
            this.toevOplInfoGrpB.Controls.Add(this.label16);
            this.toevOplInfoGrpB.Controls.Add(this.label17);
            this.toevOplInfoGrpB.Controls.Add(this.label18);
            this.toevOplInfoGrpB.Controls.Add(this.label19);
            this.toevOplInfoGrpB.Controls.Add(this.label22);
            this.toevOplInfoGrpB.Controls.Add(this.label23);
            this.toevOplInfoGrpB.Controls.Add(this.eindDatDtP);
            this.toevOplInfoGrpB.Controls.Add(this.startDatDtP);
            this.toevOplInfoGrpB.Controls.Add(this.oplCdTB);
            this.toevOplInfoGrpB.Controls.Add(this.OeNumTB);
            this.toevOplInfoGrpB.Controls.Add(this.refOplTB);
            this.toevOplInfoGrpB.Controls.Add(this.oplPlTB);
            this.toevOplInfoGrpB.Controls.Add(this.cntcpTB);
            this.toevOplInfoGrpB.Controls.Add(this.oplTB);
            this.toevOplInfoGrpB.Controls.Add(this.oplInstTB);
            this.toevOplInfoGrpB.Location = new System.Drawing.Point(7, 425);
            this.toevOplInfoGrpB.Name = "toevOplInfoGrpB";
            this.toevOplInfoGrpB.Size = new System.Drawing.Size(857, 759);
            this.toevOplInfoGrpB.TabIndex = 3;
            this.toevOplInfoGrpB.TabStop = false;
            this.toevOplInfoGrpB.Text = "Toevoegen";
            // 
            // saveChangeOplInfoButton
            // 
            this.saveChangeOplInfoButton.Location = new System.Drawing.Point(284, 684);
            this.saveChangeOplInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangeOplInfoButton.Name = "saveChangeOplInfoButton";
            this.saveChangeOplInfoButton.Size = new System.Drawing.Size(211, 68);
            this.saveChangeOplInfoButton.TabIndex = 79;
            this.saveChangeOplInfoButton.Text = "Save changes";
            this.saveChangeOplInfoButton.UseVisualStyleBackColor = true;
            this.saveChangeOplInfoButton.Visible = false;
            this.saveChangeOplInfoButton.Click += new System.EventHandler(this.SaveChangeOplInfoButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 107);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(449, 25);
            this.label12.TabIndex = 85;
            this.label12.Text = "Geef naam in van opleiding om te verwijderen";
            this.label12.Visible = false;
            // 
            // oplVrwdrTB
            // 
            this.oplVrwdrTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplVrwdrTB.Location = new System.Drawing.Point(12, 136);
            this.oplVrwdrTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplVrwdrTB.Name = "oplVrwdrTB";
            this.oplVrwdrTB.Size = new System.Drawing.Size(507, 32);
            this.oplVrwdrTB.TabIndex = 84;
            this.oplVrwdrTB.Visible = false;
            // 
            // deleteOplInfoButton
            // 
            this.deleteOplInfoButton.Location = new System.Drawing.Point(557, 129);
            this.deleteOplInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOplInfoButton.Name = "deleteOplInfoButton";
            this.deleteOplInfoButton.Size = new System.Drawing.Size(171, 44);
            this.deleteOplInfoButton.TabIndex = 83;
            this.deleteOplInfoButton.Text = "Verwijderen";
            this.deleteOplInfoButton.UseVisualStyleBackColor = true;
            this.deleteOplInfoButton.Visible = false;
            this.deleteOplInfoButton.Click += new System.EventHandler(this.DeleteOplInfoButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 33);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(416, 25);
            this.label25.TabIndex = 82;
            this.label25.Text = "Geef naam in van opleiding om te wijzigen";
            this.label25.Visible = false;
            // 
            // CreateOpleidingsInfoButton
            // 
            this.CreateOpleidingsInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOpleidingsInfoButton.Location = new System.Drawing.Point(12, 684);
            this.CreateOpleidingsInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOpleidingsInfoButton.Name = "CreateOpleidingsInfoButton";
            this.CreateOpleidingsInfoButton.Size = new System.Drawing.Size(211, 68);
            this.CreateOpleidingsInfoButton.TabIndex = 57;
            this.CreateOpleidingsInfoButton.Text = "Create";
            this.CreateOpleidingsInfoButton.UseVisualStyleBackColor = true;
            this.CreateOpleidingsInfoButton.Click += new System.EventHandler(this.CreateOpleidingsInfoButton_Click_1);
            // 
            // wijzigOplInfobutton
            // 
            this.wijzigOplInfobutton.Location = new System.Drawing.Point(557, 55);
            this.wijzigOplInfobutton.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigOplInfobutton.Name = "wijzigOplInfobutton";
            this.wijzigOplInfobutton.Size = new System.Drawing.Size(171, 44);
            this.wijzigOplInfobutton.TabIndex = 81;
            this.wijzigOplInfobutton.Text = "Wijzigen";
            this.wijzigOplInfobutton.UseVisualStyleBackColor = true;
            this.wijzigOplInfobutton.Visible = false;
            this.wijzigOplInfobutton.Click += new System.EventHandler(this.WijzigOplInfobutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 633);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 26);
            this.label6.TabIndex = 56;
            this.label6.Text = "Eind datum";
            // 
            // wijzigOplInfoTextBox
            // 
            this.wijzigOplInfoTextBox.Location = new System.Drawing.Point(12, 62);
            this.wijzigOplInfoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigOplInfoTextBox.Name = "wijzigOplInfoTextBox";
            this.wijzigOplInfoTextBox.Size = new System.Drawing.Size(505, 31);
            this.wijzigOplInfoTextBox.TabIndex = 80;
            this.wijzigOplInfoTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(557, 579);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 55;
            this.label7.Text = "Start datum";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(557, 523);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 26);
            this.label15.TabIndex = 54;
            this.label15.Text = "Opleidingscode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(557, 469);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 26);
            this.label16.TabIndex = 53;
            this.label16.Text = "Oe-Nummer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(557, 413);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(279, 26);
            this.label17.TabIndex = 52;
            this.label17.Text = "Referentie Opleidingsplaats";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(557, 360);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(173, 26);
            this.label18.TabIndex = 51;
            this.label18.Text = "Opleidingsplaats";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(557, 304);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 26);
            this.label19.TabIndex = 50;
            this.label19.Text = "Contactpersoon";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(557, 250);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 26);
            this.label22.TabIndex = 49;
            this.label22.Text = "Opleiding";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(557, 194);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 26);
            this.label23.TabIndex = 48;
            this.label23.Text = "Opleidingsinstelling";
            // 
            // eindDatDtP
            // 
            this.eindDatDtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eindDatDtP.Location = new System.Drawing.Point(12, 627);
            this.eindDatDtP.Margin = new System.Windows.Forms.Padding(4);
            this.eindDatDtP.Name = "eindDatDtP";
            this.eindDatDtP.Size = new System.Drawing.Size(507, 32);
            this.eindDatDtP.TabIndex = 47;
            this.eindDatDtP.Validating += new System.ComponentModel.CancelEventHandler(this.EindDatDtP_Validating);
            // 
            // startDatDtP
            // 
            this.startDatDtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatDtP.Location = new System.Drawing.Point(12, 573);
            this.startDatDtP.Margin = new System.Windows.Forms.Padding(4);
            this.startDatDtP.Name = "startDatDtP";
            this.startDatDtP.Size = new System.Drawing.Size(507, 32);
            this.startDatDtP.TabIndex = 46;
            this.startDatDtP.Validating += new System.ComponentModel.CancelEventHandler(this.StartDatDtP_Validating);
            // 
            // oplCdTB
            // 
            this.oplCdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplCdTB.Location = new System.Drawing.Point(12, 520);
            this.oplCdTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplCdTB.Name = "oplCdTB";
            this.oplCdTB.Size = new System.Drawing.Size(507, 32);
            this.oplCdTB.TabIndex = 45;
            this.oplCdTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplCdTB_Validating);
            // 
            // OeNumTB
            // 
            this.OeNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OeNumTB.Location = new System.Drawing.Point(12, 466);
            this.OeNumTB.Margin = new System.Windows.Forms.Padding(4);
            this.OeNumTB.Name = "OeNumTB";
            this.OeNumTB.Size = new System.Drawing.Size(507, 32);
            this.OeNumTB.TabIndex = 44;
            this.OeNumTB.Validating += new System.ComponentModel.CancelEventHandler(this.OeNumTB_Validating);
            // 
            // refOplTB
            // 
            this.refOplTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refOplTB.Location = new System.Drawing.Point(12, 410);
            this.refOplTB.Margin = new System.Windows.Forms.Padding(4);
            this.refOplTB.Name = "refOplTB";
            this.refOplTB.Size = new System.Drawing.Size(507, 32);
            this.refOplTB.TabIndex = 43;
            this.refOplTB.Validating += new System.ComponentModel.CancelEventHandler(this.RefOplTB_Validating);
            // 
            // oplPlTB
            // 
            this.oplPlTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplPlTB.Location = new System.Drawing.Point(12, 357);
            this.oplPlTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplPlTB.Name = "oplPlTB";
            this.oplPlTB.Size = new System.Drawing.Size(507, 32);
            this.oplPlTB.TabIndex = 42;
            this.oplPlTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplPlTB_Validating);
            // 
            // cntcpTB
            // 
            this.cntcpTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntcpTB.Location = new System.Drawing.Point(12, 301);
            this.cntcpTB.Margin = new System.Windows.Forms.Padding(4);
            this.cntcpTB.Name = "cntcpTB";
            this.cntcpTB.Size = new System.Drawing.Size(507, 32);
            this.cntcpTB.TabIndex = 41;
            this.cntcpTB.Validating += new System.ComponentModel.CancelEventHandler(this.CntcpTB_Validating);
            // 
            // oplTB
            // 
            this.oplTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplTB.Location = new System.Drawing.Point(12, 247);
            this.oplTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplTB.Name = "oplTB";
            this.oplTB.Size = new System.Drawing.Size(507, 32);
            this.oplTB.TabIndex = 40;
            this.oplTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplTB_Validating);
            // 
            // oplInstTB
            // 
            this.oplInstTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oplInstTB.Location = new System.Drawing.Point(12, 191);
            this.oplInstTB.Margin = new System.Windows.Forms.Padding(4);
            this.oplInstTB.Name = "oplInstTB";
            this.oplInstTB.Size = new System.Drawing.Size(507, 32);
            this.oplInstTB.TabIndex = 39;
            this.oplInstTB.Validating += new System.ComponentModel.CancelEventHandler(this.OplInstTB_Validating);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.opleidingsinstellingDataGridViewTextBoxColumn,
            this.opleidingDataGridViewTextBoxColumn,
            this.contactpersoonDataGridViewTextBoxColumn,
            this.opleidingsplaatsDataGridViewTextBoxColumn,
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn,
            this.oeNummerDataGridViewTextBoxColumn,
            this.opleidingscodeDataGridViewTextBoxColumn,
            this.startDatumDataGridViewTextBoxColumn,
            this.eindDatumeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.opleidingsinformatiesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 7);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1934, 412);
            this.dataGridView3.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 200;
            // 
            // opleidingsinstellingDataGridViewTextBoxColumn
            // 
            this.opleidingsinstellingDataGridViewTextBoxColumn.DataPropertyName = "Opleidingsinstelling";
            this.opleidingsinstellingDataGridViewTextBoxColumn.HeaderText = "Opleidingsinstelling";
            this.opleidingsinstellingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opleidingsinstellingDataGridViewTextBoxColumn.Name = "opleidingsinstellingDataGridViewTextBoxColumn";
            this.opleidingsinstellingDataGridViewTextBoxColumn.Width = 200;
            // 
            // opleidingDataGridViewTextBoxColumn
            // 
            this.opleidingDataGridViewTextBoxColumn.DataPropertyName = "Opleiding";
            this.opleidingDataGridViewTextBoxColumn.HeaderText = "Opleiding";
            this.opleidingDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opleidingDataGridViewTextBoxColumn.Name = "opleidingDataGridViewTextBoxColumn";
            this.opleidingDataGridViewTextBoxColumn.Width = 200;
            // 
            // contactpersoonDataGridViewTextBoxColumn
            // 
            this.contactpersoonDataGridViewTextBoxColumn.DataPropertyName = "Contactpersoon";
            this.contactpersoonDataGridViewTextBoxColumn.HeaderText = "Contactpersoon";
            this.contactpersoonDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.contactpersoonDataGridViewTextBoxColumn.Name = "contactpersoonDataGridViewTextBoxColumn";
            this.contactpersoonDataGridViewTextBoxColumn.Width = 200;
            // 
            // opleidingsplaatsDataGridViewTextBoxColumn
            // 
            this.opleidingsplaatsDataGridViewTextBoxColumn.DataPropertyName = "Opleidingsplaats";
            this.opleidingsplaatsDataGridViewTextBoxColumn.HeaderText = "Opleidingsplaats";
            this.opleidingsplaatsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opleidingsplaatsDataGridViewTextBoxColumn.Name = "opleidingsplaatsDataGridViewTextBoxColumn";
            this.opleidingsplaatsDataGridViewTextBoxColumn.Width = 200;
            // 
            // referentieOpleidingsplaatsDataGridViewTextBoxColumn
            // 
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn.DataPropertyName = "ReferentieOpleidingsplaats";
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn.HeaderText = "ReferentieOpleidingsplaats";
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn.Name = "referentieOpleidingsplaatsDataGridViewTextBoxColumn";
            this.referentieOpleidingsplaatsDataGridViewTextBoxColumn.Width = 200;
            // 
            // oeNummerDataGridViewTextBoxColumn
            // 
            this.oeNummerDataGridViewTextBoxColumn.DataPropertyName = "OeNummer";
            this.oeNummerDataGridViewTextBoxColumn.HeaderText = "OeNummer";
            this.oeNummerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.oeNummerDataGridViewTextBoxColumn.Name = "oeNummerDataGridViewTextBoxColumn";
            this.oeNummerDataGridViewTextBoxColumn.Width = 200;
            // 
            // opleidingscodeDataGridViewTextBoxColumn
            // 
            this.opleidingscodeDataGridViewTextBoxColumn.DataPropertyName = "Opleidingscode";
            this.opleidingscodeDataGridViewTextBoxColumn.HeaderText = "Opleidingscode";
            this.opleidingscodeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.opleidingscodeDataGridViewTextBoxColumn.Name = "opleidingscodeDataGridViewTextBoxColumn";
            this.opleidingscodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // startDatumDataGridViewTextBoxColumn
            // 
            this.startDatumDataGridViewTextBoxColumn.DataPropertyName = "StartDatum";
            this.startDatumDataGridViewTextBoxColumn.HeaderText = "StartDatum";
            this.startDatumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.startDatumDataGridViewTextBoxColumn.Name = "startDatumDataGridViewTextBoxColumn";
            this.startDatumDataGridViewTextBoxColumn.Width = 200;
            // 
            // eindDatumeDataGridViewTextBoxColumn
            // 
            this.eindDatumeDataGridViewTextBoxColumn.DataPropertyName = "EindDatume";
            this.eindDatumeDataGridViewTextBoxColumn.HeaderText = "EindDatume";
            this.eindDatumeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.eindDatumeDataGridViewTextBoxColumn.Name = "eindDatumeDataGridViewTextBoxColumn";
            this.eindDatumeDataGridViewTextBoxColumn.Width = 200;
            // 
            // DocTabP
            // 
            this.DocTabP.BackColor = System.Drawing.Color.Silver;
            this.DocTabP.Controls.Add(this.vrwdrDocRB);
            this.DocTabP.Controls.Add(this.wijzDocRB);
            this.DocTabP.Controls.Add(this.toevDocRB);
            this.DocTabP.Controls.Add(this.docZoekGrpB);
            this.DocTabP.Controls.Add(this.docToevGrpB);
            this.DocTabP.Controls.Add(this.dataGridView2);
            this.DocTabP.Location = new System.Drawing.Point(8, 39);
            this.DocTabP.Name = "DocTabP";
            this.DocTabP.Padding = new System.Windows.Forms.Padding(3);
            this.DocTabP.Size = new System.Drawing.Size(1944, 1190);
            this.DocTabP.TabIndex = 1;
            this.DocTabP.Text = "Docenten";
            // 
            // vrwdrDocRB
            // 
            this.vrwdrDocRB.AutoSize = true;
            this.vrwdrDocRB.Location = new System.Drawing.Point(894, 888);
            this.vrwdrDocRB.Name = "vrwdrDocRB";
            this.vrwdrDocRB.Size = new System.Drawing.Size(156, 29);
            this.vrwdrDocRB.TabIndex = 16;
            this.vrwdrDocRB.Text = "Verwijderen";
            this.vrwdrDocRB.UseVisualStyleBackColor = true;
            this.vrwdrDocRB.CheckedChanged += new System.EventHandler(this.VrwdrDocRB_CheckedChanged);
            // 
            // wijzDocRB
            // 
            this.wijzDocRB.AutoSize = true;
            this.wijzDocRB.Location = new System.Drawing.Point(894, 785);
            this.wijzDocRB.Name = "wijzDocRB";
            this.wijzDocRB.Size = new System.Drawing.Size(125, 29);
            this.wijzDocRB.TabIndex = 15;
            this.wijzDocRB.Text = "Wijzigen";
            this.wijzDocRB.UseVisualStyleBackColor = true;
            this.wijzDocRB.CheckedChanged += new System.EventHandler(this.WijzDocRB_CheckedChanged);
            // 
            // toevDocRB
            // 
            this.toevDocRB.AutoSize = true;
            this.toevDocRB.Checked = true;
            this.toevDocRB.Location = new System.Drawing.Point(894, 688);
            this.toevDocRB.Name = "toevDocRB";
            this.toevDocRB.Size = new System.Drawing.Size(151, 29);
            this.toevDocRB.TabIndex = 14;
            this.toevDocRB.TabStop = true;
            this.toevDocRB.Text = "Toevoegen";
            this.toevDocRB.UseVisualStyleBackColor = true;
            this.toevDocRB.CheckedChanged += new System.EventHandler(this.ToevDocRB_CheckedChanged);
            // 
            // docZoekGrpB
            // 
            this.docZoekGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.docZoekGrpB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("docZoekGrpB.BackgroundImage")));
            this.docZoekGrpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.docZoekGrpB.Controls.Add(this.label11);
            this.docZoekGrpB.Controls.Add(this.docZoekBT);
            this.docZoekGrpB.Controls.Add(this.DocZoekTB);
            this.docZoekGrpB.Location = new System.Drawing.Point(1081, 425);
            this.docZoekGrpB.Name = "docZoekGrpB";
            this.docZoekGrpB.Size = new System.Drawing.Size(857, 759);
            this.docZoekGrpB.TabIndex = 3;
            this.docZoekGrpB.TabStop = false;
            this.docZoekGrpB.Text = "Zoeken";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 25);
            this.label11.TabIndex = 59;
            this.label11.Text = "Geef naam van docent in";
            // 
            // docZoekBT
            // 
            this.docZoekBT.Location = new System.Drawing.Point(537, 97);
            this.docZoekBT.Name = "docZoekBT";
            this.docZoekBT.Size = new System.Drawing.Size(177, 39);
            this.docZoekBT.TabIndex = 58;
            this.docZoekBT.Text = "Zoek";
            this.docZoekBT.UseVisualStyleBackColor = true;
            this.docZoekBT.Click += new System.EventHandler(this.DocZoekBT_Click);
            // 
            // DocZoekTB
            // 
            this.DocZoekTB.Location = new System.Drawing.Point(21, 101);
            this.DocZoekTB.Name = "DocZoekTB";
            this.DocZoekTB.Size = new System.Drawing.Size(495, 31);
            this.DocZoekTB.TabIndex = 57;
            // 
            // docToevGrpB
            // 
            this.docToevGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.docToevGrpB.Controls.Add(this.docZoekComB);
            this.docToevGrpB.Controls.Add(this.label39);
            this.docToevGrpB.Controls.Add(this.docOplComB);
            this.docToevGrpB.Controls.Add(this.label10);
            this.docToevGrpB.Controls.Add(this.vrwdrDocTB);
            this.docToevGrpB.Controls.Add(this.saveChangeDocButton);
            this.docToevGrpB.Controls.Add(this.createDocentButton);
            this.docToevGrpB.Controls.Add(this.label20);
            this.docToevGrpB.Controls.Add(this.label5);
            this.docToevGrpB.Controls.Add(this.docBedrijfTB);
            this.docToevGrpB.Controls.Add(this.docNaamTB);
            this.docToevGrpB.Controls.Add(this.deleteDocButton);
            this.docToevGrpB.Controls.Add(this.label27);
            this.docToevGrpB.Controls.Add(this.wijzDocTB);
            this.docToevGrpB.Controls.Add(this.wijzigDocButton);
            this.docToevGrpB.Location = new System.Drawing.Point(7, 425);
            this.docToevGrpB.Name = "docToevGrpB";
            this.docToevGrpB.Size = new System.Drawing.Size(857, 759);
            this.docToevGrpB.TabIndex = 2;
            this.docToevGrpB.TabStop = false;
            this.docToevGrpB.Text = "Toevoegen";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(557, 425);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(103, 25);
            this.label39.TabIndex = 75;
            this.label39.Text = "Opleiding";
            // 
            // docOplComB
            // 
            this.docOplComB.FormattingEnabled = true;
            this.docOplComB.Location = new System.Drawing.Point(12, 422);
            this.docOplComB.Name = "docOplComB";
            this.docOplComB.Size = new System.Drawing.Size(507, 33);
            this.docOplComB.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(427, 25);
            this.label10.TabIndex = 73;
            this.label10.Text = "Geef naam in van docent om te verwijderen";
            this.label10.Visible = false;
            // 
            // vrwdrDocTB
            // 
            this.vrwdrDocTB.Location = new System.Drawing.Point(12, 184);
            this.vrwdrDocTB.Margin = new System.Windows.Forms.Padding(4);
            this.vrwdrDocTB.Name = "vrwdrDocTB";
            this.vrwdrDocTB.Size = new System.Drawing.Size(505, 31);
            this.vrwdrDocTB.TabIndex = 72;
            this.vrwdrDocTB.Visible = false;
            // 
            // saveChangeDocButton
            // 
            this.saveChangeDocButton.Location = new System.Drawing.Point(12, 526);
            this.saveChangeDocButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangeDocButton.Name = "saveChangeDocButton";
            this.saveChangeDocButton.Size = new System.Drawing.Size(211, 68);
            this.saveChangeDocButton.TabIndex = 71;
            this.saveChangeDocButton.Text = "Save changes";
            this.saveChangeDocButton.UseVisualStyleBackColor = true;
            this.saveChangeDocButton.Visible = false;
            this.saveChangeDocButton.Click += new System.EventHandler(this.SaveChangeDocButton_Click);
            // 
            // createDocentButton
            // 
            this.createDocentButton.Location = new System.Drawing.Point(12, 684);
            this.createDocentButton.Margin = new System.Windows.Forms.Padding(4);
            this.createDocentButton.Name = "createDocentButton";
            this.createDocentButton.Size = new System.Drawing.Size(211, 68);
            this.createDocentButton.TabIndex = 39;
            this.createDocentButton.Text = "Create";
            this.createDocentButton.UseVisualStyleBackColor = true;
            this.createDocentButton.Click += new System.EventHandler(this.CreateDocentButton_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(557, 365);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 25);
            this.label20.TabIndex = 38;
            this.label20.Text = "Bedrijf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Naam";
            // 
            // docBedrijfTB
            // 
            this.docBedrijfTB.Location = new System.Drawing.Point(12, 362);
            this.docBedrijfTB.Margin = new System.Windows.Forms.Padding(4);
            this.docBedrijfTB.Name = "docBedrijfTB";
            this.docBedrijfTB.Size = new System.Drawing.Size(507, 31);
            this.docBedrijfTB.TabIndex = 36;
            this.docBedrijfTB.Validating += new System.ComponentModel.CancelEventHandler(this.DocBedrijfTB_Validating);
            // 
            // docNaamTB
            // 
            this.docNaamTB.Location = new System.Drawing.Point(12, 306);
            this.docNaamTB.Margin = new System.Windows.Forms.Padding(4);
            this.docNaamTB.Name = "docNaamTB";
            this.docNaamTB.Size = new System.Drawing.Size(507, 31);
            this.docNaamTB.TabIndex = 35;
            this.docNaamTB.Validating += new System.ComponentModel.CancelEventHandler(this.DocNaamTB_Validating);
            // 
            // deleteDocButton
            // 
            this.deleteDocButton.Location = new System.Drawing.Point(557, 177);
            this.deleteDocButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteDocButton.Name = "deleteDocButton";
            this.deleteDocButton.Size = new System.Drawing.Size(171, 44);
            this.deleteDocButton.TabIndex = 66;
            this.deleteDocButton.Text = "Verwijderen";
            this.deleteDocButton.UseVisualStyleBackColor = true;
            this.deleteDocButton.Visible = false;
            this.deleteDocButton.Click += new System.EventHandler(this.DeleteDocButton_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 72);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(394, 25);
            this.label27.TabIndex = 65;
            this.label27.Text = "Geef naam in van docent om te wijzigen";
            this.label27.Visible = false;
            // 
            // wijzDocTB
            // 
            this.wijzDocTB.Location = new System.Drawing.Point(12, 101);
            this.wijzDocTB.Margin = new System.Windows.Forms.Padding(4);
            this.wijzDocTB.Name = "wijzDocTB";
            this.wijzDocTB.Size = new System.Drawing.Size(505, 31);
            this.wijzDocTB.TabIndex = 63;
            this.wijzDocTB.Visible = false;
            // 
            // wijzigDocButton
            // 
            this.wijzigDocButton.Location = new System.Drawing.Point(557, 96);
            this.wijzigDocButton.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigDocButton.Name = "wijzigDocButton";
            this.wijzigDocButton.Size = new System.Drawing.Size(171, 44);
            this.wijzigDocButton.TabIndex = 64;
            this.wijzigDocButton.Text = "Wijzigen";
            this.wijzigDocButton.UseVisualStyleBackColor = true;
            this.wijzigDocButton.Visible = false;
            this.wijzigDocButton.Click += new System.EventHandler(this.WijzigDocButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.naamDataGridViewTextBoxColumn1,
            this.bedrijfDataGridViewTextBoxColumn,
            this.Opleiding_Id});
            this.dataGridView2.DataSource = this.docentensBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1934, 412);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 200;
            // 
            // naamDataGridViewTextBoxColumn1
            // 
            this.naamDataGridViewTextBoxColumn1.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn1.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.naamDataGridViewTextBoxColumn1.Name = "naamDataGridViewTextBoxColumn1";
            this.naamDataGridViewTextBoxColumn1.Width = 200;
            // 
            // bedrijfDataGridViewTextBoxColumn
            // 
            this.bedrijfDataGridViewTextBoxColumn.DataPropertyName = "Bedrijf";
            this.bedrijfDataGridViewTextBoxColumn.HeaderText = "Bedrijf";
            this.bedrijfDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bedrijfDataGridViewTextBoxColumn.Name = "bedrijfDataGridViewTextBoxColumn";
            this.bedrijfDataGridViewTextBoxColumn.Width = 200;
            // 
            // Opleiding_Id
            // 
            this.Opleiding_Id.DataPropertyName = "Opleiding_Id";
            this.Opleiding_Id.HeaderText = "Opleiding_Id";
            this.Opleiding_Id.MinimumWidth = 10;
            this.Opleiding_Id.Name = "Opleiding_Id";
            this.Opleiding_Id.Width = 200;
            // 
            // dlnmrTabP
            // 
            this.dlnmrTabP.AutoScroll = true;
            this.dlnmrTabP.BackColor = System.Drawing.Color.Silver;
            this.dlnmrTabP.Controls.Add(this.dataGridView1);
            this.dlnmrTabP.Controls.Add(this.DeleteRadioB);
            this.dlnmrTabP.Controls.Add(this.WijzigRadioB);
            this.dlnmrTabP.Controls.Add(this.ToevRadioB);
            this.dlnmrTabP.Controls.Add(this.WijzigenGrpB);
            this.dlnmrTabP.Controls.Add(this.ToevoegenGrpB);
            this.dlnmrTabP.Location = new System.Drawing.Point(8, 39);
            this.dlnmrTabP.Name = "dlnmrTabP";
            this.dlnmrTabP.Padding = new System.Windows.Forms.Padding(3);
            this.dlnmrTabP.Size = new System.Drawing.Size(1944, 1190);
            this.dlnmrTabP.TabIndex = 0;
            this.dlnmrTabP.Text = "Deelnemer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.geboorteDatumDataGridViewTextBoxColumn,
            this.woonplaatsDataGridViewTextBoxColumn,
            this.badgeNummerDataGridViewTextBoxColumn,
            this.opleidingIdDataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.deelnemersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1931, 415);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.Width = 200;
            // 
            // geboorteDatumDataGridViewTextBoxColumn
            // 
            this.geboorteDatumDataGridViewTextBoxColumn.DataPropertyName = "GeboorteDatum";
            this.geboorteDatumDataGridViewTextBoxColumn.HeaderText = "GeboorteDatum";
            this.geboorteDatumDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.geboorteDatumDataGridViewTextBoxColumn.Name = "geboorteDatumDataGridViewTextBoxColumn";
            this.geboorteDatumDataGridViewTextBoxColumn.Width = 200;
            // 
            // woonplaatsDataGridViewTextBoxColumn
            // 
            this.woonplaatsDataGridViewTextBoxColumn.DataPropertyName = "Woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.HeaderText = "Woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.woonplaatsDataGridViewTextBoxColumn.Name = "woonplaatsDataGridViewTextBoxColumn";
            this.woonplaatsDataGridViewTextBoxColumn.Width = 200;
            // 
            // badgeNummerDataGridViewTextBoxColumn
            // 
            this.badgeNummerDataGridViewTextBoxColumn.DataPropertyName = "BadgeNummer";
            this.badgeNummerDataGridViewTextBoxColumn.HeaderText = "BadgeNummer";
            this.badgeNummerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.badgeNummerDataGridViewTextBoxColumn.Name = "badgeNummerDataGridViewTextBoxColumn";
            this.badgeNummerDataGridViewTextBoxColumn.Width = 200;
            // 
            // opleidingIdDataGridViewTextBoxColumn4
            // 
            this.opleidingIdDataGridViewTextBoxColumn4.DataPropertyName = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn4.HeaderText = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.opleidingIdDataGridViewTextBoxColumn4.Name = "opleidingIdDataGridViewTextBoxColumn4";
            this.opleidingIdDataGridViewTextBoxColumn4.Width = 200;
            // 
            // DeleteRadioB
            // 
            this.DeleteRadioB.AutoSize = true;
            this.DeleteRadioB.Location = new System.Drawing.Point(894, 888);
            this.DeleteRadioB.Name = "DeleteRadioB";
            this.DeleteRadioB.Size = new System.Drawing.Size(156, 29);
            this.DeleteRadioB.TabIndex = 13;
            this.DeleteRadioB.Text = "Verwijderen";
            this.DeleteRadioB.UseVisualStyleBackColor = true;
            this.DeleteRadioB.CheckedChanged += new System.EventHandler(this.DeleteRadioB_CheckedChanged);
            // 
            // WijzigRadioB
            // 
            this.WijzigRadioB.AutoSize = true;
            this.WijzigRadioB.Location = new System.Drawing.Point(894, 785);
            this.WijzigRadioB.Name = "WijzigRadioB";
            this.WijzigRadioB.Size = new System.Drawing.Size(125, 29);
            this.WijzigRadioB.TabIndex = 12;
            this.WijzigRadioB.Text = "Wijzigen";
            this.WijzigRadioB.UseVisualStyleBackColor = true;
            this.WijzigRadioB.CheckedChanged += new System.EventHandler(this.WijzigRadioB_CheckedChanged);
            // 
            // ToevRadioB
            // 
            this.ToevRadioB.AutoSize = true;
            this.ToevRadioB.Checked = true;
            this.ToevRadioB.Location = new System.Drawing.Point(894, 688);
            this.ToevRadioB.Name = "ToevRadioB";
            this.ToevRadioB.Size = new System.Drawing.Size(151, 29);
            this.ToevRadioB.TabIndex = 11;
            this.ToevRadioB.TabStop = true;
            this.ToevRadioB.Text = "Toevoegen";
            this.ToevRadioB.UseVisualStyleBackColor = true;
            this.ToevRadioB.CheckedChanged += new System.EventHandler(this.ToevRadioB_CheckedChanged);
            // 
            // WijzigenGrpB
            // 
            this.WijzigenGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.WijzigenGrpB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WijzigenGrpB.BackgroundImage")));
            this.WijzigenGrpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WijzigenGrpB.Controls.Add(this.label55);
            this.WijzigenGrpB.Controls.Add(this.searchButton);
            this.WijzigenGrpB.Controls.Add(this.searchTB);
            this.WijzigenGrpB.Location = new System.Drawing.Point(1081, 425);
            this.WijzigenGrpB.Name = "WijzigenGrpB";
            this.WijzigenGrpB.Size = new System.Drawing.Size(857, 759);
            this.WijzigenGrpB.TabIndex = 2;
            this.WijzigenGrpB.TabStop = false;
            this.WijzigenGrpB.Text = "Zoeken";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(21, 70);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(288, 25);
            this.label55.TabIndex = 56;
            this.label55.Text = "Geef naam van deelnemer in";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(537, 97);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(177, 39);
            this.searchButton.TabIndex = 55;
            this.searchButton.Text = "Zoek";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(21, 101);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(495, 31);
            this.searchTB.TabIndex = 54;
            // 
            // ToevoegenGrpB
            // 
            this.ToevoegenGrpB.BackColor = System.Drawing.Color.DarkGray;
            this.ToevoegenGrpB.Controls.Add(this.comboBox1);
            this.ToevoegenGrpB.Controls.Add(this.label38);
            this.ToevoegenGrpB.Controls.Add(this.dlnmrOplComB);
            this.ToevoegenGrpB.Controls.Add(this.label56);
            this.ToevoegenGrpB.Controls.Add(this.deleteDlnmrTB);
            this.ToevoegenGrpB.Controls.Add(this.saveChangeDeelnemerButton);
            this.ToevoegenGrpB.Controls.Add(this.deleteDeelnemerButton);
            this.ToevoegenGrpB.Controls.Add(this.label21);
            this.ToevoegenGrpB.Controls.Add(this.createDeelnemerButton);
            this.ToevoegenGrpB.Controls.Add(this.WijzigZoekButton);
            this.ToevoegenGrpB.Controls.Add(this.geboorteDatDtP);
            this.ToevoegenGrpB.Controls.Add(this.wijzigNaamTextBox);
            this.ToevoegenGrpB.Controls.Add(this.label1);
            this.ToevoegenGrpB.Controls.Add(this.label2);
            this.ToevoegenGrpB.Controls.Add(this.label3);
            this.ToevoegenGrpB.Controls.Add(this.label4);
            this.ToevoegenGrpB.Controls.Add(this.bdgNumTB);
            this.ToevoegenGrpB.Controls.Add(this.wnpltsTB);
            this.ToevoegenGrpB.Controls.Add(this.dlnmrNaamTB);
            this.ToevoegenGrpB.Controls.Add(this.panel1);
            this.ToevoegenGrpB.Location = new System.Drawing.Point(7, 425);
            this.ToevoegenGrpB.Name = "ToevoegenGrpB";
            this.ToevoegenGrpB.Size = new System.Drawing.Size(857, 759);
            this.ToevoegenGrpB.TabIndex = 1;
            this.ToevoegenGrpB.TabStop = false;
            this.ToevoegenGrpB.Text = "Toevoegen";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(505, 33);
            this.comboBox1.TabIndex = 63;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(557, 527);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(103, 25);
            this.label38.TabIndex = 62;
            this.label38.Text = "Opleiding";
            // 
            // dlnmrOplComB
            // 
            this.dlnmrOplComB.FormattingEnabled = true;
            this.dlnmrOplComB.Location = new System.Drawing.Point(12, 524);
            this.dlnmrOplComB.Name = "dlnmrOplComB";
            this.dlnmrOplComB.Size = new System.Drawing.Size(505, 33);
            this.dlnmrOplComB.TabIndex = 61;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(12, 155);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(463, 25);
            this.label56.TabIndex = 60;
            this.label56.Text = "Geef naam in van deelnemer om te verwijderen";
            this.label56.Visible = false;
            // 
            // deleteDlnmrTB
            // 
            this.deleteDlnmrTB.Location = new System.Drawing.Point(12, 184);
            this.deleteDlnmrTB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteDlnmrTB.Name = "deleteDlnmrTB";
            this.deleteDlnmrTB.Size = new System.Drawing.Size(505, 31);
            this.deleteDlnmrTB.TabIndex = 59;
            this.deleteDlnmrTB.Visible = false;
            // 
            // saveChangeDeelnemerButton
            // 
            this.saveChangeDeelnemerButton.Location = new System.Drawing.Point(12, 608);
            this.saveChangeDeelnemerButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangeDeelnemerButton.Name = "saveChangeDeelnemerButton";
            this.saveChangeDeelnemerButton.Size = new System.Drawing.Size(211, 68);
            this.saveChangeDeelnemerButton.TabIndex = 54;
            this.saveChangeDeelnemerButton.Text = "Save changes";
            this.saveChangeDeelnemerButton.UseVisualStyleBackColor = true;
            this.saveChangeDeelnemerButton.Visible = false;
            this.saveChangeDeelnemerButton.Click += new System.EventHandler(this.SaveChangeDeelnemerButton_Click);
            // 
            // deleteDeelnemerButton
            // 
            this.deleteDeelnemerButton.Location = new System.Drawing.Point(557, 177);
            this.deleteDeelnemerButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteDeelnemerButton.Name = "deleteDeelnemerButton";
            this.deleteDeelnemerButton.Size = new System.Drawing.Size(171, 44);
            this.deleteDeelnemerButton.TabIndex = 58;
            this.deleteDeelnemerButton.Text = "Verwijderen";
            this.deleteDeelnemerButton.UseVisualStyleBackColor = true;
            this.deleteDeelnemerButton.Visible = false;
            this.deleteDeelnemerButton.Click += new System.EventHandler(this.DeleteDeelnemerButton_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 72);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(430, 25);
            this.label21.TabIndex = 57;
            this.label21.Text = "Geef naam in van deelnemer om te wijzigen";
            this.label21.Visible = false;
            // 
            // createDeelnemerButton
            // 
            this.createDeelnemerButton.Location = new System.Drawing.Point(12, 684);
            this.createDeelnemerButton.Margin = new System.Windows.Forms.Padding(4);
            this.createDeelnemerButton.Name = "createDeelnemerButton";
            this.createDeelnemerButton.Size = new System.Drawing.Size(211, 68);
            this.createDeelnemerButton.TabIndex = 41;
            this.createDeelnemerButton.Text = "Create";
            this.createDeelnemerButton.UseVisualStyleBackColor = true;
            this.createDeelnemerButton.Click += new System.EventHandler(this.CreateDeelnemerButton_Click);
            // 
            // WijzigZoekButton
            // 
            this.WijzigZoekButton.Location = new System.Drawing.Point(557, 96);
            this.WijzigZoekButton.Margin = new System.Windows.Forms.Padding(4);
            this.WijzigZoekButton.Name = "WijzigZoekButton";
            this.WijzigZoekButton.Size = new System.Drawing.Size(171, 44);
            this.WijzigZoekButton.TabIndex = 56;
            this.WijzigZoekButton.Text = "Wijzigen";
            this.WijzigZoekButton.UseVisualStyleBackColor = true;
            this.WijzigZoekButton.Visible = false;
            this.WijzigZoekButton.Click += new System.EventHandler(this.WijzigZoekButton_Click);
            // 
            // geboorteDatDtP
            // 
            this.geboorteDatDtP.Location = new System.Drawing.Point(12, 362);
            this.geboorteDatDtP.Margin = new System.Windows.Forms.Padding(4);
            this.geboorteDatDtP.Name = "geboorteDatDtP";
            this.geboorteDatDtP.Size = new System.Drawing.Size(505, 31);
            this.geboorteDatDtP.TabIndex = 40;
            this.geboorteDatDtP.Validating += new System.ComponentModel.CancelEventHandler(this.GeboorteDatDtP_Validating);
            // 
            // wijzigNaamTextBox
            // 
            this.wijzigNaamTextBox.Location = new System.Drawing.Point(12, 101);
            this.wijzigNaamTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigNaamTextBox.Name = "wijzigNaamTextBox";
            this.wijzigNaamTextBox.Size = new System.Drawing.Size(505, 31);
            this.wijzigNaamTextBox.TabIndex = 55;
            this.wijzigNaamTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 475);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Badge nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Woonplaats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 367);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Geboortedatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Naam";
            // 
            // bdgNumTB
            // 
            this.bdgNumTB.Location = new System.Drawing.Point(12, 472);
            this.bdgNumTB.Margin = new System.Windows.Forms.Padding(4);
            this.bdgNumTB.Name = "bdgNumTB";
            this.bdgNumTB.Size = new System.Drawing.Size(505, 31);
            this.bdgNumTB.TabIndex = 35;
            this.bdgNumTB.Validating += new System.ComponentModel.CancelEventHandler(this.BdgNumTB_Validating);
            // 
            // wnpltsTB
            // 
            this.wnpltsTB.Location = new System.Drawing.Point(12, 416);
            this.wnpltsTB.Margin = new System.Windows.Forms.Padding(4);
            this.wnpltsTB.Name = "wnpltsTB";
            this.wnpltsTB.Size = new System.Drawing.Size(505, 31);
            this.wnpltsTB.TabIndex = 34;
            this.wnpltsTB.Validating += new System.ComponentModel.CancelEventHandler(this.WnpltsTB_Validating);
            // 
            // dlnmrNaamTB
            // 
            this.dlnmrNaamTB.Location = new System.Drawing.Point(12, 306);
            this.dlnmrNaamTB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrNaamTB.Name = "dlnmrNaamTB";
            this.dlnmrNaamTB.Size = new System.Drawing.Size(505, 31);
            this.dlnmrNaamTB.TabIndex = 33;
            this.dlnmrNaamTB.Validating += new System.ComponentModel.CancelEventHandler(this.DlnmrNaamTB_Validating);
            // 
            // BeheerTabControl
            // 
            this.BeheerTabControl.Controls.Add(this.dlnmrTabP);
            this.BeheerTabControl.Controls.Add(this.DocTabP);
            this.BeheerTabControl.Controls.Add(this.oplInfoTabP);
            this.BeheerTabControl.Controls.Add(this.ntOplDgTabP);
            this.BeheerTabControl.Controls.Add(this.tijdRegTabP);
            this.BeheerTabControl.Controls.Add(this.ExtraTabP);
            this.BeheerTabControl.Location = new System.Drawing.Point(13, 12);
            this.BeheerTabControl.Name = "BeheerTabControl";
            this.BeheerTabControl.SelectedIndex = 0;
            this.BeheerTabControl.Size = new System.Drawing.Size(1960, 1237);
            this.BeheerTabControl.TabIndex = 0;
            this.BeheerTabControl.SelectedIndexChanged += new System.EventHandler(this.BeheerTabControl_SelectedIndexChanged);
            // 
            // opleidingIdDataGridViewTextBoxColumn2
            // 
            this.opleidingIdDataGridViewTextBoxColumn2.DataPropertyName = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn2.HeaderText = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.opleidingIdDataGridViewTextBoxColumn2.Name = "opleidingIdDataGridViewTextBoxColumn2";
            this.opleidingIdDataGridViewTextBoxColumn2.Width = 200;
            // 
            // docentIdDataGridViewTextBoxColumn
            // 
            this.docentIdDataGridViewTextBoxColumn.DataPropertyName = "Docent_Id";
            this.docentIdDataGridViewTextBoxColumn.HeaderText = "Docent_Id";
            this.docentIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.docentIdDataGridViewTextBoxColumn.Name = "docentIdDataGridViewTextBoxColumn";
            this.docentIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // idDataGridViewTextBoxColumn5
            // 
            this.idDataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn5.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn5.Name = "idDataGridViewTextBoxColumn5";
            this.idDataGridViewTextBoxColumn5.ReadOnly = true;
            this.idDataGridViewTextBoxColumn5.Width = 200;
            // 
            // docOplCreateButton
            // 
            this.docOplCreateButton.Location = new System.Drawing.Point(12, 684);
            this.docOplCreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.docOplCreateButton.Name = "docOplCreateButton";
            this.docOplCreateButton.Size = new System.Drawing.Size(211, 68);
            this.docOplCreateButton.TabIndex = 47;
            this.docOplCreateButton.Text = "Create";
            this.docOplCreateButton.UseVisualStyleBackColor = true;
            // 
            // docOpl1ComB
            // 
            this.docOpl1ComB.FormattingEnabled = true;
            this.docOpl1ComB.Location = new System.Drawing.Point(12, 362);
            this.docOpl1ComB.Margin = new System.Windows.Forms.Padding(4);
            this.docOpl1ComB.Name = "docOpl1ComB";
            this.docOpl1ComB.Size = new System.Drawing.Size(507, 33);
            this.docOpl1ComB.TabIndex = 48;
            // 
            // docNaamComB
            // 
            this.docNaamComB.FormattingEnabled = true;
            this.docNaamComB.Location = new System.Drawing.Point(12, 306);
            this.docNaamComB.Margin = new System.Windows.Forms.Padding(4);
            this.docNaamComB.Name = "docNaamComB";
            this.docNaamComB.Size = new System.Drawing.Size(507, 33);
            this.docNaamComB.TabIndex = 49;
            // 
            // saveChangeDocOplButton
            // 
            this.saveChangeDocOplButton.Location = new System.Drawing.Point(12, 416);
            this.saveChangeDocOplButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangeDocOplButton.Name = "saveChangeDocOplButton";
            this.saveChangeDocOplButton.Size = new System.Drawing.Size(211, 68);
            this.saveChangeDocOplButton.TabIndex = 67;
            this.saveChangeDocOplButton.Text = "Save changes";
            this.saveChangeDocOplButton.UseVisualStyleBackColor = true;
            this.saveChangeDocOplButton.Visible = false;
            // 
            // docOplWijzTB
            // 
            this.docOplWijzTB.Location = new System.Drawing.Point(12, 101);
            this.docOplWijzTB.Margin = new System.Windows.Forms.Padding(4);
            this.docOplWijzTB.Name = "docOplWijzTB";
            this.docOplWijzTB.Size = new System.Drawing.Size(505, 31);
            this.docOplWijzTB.TabIndex = 68;
            this.docOplWijzTB.Visible = false;
            // 
            // docOplWijzBT
            // 
            this.docOplWijzBT.Location = new System.Drawing.Point(557, 96);
            this.docOplWijzBT.Margin = new System.Windows.Forms.Padding(4);
            this.docOplWijzBT.Name = "docOplWijzBT";
            this.docOplWijzBT.Size = new System.Drawing.Size(171, 44);
            this.docOplWijzBT.TabIndex = 69;
            this.docOplWijzBT.Text = "Wijzigen";
            this.docOplWijzBT.UseVisualStyleBackColor = true;
            this.docOplWijzBT.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 72);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(394, 25);
            this.label24.TabIndex = 70;
            this.label24.Visible = false;
            // 
            // docOplVrwdrBT
            // 
            this.docOplVrwdrBT.Location = new System.Drawing.Point(557, 177);
            this.docOplVrwdrBT.Margin = new System.Windows.Forms.Padding(4);
            this.docOplVrwdrBT.Name = "docOplVrwdrBT";
            this.docOplVrwdrBT.Size = new System.Drawing.Size(171, 44);
            this.docOplVrwdrBT.TabIndex = 71;
            this.docOplVrwdrBT.Text = "Verwijderen";
            this.docOplVrwdrBT.UseVisualStyleBackColor = true;
            this.docOplVrwdrBT.Visible = false;
            // 
            // docOplvrwdrTb
            // 
            this.docOplvrwdrTb.Location = new System.Drawing.Point(12, 184);
            this.docOplvrwdrTb.Margin = new System.Windows.Forms.Padding(4);
            this.docOplvrwdrTb.Name = "docOplvrwdrTb";
            this.docOplvrwdrTb.Size = new System.Drawing.Size(505, 31);
            this.docOplvrwdrTb.TabIndex = 72;
            this.docOplvrwdrTb.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 155);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(427, 25);
            this.label26.TabIndex = 73;
            this.label26.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(557, 309);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 25);
            this.label30.TabIndex = 74;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(557, 365);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 25);
            this.label29.TabIndex = 75;
            // 
            // docOplZoekTB
            // 
            this.docOplZoekTB.Location = new System.Drawing.Point(21, 101);
            this.docOplZoekTB.Margin = new System.Windows.Forms.Padding(4);
            this.docOplZoekTB.Name = "docOplZoekTB";
            this.docOplZoekTB.Size = new System.Drawing.Size(505, 31);
            this.docOplZoekTB.TabIndex = 69;
            // 
            // docOplZoekBT
            // 
            this.docOplZoekBT.Location = new System.Drawing.Point(537, 97);
            this.docOplZoekBT.Margin = new System.Windows.Forms.Padding(4);
            this.docOplZoekBT.Name = "docOplZoekBT";
            this.docOplZoekBT.Size = new System.Drawing.Size(171, 44);
            this.docOplZoekBT.TabIndex = 70;
            this.docOplZoekBT.Text = "Zoeken";
            this.docOplZoekBT.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(252, 25);
            this.label28.TabIndex = 71;
            // 
            // deelnemerIdDataGridViewTextBoxColumn
            // 
            this.deelnemerIdDataGridViewTextBoxColumn.DataPropertyName = "Deelnemer_Id";
            this.deelnemerIdDataGridViewTextBoxColumn.HeaderText = "Deelnemer_Id";
            this.deelnemerIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.deelnemerIdDataGridViewTextBoxColumn.Name = "deelnemerIdDataGridViewTextBoxColumn";
            this.deelnemerIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // opleidingIdDataGridViewTextBoxColumn1
            // 
            this.opleidingIdDataGridViewTextBoxColumn1.DataPropertyName = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn1.HeaderText = "Opleiding_Id";
            this.opleidingIdDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.opleidingIdDataGridViewTextBoxColumn1.Name = "opleidingIdDataGridViewTextBoxColumn1";
            this.opleidingIdDataGridViewTextBoxColumn1.Width = 200;
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Width = 200;
            // 
            // wijzigDlnmrOplZoekTextBox
            // 
            this.wijzigDlnmrOplZoekTextBox.Location = new System.Drawing.Point(12, 101);
            this.wijzigDlnmrOplZoekTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigDlnmrOplZoekTextBox.Name = "wijzigDlnmrOplZoekTextBox";
            this.wijzigDlnmrOplZoekTextBox.Size = new System.Drawing.Size(505, 31);
            this.wijzigDlnmrOplZoekTextBox.TabIndex = 57;
            this.wijzigDlnmrOplZoekTextBox.Visible = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(557, 309);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(68, 25);
            this.label48.TabIndex = 42;
            // 
            // wijzigDlnmrOplZoekButton
            // 
            this.wijzigDlnmrOplZoekButton.Location = new System.Drawing.Point(557, 96);
            this.wijzigDlnmrOplZoekButton.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigDlnmrOplZoekButton.Name = "wijzigDlnmrOplZoekButton";
            this.wijzigDlnmrOplZoekButton.Size = new System.Drawing.Size(171, 44);
            this.wijzigDlnmrOplZoekButton.TabIndex = 58;
            this.wijzigDlnmrOplZoekButton.Text = "Wijzigen";
            this.wijzigDlnmrOplZoekButton.UseVisualStyleBackColor = true;
            this.wijzigDlnmrOplZoekButton.Visible = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(557, 365);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(103, 25);
            this.label47.TabIndex = 43;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(12, 72);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(430, 25);
            this.label51.TabIndex = 59;
            this.label51.Visible = false;
            // 
            // deleteDlnmrOplButton
            // 
            this.deleteDlnmrOplButton.Location = new System.Drawing.Point(557, 177);
            this.deleteDlnmrOplButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteDlnmrOplButton.Name = "deleteDlnmrOplButton";
            this.deleteDlnmrOplButton.Size = new System.Drawing.Size(171, 44);
            this.deleteDlnmrOplButton.TabIndex = 60;
            this.deleteDlnmrOplButton.Text = "Verwijderen";
            this.deleteDlnmrOplButton.UseVisualStyleBackColor = true;
            this.deleteDlnmrOplButton.Visible = false;
            // 
            // createDlnmrOplButton
            // 
            this.createDlnmrOplButton.Location = new System.Drawing.Point(12, 684);
            this.createDlnmrOplButton.Margin = new System.Windows.Forms.Padding(4);
            this.createDlnmrOplButton.Name = "createDlnmrOplButton";
            this.createDlnmrOplButton.Size = new System.Drawing.Size(211, 68);
            this.createDlnmrOplButton.TabIndex = 44;
            this.createDlnmrOplButton.Text = "Create";
            this.createDlnmrOplButton.UseVisualStyleBackColor = true;
            // 
            // saveChangeDlnmrOplButton
            // 
            this.saveChangeDlnmrOplButton.Location = new System.Drawing.Point(12, 416);
            this.saveChangeDlnmrOplButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangeDlnmrOplButton.Name = "saveChangeDlnmrOplButton";
            this.saveChangeDlnmrOplButton.Size = new System.Drawing.Size(211, 68);
            this.saveChangeDlnmrOplButton.TabIndex = 63;
            this.saveChangeDlnmrOplButton.Text = "Save changes";
            this.saveChangeDlnmrOplButton.UseVisualStyleBackColor = true;
            this.saveChangeDlnmrOplButton.Visible = false;
            // 
            // dlnmrOplOplComB
            // 
            this.dlnmrOplOplComB.FormattingEnabled = true;
            this.dlnmrOplOplComB.Location = new System.Drawing.Point(12, 362);
            this.dlnmrOplOplComB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplOplComB.Name = "dlnmrOplOplComB";
            this.dlnmrOplOplComB.Size = new System.Drawing.Size(507, 33);
            this.dlnmrOplOplComB.TabIndex = 45;
            // 
            // dlnmrOplNaamComB
            // 
            this.dlnmrOplNaamComB.FormattingEnabled = true;
            this.dlnmrOplNaamComB.Location = new System.Drawing.Point(12, 306);
            this.dlnmrOplNaamComB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplNaamComB.Name = "dlnmrOplNaamComB";
            this.dlnmrOplNaamComB.Size = new System.Drawing.Size(507, 33);
            this.dlnmrOplNaamComB.TabIndex = 46;
            // 
            // dlnmrOplVrwdrTB
            // 
            this.dlnmrOplVrwdrTB.Location = new System.Drawing.Point(12, 184);
            this.dlnmrOplVrwdrTB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplVrwdrTB.Name = "dlnmrOplVrwdrTB";
            this.dlnmrOplVrwdrTB.Size = new System.Drawing.Size(505, 31);
            this.dlnmrOplVrwdrTB.TabIndex = 64;
            this.dlnmrOplVrwdrTB.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(463, 25);
            this.label13.TabIndex = 65;
            this.label13.Visible = false;
            // 
            // dlnmrOplZoekTB
            // 
            this.dlnmrOplZoekTB.Location = new System.Drawing.Point(21, 101);
            this.dlnmrOplZoekTB.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplZoekTB.Name = "dlnmrOplZoekTB";
            this.dlnmrOplZoekTB.Size = new System.Drawing.Size(505, 31);
            this.dlnmrOplZoekTB.TabIndex = 66;
            // 
            // dlnmrOplZoekBT
            // 
            this.dlnmrOplZoekBT.Location = new System.Drawing.Point(537, 97);
            this.dlnmrOplZoekBT.Margin = new System.Windows.Forms.Padding(4);
            this.dlnmrOplZoekBT.Name = "dlnmrOplZoekBT";
            this.dlnmrOplZoekBT.Size = new System.Drawing.Size(171, 44);
            this.dlnmrOplZoekBT.TabIndex = 67;
            this.dlnmrOplZoekBT.Text = "Zoeken";
            this.dlnmrOplZoekBT.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(288, 25);
            this.label14.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 295);
            this.panel1.TabIndex = 64;
            // 
            // docZoekComB
            // 
            this.docZoekComB.FormattingEnabled = true;
            this.docZoekComB.Location = new System.Drawing.Point(12, 240);
            this.docZoekComB.Name = "docZoekComB";
            this.docZoekComB.Size = new System.Drawing.Size(507, 33);
            this.docZoekComB.TabIndex = 76;
            // 
            // oplInfoComB
            // 
            this.oplInfoComB.FormattingEnabled = true;
            this.oplInfoComB.Location = new System.Drawing.Point(26, 617);
            this.oplInfoComB.Name = "oplInfoComB";
            this.oplInfoComB.Size = new System.Drawing.Size(540, 33);
            this.oplInfoComB.TabIndex = 60;
            // 
            // BeheerAllesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1985, 1323);
            this.Controls.Add(this.BeheerTabControl);
            this.Name = "BeheerAllesForm";
            this.Text = "BeheerAllesForm";
            this.Load += new System.EventHandler(this.BeheerAllesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deelnemersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aanwezigheidslijstDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docentensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aanwezigheidslijstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opleidingsinformatiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nietOpleidingsDagensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deelnemersOpleidingensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docetenOpleidingensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tijdsregistratiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlnmrErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oplInfoErrorProvider)).EndInit();
            this.tijdRegTabP.ResumeLayout(false);
            this.tijdRegTabP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ntOplDgTabP.ResumeLayout(false);
            this.ntOplDgTabP.PerformLayout();
            this.vakDagZoekGrpB.ResumeLayout(false);
            this.vakDagZoekGrpB.PerformLayout();
            this.vakDagGrpB.ResumeLayout(false);
            this.vakDagGrpB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.oplInfoTabP.ResumeLayout(false);
            this.oplInfoTabP.PerformLayout();
            this.WijzOplInfoGrpB.ResumeLayout(false);
            this.WijzOplInfoGrpB.PerformLayout();
            this.toevOplInfoGrpB.ResumeLayout(false);
            this.toevOplInfoGrpB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.DocTabP.ResumeLayout(false);
            this.DocTabP.PerformLayout();
            this.docZoekGrpB.ResumeLayout(false);
            this.docZoekGrpB.PerformLayout();
            this.docToevGrpB.ResumeLayout(false);
            this.docToevGrpB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.dlnmrTabP.ResumeLayout(false);
            this.dlnmrTabP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.WijzigenGrpB.ResumeLayout(false);
            this.WijzigenGrpB.PerformLayout();
            this.ToevoegenGrpB.ResumeLayout(false);
            this.ToevoegenGrpB.PerformLayout();
            this.BeheerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AanwezigheidslijstDataSet aanwezigheidslijstDataSet;
        private AanwezigheidslijstDataSetTableAdapters.DeelnemersTableAdapter deelnemersTableAdapter;
        private System.Windows.Forms.BindingSource docentensBindingSource;
        private AanwezigheidslijstDataSetTableAdapters.DocentensTableAdapter docentensTableAdapter;
        private System.Windows.Forms.BindingSource opleidingsinformatiesBindingSource;
        private AanwezigheidslijstDataSetTableAdapters.OpleidingsinformatiesTableAdapter opleidingsinformatiesTableAdapter;
        private System.Windows.Forms.BindingSource nietOpleidingsDagensBindingSource;
        private AanwezigheidslijstDataSetTableAdapters.NietOpleidingsDagensTableAdapter nietOpleidingsDagensTableAdapter;
        private System.Windows.Forms.BindingSource deelnemersOpleidingensBindingSource;
        private AanwezigheidslijstDataSetTableAdapters.DeelnemersOpleidingensTableAdapter deelnemersOpleidingensTableAdapter;
        private System.Windows.Forms.BindingSource docetenOpleidingensBindingSource;
        private AanwezigheidslijstDataSetTableAdapters.DocetenOpleidingensTableAdapter docetenOpleidingensTableAdapter;
        private System.Windows.Forms.BindingSource tijdsregistratiesBindingSource;
        private AanwezigheidslijstDataSetTableAdapters.TijdsregistratiesTableAdapter tijdsregistratiesTableAdapter;
        private System.Windows.Forms.ErrorProvider dlnmrErrorProvider;
        private AanwezigheidslijstDataSet aanwezigheidslijstDataSet1;
        private System.Windows.Forms.BindingSource deelnemersBindingSource;
        private System.Windows.Forms.ErrorProvider DocErrorProvider;
        private System.Windows.Forms.ErrorProvider oplInfoErrorProvider;
        private System.Windows.Forms.TabControl BeheerTabControl;
        private System.Windows.Forms.TabPage dlnmrTabP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geboorteDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woonplaatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn badgeNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingIdDataGridViewTextBoxColumn4;
        private System.Windows.Forms.RadioButton DeleteRadioB;
        private System.Windows.Forms.RadioButton WijzigRadioB;
        private System.Windows.Forms.RadioButton ToevRadioB;
        private System.Windows.Forms.GroupBox WijzigenGrpB;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.GroupBox ToevoegenGrpB;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox dlnmrOplComB;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox deleteDlnmrTB;
        private System.Windows.Forms.Button saveChangeDeelnemerButton;
        private System.Windows.Forms.Button deleteDeelnemerButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button createDeelnemerButton;
        private System.Windows.Forms.Button WijzigZoekButton;
        private System.Windows.Forms.DateTimePicker geboorteDatDtP;
        private System.Windows.Forms.TextBox wijzigNaamTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bdgNumTB;
        private System.Windows.Forms.TextBox wnpltsTB;
        private System.Windows.Forms.TextBox dlnmrNaamTB;
        private System.Windows.Forms.TabPage DocTabP;
        private System.Windows.Forms.RadioButton vrwdrDocRB;
        private System.Windows.Forms.RadioButton wijzDocRB;
        private System.Windows.Forms.RadioButton toevDocRB;
        private System.Windows.Forms.GroupBox docZoekGrpB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button docZoekBT;
        private System.Windows.Forms.TextBox DocZoekTB;
        private System.Windows.Forms.GroupBox docToevGrpB;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox docOplComB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vrwdrDocTB;
        private System.Windows.Forms.Button saveChangeDocButton;
        private System.Windows.Forms.Button createDocentButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox docBedrijfTB;
        private System.Windows.Forms.TextBox docNaamTB;
        private System.Windows.Forms.Button deleteDocButton;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox wijzDocTB;
        private System.Windows.Forms.Button wijzigDocButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opleiding_Id;
        private System.Windows.Forms.TabPage oplInfoTabP;
        private System.Windows.Forms.RadioButton oplVrwdrRB;
        private System.Windows.Forms.RadioButton oplWijzRB;
        private System.Windows.Forms.RadioButton oplToevRB;
        private System.Windows.Forms.GroupBox WijzOplInfoGrpB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button oplInfoZoekBT;
        private System.Windows.Forms.TextBox oplInfoZoekTB;
        private System.Windows.Forms.GroupBox toevOplInfoGrpB;
        private System.Windows.Forms.Button saveChangeOplInfoButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox oplVrwdrTB;
        private System.Windows.Forms.Button deleteOplInfoButton;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button CreateOpleidingsInfoButton;
        private System.Windows.Forms.Button wijzigOplInfobutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wijzigOplInfoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker eindDatDtP;
        private System.Windows.Forms.DateTimePicker startDatDtP;
        private System.Windows.Forms.TextBox oplCdTB;
        private System.Windows.Forms.TextBox OeNumTB;
        private System.Windows.Forms.TextBox refOplTB;
        private System.Windows.Forms.TextBox oplPlTB;
        private System.Windows.Forms.TextBox cntcpTB;
        private System.Windows.Forms.TextBox oplTB;
        private System.Windows.Forms.TextBox oplInstTB;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingsinstellingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersoonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingsplaatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referentieOpleidingsplaatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oeNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingscodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eindDatumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage ntOplDgTabP;
        private System.Windows.Forms.RadioButton vakDagVrwdrRB;
        private System.Windows.Forms.RadioButton VakDagWijzRB;
        private System.Windows.Forms.RadioButton vakDagToevRB;
        private System.Windows.Forms.GroupBox vakDagZoekGrpB;
        private System.Windows.Forms.Button vakDagZoekBT;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker vakDagZoekDTP;
        private System.Windows.Forms.GroupBox vakDagGrpB;
        private System.Windows.Forms.DateTimePicker vakDagVrwdrDTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker WijzigZoekdateTimePicker;
        private System.Windows.Forms.Button saveChangeVakDagButton;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox vakdagOplIdComB;
        private System.Windows.Forms.CheckBox nmdgCB;
        private System.Windows.Forms.CheckBox vmdgCB;
        private System.Windows.Forms.DateTimePicker vakDagDtP;
        private System.Windows.Forms.Button createNietOplDagButton;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button deleteVakDagButton;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button wijzigVakDagZoekButton;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn voormiddagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn namiddagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tijdRegTabP;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox tijdsRegListBox;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deelnemerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage ExtraTabP;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn docentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button docOplCreateButton;
        private System.Windows.Forms.ComboBox docOpl1ComB;
        private System.Windows.Forms.ComboBox docNaamComB;
        private System.Windows.Forms.Button saveChangeDocOplButton;
        private System.Windows.Forms.TextBox docOplWijzTB;
        private System.Windows.Forms.Button docOplWijzBT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button docOplVrwdrBT;
        private System.Windows.Forms.TextBox docOplvrwdrTb;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox docOplZoekTB;
        private System.Windows.Forms.Button docOplZoekBT;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewTextBoxColumn deelnemerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opleidingIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox wijzigDlnmrOplZoekTextBox;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button wijzigDlnmrOplZoekButton;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Button deleteDlnmrOplButton;
        private System.Windows.Forms.Button createDlnmrOplButton;
        private System.Windows.Forms.Button saveChangeDlnmrOplButton;
        private System.Windows.Forms.ComboBox dlnmrOplOplComB;
        private System.Windows.Forms.ComboBox dlnmrOplNaamComB;
        private System.Windows.Forms.TextBox dlnmrOplVrwdrTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox dlnmrOplZoekTB;
        private System.Windows.Forms.Button dlnmrOplZoekBT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox docZoekComB;
        private System.Windows.Forms.ComboBox oplInfoComB;
    }
}