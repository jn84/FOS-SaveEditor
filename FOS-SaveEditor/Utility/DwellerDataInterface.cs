using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FOS_SaveEditor.GameData;
using Newtonsoft.Json.Linq;

namespace FOS_SaveEditor.Utility
{
	public class DwellerDataInterface
	{
		public JObject RawDwellerData { get; }

        public DwellerDataInterface(JObject dData)
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

			// Might eventually be implemented
			// We need a formula for the relationship between dweller experience and dweller level
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

		public void AddPet(Pet p)
		{
			RawDwellerData.Add("equippedPet", JObject.Parse("{ \"id\": \"goldenret_c\", \"type\": \"Pet\", \"hasBeenAssigned\": false, \"hasRandonWeaponBeenAssigned\": false, \"extraData\": { \"uniqueName\": \"\", \"bonus\": \"\", \"bonusValue\": 0.0 } }"));
			RawDwellerData["equippedPet"]["id"] = p.PetID;
			RawDwellerData["equippedPet"]["type"] = "Pet";
			RawDwellerData["equippedPet"]["hasBeenAssigned"] = false;
			RawDwellerData["equippedPet"]["hasRandonWeaponBeenAssigned"] = false;
			RawDwellerData["equippedPet"]["extraData"]["uniqueName"] = p.PetName;
			RawDwellerData["equippedPet"]["extraData"]["bonus"] = p.PetBonus;
			RawDwellerData["equippedPet"]["extraData"]["bonusValue"] = p.PetMaxValue;
		}

		public void RemovePet()
	    {
		    try
		    {
			    RawDwellerData.Remove("equippedPet");
		    }
		    catch (NullReferenceException)
		    {
			    // Dweller already lacked a pet node. Removing will throw NRE since it doesn't exist
		    }
	    }

        public string PetId
        {
            get
            {
                try
                {
                    return RawDwellerData["equippedPet"]["id"].Value<string>();
                }
                catch (Exception e)
                {
                    return "null";
                }
            }
            set { RawDwellerData["equippedPet"]["id"] = value; }
        }

        public bool PetAssigned
        {
            get
            {
                try
                {
                    return RawDwellerData["equippedPet"]["hasBeenAssigned"].Value<bool>();
                }
                catch (Exception)
                {
                    return false;
                }
            }
            set { RawDwellerData["equippedPet"]["hasBeenAssigned"] = value; }
        }

	    public string PetName
	    {
	        get
	        {
	            try
	            {
                    return RawDwellerData["equippedPet"]["extraData"]["uniqueName"].Value<string>();
                }
	            catch (Exception)
	            {
	                return "null";
	            }
	        }
            set { RawDwellerData["equippedPet"]["extraData"]["uniqueName"] = value; }
        }

        public string PetBonusType
        {
            get
            {
                try
                {
                    return RawDwellerData["equippedPet"]["extraData"]["bonus"].Value<string>();
                }
                catch (Exception)
                {
                    return "null";
                }
            }
            set { RawDwellerData["equippedPet"]["extraData"]["bonus"] = value; }
        }

        public int PetBonusValue
        {
            get
            {
                try
                {
                    return (int)RawDwellerData["equippedPet"]["extraData"]["bonusValue"].Value<double>();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set { RawDwellerData["equippedPet"]["extraData"]["bonusValue"] = (double)value; }
        }

    }
}
