using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FOS_SaveEditor.VaultObjects;
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
			return vaultData["storage"]["storage"]["resources"]["Nuka"].Value<double>();
		}

		public void AddLunchBox()
		{
			var lbArr = vaultData["vault"]["LunchBoxesByType"].Values<int>().ToList();
			lbArr.Insert(0, 0);
			vaultData["vault"]["LunchBoxesByType"] = new JArray(lbArr);
			vaultData["vault"]["LunchBoxesCount"] = lbArr.Count;
		}

		public void RemoveLunchBox()
		{
			var lbArr = vaultData["vault"]["LunchBoxesByType"].Values<int>().ToList();
			lbArr.Remove(0);
			vaultData["vault"]["LunchBoxesByType"] = new JArray(lbArr);
			vaultData["vault"]["LunchBoxesCount"] = lbArr.Count;
		}

		public int GetNumberOfHandyBoxes()
		{
			return vaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 1);
		}

		public void AddHandyBox()
		{
			var lbArr = vaultData["vault"]["LunchBoxesByType"].Values<int>().ToList();
			lbArr.Add(1);
			vaultData["vault"]["LunchBoxesByType"] = new JArray(lbArr);
			vaultData["vault"]["LunchBoxesCount"] = lbArr.Count;
		}

		public void RemoveHandyBox()
		{
			var lbArr = vaultData["vault"]["LunchBoxesByType"].Values<int>().ToList();
			lbArr.Remove(1);
			vaultData["vault"]["LunchBoxesByType"] = new JArray(lbArr);
			vaultData["vault"]["LunchBoxesCount"] = lbArr.Count;
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
