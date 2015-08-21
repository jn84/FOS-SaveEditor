using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOS_SaveEditor.Utility;

namespace FOS_SaveEditor
{
	public partial class FOSSEditor : Form
	{
		public FOSSEditor()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dlgLoadSave.Multiselect = false;
			dlgLoadSave.CheckFileExists = true;
			dlgLoadSave.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			dlgLoadSave.ShowDialog();
		}

		private void dlgLoadSave_FileOk(object sender, CancelEventArgs e)
		{
			txtFilepathName.Text = dlgLoadSave.FileName;
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			var text = File.ReadAllText(txtFilepathName.Text);
			CryptoHandler.IsEncrypted(text);
			var output = Utility.CryptoHandler.DecryptSave(text);
			File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "decrypted.sav"), output);
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			var text = File.ReadAllText(txtFilepathName.Text);
			CryptoHandler.IsEncrypted(text);
			var output = Utility.CryptoHandler.EncryptSave(text);
			File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "encrypted.sav"), output);
		}
	}
}
