using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOS_SaveEditor.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

		private void btnLoadSave_Click(object sender, EventArgs e)
		{
			string inputFile;
			string workingData;

			// Pick the file
			dlgLoadSave.ShowDialog();
			if (dlgLoadSave.SafeFileName == null || dlgLoadSave.SafeFileName.Equals(""))
				return;

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
			vaultData = new VaultDataInterface(workingData);

			// Parse VaultData object into form controls
			PopulateVaultData();

			// Enable form controls
			dgridDwellers.Enabled = true;
			numCaps.Enabled = true;
			numLunchBox.Enabled = true;
			numHandyBox.Enabled = true;
			numStimpak.Enabled = true;
			numRadaway.Enabled = true;
			btnSaveEncrypted.Enabled = true;
			btnSaveJson.Enabled = true;
		}

		private void btnSaveEncrypted_Click(object sender, EventArgs e)
		{

		}

		private void btnSaveJson_Click(object sender, EventArgs e)
		{

		}

		private void PopulateVaultData()
		{
			numCaps.Text = vaultData.GetNumberOfCaps().ToString(CultureInfo.InvariantCulture);
			numLunchBox.Text = vaultData.GetNumberOfLunchBoxes().ToString();
			numHandyBox.Text = vaultData.GetNumberOfHandyBoxes().ToString();
			numRadaway.Text = vaultData.GetNumberOfRadaways().ToString();
			numStimpak.Text = vaultData.GetNumberOfStimpaks().ToString();

			var dwellerList = 
				vaultData.GetDwellers().Select(dweller => new DwellerDataInterface(dweller)).ToList();

			foreach (var dweller in dwellerList)
			{
				var row = (DataGridViewRow) dgridDwellers.Rows[0].Clone();
				row.Cells[dgridDwellers.Columns["firstName"].Index].Value =
					dweller.GetFirstName();
				row.Cells[dgridDwellers.Columns["lastName"].Index].Value =
					dweller.GetLastName();
				row.Cells[dgridDwellers.Columns["level"].Index].Value =
					dweller.GetLevel();
				row.Cells[dgridDwellers.Columns["specialS"].Index].Value =
					dweller.GetS();
				row.Cells[dgridDwellers.Columns["specialP"].Index].Value =
					dweller.GetP();
				row.Cells[dgridDwellers.Columns["specialE"].Index].Value =
					dweller.GetE();
				row.Cells[dgridDwellers.Columns["specialC"].Index].Value =
					dweller.GetC();
				row.Cells[dgridDwellers.Columns["specialI"].Index].Value =
					dweller.GetI();
				row.Cells[dgridDwellers.Columns["specialA"].Index].Value =
					dweller.GetA();
				row.Cells[dgridDwellers.Columns["specialL"].Index].Value =
					dweller.GetL();
				row.Cells[dgridDwellers.Columns["dwellerID"].Index].Value =
					dweller.GetId();
				dgridDwellers.Rows.Add(row);
			}
		}
	}
}
