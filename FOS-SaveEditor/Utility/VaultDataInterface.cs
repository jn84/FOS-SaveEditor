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
		private readonly JObject _vaultData;

		private VaultDataInterface() { }

		public VaultDataInterface(string vaultJsonText)
		{
			_vaultData = JObject.Parse(vaultJsonText);
		}

		public int GetNumberOfDwellers()
		{
			return _vaultData["dwellers"]["dwellers"].Count();
		}

		public int GetNumberOfLunchBoxes()
		{
			Console.WriteLine(_vaultData["vault"]["LunchBoxesByType"]);
			return _vaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 0);
		}

		public int GetNumberOfHandyBoxes()
		{
			return _vaultData["vault"]["LunchBoxesByType"].Values<int>().Count(val => val == 1);
		}

		public double GetNumberOfCaps()
		{
			return _vaultData["vault"]["storage"]["resources"]["Nuka"].Value<double>();
		}

		public void SetNumberOfCaps(int caps)
		{
			_vaultData["vault"]["storage"]["resources"]["Nuka"] = (double) caps;
		}

		public int GetNumberOfStimpaks()
		{
			return _vaultData["vault"]["storage"]["resources"]["StimPack"].Value<int>();
		}

		public void SetNumberOfStimPaks(int stims)
		{
			
		}

		public int GetNumberOfRadaways()
		{
			return _vaultData["vault"]["storage"]["resources"]["RadAway"].Value<int>();
		}

		public void SetNumberOfRadaways(int rads)
		{

		}

		public void SetLunchHandyBoxes(int lunch, int handy)
		{
			var newArr = new List<int>();
			for (var i = 0; i < lunch; i++)
				newArr.Add(0);
			for (var i = 0; i < handy; i++)
				newArr.Add(1);
			_vaultData["vault"]["LunchBoxesByType"] = new JArray(newArr);
			_vaultData["vault"]["LunchBoxesCount"] = newArr.Count;
		}

		public List<JToken> GetDwellers()
		{
			return _vaultData["dwellers"]["dwellers"].ToList();
		}

		public void WriteDwellers(List<JToken> dwellerList)
		{
			_vaultData["dwellers"]["dwellers"] = new JArray(dwellerList);
		}
	}
}
