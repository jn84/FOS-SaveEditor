using System;
using Newtonsoft.Json.Linq;

namespace FOS_SaveEditor.Utility
{
	public class DwellerDataInterface
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

		public int GetLevel()
		{
			return RawDwellerData["experience"]["currentLevel"].Value<int>();
		}

		public void SetLevel(int newLevel)
		{
			// We need the formula for how level relates to experience
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
			SetSpecial(value, 1);
		}

		public int GetP()
		{
			return RawDwellerData["stats"]["stats"][2]["value"].Value<int>();
		}

		public void SetP(int value)
		{
			if (value <= 0) return;
			SetSpecial(value, 2);
		}

		public int GetE()
		{
			return RawDwellerData["stats"]["stats"][3]["value"].Value<int>();
		}

		public void SetE(int value)
		{
			if (value <= 0) return;
			SetSpecial(value, 3);
		}

		public int GetC()
		{
			return RawDwellerData["stats"]["stats"][4]["value"].Value<int>();
		}

		public void SetC(int value)
		{
			if (value <= 0) return;
			SetSpecial(value, 4);
		}

		public int GetI()
		{
			return RawDwellerData["stats"]["stats"][5]["value"].Value<int>();
		}

		public void SetI(int value)
		{
			if (value <= 0) return;
			SetSpecial(value, 5);
		}

		public int GetA()
		{
			return RawDwellerData["stats"]["stats"][6]["value"].Value<int>();
		}

		public void SetA(int value)
		{
			if (value <= 0) return;
			SetSpecial(value, 6);
		}

		public int GetL()
		{
			return RawDwellerData["stats"]["stats"][7]["value"].Value<int>();
		}

		public void SetL(int value)
		{
			if (value <= 0) return;
			SetSpecial(value, 7);
		}

		private void SetSpecial(int value, int specialId)
		{
			RawDwellerData["stats"]["stats"][specialId]["value"] = value;
			RawDwellerData["stats"]["stats"][specialId]["exp"] = (double)(600 * ((int)Math.Pow(value, 3) - value));
		}
	}
}
