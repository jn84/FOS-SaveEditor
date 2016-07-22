namespace FOS_SaveEditor
{
	partial class FOSSEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOSSEditor));
            this.dlgLoadSave = new System.Windows.Forms.OpenFileDialog();
            this.dgridDwellers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numudPetCarriers = new System.Windows.Forms.NumericUpDown();
            this.lblPetCarriers = new System.Windows.Forms.Label();
            this.lblRadaway = new System.Windows.Forms.Label();
            this.lblStimpak = new System.Windows.Forms.Label();
            this.lblHandyBox = new System.Windows.Forms.Label();
            this.lblLunchBox = new System.Windows.Forms.Label();
            this.lblCaps = new System.Windows.Forms.Label();
            this.numRadaway = new System.Windows.Forms.NumericUpDown();
            this.numStimpak = new System.Windows.Forms.NumericUpDown();
            this.numHandyBox = new System.Windows.Forms.NumericUpDown();
            this.numLunchBox = new System.Windows.Forms.NumericUpDown();
            this.numCaps = new System.Windows.Forms.NumericUpDown();
            this.grpDwellers = new System.Windows.Forms.GroupBox();
            this.btnLoadSave = new System.Windows.Forms.Button();
            this.btnSaveEncrypted = new System.Windows.Forms.Button();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgSaveJson = new System.Windows.Forms.SaveFileDialog();
            this.grpVaultResources = new System.Windows.Forms.GroupBox();
            this.lblMaxWater = new System.Windows.Forms.Label();
            this.lblMaxFood = new System.Windows.Forms.Label();
            this.lblMaxElectricity = new System.Windows.Forms.Label();
            this.lblMax3 = new System.Windows.Forms.Label();
            this.lblMax2 = new System.Windows.Forms.Label();
            this.lblMax1 = new System.Windows.Forms.Label();
            this.numudWater = new System.Windows.Forms.NumericUpDown();
            this.numudFood = new System.Windows.Forms.NumericUpDown();
            this.numudEnergy = new System.Windows.Forms.NumericUpDown();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblElectricity = new System.Windows.Forms.Label();
            this.grpCraftedItems = new System.Windows.Forms.GroupBox();
            this.numudStarterPacks = new System.Windows.Forms.NumericUpDown();
            this.numudNukaQuantums = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNukaQuantums = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dwellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEditEquipment = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgridDwellers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudPetCarriers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadaway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStimpak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHandyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaps)).BeginInit();
            this.grpDwellers.SuspendLayout();
            this.grpVaultResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudEnergy)).BeginInit();
            this.grpCraftedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudStarterPacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNukaQuantums)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgLoadSave
            // 
            this.dlgLoadSave.Filter = "Fallout Shelter Save Files|*.sav|Json Files|*.json";
            // 
            // dgridDwellers
            // 
            this.dgridDwellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridDwellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.level,
            this.specialS,
            this.specialP,
            this.specialE,
            this.specialC,
            this.specialI,
            this.specialA,
            this.specialL,
            this.dwellerID,
            this.colMaxBtn,
            this.colEditEquipment});
            this.dgridDwellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridDwellers.Enabled = false;
            this.dgridDwellers.Location = new System.Drawing.Point(3, 16);
            this.dgridDwellers.Name = "dgridDwellers";
            this.dgridDwellers.Size = new System.Drawing.Size(670, 258);
            this.dgridDwellers.TabIndex = 1;
            this.dgridDwellers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridDwellers_CellContentClick);
            this.dgridDwellers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridDwellers_CellValueChanged);
            this.dgridDwellers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgridDwellers_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numudPetCarriers);
            this.groupBox1.Controls.Add(this.lblPetCarriers);
            this.groupBox1.Controls.Add(this.lblRadaway);
            this.groupBox1.Controls.Add(this.lblStimpak);
            this.groupBox1.Controls.Add(this.lblHandyBox);
            this.groupBox1.Controls.Add(this.lblLunchBox);
            this.groupBox1.Controls.Add(this.lblCaps);
            this.groupBox1.Controls.Add(this.numRadaway);
            this.groupBox1.Controls.Add(this.numStimpak);
            this.groupBox1.Controls.Add(this.numHandyBox);
            this.groupBox1.Controls.Add(this.numLunchBox);
            this.groupBox1.Controls.Add(this.numCaps);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vault Assets";
            // 
            // numudPetCarriers
            // 
            this.numudPetCarriers.Enabled = false;
            this.numudPetCarriers.Location = new System.Drawing.Point(115, 99);
            this.numudPetCarriers.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numudPetCarriers.Name = "numudPetCarriers";
            this.numudPetCarriers.Size = new System.Drawing.Size(120, 20);
            this.numudPetCarriers.TabIndex = 11;
            // 
            // lblPetCarriers
            // 
            this.lblPetCarriers.AutoSize = true;
            this.lblPetCarriers.Location = new System.Drawing.Point(6, 101);
            this.lblPetCarriers.Name = "lblPetCarriers";
            this.lblPetCarriers.Size = new System.Drawing.Size(61, 13);
            this.lblPetCarriers.TabIndex = 10;
            this.lblPetCarriers.Text = "Pet Carriers";
            // 
            // lblRadaway
            // 
            this.lblRadaway.AutoSize = true;
            this.lblRadaway.Location = new System.Drawing.Point(6, 154);
            this.lblRadaway.Name = "lblRadaway";
            this.lblRadaway.Size = new System.Drawing.Size(57, 13);
            this.lblRadaway.TabIndex = 9;
            this.lblRadaway.Text = "Radaways";
            // 
            // lblStimpak
            // 
            this.lblStimpak.AutoSize = true;
            this.lblStimpak.Location = new System.Drawing.Point(6, 127);
            this.lblStimpak.Name = "lblStimpak";
            this.lblStimpak.Size = new System.Drawing.Size(50, 13);
            this.lblStimpak.TabIndex = 8;
            this.lblStimpak.Text = "Stimpaks";
            // 
            // lblHandyBox
            // 
            this.lblHandyBox.AutoSize = true;
            this.lblHandyBox.Location = new System.Drawing.Point(6, 75);
            this.lblHandyBox.Name = "lblHandyBox";
            this.lblHandyBox.Size = new System.Drawing.Size(88, 13);
            this.lblHandyBox.TabIndex = 7;
            this.lblHandyBox.Text = "Mr. Handy Boxes";
            // 
            // lblLunchBox
            // 
            this.lblLunchBox.AutoSize = true;
            this.lblLunchBox.Location = new System.Drawing.Point(6, 48);
            this.lblLunchBox.Name = "lblLunchBox";
            this.lblLunchBox.Size = new System.Drawing.Size(69, 13);
            this.lblLunchBox.TabIndex = 6;
            this.lblLunchBox.Text = "Lunch Boxes";
            // 
            // lblCaps
            // 
            this.lblCaps.AutoSize = true;
            this.lblCaps.Location = new System.Drawing.Point(6, 21);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(31, 13);
            this.lblCaps.TabIndex = 5;
            this.lblCaps.Text = "Caps";
            // 
            // numRadaway
            // 
            this.numRadaway.Enabled = false;
            this.numRadaway.Location = new System.Drawing.Point(115, 152);
            this.numRadaway.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numRadaway.Name = "numRadaway";
            this.numRadaway.Size = new System.Drawing.Size(120, 20);
            this.numRadaway.TabIndex = 4;
            // 
            // numStimpak
            // 
            this.numStimpak.Enabled = false;
            this.numStimpak.Location = new System.Drawing.Point(115, 125);
            this.numStimpak.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numStimpak.Name = "numStimpak";
            this.numStimpak.Size = new System.Drawing.Size(120, 20);
            this.numStimpak.TabIndex = 3;
            // 
            // numHandyBox
            // 
            this.numHandyBox.Enabled = false;
            this.numHandyBox.Location = new System.Drawing.Point(115, 73);
            this.numHandyBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHandyBox.Name = "numHandyBox";
            this.numHandyBox.Size = new System.Drawing.Size(120, 20);
            this.numHandyBox.TabIndex = 2;
            // 
            // numLunchBox
            // 
            this.numLunchBox.Enabled = false;
            this.numLunchBox.Location = new System.Drawing.Point(115, 46);
            this.numLunchBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numLunchBox.Name = "numLunchBox";
            this.numLunchBox.Size = new System.Drawing.Size(120, 20);
            this.numLunchBox.TabIndex = 1;
            // 
            // numCaps
            // 
            this.numCaps.Enabled = false;
            this.numCaps.Location = new System.Drawing.Point(115, 19);
            this.numCaps.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numCaps.Name = "numCaps";
            this.numCaps.Size = new System.Drawing.Size(120, 20);
            this.numCaps.TabIndex = 0;
            // 
            // grpDwellers
            // 
            this.grpDwellers.Controls.Add(this.dgridDwellers);
            this.grpDwellers.Location = new System.Drawing.Point(6, 199);
            this.grpDwellers.Name = "grpDwellers";
            this.grpDwellers.Size = new System.Drawing.Size(676, 277);
            this.grpDwellers.TabIndex = 3;
            this.grpDwellers.TabStop = false;
            this.grpDwellers.Text = "Dwellers";
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.Location = new System.Drawing.Point(463, 19);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(219, 23);
            this.btnLoadSave.TabIndex = 4;
            this.btnLoadSave.Text = "Load Save...";
            this.btnLoadSave.UseVisualStyleBackColor = true;
            this.btnLoadSave.Click += new System.EventHandler(this.btnLoadSave_Click);
            // 
            // btnSaveEncrypted
            // 
            this.btnSaveEncrypted.Enabled = false;
            this.btnSaveEncrypted.Location = new System.Drawing.Point(463, 48);
            this.btnSaveEncrypted.Name = "btnSaveEncrypted";
            this.btnSaveEncrypted.Size = new System.Drawing.Size(219, 23);
            this.btnSaveEncrypted.TabIndex = 5;
            this.btnSaveEncrypted.Text = "Save As...";
            this.btnSaveEncrypted.UseVisualStyleBackColor = true;
            this.btnSaveEncrypted.Click += new System.EventHandler(this.btnSaveEncrypted_Click);
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Enabled = false;
            this.btnSaveJson.Location = new System.Drawing.Point(463, 77);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(219, 23);
            this.btnSaveJson.TabIndex = 6;
            this.btnSaveJson.Text = "Save As Json...";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "sav";
            // 
            // dlgSaveJson
            // 
            this.dlgSaveJson.DefaultExt = "json";
            // 
            // grpVaultResources
            // 
            this.grpVaultResources.Controls.Add(this.lblMaxWater);
            this.grpVaultResources.Controls.Add(this.lblMaxFood);
            this.grpVaultResources.Controls.Add(this.lblMaxElectricity);
            this.grpVaultResources.Controls.Add(this.lblMax3);
            this.grpVaultResources.Controls.Add(this.lblMax2);
            this.grpVaultResources.Controls.Add(this.lblMax1);
            this.grpVaultResources.Controls.Add(this.numudWater);
            this.grpVaultResources.Controls.Add(this.numudFood);
            this.grpVaultResources.Controls.Add(this.numudEnergy);
            this.grpVaultResources.Controls.Add(this.lblWater);
            this.grpVaultResources.Controls.Add(this.lblFood);
            this.grpVaultResources.Controls.Add(this.lblElectricity);
            this.grpVaultResources.Location = new System.Drawing.Point(6, 12);
            this.grpVaultResources.Name = "grpVaultResources";
            this.grpVaultResources.Size = new System.Drawing.Size(204, 102);
            this.grpVaultResources.TabIndex = 7;
            this.grpVaultResources.TabStop = false;
            this.grpVaultResources.Text = "Vault Resources";
            // 
            // lblMaxWater
            // 
            this.lblMaxWater.AutoSize = true;
            this.lblMaxWater.Location = new System.Drawing.Point(159, 77);
            this.lblMaxWater.Name = "lblMaxWater";
            this.lblMaxWater.Size = new System.Drawing.Size(13, 13);
            this.lblMaxWater.TabIndex = 11;
            this.lblMaxWater.Text = "0";
            // 
            // lblMaxFood
            // 
            this.lblMaxFood.AutoSize = true;
            this.lblMaxFood.Location = new System.Drawing.Point(159, 50);
            this.lblMaxFood.Name = "lblMaxFood";
            this.lblMaxFood.Size = new System.Drawing.Size(13, 13);
            this.lblMaxFood.TabIndex = 10;
            this.lblMaxFood.Text = "0";
            // 
            // lblMaxElectricity
            // 
            this.lblMaxElectricity.AutoSize = true;
            this.lblMaxElectricity.Location = new System.Drawing.Point(159, 23);
            this.lblMaxElectricity.Name = "lblMaxElectricity";
            this.lblMaxElectricity.Size = new System.Drawing.Size(13, 13);
            this.lblMaxElectricity.TabIndex = 9;
            this.lblMaxElectricity.Text = "0";
            // 
            // lblMax3
            // 
            this.lblMax3.AutoSize = true;
            this.lblMax3.Location = new System.Drawing.Point(129, 77);
            this.lblMax3.Name = "lblMax3";
            this.lblMax3.Size = new System.Drawing.Size(30, 13);
            this.lblMax3.TabIndex = 8;
            this.lblMax3.Text = "Max:";
            // 
            // lblMax2
            // 
            this.lblMax2.AutoSize = true;
            this.lblMax2.Location = new System.Drawing.Point(129, 50);
            this.lblMax2.Name = "lblMax2";
            this.lblMax2.Size = new System.Drawing.Size(30, 13);
            this.lblMax2.TabIndex = 7;
            this.lblMax2.Text = "Max:";
            // 
            // lblMax1
            // 
            this.lblMax1.AutoSize = true;
            this.lblMax1.Location = new System.Drawing.Point(129, 23);
            this.lblMax1.Name = "lblMax1";
            this.lblMax1.Size = new System.Drawing.Size(30, 13);
            this.lblMax1.TabIndex = 6;
            this.lblMax1.Text = "Max:";
            // 
            // numudWater
            // 
            this.numudWater.Enabled = false;
            this.numudWater.Location = new System.Drawing.Point(64, 75);
            this.numudWater.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numudWater.Name = "numudWater";
            this.numudWater.Size = new System.Drawing.Size(59, 20);
            this.numudWater.TabIndex = 5;
            // 
            // numudFood
            // 
            this.numudFood.Enabled = false;
            this.numudFood.Location = new System.Drawing.Point(64, 48);
            this.numudFood.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numudFood.Name = "numudFood";
            this.numudFood.Size = new System.Drawing.Size(59, 20);
            this.numudFood.TabIndex = 4;
            // 
            // numudEnergy
            // 
            this.numudEnergy.Enabled = false;
            this.numudEnergy.Location = new System.Drawing.Point(64, 21);
            this.numudEnergy.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numudEnergy.Name = "numudEnergy";
            this.numudEnergy.Size = new System.Drawing.Size(59, 20);
            this.numudEnergy.TabIndex = 3;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(6, 75);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(36, 13);
            this.lblWater.TabIndex = 2;
            this.lblWater.Text = "Water";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(6, 48);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(31, 13);
            this.lblFood.TabIndex = 1;
            this.lblFood.Text = "Food";
            // 
            // lblElectricity
            // 
            this.lblElectricity.AutoSize = true;
            this.lblElectricity.Location = new System.Drawing.Point(6, 21);
            this.lblElectricity.Name = "lblElectricity";
            this.lblElectricity.Size = new System.Drawing.Size(52, 13);
            this.lblElectricity.TabIndex = 0;
            this.lblElectricity.Text = "Electricity";
            // 
            // grpCraftedItems
            // 
            this.grpCraftedItems.Controls.Add(this.numudStarterPacks);
            this.grpCraftedItems.Controls.Add(this.numudNukaQuantums);
            this.grpCraftedItems.Controls.Add(this.label1);
            this.grpCraftedItems.Controls.Add(this.lblNukaQuantums);
            this.grpCraftedItems.Location = new System.Drawing.Point(6, 121);
            this.grpCraftedItems.Name = "grpCraftedItems";
            this.grpCraftedItems.Size = new System.Drawing.Size(204, 72);
            this.grpCraftedItems.TabIndex = 8;
            this.grpCraftedItems.TabStop = false;
            this.grpCraftedItems.Text = "Other Assets";
            // 
            // numudStarterPacks
            // 
            this.numudStarterPacks.Enabled = false;
            this.numudStarterPacks.Location = new System.Drawing.Point(105, 46);
            this.numudStarterPacks.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numudStarterPacks.Name = "numudStarterPacks";
            this.numudStarterPacks.Size = new System.Drawing.Size(93, 20);
            this.numudStarterPacks.TabIndex = 16;
            // 
            // numudNukaQuantums
            // 
            this.numudNukaQuantums.Enabled = false;
            this.numudNukaQuantums.Location = new System.Drawing.Point(105, 19);
            this.numudNukaQuantums.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numudNukaQuantums.Name = "numudNukaQuantums";
            this.numudNukaQuantums.Size = new System.Drawing.Size(93, 20);
            this.numudNukaQuantums.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Starter Packs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNukaQuantums
            // 
            this.lblNukaQuantums.AutoSize = true;
            this.lblNukaQuantums.Location = new System.Drawing.Point(6, 21);
            this.lblNukaQuantums.Name = "lblNukaQuantums";
            this.lblNukaQuantums.Size = new System.Drawing.Size(84, 13);
            this.lblNukaQuantums.TabIndex = 13;
            this.lblNukaQuantums.Text = "Nuka Quantums";
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstName.DataPropertyName = "DwellerFirstName";
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "DwellerLastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastName.Width = 115;
            // 
            // level
            // 
            this.level.DataPropertyName = "DwellerLevel";
            this.level.HeaderText = "Level";
            this.level.Name = "level";
            this.level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.level.Width = 40;
            // 
            // specialS
            // 
            this.specialS.DataPropertyName = "DwellerStatS";
            this.specialS.HeaderText = "S";
            this.specialS.Name = "specialS";
            this.specialS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialS.Width = 30;
            // 
            // specialP
            // 
            this.specialP.DataPropertyName = "DwellerStatP";
            this.specialP.HeaderText = "P";
            this.specialP.Name = "specialP";
            this.specialP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialP.Width = 30;
            // 
            // specialE
            // 
            this.specialE.DataPropertyName = "DwellerStatE";
            this.specialE.HeaderText = "E";
            this.specialE.Name = "specialE";
            this.specialE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialE.Width = 30;
            // 
            // specialC
            // 
            this.specialC.DataPropertyName = "DwellerStatC";
            this.specialC.HeaderText = "C";
            this.specialC.Name = "specialC";
            this.specialC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialC.Width = 30;
            // 
            // specialI
            // 
            this.specialI.DataPropertyName = "DwellerStatI";
            this.specialI.HeaderText = "I";
            this.specialI.Name = "specialI";
            this.specialI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialI.Width = 30;
            // 
            // specialA
            // 
            this.specialA.DataPropertyName = "DwellerStatA";
            this.specialA.HeaderText = "A";
            this.specialA.Name = "specialA";
            this.specialA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialA.Width = 30;
            // 
            // specialL
            // 
            this.specialL.DataPropertyName = "DwellerStatL";
            this.specialL.HeaderText = "L";
            this.specialL.Name = "specialL";
            this.specialL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialL.Width = 30;
            // 
            // dwellerID
            // 
            this.dwellerID.DataPropertyName = "DwellerID";
            this.dwellerID.HeaderText = "ID";
            this.dwellerID.Name = "dwellerID";
            this.dwellerID.ReadOnly = true;
            this.dwellerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dwellerID.Visible = false;
            // 
            // colMaxBtn
            // 
            this.colMaxBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaxBtn.DataPropertyName = "ButtonMax";
            this.colMaxBtn.HeaderText = "Max Stats";
            this.colMaxBtn.Name = "colMaxBtn";
            this.colMaxBtn.Text = "Max";
            this.colMaxBtn.ToolTipText = "Set all SPECIAL to maximum";
            this.colMaxBtn.Width = 60;
            // 
            // colEditEquipment
            // 
            this.colEditEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colEditEquipment.DataPropertyName = "ButtonEditEquipment";
            this.colEditEquipment.HeaderText = "Equipment";
            this.colEditEquipment.Name = "colEditEquipment";
            this.colEditEquipment.Text = "Edit";
            this.colEditEquipment.Width = 63;
            // 
            // FOSSEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 480);
            this.Controls.Add(this.grpCraftedItems);
            this.Controls.Add(this.grpVaultResources);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.btnSaveEncrypted);
            this.Controls.Add(this.btnLoadSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDwellers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FOSSEditor";
            this.Text = "Fallout Shelter Save Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridDwellers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudPetCarriers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadaway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStimpak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHandyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLunchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaps)).EndInit();
            this.grpDwellers.ResumeLayout(false);
            this.grpVaultResources.ResumeLayout(false);
            this.grpVaultResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudEnergy)).EndInit();
            this.grpCraftedItems.ResumeLayout(false);
            this.grpCraftedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudStarterPacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNukaQuantums)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog dlgLoadSave;
		private System.Windows.Forms.DataGridView dgridDwellers;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblRadaway;
		private System.Windows.Forms.Label lblStimpak;
		private System.Windows.Forms.Label lblHandyBox;
		private System.Windows.Forms.Label lblLunchBox;
		private System.Windows.Forms.Label lblCaps;
		private System.Windows.Forms.NumericUpDown numRadaway;
		private System.Windows.Forms.NumericUpDown numStimpak;
		private System.Windows.Forms.NumericUpDown numHandyBox;
		private System.Windows.Forms.NumericUpDown numLunchBox;
		private System.Windows.Forms.NumericUpDown numCaps;
		private System.Windows.Forms.GroupBox grpDwellers;
		private System.Windows.Forms.Button btnLoadSave;
		private System.Windows.Forms.Button btnSaveEncrypted;
		private System.Windows.Forms.Button btnSaveJson;
		private System.Windows.Forms.SaveFileDialog dlgSave;
		private System.Windows.Forms.SaveFileDialog dlgSaveJson;
        private System.Windows.Forms.GroupBox grpVaultResources;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.NumericUpDown numudPetCarriers;
        private System.Windows.Forms.Label lblPetCarriers;
        private System.Windows.Forms.Label lblMaxWater;
        private System.Windows.Forms.Label lblMaxFood;
        private System.Windows.Forms.Label lblMaxElectricity;
        private System.Windows.Forms.Label lblMax3;
        private System.Windows.Forms.Label lblMax2;
        private System.Windows.Forms.Label lblMax1;
        private System.Windows.Forms.NumericUpDown numudWater;
        private System.Windows.Forms.NumericUpDown numudFood;
        private System.Windows.Forms.NumericUpDown numudEnergy;
        private System.Windows.Forms.GroupBox grpCraftedItems;
        private System.Windows.Forms.NumericUpDown numudNukaQuantums;
        private System.Windows.Forms.Label lblNukaQuantums;
        private System.Windows.Forms.NumericUpDown numudStarterPacks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialS;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialP;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialE;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialC;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialI;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialA;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dwellerID;
        private System.Windows.Forms.DataGridViewButtonColumn colMaxBtn;
        private System.Windows.Forms.DataGridViewButtonColumn colEditEquipment;
    }
}

