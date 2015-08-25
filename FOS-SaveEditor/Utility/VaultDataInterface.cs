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
		private JObject vaultData;

		private VaultDataInterface() { }

		public VaultDataInterface(string vaultJsonText)
		{
			//MessageBox.Show(vaultJsonText);
			vaultData = JObject.Parse(vaultJsonText);
		}

		public int GetNumberOfDwellers()
		{
			return vaultData["dwellers"]["dwellers"].Count();
		}

		public int GetNumberOfLunchBoxes()
		{
			Console.WriteLine(vaultData["vault"]["LunchBoxesByType"]);
			return vaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 0);
		}

		public double GetNumberOfCaps()
		{
			return vaultData["vault"]["storage"]["resources"]["Nuka"].Value<double>();
		}

		public int GetNumberOfHandyBoxes()
		{
			return vaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 1);
		}

		public void SetLunchHandyBoxes(int lunch, int handy)
		{
			var newArr = new List<int>();
			for (var i = 0; i < lunch; i++)
				newArr.Add(0);
			for (var i = 0; i < handy; i++)
				newArr.Add(1);
			vaultData["vault"]["LunchBoxesByType"] = new JArray(newArr);
			vaultData["vault"]["LunchBoxesCount"] = newArr.Count;
		}

		public List<JToken> GetDwellers()
		{
			return vaultData["dwellers"]["dwellers"].ToList();
		}

		public void WriteDwellers(List<JToken> dwellerList)
		{
			vaultData["dwellers"]["dwellers"] = new JArray(dwellerList);
		}
	}
}
