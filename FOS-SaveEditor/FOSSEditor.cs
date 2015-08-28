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
		private string _qualifiedFilename;

		private VaultDataInterface vaultData;

		private List<DwellerDataInterface> dwellerList; 

		public FOSSEditor()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dlgLoadSave.Multiselect = false;
			dlgLoadSave.CheckFileExists = true;
			dlgLoadSave.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

			dlgSave.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

			dlgSaveJson.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
		}

		private void btnLoadSave_Click(object sender, EventArgs e)
		{
			string inputFile;
			string workingData;

			// Pick the file
			dlgLoadSave.ShowDialog();
			if (dlgLoadSave.SafeFileName == null || dlgLoadSave.SafeFileName.Equals(""))
				return;
			_qualifiedFilename = dlgLoadSave.FileName;


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
			dlgSave.FileName = Path.GetFileNameWithoutExtension(_qualifiedFilename) + "-modified";
			if (dlgSave.ShowDialog() != DialogResult.OK)
				return;
			WriteVaultData();
			File.WriteAllText(dlgSave.FileName, CryptoHandler.EncryptSave(vaultData.VaultData.ToString(Formatting.None)));
		}

		private void btnSaveJson_Click(object sender, EventArgs e)
		{
			dlgSaveJson.FileName = Path.GetFileNameWithoutExtension(_qualifiedFilename) + "-modified";
			if (dlgSaveJson.ShowDialog() != DialogResult.OK)
				return;
			WriteVaultData();
			File.WriteAllText(dlgSaveJson.FileName, vaultData.VaultData.ToString(Formatting.Indented));
		}

		private void WriteVaultData()
		{
			// Save the dwellers
			var newDwellerIds = new List<int>();
			foreach (DataGridViewRow row in dgridDwellers.Rows)
			{
				if (row.Cells["dwellerID"].Value == null)
					continue;
				var id = Convert.ToInt32(row.Cells["dwellerID"].Value);
				var listIndex = dwellerList.FindIndex(dId => dId.GetId().Equals(id));
				dwellerList[listIndex].SetFirstName(row.Cells["firstName"].Value.ToString());
				dwellerList[listIndex].SetLastName(row.Cells["lastName"].Value.ToString());
				dwellerList[listIndex].SetS(Convert.ToInt32(row.Cells["specialS"].Value));
				dwellerList[listIndex].SetP(Convert.ToInt32(row.Cells["specialP"].Value));
				dwellerList[listIndex].SetE(Convert.ToInt32(row.Cells["specialE"].Value));
				dwellerList[listIndex].SetC(Convert.ToInt32(row.Cells["specialC"].Value));
				dwellerList[listIndex].SetI(Convert.ToInt32(row.Cells["specialI"].Value));
				dwellerList[listIndex].SetA(Convert.ToInt32(row.Cells["specialA"].Value));
				dwellerList[listIndex].SetL(Convert.ToInt32(row.Cells["specialL"].Value));
			}
			vaultData.SetLunchHandyBoxes(Convert.ToInt32(numLunchBox.Text), Convert.ToInt32(numHandyBox.Text));
			vaultData.SetNumberOfCaps(Convert.ToInt32(numCaps.Text));
			vaultData.SetNumberOfStimPaks(Convert.ToInt32(numStimpak.Text));
			vaultData.SetNumberOfRadaways(Convert.ToInt32(numRadaway.Text));
		}

		private void PopulateVaultData()
		{
			dgridDwellers.Rows.Clear();

			numCaps.Text = vaultData.GetNumberOfCaps().ToString(CultureInfo.InvariantCulture);
			numLunchBox.Text = vaultData.GetNumberOfLunchBoxes().ToString();
			numHandyBox.Text = vaultData.GetNumberOfHandyBoxes().ToString();
			numRadaway.Text = vaultData.GetNumberOfRadaways().ToString();
			numStimpak.Text = vaultData.GetNumberOfStimpaks().ToString();

			dwellerList = 
				vaultData.GetDwellers().Select(dweller => new DwellerDataInterface(dweller)).ToList();

			List<DataGridViewRow> dwellerRows = new List<DataGridViewRow>();

			for (int i = 0; i < dwellerList.Count; i++)
			{
				dwellerRows.Add((DataGridViewRow)dgridDwellers.Rows[0].Clone());
				dwellerRows[i].Cells[dgridDwellers.Columns["firstName"].Index].Value = dwellerList[i].GetFirstName();
				dwellerRows[i].Cells[dgridDwellers.Columns["lastName"].Index].Value =  dwellerList[i].GetLastName();
				dwellerRows[i].Cells[dgridDwellers.Columns["level"].Index].Value =     dwellerList[i].GetLevel();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialS"].Index].Value =  dwellerList[i].GetS();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialP"].Index].Value =  dwellerList[i].GetP();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialE"].Index].Value =  dwellerList[i].GetE();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialC"].Index].Value =  dwellerList[i].GetC();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialI"].Index].Value =  dwellerList[i].GetI();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialA"].Index].Value =  dwellerList[i].GetA();
				dwellerRows[i].Cells[dgridDwellers.Columns["specialL"].Index].Value =  dwellerList[i].GetL();
				dwellerRows[i].Cells[dgridDwellers.Columns["dwellerID"].Index].Value = dwellerList[i].GetId();
			}

			dgridDwellers.Rows.AddRange(dwellerRows.ToArray());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dgridDwellers.Rows.Add(new DataGridViewRow());
		}
	}
}
