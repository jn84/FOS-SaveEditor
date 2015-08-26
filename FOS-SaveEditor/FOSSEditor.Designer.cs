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
			this.dlgLoadSave = new System.Windows.Forms.OpenFileDialog();
			this.dgridDwellers = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numCaps = new System.Windows.Forms.NumericUpDown();
			this.numLunchBox = new System.Windows.Forms.NumericUpDown();
			this.numHandyBox = new System.Windows.Forms.NumericUpDown();
			this.numStimpak = new System.Windows.Forms.NumericUpDown();
			this.numRadaway = new System.Windows.Forms.NumericUpDown();
			this.lblCaps = new System.Windows.Forms.Label();
			this.lblLunchBox = new System.Windows.Forms.Label();
			this.lblHandyBox = new System.Windows.Forms.Label();
			this.lblStimpak = new System.Windows.Forms.Label();
			this.lblRadaway = new System.Windows.Forms.Label();
			this.grpDwellers = new System.Windows.Forms.GroupBox();
			this.btnLoadSave = new System.Windows.Forms.Button();
			this.btnSaveEncrypted = new System.Windows.Forms.Button();
			this.btnSaveJson = new System.Windows.Forms.Button();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.dlgSaveJson = new System.Windows.Forms.SaveFileDialog();
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
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgridDwellers)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCaps)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numLunchBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numHandyBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStimpak)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRadaway)).BeginInit();
			this.grpDwellers.SuspendLayout();
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
            this.dwellerID});
			this.dgridDwellers.Enabled = false;
			this.dgridDwellers.Location = new System.Drawing.Point(6, 18);
			this.dgridDwellers.Name = "dgridDwellers";
			this.dgridDwellers.Size = new System.Drawing.Size(541, 222);
			this.dgridDwellers.TabIndex = 1;
			// 
			// groupBox1
			// 
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
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 160);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vault Assets";
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
			// numStimpak
			// 
			this.numStimpak.Enabled = false;
			this.numStimpak.Location = new System.Drawing.Point(115, 100);
			this.numStimpak.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numStimpak.Name = "numStimpak";
			this.numStimpak.Size = new System.Drawing.Size(120, 20);
			this.numStimpak.TabIndex = 3;
			// 
			// numRadaway
			// 
			this.numRadaway.Enabled = false;
			this.numRadaway.Location = new System.Drawing.Point(115, 127);
			this.numRadaway.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numRadaway.Name = "numRadaway";
			this.numRadaway.Size = new System.Drawing.Size(120, 20);
			this.numRadaway.TabIndex = 4;
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
			// lblLunchBox
			// 
			this.lblLunchBox.AutoSize = true;
			this.lblLunchBox.Location = new System.Drawing.Point(6, 48);
			this.lblLunchBox.Name = "lblLunchBox";
			this.lblLunchBox.Size = new System.Drawing.Size(69, 13);
			this.lblLunchBox.TabIndex = 6;
			this.lblLunchBox.Text = "Lunch Boxes";
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
			// lblStimpak
			// 
			this.lblStimpak.AutoSize = true;
			this.lblStimpak.Location = new System.Drawing.Point(6, 102);
			this.lblStimpak.Name = "lblStimpak";
			this.lblStimpak.Size = new System.Drawing.Size(50, 13);
			this.lblStimpak.TabIndex = 8;
			this.lblStimpak.Text = "Stimpaks";
			// 
			// lblRadaway
			// 
			this.lblRadaway.AutoSize = true;
			this.lblRadaway.Location = new System.Drawing.Point(6, 129);
			this.lblRadaway.Name = "lblRadaway";
			this.lblRadaway.Size = new System.Drawing.Size(57, 13);
			this.lblRadaway.TabIndex = 9;
			this.lblRadaway.Text = "Radaways";
			// 
			// grpDwellers
			// 
			this.grpDwellers.Controls.Add(this.dgridDwellers);
			this.grpDwellers.Location = new System.Drawing.Point(260, 13);
			this.grpDwellers.Name = "grpDwellers";
			this.grpDwellers.Size = new System.Drawing.Size(553, 246);
			this.grpDwellers.TabIndex = 3;
			this.grpDwellers.TabStop = false;
			this.grpDwellers.Text = "Dwellers";
			// 
			// btnLoadSave
			// 
			this.btnLoadSave.Location = new System.Drawing.Point(12, 178);
			this.btnLoadSave.Name = "btnLoadSave";
			this.btnLoadSave.Size = new System.Drawing.Size(241, 23);
			this.btnLoadSave.TabIndex = 4;
			this.btnLoadSave.Text = "Load Save...";
			this.btnLoadSave.UseVisualStyleBackColor = true;
			this.btnLoadSave.Click += new System.EventHandler(this.btnLoadSave_Click);
			// 
			// btnSaveEncrypted
			// 
			this.btnSaveEncrypted.Enabled = false;
			this.btnSaveEncrypted.Location = new System.Drawing.Point(12, 207);
			this.btnSaveEncrypted.Name = "btnSaveEncrypted";
			this.btnSaveEncrypted.Size = new System.Drawing.Size(241, 23);
			this.btnSaveEncrypted.TabIndex = 5;
			this.btnSaveEncrypted.Text = "Save As...";
			this.btnSaveEncrypted.UseVisualStyleBackColor = true;
			this.btnSaveEncrypted.Click += new System.EventHandler(this.btnSaveEncrypted_Click);
			// 
			// btnSaveJson
			// 
			this.btnSaveJson.Enabled = false;
			this.btnSaveJson.Location = new System.Drawing.Point(12, 236);
			this.btnSaveJson.Name = "btnSaveJson";
			this.btnSaveJson.Size = new System.Drawing.Size(241, 23);
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
			// firstName
			// 
			this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.firstName.HeaderText = "First Name";
			this.firstName.Name = "firstName";
			// 
			// lastName
			// 
			this.lastName.HeaderText = "Last Name";
			this.lastName.Name = "lastName";
			this.lastName.Width = 120;
			// 
			// level
			// 
			this.level.HeaderText = "Level";
			this.level.Name = "level";
			this.level.Width = 50;
			// 
			// specialS
			// 
			this.specialS.HeaderText = "S";
			this.specialS.Name = "specialS";
			this.specialS.Width = 30;
			// 
			// specialP
			// 
			this.specialP.HeaderText = "P";
			this.specialP.Name = "specialP";
			this.specialP.Width = 30;
			// 
			// specialE
			// 
			this.specialE.HeaderText = "E";
			this.specialE.Name = "specialE";
			this.specialE.Width = 30;
			// 
			// specialC
			// 
			this.specialC.HeaderText = "C";
			this.specialC.Name = "specialC";
			this.specialC.Width = 30;
			// 
			// specialI
			// 
			this.specialI.HeaderText = "I";
			this.specialI.Name = "specialI";
			this.specialI.Width = 30;
			// 
			// specialA
			// 
			this.specialA.HeaderText = "A";
			this.specialA.Name = "specialA";
			this.specialA.Width = 30;
			// 
			// specialL
			// 
			this.specialL.HeaderText = "L";
			this.specialL.Name = "specialL";
			this.specialL.Width = 30;
			// 
			// dwellerID
			// 
			this.dwellerID.HeaderText = "ID";
			this.dwellerID.Name = "dwellerID";
			this.dwellerID.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(882, 49);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FOSSEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1041, 270);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSaveJson);
			this.Controls.Add(this.btnSaveEncrypted);
			this.Controls.Add(this.btnLoadSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grpDwellers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FOSSEditor";
			this.Text = "Fallout Shelter Save Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgridDwellers)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCaps)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numLunchBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numHandyBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numStimpak)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRadaway)).EndInit();
			this.grpDwellers.ResumeLayout(false);
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
		private System.Windows.Forms.Button button1;
	}
}

