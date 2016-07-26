using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FOS_SaveEditor.Utility;
using FOS_SaveEditor.GameData;
using XComponent.SliderBar;

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
            
            UpdateAllLabels();

            UpdateOutfitGender();  
            //lstOutfit.Invalidate();
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

            // Outfit
            _dwellerData.OutfitId = lstOutfit.SelectedValue as string;
            _dwellerData.WeaponId = lstWeapons.SelectedValue as string;

        }

        private void formDwellerEdit_Load(object sender, EventArgs e)
        {
            LoadDwellerData();
            lstOutfit.SelectedValue = _dwellerData.OutfitId;
            lstWeapons.SelectedValue = _dwellerData.WeaponId;
        }

        public void UpdateLabels(Label l, Label lb, MACTrackBar tb)
        {
            l.Text = tb.Value.ToString();
            if (tb.BonusValue > 0)
                lb.Text += @"+" + tb.BonusValue;
            else
                lb.Text = "";
        }

        private void trackbarS_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblSValue, lblBonusValueS, trackbarS);
        }

        private void trackbarP_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblPValue, lblBonusValueP, trackbarP);
        }

        private void trackbarE_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblEValue, lblBonusValueE, trackbarE);
        }

        private void trackbarC_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblCValue, lblBonusValueC, trackbarC);
        }

        private void trackbarI_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblIValue, lblBonusValueI, trackbarI);
        }

        private void trackbarA_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblAValue, lblBonusValueA, trackbarA);
        }

        private void trackbarL_ValueChanged(object sender, decimal value)
        {
            UpdateLabels(lblLValue, lblBonusValueL, trackbarL);
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

        private Color GetRarityColor(string rarity)
        {
            if (rarity == "Normal")
                return Color.DarkGray;
            if (rarity == "Rare")
                return Color.DodgerBlue;
            if (rarity == "Legendary")
                return Color.Gold;
            return Color.Black;
        }

        private void lstOutfit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var outfit = lstOutfit.SelectedItem as Outfit;
            _outfitImage?.Dispose();
            _outfitImage = new Bitmap("Resources//OutfitImages//" + outfit.OutfitType + ".png");
            pictboxOutfit.BackColor = GetRarityColor(outfit.OutfitRarity);
            pictboxOutfit.Image = _outfitImage;

            txtOutfitS.Text = (trackbarS.BonusValue = outfit.OutfitSpecialS).ToString();
            txtOutfitP.Text = (trackbarP.BonusValue = outfit.OutfitSpecialP).ToString();
            txtOutfitE.Text = (trackbarE.BonusValue = outfit.OutfitSpecialE).ToString();
            txtOutfitC.Text = (trackbarC.BonusValue = outfit.OutfitSpecialC).ToString();
            txtOutfitI.Text = (trackbarI.BonusValue = outfit.OutfitSpecialI).ToString();
            txtOutfitA.Text = (trackbarA.BonusValue = outfit.OutfitSpecialA).ToString();
            txtOutfitL.Text = (trackbarL.BonusValue = outfit.OutfitSpecialL).ToString();

            UpdateAllLabels();
        }

        // ReSharper disable once InconsistentNaming
        private void UpdateAllLabels()
        {
            // Crappy label workaround
            UpdateLabels(lblSValue, lblBonusValueS, trackbarS);
            UpdateLabels(lblPValue, lblBonusValueP, trackbarP);
            UpdateLabels(lblEValue, lblBonusValueE, trackbarE);
            UpdateLabels(lblCValue, lblBonusValueC, trackbarC);
            UpdateLabels(lblIValue, lblBonusValueI, trackbarI);
            UpdateLabels(lblAValue, lblBonusValueA, trackbarA);
            UpdateLabels(lblLValue, lblBonusValueL, trackbarL);
        }

        private void lstWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            var weapon = lstWeapons.SelectedItem as Weapon;
            _weaponImage?.Dispose();
            _weaponImage = new Bitmap("Resources//WeaponImages//" + weapon.WeaponType + ".png");
            pictboxWeapons.BackColor = GetRarityColor(weapon.WeaponRarity);
            pictboxWeapons.Image = _weaponImage;

            txtWeaponMin.Text = weapon.WeaponMinDamage.ToString();
            txtWeaponMax.Text = weapon.WeaponMaxDamage.ToString();
        }

        private void lstPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pet = lstPets.SelectedItem as Pet;
            _petImage?.Dispose();
            _petImage = new Bitmap("Resources//PetImages//" + pet.PetBreed + ".png");
            pictboxPets.Image = _petImage;
        }

        private void btnUndoOutfitChanges_Click(object sender, EventArgs e)
        {
            lstOutfit.SelectedValue = _dwellerData.OutfitId;
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOutfitGender();
        }

        private void UpdateOutfitGender()
        {
            if (comboGender.SelectedIndex == 0)
            {
                var source = lstOutfit.DataSource as BindingSource;
                if (source != null)
                    source.DataSource = GameDataIDs.maleOutfitBindingList;
            }
            if (comboGender.SelectedIndex == 1)
            {
                var bindingSource = lstOutfit.DataSource as BindingSource;
                if (bindingSource != null)
                    bindingSource.DataSource = GameDataIDs.femaleOutfitBindingList;
            }
        }

        private void btnWeaponUndoChanges_Click(object sender, EventArgs e)
        {
            lstWeapons.SelectedValue = _dwellerData.WeaponId;
        }
    }
}
