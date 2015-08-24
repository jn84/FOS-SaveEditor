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
		private VaultDataInterface vaultData;

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

		private void button1_Click(object sender, EventArgs e)
		{
			var jsonStr = File.ReadAllText("J:\\Projects\\FOS-SaveEditor\\FOS-SaveEditor\\bin\\Debug\\Vault1.sav");
			jsonStr = CryptoHandler.DecryptSave(jsonStr);
			var vData = new VaultDataInterface(jsonStr);

			//Console.WriteLine(vData.GetNumberOfDwellers());
			//vData.GetDwellers();
		}

		private void btnLoadSave_Click(object sender, EventArgs e)
		{
			string inputFile;
			string workingData;

			// Pick the file
			dlgLoadSave.ShowDialog();

			// Determine whether or not it is encrypted (done automatically by decryption method)
			// Decrypt if neccessary
			inputFile = File.ReadAllText(dlgLoadSave.FileName);
			workingData = CryptoHandler.GetDecryptedSave(inputFile);

			// Determine if the file is a valid fallout shelter save
			try
			{
				if (!SaveValidator.IsValidSave(workingData))
				{
					MessageBox.Show(@"Unknown error when loading " + dlgLoadSave.SafeFileName + @". The file is most likely corrupt or invalid.");
					return;
				}
			}
			catch (Exception)
			{
				MessageBox.Show(@"Unknown error when loading " + dlgLoadSave.SafeFileName + @". The file is most likely corrupt or invalid.");
				return;
			}


			// Load the save into a new VaultData object
			// Parse VaultData object into form controls
			// Enable form controls
			// Enable save buttons
		}

		private void btnSaveEncrypted_Click(object sender, EventArgs e)
		{

		}

		private void btnSaveJson_Click(object sender, EventArgs e)
		{

		}
	}
}
