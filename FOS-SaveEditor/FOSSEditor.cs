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
			// Pick the file
			// Determine whether or not it is encrypted
			// Decrypt if neccessary
			// Determine if the file is a valid fallout shelter save
			// Load the save into a new VaultData object
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
