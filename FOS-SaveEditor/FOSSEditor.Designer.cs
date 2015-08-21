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
			this.txtFilepathName = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.dlgLoadSave = new System.Windows.Forms.OpenFileDialog();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtFilepathName
			// 
			this.txtFilepathName.Location = new System.Drawing.Point(13, 13);
			this.txtFilepathName.Name = "txtFilepathName";
			this.txtFilepathName.ReadOnly = true;
			this.txtFilepathName.Size = new System.Drawing.Size(494, 20);
			this.txtFilepathName.TabIndex = 0;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(13, 40);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load Save";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// dlgLoadSave
			// 
			this.dlgLoadSave.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgLoadSave_FileOk);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(13, 107);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
			this.btnDecrypt.TabIndex = 2;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(121, 107);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 3;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// FOSSEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 419);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtFilepathName);
			this.Name = "FOSSEditor";
			this.Text = "Fallout Shelter Save Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFilepathName;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.OpenFileDialog dlgLoadSave;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Button btnEncrypt;
	}
}

