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
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.grpDwellers = new System.Windows.Forms.GroupBox();
			this.btnLoadSave = new System.Windows.Forms.Button();
			this.btnSaveEncrypted = new System.Windows.Forms.Button();
			this.btnSaveJson = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			this.grpDwellers.SuspendLayout();
			this.SuspendLayout();
			// 
			// dlgLoadSave
			// 
			this.dlgLoadSave.Filter = "Fallout Shelter Save Files|*.sav|Json Files|*.json";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(876, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.dataGridView1.Location = new System.Drawing.Point(6, 18);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 222);
			this.dataGridView1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.numericUpDown5);
			this.groupBox1.Controls.Add(this.numericUpDown4);
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 160);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vault Assets";
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
			this.dwellerID.Visible = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(115, 19);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 0;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(115, 46);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 1;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(115, 73);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown3.TabIndex = 2;
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(115, 100);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown4.TabIndex = 3;
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(115, 127);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown5.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Caps";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Lunch Boxes";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Mr. Handy Boxes";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Stimpaks";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Radaways";
			// 
			// grpDwellers
			// 
			this.grpDwellers.Controls.Add(this.dataGridView1);
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
			this.btnSaveJson.Location = new System.Drawing.Point(12, 236);
			this.btnSaveJson.Name = "btnSaveJson";
			this.btnSaveJson.Size = new System.Drawing.Size(241, 23);
			this.btnSaveJson.TabIndex = 6;
			this.btnSaveJson.Text = "Save As Json...";
			this.btnSaveJson.UseVisualStyleBackColor = true;
			this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
			// 
			// FOSSEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 270);
			this.Controls.Add(this.btnSaveJson);
			this.Controls.Add(this.btnSaveEncrypted);
			this.Controls.Add(this.btnLoadSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.grpDwellers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FOSSEditor";
			this.Text = "Fallout Shelter Save Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			this.grpDwellers.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog dlgLoadSave;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.GroupBox grpDwellers;
		private System.Windows.Forms.Button btnLoadSave;
		private System.Windows.Forms.Button btnSaveEncrypted;
		private System.Windows.Forms.Button btnSaveJson;
	}
}

