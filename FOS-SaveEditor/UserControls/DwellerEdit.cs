using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FOS_SaveEditor.Utility;
using FOS_SaveEditor.GameData;

namespace FOS_SaveEditor.UserControls
{
    public partial class DwellerEdit : Form
    {
        private readonly DwellerDataInterface _dwellerData;

        private Image _outfitImage;
        private Image _weaponImage;
        private Image _petImage;

        public DwellerEdit()
        {
            InitializeComponent();
        }

        public DwellerEdit(DwellerDataInterface d)
        {
            InitializeComponent();
            _dwellerData = d;
            LoadDwellerData();

            lstOutfit.DataSource = GameDataIDs.outfitListBindingSource;
            lstWeapons.DataSource = GameDataIDs.weaponListBindingSource;
            lstPets.DataSource = GameDataIDs.petListBindingSource;
        }

        private void LoadDwellerData()
        {
            if (_dwellerData == null)
                return;

            txtFirstName.Text = _dwellerData.DwellerFirstName;
            txtLastName.Text = _dwellerData.DwellerLastName;
            txtLevel.Text = _dwellerData.DwellerLevel.ToString();
            comboGender.SelectedIndex = _dwellerData.DwellerGender == 'M' ? 0 : 1;
            trackbarS.Value = _dwellerData.DwellerStatS;
            trackbarP.Value = _dwellerData.DwellerStatP;
            trackbarE.Value = _dwellerData.DwellerStatE;
            trackbarC.Value = _dwellerData.DwellerStatC;
            trackbarI.Value = _dwellerData.DwellerStatI;
            trackbarA.Value = _dwellerData.DwellerStatA;
            trackbarL.Value = _dwellerData.DwellerStatL;
        }

        private void CommitDwellerData()
        {
            if (_dwellerData == null)
                return;

            _dwellerData.DwellerFirstName = txtFirstName.Text;
            _dwellerData.DwellerLastName = txtLastName.Text;
            // Does nothing since DwellerLevel setter has no code.
            _dwellerData.DwellerLevel = Convert.ToInt32(txtLevel.Text);
            _dwellerData.DwellerGender = comboGender.SelectedIndex == 0 ? 'M' : 'F';
            _dwellerData.DwellerStatS = trackbarS.Value;
            _dwellerData.DwellerStatP = trackbarP.Value;
            _dwellerData.DwellerStatE = trackbarE.Value;
            _dwellerData.DwellerStatC = trackbarC.Value;
            _dwellerData.DwellerStatI = trackbarI.Value;
            _dwellerData.DwellerStatA = trackbarA.Value;
            _dwellerData.DwellerStatL = trackbarL.Value;
        }

        private void formDwellerEdit_Load(object sender, EventArgs e)
        {
            //foreach (var outfit in GameData.GameDataIDs.outfitList)
            //{
            //    lstOutfit.Items.Add(outfit.OutfitName);
            //}
        }

        public void SetLabel(Label l, string val)
        {
            l.Text = val;
        }

        private void trackbarS_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblSValue, trackbarS.Value.ToString());
        }

        private void trackbarP_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblPValue, trackbarP.Value.ToString());
        }

        private void trackbarE_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblEValue, trackbarE.Value.ToString());
        }

        private void trackbarC_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblCValue, trackbarC.Value.ToString());
        }

        private void trackbarI_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblIValue, trackbarI.Value.ToString());
        }

        private void trackbarA_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblAValue, trackbarA.Value.ToString());
        }

        private void trackbarL_ValueChanged(object sender, decimal value)
        {
            SetLabel(lblLValue, trackbarL.Value.ToString());
        }

        private void btnMaxSPECIAL_Click(object sender, EventArgs e)
        {
            trackbarS.Value = 10;
            trackbarP.Value = 10;
            trackbarE.Value = 10;
            trackbarC.Value = 10;
            trackbarI.Value = 10;
            trackbarA.Value = 10;
            trackbarL.Value = 10;
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            CommitDwellerData();
            Close();
        }

        private void btnCancelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstOutfit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var outfit = lstOutfit.SelectedItem as Outfit;
            _outfitImage?.Dispose();
            _outfitImage = new Bitmap("Resources//OutfitImages//" + outfit.OutfitType + ".png");
            pictboxOutfit.Image = _outfitImage;
        }

        private void lstWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            var weapon = lstWeapons.SelectedItem as Weapon;
            _weaponImage?.Dispose();
            _weaponImage = new Bitmap("Resources//WeaponImages//" + weapon.WeaponType + ".png");
            pictboxWeapons.Image = _weaponImage;
        }

        private void lstPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pet = lstPets.SelectedItem as Pet;
            _petImage?.Dispose();
            _petImage = new Bitmap("Resources//PetImages//" + pet.PetBreed + ".png");
            pictboxPets.Image = _petImage;
        }
    }
}
