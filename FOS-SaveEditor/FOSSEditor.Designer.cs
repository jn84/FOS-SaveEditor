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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(36, 321);
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
            this.specialL});
			this.dataGridView1.Location = new System.Drawing.Point(297, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 150);
			this.dataGridView1.TabIndex = 1;
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
			// FOSSEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 414);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FOSSEditor";
			this.Text = "Fallout Shelter Save Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
	}
}

