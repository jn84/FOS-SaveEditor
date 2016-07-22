using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FOS_SaveEditor.UserControls;
using FOS_SaveEditor.Utility;
using Newtonsoft.Json;
using FOS_SaveEditor.GameData;

namespace FOS_SaveEditor
{
    public partial class FOSSEditor : Form
    {
        private string _qualifiedFilename;
        private List<DwellerDataInterface> dwellerList;
        private BindingList<DwellerDataInterface> bindingDwellerList;
        private BindingSource dwellerListBindingSource; 
        private VaultDataInterface vaultData;

        public FOSSEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameDataIDs.DummyMethod();
            dlgLoadSave.Multiselect = false;
            dlgLoadSave.CheckFileExists = true;

            var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Fallout Shelter";

            if (Directory.Exists(dir))
            {
                dlgLoadSave.InitialDirectory = dir;

                dlgSave.InitialDirectory = dir;

                dlgSaveJson.InitialDirectory = dir;
            }
        }

        private void btnLoadSave_Click(object sender, EventArgs e)
        {
            // Pick the file
            dlgLoadSave.ShowDialog();
            if (dlgLoadSave.SafeFileName == null || dlgLoadSave.SafeFileName.Equals(""))
                return;
            _qualifiedFilename = dlgLoadSave.FileName;


            // Determine whether or not it is encrypted (done automatically by decryption method)
            // Decrypt if neccessary
            var inputFile = File.ReadAllText(dlgLoadSave.FileName);
            var workingData = CryptoHandler.GetDecryptedSave(inputFile);

            // Determine if the file is a valid fallout shelter save
            try
            {
                if (!SaveValidator.IsValidSave(workingData))
                {
                    MessageBox.Show(@"Unknown error when loading " + dlgLoadSave.SafeFileName +
                                    @". The file is most likely corrupt or invalid.");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Unknown error when loading " + dlgLoadSave.SafeFileName +
                                @". The file is most likely corrupt or invalid.");
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
            numudEnergy.Enabled = true;
            numudFood.Enabled = true;
            numudWater.Enabled = true;
            numudPetCarriers.Enabled = true;
            numudNukaQuantums.Enabled = true;
            numudStarterPacks.Enabled = true;
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
            vaultData.SetLunchHandyBoxes(
                (int) numLunchBox.Value,
                (int) numHandyBox.Value,
                (int) numudPetCarriers.Value,
                (int) numudStarterPacks.Value);
            vaultData.SetNumberOfCaps((int) numCaps.Value);
            vaultData.SetNumberOfStimPaks((int) numStimpak.Value);
            vaultData.SetNumberOfRadaways((int) numRadaway.Value);
            vaultData.SetNumberOfNukaQuantums((int) numudNukaQuantums.Value);

            vaultData.SetEnergy((int) numudEnergy.Value);
            vaultData.SetFood((int) numudFood.Value);
            vaultData.SetWater((int) numudWater.Value);
        }

        private void PopulateVaultData()
        {
            dgridDwellers.Rows.Clear();

            numCaps.Value = vaultData.GetNumberOfCaps();
            numLunchBox.Value = vaultData.GetNumberOfLunchBoxes();
            numHandyBox.Value = vaultData.GetNumberOfHandyBoxes();
            numRadaway.Value = vaultData.GetNumberOfRadaways();
            numStimpak.Value = vaultData.GetNumberOfStimpaks();
            numudEnergy.Value = vaultData.GetEnergy();
            numudFood.Value = vaultData.GetFood();
            numudWater.Value = vaultData.GetWater();
            numudPetCarriers.Value = vaultData.GetNumberOfPetCarriers();
            numudNukaQuantums.Value = vaultData.GetNumberOfNukaQuantums();

            dwellerList =
                vaultData.GetDwellers().
                Select(dweller => new DwellerDataInterface(dweller)).ToList();

            bindingDwellerList = new BindingList<DwellerDataInterface>(dwellerList);
            dwellerListBindingSource = new BindingSource(bindingDwellerList, null);

            dgridDwellers.AutoGenerateColumns = false;
            dgridDwellers.DataSource = dwellerListBindingSource;
        }

        /// <summary>
        ///     Activates when the max button is clicked in a dweller row
        /// </summary>
        private void dgridDwellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var col = e.ColumnIndex;

            // Shouldn't happen
            if (row < 0 || row + 1 > dgridDwellers.Rows.Count)
            {
                Console.WriteLine("An error occurred in FOSSEditor.cs: CellContentClick\n"
                                  + "The row index is out of range.");
                return;
            }

            // Max SPECIAL Button
            var dataGridViewColumn = dgridDwellers.Columns["colMaxBtn"];
            if (dataGridViewColumn != null && dataGridViewColumn.Index.Equals(col))
            {
                dgridDwellers.Rows[row].Cells["specialS"].Value = 10;
                dgridDwellers.Rows[row].Cells["specialP"].Value = 10;
                dgridDwellers.Rows[row].Cells["specialE"].Value = 10;
                dgridDwellers.Rows[row].Cells["specialC"].Value = 10;
                dgridDwellers.Rows[row].Cells["specialI"].Value = 10;
                dgridDwellers.Rows[row].Cells["specialA"].Value = 10;
                dgridDwellers.Rows[row].Cells["specialL"].Value = 10;
                return;
            }

            // Edit Equipment Button
            var gridViewColumn = dgridDwellers.Columns["colEditEquipment"];
            if (gridViewColumn != null && gridViewColumn.Index.Equals(col))
            {
                var selectedDwellerId = dgridDwellers.Rows[row].Cells["dwellerID"].Value;
                var dwellerData = dwellerList.Find(elem => elem.DwellerID.Equals(selectedDwellerId));
                var dwellerEditForm = new DwellerEdit(dwellerData);
                dwellerEditForm.ShowDialog();
                dgridDwellers.Invalidate();
            }
        }


        private void dgridDwellers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int GetDwellerIndexByID(int id)
        {

            return 0;
        }

        private void dgridDwellers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (var i = 0; i < e.RowCount; i++)
            {
                dgridDwellers.Rows[i + e.RowIndex].Cells["colMaxBtn"].Value = "MAX";
                dgridDwellers.Rows[i + e.RowIndex].Cells["colEditEquipment"].Value = "Edit";
            }
        }

        // Clean up
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}