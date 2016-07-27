using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace FOS_SaveEditor.Utility
{
	class VaultDataInterface
	{
		private VaultDataInterface() { }

		public VaultDataInterface(string vaultJsonText)
		{
			VaultData = JObject.Parse(vaultJsonText);
		}

		public JObject VaultData { get; }

		public int GetNumberOfDwellers()
		{
			return VaultData["dwellers"]["dwellers"].Count();
		}

		public int GetNumberOfCaps()
		{
			return VaultData["vault"]["storage"]["resources"]["Nuka"].Value<int>();
		}

		public void SetNumberOfCaps(int caps)
		{
			VaultData["vault"]["storage"]["resources"]["Nuka"] = (double) caps;
		}

		public int GetNumberOfStimpaks()
		{
			return VaultData["vault"]["storage"]["resources"]["StimPack"].Value<int>();
		}

		public void SetNumberOfStimPaks(int stims)
		{
			VaultData["vault"]["storage"]["resources"]["StimPack"] = (double) stims;
		}

		public int GetNumberOfRadaways()
		{
			return VaultData["vault"]["storage"]["resources"]["RadAway"].Value<int>();
		}

		public void SetNumberOfRadaways(int rads)
		{
			VaultData["vault"]["storage"]["resources"]["RadAway"] = (double) rads;
		}

        public int GetFood()
        {
            return VaultData["vault"]["storage"]["resources"]["Food"].Value<int>();
        }

        public void SetFood(int food)
        {
            VaultData["vault"]["storage"]["resources"]["Food"] = (double)food;
        }
        public int GetEnergy()
        {
            return VaultData["vault"]["storage"]["resources"]["Energy"].Value<int>();
        }

        public void SetEnergy(int energy)
        {
            VaultData["vault"]["storage"]["resources"]["Energy"] = (double)energy;
        }
        public int GetWater()
        {
            return VaultData["vault"]["storage"]["resources"]["Water"].Value<int>();
        }

        public void SetWater(int water)
        {
            VaultData["vault"]["storage"]["resources"]["Water"] = (double)water;
        }

        public int GetNumberOfNukaQuantums()
        {
            return VaultData["vault"]["storage"]["resources"]["NukaColaQuantum"].Value<int>();
        }

        public void SetNumberOfNukaQuantums(int quantums)
        {
            VaultData["vault"]["storage"]["resources"]["NukaColaQuantum"] = (double)quantums;
        }

        // Lunchbox Types

        public int GetNumberOfPetCarriers()
        {
            return VaultData["vault"]["storage"]["resources"]["PetCarrier"].Value<int>();
        }

        public int GetNumberOfLunchBoxes()
        {
            return VaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 0);
        }

        public int GetNumberOfHandyBoxes()
        {
            return VaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 1);
        }

        public int GetNumberOfStarterBoxes()
        {
            return VaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 3);
        }

        public void SetLunchHandyBoxes(int lunch, int handy, int pet, int starter)
		{
            // Box Types:
            //          : Normal  - 0
            //          : Handy   - 1 
            //          : Pet     - 2
            //          : Starter - 3

            VaultData["vault"]["storage"]["resources"]["Lunchbox"] = (double) lunch;
            VaultData["vault"]["storage"]["resources"]["MrHandy"] = (double) handy;
            VaultData["vault"]["storage"]["resources"]["PetCarrier"] = (double) pet;

            var newArr = new List<int>();

            for (var i = 0; i < lunch; i++)
				newArr.Add(0);

            for (var i = 0; i < handy; i++)
				newArr.Add(1);

            for (var i = 0; i < pet; i++)
                newArr.Add(2);

            for (var i = 0; i < starter; i++)
                newArr.Add(3);

            VaultData["vault"]["LunchBoxesByType"] = new JArray(newArr);
			VaultData["vault"]["LunchBoxesCount"] = newArr.Count;
		}

        // Find all references!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
		public List<JObject> GetDwellers()
		{
		    var arr = VaultData["dwellers"]["dwellers"].ToArray();

		    List<JObject> dList = arr.Select(dweller => new JObject(dweller)).ToList();

		    return dList;
		}

		public void WriteDwellers(List<JToken> dwellerList)
		{
			VaultData["dwellers"]["dwellers"] = new JArray(dwellerList);
		}
	}
}
