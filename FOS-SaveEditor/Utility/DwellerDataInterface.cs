﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json.Linq;

namespace FOS_SaveEditor.Utility
{
	public class DwellerDataInterface
	{
		public JToken RawDwellerData { get; }

        public DwellerDataInterface(JToken dData)
        {
            RawDwellerData = dData;
        }

        // TODO: Implement code to manage dweller equipment

        // Properties for DataSource mapping

        // ReSharper disable once InconsistentNaming
        public int DwellerID
	    {
	        get { return RawDwellerData["serializeId"].Value<int>(); }
	        // ReSharper disable once ValueParameterNotUsed
            set {  }
	    }

	    public string DwellerFirstName 
	    {
            get { return RawDwellerData["name"].Value<string>(); }
            set { RawDwellerData["name"] = value; }
	    }

        public string DwellerLastName
        {
            get { return RawDwellerData["lastName"].Value<string>(); }
            set { RawDwellerData["lastName"] = value; }
        }

	    public char DwellerGender
	    {
	        get { return RawDwellerData["gender"].Value<int>().Equals(1) ? 'F' : 'M'; }
	        set
	        {
                if (value.Equals('M'))
                    RawDwellerData["gender"] = 2;
                else if (value.Equals('F'))
                    RawDwellerData["gender"] = 1;
            }
	    }

	    public int DwellerLevel
	    {
	        get { return RawDwellerData["experience"]["currentLevel"].Value<int>(); }
	        // ReSharper disable once ValueParameterNotUsed
            set { }
	    }

	    public int DwellerStatS
	    {
	        get { return RawDwellerData["stats"]["stats"][1]["value"].Value<int>(); }
            set { SetSpecial(value, 1); }
	    }

        public int DwellerStatP
        {
            get { return RawDwellerData["stats"]["stats"][2]["value"].Value<int>(); }
            set { SetSpecial(value, 2); }
        }

        public int DwellerStatE
        {
            get { return RawDwellerData["stats"]["stats"][3]["value"].Value<int>(); }
            set { SetSpecial(value, 3); }
        }

        public int DwellerStatC
        {
            get { return RawDwellerData["stats"]["stats"][4]["value"].Value<int>(); }
            set { SetSpecial(value, 4); }
        }

        public int DwellerStatI
        {
            get { return RawDwellerData["stats"]["stats"][5]["value"].Value<int>(); }
            set { SetSpecial(value, 5); }
        }

        public int DwellerStatA
        {
            get { return RawDwellerData["stats"]["stats"][6]["value"].Value<int>(); }
            set { SetSpecial(value, 6); }
        }

        public int DwellerStatL
        {
            get { return RawDwellerData["stats"]["stats"][7]["value"].Value<int>(); }
            set { SetSpecial(value, 7); }
        }

		public int GetId()
		{
			return RawDwellerData["serializeId"].Value<int>();
		}

		public string GetFirstName()
		{
			return RawDwellerData["name"].Value<string>();
		}

		public void SetFirstName(string newFirstName)
		{
			RawDwellerData["name"] = newFirstName;
		}

		public string GetLastName()
		{
			return RawDwellerData["lastName"].Value<string>();
		}

		public void SetLastName(string newLastName)
		{
			RawDwellerData["lastName"] = newLastName;
		}

		public char GetGender()
		{
			return RawDwellerData["gender"].Value<int>().Equals(1) ? 'F' : 'M';
		}

		public void SetGender(char value)
		{
			if (value.Equals('M'))
				RawDwellerData["gender"] = 2;
			else if (value.Equals('F'))
				RawDwellerData["gender"] = 1;
		}

		public int GetLevel()
		{
			return RawDwellerData["experience"]["currentLevel"].Value<int>();
		}

		public void SetLevel(int newLevel)
		{
			// We need the formula for how level relates to experience
		}

        // SPECIAL stats require a matching experience value
        // or else the game will crash when loading the save.
        // 
        // 600 * ( n ^ 3 - n ) where n = stat level

        private void SetSpecial(int value, int specialId)
		{
		    if (value < 1) return;
			RawDwellerData["stats"]["stats"][specialId]["value"] = value;
			RawDwellerData["stats"]["stats"][specialId]["exp"] = (double)(600 * ((int)Math.Pow(value, 3) - value));
        }

