using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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

		public int GetNumberOfLunchBoxes()
		{
			Console.WriteLine(VaultData["vault"]["LunchBoxesByType"]);
			return VaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 0);
		}

		public int GetNumberOfHandyBoxes()
		{
			return VaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 1);
		}

		public double GetNumberOfCaps()
		{
			return VaultData["vault"]["storage"]["resources"]["Nuka"].Value<double>();
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

		public void SetLunchHandyBoxes(int lunch, int handy)
		{
			var newArr = new List<int>();
			for (var i = 0; i < lunch; i++)
				newArr.Add(0);
			for (var i = 0; i < handy; i++)
				newArr.Add(1);
			VaultData["vault"]["LunchBoxesByType"] = new JArray(newArr);
			VaultData["vault"]["LunchBoxesCount"] = newArr.Count;
		}

		public List<JToken> GetDwellers()
		{
			return VaultData["dwellers"]["dwellers"].ToList();
		}

		public void WriteDwellers(List<JToken> dwellerList)
		{
			VaultData["dwellers"]["dwellers"] = new JArray(dwellerList);
		}
	}
}
