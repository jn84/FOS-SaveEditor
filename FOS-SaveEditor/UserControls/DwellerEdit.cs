using System;
using System.Windows.Forms;
using FOS_SaveEditor.Utility;

namespace FOS_SaveEditor.UserControls
{
    public partial class DwellerEdit : Form
    {
        private DwellerDataInterface dwellerData;

        public DwellerEdit()
        {
            InitializeComponent();
        }

        public DwellerEdit(DwellerDataInterface d)
        {
            InitializeComponent();
            dwellerData = d;
            LoadDwellerData();
        }

        private void LoadDwellerData()
        {
            if (dwellerData == null)
                return;

            txtFirstName.Text = dwellerData.DwellerFirstName;
            txtLastName.Text = dwellerData.DwellerLastName;
            txtLevel.Text = dwellerData.DwellerLevel.ToString();
            comboGender.SelectedIndex = dwellerData.DwellerGender == 'M' ? 0 : 1;
            trackbarS.Value = dwellerData.DwellerStatS;
            trackbarP.Value = dwellerData.DwellerStatP;
            trackbarE.Value = dwellerData.DwellerStatE;
            trackbarC.Value = dwellerData.DwellerStatC;
            trackbarI.Value = dwellerData.DwellerStatI;
            trackbarA.Value = dwellerData.DwellerStatA;
            trackbarL.Value = dwellerData.DwellerStatL;
        }

        private void CommitDwellerData()
        {
            if (dwellerData == null)
                return;

            dwellerData.DwellerFirstName = txtFirstName.Text;
            dwellerData.DwellerLastName = txtLastName.Text;
            // Does nothing since DwellerLevel setter has no code.
            dwellerData.DwellerLevel = Convert.ToInt32(txtLevel.Text);
            dwellerData.DwellerGender = comboGender.SelectedIndex == 0 ? 'M' : 'F';
            dwellerData.DwellerStatS = trackbarS.Value;
            dwellerData.DwellerStatP = trackbarP.Value;
            dwellerData.DwellerStatE = trackbarE.Value;
            dwellerData.DwellerStatC = trackbarC.Value;
            dwellerData.DwellerStatI = trackbarI.Value;
            dwellerData.DwellerStatA = trackbarA.Value;
            dwellerData.DwellerStatL = trackbarL.Value;
        }

        private void formDwellerEdit_Load(object sender, EventArgs e)
        {

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
    }
}
