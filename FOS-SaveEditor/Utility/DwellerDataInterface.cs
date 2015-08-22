using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOS_SaveEditor.Utility
{
	class DwellerDataInterface
	{
		public JToken RawDwellerData { get; }

		private DwellerDataInterface() { }

		public DwellerDataInterface(JToken dData)
		{
			RawDwellerData = dData;
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

		// It seems that SPECIAL stats require a matching experience value
		// or else the game will crash when loading the save.
		// 
		// 600*(n^3-n) where n = stat level


		public int GetS()
		{
			return RawDwellerData["stats"]["stats"][1]["value"].Value<int>();
		}

		public void SetS(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][1]["value"] = value;
			RawDwellerData["stats"]["stats"][1]["exp"] = (double)(600 * (value ^ 3 - value));
		}

		public int GetP()
		{
			return RawDwellerData["stats"]["stats"][2]["value"].Value<int>();
		}

		public void SetP(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][2]["value"] = value;
			RawDwellerData["stats"]["stats"][2]["exp"] = (double)(600 * (value ^ 3 - value));
		}

		public int GetE()
		{
			return RawDwellerData["stats"]["stats"][3]["value"].Value<int>();
		}

		public void SetE(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][3]["value"] = value;
			RawDwellerData["stats"]["stats"][3]["exp"] = (double)(600 * (value ^ 3 - value));
		}

		public int GetC()
		{
			return RawDwellerData["stats"]["stats"][4]["value"].Value<int>();
		}

		public void SetC(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][4]["value"] = value;
			RawDwellerData["stats"]["stats"][4]["exp"] = (double)(600 * (value ^ 3 - value));
		}

		public int GetI()
		{
			return RawDwellerData["stats"]["stats"][5]["value"].Value<int>();
		}

		public void SetI(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][5]["value"] = value;
			RawDwellerData["stats"]["stats"][5]["exp"] = (double)(600 * (value ^ 3 - value));
		}

		public int GetA()
		{
			return RawDwellerData["stats"]["stats"][6]["value"].Value<int>();
		}

		public void SetA(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][6]["value"] = value;
			RawDwellerData["stats"]["stats"][6]["exp"] = (double)(600 * (value ^ 3 - value));
		}

		public int GetL()
		{
			return RawDwellerData["stats"]["stats"][7]["value"].Value<int>();
		}

		public void SetL(int value)
		{
			if (value <= 0) return;
			RawDwellerData["stats"]["stats"][7]["value"] = value;
			RawDwellerData["stats"]["stats"][7]["exp"] = (double)(600 * (value ^ 3 - value));
		}

	}
}