        //"equipedOutfit": {
        //  "id": "jumpsuit",
        //  "type": "Outfit",
        //  "hasBeenAssigned": false,
        //  "hasRandonWeaponBeenAssigned": false
        //},

	    public string OutfitId
	    {
	        get { return RawDwellerData["equipedOutfit"]["id"].Value<string>(); }
            set { RawDwellerData["equipedOutfit"]["id"] = value; }
	    }

	    public bool OutfitAssigned
	    {
	        get { return RawDwellerData["equipedOutfit"]["hasBeenAssigned"].Value<bool>(); }
            set { RawDwellerData["equipedOutfit"]["hasBeenAssigned"] = value; }
	    }

        //"equipedWeapon": {
        //  "id": "GaussRifle_Accelerated",
        //  "type": "Weapon",
        //  "hasBeenAssigned": false,
        //  "hasRandonWeaponBeenAssigned": false
        //},

        public string WeaponId
        {
            get { return RawDwellerData["equipedWeapon"]["id"].Value<string>(); }
            set { RawDwellerData["equipedWeapon"]["id"] = value; }
        }

        public bool WeaponAssigned
        {
            get { return RawDwellerData["equipedWeapon"]["hasBeenAssigned"].Value<bool>(); }
            set { RawDwellerData["equipedWeapon"]["hasBeenAssigned"] = value; }
        }

        //"equippedPet": {
        //  "id": "goldenret_c",
        //  "type": "Pet",
        //  "hasBeenAssigned": false,
        //  "hasRandonWeaponBeenAssigned": false,
        //  "extraData": {
        //    "uniqueName": "Golden Retriever",
        //    "bonus": "WastelandItemBoost",
        //    "bonusValue": 6.0
        //  }
        //},

	    public void AddPet(string id, string name, string bonusType, double bonusValue)
	    {
	        RawDwellerData["equipedPet"]["id"] = id;
	        RawDwellerData["equipedPet"]["type"] = "Pet";
	        RawDwellerData["equipedPet"]["hasBeenAssigned"] = false;
	        RawDwellerData["equipedPet"]["hasRandomWeaponBeenAssigned"] = false;
	        RawDwellerData["equipedPet"]["extraData"]["uniqueName"] = name;
	        RawDwellerData["equipedPet"]["extraData"]["bonus"] = bonusType;
	        RawDwellerData["equipedPet"]["extraData"]["bonusValue"] = bonusValue;
	    }

	    public void RemovePet()
	    {
	        RawDwellerData["equipedPet"].Remove();
	    }

        public string PetId
        {
            get
            {
                try
                {
                    return RawDwellerData["equipedPet"]["id"].Value<string>();
                }
                catch (Exception)
                {
                    return "null";
                }
            }
            set { RawDwellerData["equipedPet"]["id"] = value; }
        }

        public bool PetAssigned
        {
            get
            {
                try
                {
                    return RawDwellerData["equipedPet"]["hasBeenAssigned"].Value<bool>();
                }
                catch (Exception)
                {
                    return false;
                }
            }
            set { RawDwellerData["equipedPet"]["hasBeenAssigned"] = value; }
        }

	    public string PetName
	    {
	        get
	        {
	            try
	            {
                    return RawDwellerData["equipedPet"]["extraData"]["uniqueName"].Value<string>();
                }
	            catch (Exception)
	            {
	                return "null";
	            }
	        }
            set { RawDwellerData["equipedPet"]["extraData"]["uniqueName"] = value; }
        }

        public string PetBonusType
        {
            get
            {
                try
                {
                    return RawDwellerData["equipedPet"]["extraData"]["bonus"].Value<string>();
                }
                catch (Exception)
                {
                    return "null";
                }
            }
            set { RawDwellerData["equipedPet"]["extraData"]["bonus"] = value; }
        }

        public int PetBonusValue
        {
            get
            {
                try
                {
                    return (int)RawDwellerData["equipedPet"]["extraData"]["bonusValue"].Value<double>();
                }
                catch (Exception)
                {
                    return 0;
                    throw;
                }
            }
            set { RawDwellerData["equipedPet"]["extraData"]["bonusValue"] = (double)value; }
        }

    }
}
