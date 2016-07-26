namespace FOS_SaveEditor.UserControls
{
    partial class DwellerEdit
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
            this.components = new System.ComponentModel.Container();
            this.trackbarS = new XComponent.SliderBar.MACTrackBar();
            this.grpDwellerInfo = new System.Windows.Forms.GroupBox();
            this.btnMaxSPECIAL = new System.Windows.Forms.Button();
            this.lblL = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblLValue = new System.Windows.Forms.Label();
            this.lblAValue = new System.Windows.Forms.Label();
            this.lblIValue = new System.Windows.Forms.Label();
            this.lblCValue = new System.Windows.Forms.Label();
            this.lblEValue = new System.Windows.Forms.Label();
            this.lblPValue = new System.Windows.Forms.Label();
            this.lblSValue = new System.Windows.Forms.Label();
            this.trackbarL = new XComponent.SliderBar.MACTrackBar();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.trackbarA = new XComponent.SliderBar.MACTrackBar();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.trackbarI = new XComponent.SliderBar.MACTrackBar();
            this.trackbarC = new XComponent.SliderBar.MACTrackBar();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.trackbarE = new XComponent.SliderBar.MACTrackBar();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.trackbarP = new XComponent.SliderBar.MACTrackBar();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnCancelClose = new System.Windows.Forms.Button();
            this.tabControlEquipment = new System.Windows.Forms.TabControl();
            this.tabPageOutfit = new System.Windows.Forms.TabPage();
            this.pictboxOutfit = new System.Windows.Forms.PictureBox();
            this.lstOutfit = new System.Windows.Forms.ListBox();
            this.outfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageWeapon = new System.Windows.Forms.TabPage();
            this.pictboxWeapons = new System.Windows.Forms.PictureBox();
            this.lstWeapons = new System.Windows.Forms.ListBox();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePet = new System.Windows.Forms.TabPage();
            this.pictboxPets = new System.Windows.Forms.PictureBox();
            this.lstPets = new System.Windows.Forms.ListBox();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpDwellerInfo.SuspendLayout();
            this.tabControlEquipment.SuspendLayout();
            this.tabPageOutfit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxOutfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outfitBindingSource)).BeginInit();
            this.tabPageWeapon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            this.tabPagePet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trackbarS
            // 
            this.trackbarS.BackColor = System.Drawing.Color.Transparent;
            this.trackbarS.BonusValue = 0;
            this.trackbarS.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarS.IndentHeight = 6;
            this.trackbarS.Location = new System.Drawing.Point(7, 155);
            this.trackbarS.Maximum = 10;
            this.trackbarS.Minimum = 1;
            this.trackbarS.Name = "trackbarS";
            this.trackbarS.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarS.Size = new System.Drawing.Size(24, 137);
            this.trackbarS.TabIndex = 0;
            this.trackbarS.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarS.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarS.TickHeight = 4;
            this.trackbarS.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarS.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarS.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarS.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarS.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarS.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarS.TrackLineHeight = 12;
            this.trackbarS.Value = 5;
            this.trackbarS.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarS_ValueChanged);
            // 
            // grpDwellerInfo
            // 
            this.grpDwellerInfo.Controls.Add(this.btnMaxSPECIAL);
            this.grpDwellerInfo.Controls.Add(this.lblL);
            this.grpDwellerInfo.Controls.Add(this.lblA);
            this.grpDwellerInfo.Controls.Add(this.lblI);
            this.grpDwellerInfo.Controls.Add(this.lblC);
            this.grpDwellerInfo.Controls.Add(this.lblE);
            this.grpDwellerInfo.Controls.Add(this.lblP);
            this.grpDwellerInfo.Controls.Add(this.lblS);
            this.grpDwellerInfo.Controls.Add(this.lblLValue);
            this.grpDwellerInfo.Controls.Add(this.lblAValue);
            this.grpDwellerInfo.Controls.Add(this.lblIValue);
            this.grpDwellerInfo.Controls.Add(this.lblCValue);
            this.grpDwellerInfo.Controls.Add(this.lblEValue);
            this.grpDwellerInfo.Controls.Add(this.lblPValue);
            this.grpDwellerInfo.Controls.Add(this.lblSValue);
            this.grpDwellerInfo.Controls.Add(this.trackbarL);
            this.grpDwellerInfo.Controls.Add(this.comboGender);
            this.grpDwellerInfo.Controls.Add(this.trackbarA);
            this.grpDwellerInfo.Controls.Add(this.txtLevel);
            this.grpDwellerInfo.Controls.Add(this.trackbarI);
            this.grpDwellerInfo.Controls.Add(this.trackbarC);
            this.grpDwellerInfo.Controls.Add(this.txtLastName);
            this.grpDwellerInfo.Controls.Add(this.trackbarE);
            this.grpDwellerInfo.Controls.Add(this.txtFirstName);
            this.grpDwellerInfo.Controls.Add(this.trackbarP);
            this.grpDwellerInfo.Controls.Add(this.lblLevel);
            this.grpDwellerInfo.Controls.Add(this.lblGender);
            this.grpDwellerInfo.Controls.Add(this.trackbarS);
            this.grpDwellerInfo.Controls.Add(this.lblLastName);
            this.grpDwellerInfo.Controls.Add(this.lblFirstName);
            this.grpDwellerInfo.Location = new System.Drawing.Point(13, 13);
            this.grpDwellerInfo.Name = "grpDwellerInfo";
            this.grpDwellerInfo.Size = new System.Drawing.Size(185, 314);
            this.grpDwellerInfo.TabIndex = 1;
            this.grpDwellerInfo.TabStop = false;
            this.grpDwellerInfo.Text = "Dweller Information";
            // 
            // btnMaxSPECIAL
            // 
            this.btnMaxSPECIAL.Location = new System.Drawing.Point(7, 117);
            this.btnMaxSPECIAL.Name = "btnMaxSPECIAL";
            this.btnMaxSPECIAL.Size = new System.Drawing.Size(168, 23);
            this.btnMaxSPECIAL.TabIndex = 24;
            this.btnMaxSPECIAL.Text = "Max SPECIAL";
            this.btnMaxSPECIAL.UseVisualStyleBackColor = true;
            this.btnMaxSPECIAL.Click += new System.EventHandler(this.btnMaxSPECIAL_Click);
            // 
            // lblL
            // 
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.Location = new System.Drawing.Point(153, 143);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(24, 19);
            this.lblL.TabIndex = 23;
            this.lblL.Text = "L";
            this.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(129, 143);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 19);
            this.lblA.TabIndex = 22;
            this.lblA.Text = "A";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblI
            // 
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(105, 143);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(24, 19);
            this.lblI.TabIndex = 21;
            this.lblI.Text = "I";
            this.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(81, 143);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 19);
            this.lblC.TabIndex = 20;
            this.lblC.Text = "C";
            this.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblE
            // 
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(57, 143);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(24, 19);
            this.lblE.TabIndex = 19;
            this.lblE.Text = "E";
            this.lblE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP
            // 
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(34, 143);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(24, 19);
            this.lblP.TabIndex = 18;
            this.lblP.Text = "P";
            this.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblS
            // 
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(10, 143);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(24, 19);
            this.lblS.TabIndex = 17;
            this.lblS.Text = "S";
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLValue
            // 
            this.lblLValue.Location = new System.Drawing.Point(152, 290);
            this.lblLValue.Name = "lblLValue";
            this.lblLValue.Size = new System.Drawing.Size(23, 16);
            this.lblLValue.TabIndex = 16;
            this.lblLValue.Text = "10";
            this.lblLValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAValue
            // 
            this.lblAValue.Location = new System.Drawing.Point(128, 290);
            this.lblAValue.Name = "lblAValue";
            this.lblAValue.Size = new System.Drawing.Size(23, 16);
            this.lblAValue.TabIndex = 15;
            this.lblAValue.Text = "10";
            this.lblAValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIValue
            // 
            this.lblIValue.Location = new System.Drawing.Point(104, 290);
            this.lblIValue.Name = "lblIValue";
            this.lblIValue.Size = new System.Drawing.Size(23, 16);
            this.lblIValue.TabIndex = 14;
            this.lblIValue.Text = "10";
            this.lblIValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCValue
            // 
            this.lblCValue.Location = new System.Drawing.Point(80, 290);
            this.lblCValue.Name = "lblCValue";
            this.lblCValue.Size = new System.Drawing.Size(23, 16);
            this.lblCValue.TabIndex = 13;
            this.lblCValue.Text = "10";
            this.lblCValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEValue
            // 
            this.lblEValue.Location = new System.Drawing.Point(56, 290);
            this.lblEValue.Name = "lblEValue";
            this.lblEValue.Size = new System.Drawing.Size(23, 16);
            this.lblEValue.TabIndex = 12;
            this.lblEValue.Text = "10";
            this.lblEValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPValue
            // 
            this.lblPValue.Location = new System.Drawing.Point(32, 290);
            this.lblPValue.Name = "lblPValue";
            this.lblPValue.Size = new System.Drawing.Size(23, 16);
            this.lblPValue.TabIndex = 11;
            this.lblPValue.Text = "10";
            this.lblPValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSValue
            // 
            this.lblSValue.Location = new System.Drawing.Point(8, 290);
            this.lblSValue.Name = "lblSValue";
            this.lblSValue.Size = new System.Drawing.Size(23, 16);
            this.lblSValue.TabIndex = 10;
            this.lblSValue.Text = "10";
            this.lblSValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackbarL
            // 
            this.trackbarL.BackColor = System.Drawing.Color.Transparent;
            this.trackbarL.BonusValue = 0;
            this.trackbarL.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarL.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarL.IndentHeight = 6;
            this.trackbarL.Location = new System.Drawing.Point(151, 155);
            this.trackbarL.Maximum = 10;
            this.trackbarL.Minimum = 1;
            this.trackbarL.Name = "trackbarL";
            this.trackbarL.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarL.Size = new System.Drawing.Size(24, 137);
            this.trackbarL.TabIndex = 7;
            this.trackbarL.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarL.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarL.TickHeight = 4;
            this.trackbarL.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarL.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarL.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarL.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarL.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarL.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarL.TrackLineHeight = 12;
            this.trackbarL.Value = 5;
            this.trackbarL.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarL_ValueChanged);
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(70, 86);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(100, 21);
            this.comboGender.TabIndex = 9;
            // 
            // trackbarA
            // 
            this.trackbarA.BackColor = System.Drawing.Color.Transparent;
            this.trackbarA.BonusValue = 0;
            this.trackbarA.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarA.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarA.IndentHeight = 6;
            this.trackbarA.Location = new System.Drawing.Point(127, 155);
            this.trackbarA.Maximum = 10;
            this.trackbarA.Minimum = 1;
            this.trackbarA.Name = "trackbarA";
            this.trackbarA.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarA.Size = new System.Drawing.Size(24, 137);
            this.trackbarA.TabIndex = 6;
            this.trackbarA.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarA.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarA.TickHeight = 4;
            this.trackbarA.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarA.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarA.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarA.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarA.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarA.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarA.TrackLineHeight = 12;
            this.trackbarA.Value = 5;
            this.trackbarA.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarA_ValueChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(70, 65);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 6;
            // 
            // trackbarI
            // 
            this.trackbarI.BackColor = System.Drawing.Color.Transparent;
            this.trackbarI.BonusValue = 0;
            this.trackbarI.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarI.IndentHeight = 6;
            this.trackbarI.Location = new System.Drawing.Point(103, 155);
            this.trackbarI.Maximum = 10;
            this.trackbarI.Minimum = 1;
            this.trackbarI.Name = "trackbarI";
            this.trackbarI.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarI.Size = new System.Drawing.Size(24, 137);
            this.trackbarI.TabIndex = 5;
            this.trackbarI.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarI.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarI.TickHeight = 4;
            this.trackbarI.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarI.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarI.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarI.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarI.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarI.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarI.TrackLineHeight = 12;
            this.trackbarI.Value = 5;
            this.trackbarI.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarI_ValueChanged);
            // 
            // trackbarC
            // 
            this.trackbarC.BackColor = System.Drawing.Color.Transparent;
            this.trackbarC.BonusValue = 3;
            this.trackbarC.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarC.IndentHeight = 6;
            this.trackbarC.Location = new System.Drawing.Point(79, 155);
            this.trackbarC.Maximum = 10;
            this.trackbarC.Minimum = 1;
            this.trackbarC.Name = "trackbarC";
            this.trackbarC.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarC.Size = new System.Drawing.Size(24, 137);
            this.trackbarC.TabIndex = 4;
            this.trackbarC.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarC.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarC.TickHeight = 4;
            this.trackbarC.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarC.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarC.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarC.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarC.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarC.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarC.TrackLineHeight = 12;
            this.trackbarC.Value = 5;
            this.trackbarC.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarC_ValueChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 44);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // trackbarE
            // 
            this.trackbarE.BackColor = System.Drawing.Color.Transparent;
            this.trackbarE.BonusValue = 0;
            this.trackbarE.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarE.IndentHeight = 6;
            this.trackbarE.Location = new System.Drawing.Point(55, 155);
            this.trackbarE.Maximum = 10;
            this.trackbarE.Minimum = 1;
            this.trackbarE.Name = "trackbarE";
            this.trackbarE.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarE.Size = new System.Drawing.Size(24, 137);
            this.trackbarE.TabIndex = 3;
            this.trackbarE.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarE.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarE.TickHeight = 4;
            this.trackbarE.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarE.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarE.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarE.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarE.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarE.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarE.TrackLineHeight = 12;
            this.trackbarE.Value = 5;
            this.trackbarE.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarE_ValueChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(70, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // trackbarP
            // 
            this.trackbarP.BackColor = System.Drawing.Color.Transparent;
            this.trackbarP.BonusValue = 0;
            this.trackbarP.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackbarP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackbarP.IndentHeight = 6;
            this.trackbarP.Location = new System.Drawing.Point(31, 155);
            this.trackbarP.Maximum = 10;
            this.trackbarP.Minimum = 1;
            this.trackbarP.Name = "trackbarP";
            this.trackbarP.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackbarP.Size = new System.Drawing.Size(24, 137);
            this.trackbarP.TabIndex = 2;
            this.trackbarP.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarP.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.trackbarP.TickHeight = 4;
            this.trackbarP.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbarP.TrackerColor = System.Drawing.Color.LimeGreen;
            this.trackbarP.TrackerSize = new System.Drawing.Size(5, 12);
            this.trackbarP.TrackLineColorBonus = System.Drawing.Color.DarkGoldenrod;
            this.trackbarP.TrackLineColorMax = System.Drawing.Color.Black;
            this.trackbarP.TrackLineColorMin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.trackbarP.TrackLineHeight = 12;
            this.trackbarP.Value = 5;
            this.trackbarP.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackbarP_ValueChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(31, 68);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(22, 89);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(12, 333);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(320, 25);
            this.btnSaveClose.TabIndex = 2;
            this.btnSaveClose.Text = "&Save Changes && Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnCancelClose
            // 
            this.btnCancelClose.Location = new System.Drawing.Point(349, 333);
            this.btnCancelClose.Name = "btnCancelClose";
            this.btnCancelClose.Size = new System.Drawing.Size(320, 25);
            this.btnCancelClose.TabIndex = 3;
            this.btnCancelClose.Text = "&Cancel Changes && Close";
            this.btnCancelClose.UseVisualStyleBackColor = true;
            this.btnCancelClose.Click += new System.EventHandler(this.btnCancelClose_Click);
            // 
            // tabControlEquipment
            // 
            this.tabControlEquipment.Controls.Add(this.tabPageOutfit);
            this.tabControlEquipment.Controls.Add(this.tabPageWeapon);
            this.tabControlEquipment.Controls.Add(this.tabPagePet);
            this.tabControlEquipment.Location = new System.Drawing.Point(205, 13);
            this.tabControlEquipment.Multiline = true;
            this.tabControlEquipment.Name = "tabControlEquipment";
            this.tabControlEquipment.SelectedIndex = 0;
            this.tabControlEquipment.Size = new System.Drawing.Size(464, 314);
            this.tabControlEquipment.TabIndex = 0;
            // 
            // tabPageOutfit
            // 
            this.tabPageOutfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageOutfit.Controls.Add(this.pictboxOutfit);
            this.tabPageOutfit.Controls.Add(this.lstOutfit);
            this.tabPageOutfit.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutfit.Name = "tabPageOutfit";
            this.tabPageOutfit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutfit.Size = new System.Drawing.Size(456, 288);
            this.tabPageOutfit.TabIndex = 0;
            this.tabPageOutfit.Text = "Outfit";
            this.tabPageOutfit.UseVisualStyleBackColor = true;
            // 
            // pictboxOutfit
            // 
            this.pictboxOutfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictboxOutfit.Location = new System.Drawing.Point(6, 107);
            this.pictboxOutfit.Name = "pictboxOutfit";
            this.pictboxOutfit.Size = new System.Drawing.Size(171, 171);
            this.pictboxOutfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxOutfit.TabIndex = 1;
            this.pictboxOutfit.TabStop = false;
            // 
            // lstOutfit
            // 
            this.lstOutfit.DataSource = this.outfitBindingSource;
            this.lstOutfit.DisplayMember = "OutfitName";
            this.lstOutfit.FormattingEnabled = true;
            this.lstOutfit.Location = new System.Drawing.Point(6, 6);
            this.lstOutfit.Name = "lstOutfit";
            this.lstOutfit.Size = new System.Drawing.Size(171, 95);
            this.lstOutfit.TabIndex = 0;
            this.lstOutfit.SelectedIndexChanged += new System.EventHandler(this.lstOutfit_SelectedIndexChanged);
            // 
            // outfitBindingSource
            // 
            this.outfitBindingSource.DataSource = typeof(FOS_SaveEditor.GameData.Outfit);
            // 
            // tabPageWeapon
            // 
            this.tabPageWeapon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageWeapon.Controls.Add(this.pictboxWeapons);
            this.tabPageWeapon.Controls.Add(this.lstWeapons);
            this.tabPageWeapon.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeapon.Name = "tabPageWeapon";
            this.tabPageWeapon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWeapon.Size = new System.Drawing.Size(456, 288);
            this.tabPageWeapon.TabIndex = 1;
            this.tabPageWeapon.Text = "Weapon";
            this.tabPageWeapon.UseVisualStyleBackColor = true;
            // 
            // pictboxWeapons
            // 
            this.pictboxWeapons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictboxWeapons.Location = new System.Drawing.Point(6, 107);
            this.pictboxWeapons.Name = "pictboxWeapons";
            this.pictboxWeapons.Size = new System.Drawing.Size(171, 171);
            this.pictboxWeapons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxWeapons.TabIndex = 1;
            this.pictboxWeapons.TabStop = false;
            // 
            // lstWeapons
            // 
            this.lstWeapons.DataSource = this.weaponBindingSource;
            this.lstWeapons.DisplayMember = "WeaponName";
            this.lstWeapons.FormattingEnabled = true;
            this.lstWeapons.Location = new System.Drawing.Point(6, 6);
            this.lstWeapons.Name = "lstWeapons";
            this.lstWeapons.Size = new System.Drawing.Size(171, 95);
            this.lstWeapons.TabIndex = 0;
            this.lstWeapons.SelectedIndexChanged += new System.EventHandler(this.lstWeapons_SelectedIndexChanged);
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataSource = typeof(FOS_SaveEditor.GameData.Weapon);
            // 
            // tabPagePet
            // 
            this.tabPagePet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePet.Controls.Add(this.pictboxPets);
            this.tabPagePet.Controls.Add(this.lstPets);
            this.tabPagePet.Location = new System.Drawing.Point(4, 22);
            this.tabPagePet.Name = "tabPagePet";
            this.tabPagePet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePet.Size = new System.Drawing.Size(456, 288);
            this.tabPagePet.TabIndex = 2;
            this.tabPagePet.Text = "Pet";
            this.tabPagePet.UseVisualStyleBackColor = true;
            // 
            // pictboxPets
            // 
            this.pictboxPets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictboxPets.Location = new System.Drawing.Point(6, 107);
            this.pictboxPets.Name = "pictboxPets";
            this.pictboxPets.Size = new System.Drawing.Size(171, 171);
            this.pictboxPets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxPets.TabIndex = 1;
            this.pictboxPets.TabStop = false;
            // 
            // lstPets
            // 
            this.lstPets.DataSource = this.petBindingSource;
            this.lstPets.DisplayMember = "PetName";
            this.lstPets.FormattingEnabled = true;
            this.lstPets.Location = new System.Drawing.Point(6, 6);
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(171, 95);
            this.lstPets.TabIndex = 0;
            this.lstPets.SelectedIndexChanged += new System.EventHandler(this.lstPets_SelectedIndexChanged);
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataSource = typeof(FOS_SaveEditor.GameData.Pet);
            // 
            // DwellerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 370);
            this.Controls.Add(this.tabControlEquipment);
            this.Controls.Add(this.btnCancelClose);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.grpDwellerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DwellerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DwellerEdit";
            this.Load += new System.EventHandler(this.formDwellerEdit_Load);
            this.grpDwellerInfo.ResumeLayout(false);
            this.grpDwellerInfo.PerformLayout();
            this.tabControlEquipment.ResumeLayout(false);
            this.tabPageOutfit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictboxOutfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outfitBindingSource)).EndInit();
            this.tabPageWeapon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictboxWeapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            this.tabPagePet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictboxPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XComponent.SliderBar.MACTrackBar trackbarS;
        private System.Windows.Forms.GroupBox grpDwellerInfo;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblLValue;
        private System.Windows.Forms.Label lblAValue;
        private System.Windows.Forms.Label lblIValue;
        private System.Windows.Forms.Label lblCValue;
        private System.Windows.Forms.Label lblEValue;
        private System.Windows.Forms.Label lblPValue;
        private System.Windows.Forms.Label lblSValue;
        private XComponent.SliderBar.MACTrackBar trackbarL;
        private System.Windows.Forms.ComboBox comboGender;
        private XComponent.SliderBar.MACTrackBar trackbarA;
        private System.Windows.Forms.TextBox txtLevel;
        private XComponent.SliderBar.MACTrackBar trackbarI;
        private XComponent.SliderBar.MACTrackBar trackbarC;
        private System.Windows.Forms.TextBox txtLastName;
        private XComponent.SliderBar.MACTrackBar trackbarE;
        private System.Windows.Forms.TextBox txtFirstName;
        private XComponent.SliderBar.MACTrackBar trackbarP;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnMaxSPECIAL;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnCancelClose;
        private System.Windows.Forms.TabControl tabControlEquipment;
        private System.Windows.Forms.TabPage tabPageOutfit;
        private System.Windows.Forms.TabPage tabPageWeapon;
        private System.Windows.Forms.TabPage tabPagePet;
        private System.Windows.Forms.ListBox lstOutfit;
        private System.Windows.Forms.PictureBox pictboxOutfit;
        private System.Windows.Forms.BindingSource outfitBindingSource;
        private System.Windows.Forms.BindingSource petBindingSource;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private System.Windows.Forms.PictureBox pictboxWeapons;
        private System.Windows.Forms.ListBox lstWeapons;
        private System.Windows.Forms.PictureBox pictboxPets;
        private System.Windows.Forms.ListBox lstPets;
    }
}