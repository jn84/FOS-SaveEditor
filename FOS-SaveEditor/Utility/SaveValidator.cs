using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FOS_SaveEditor.Utility
{
	static class SaveValidator
	{
		private static readonly List<string[]> CheckList = new List<string[]>();

		static SaveValidator()
		{
			CheckList.Add(new[] { "timeMgr" });
			CheckList.Add(new[] { "localNotificationMgr" });
			CheckList.Add(new[] { "taskMgr" });
			CheckList.Add(new[] { "ratingMgr" });
			CheckList.Add(new[] { "dwellers" });
			CheckList.Add(new[] { "constructMgr" });
			CheckList.Add(new[] { "vault" });
			CheckList.Add(new[] { "dwellerSpawner" });
			CheckList.Add(new[] { "deviceName" });
			CheckList.Add(new[] { "tutorialManager" });
			CheckList.Add(new[] { "objectiveMgr" });
			CheckList.Add(new[] { "unlockableMgr" });
			CheckList.Add(new[] { "survivalW" });
			CheckList.Add(new[] { "happinessManager" });
			CheckList.Add(new[] { "refugeeSpawner" });
			CheckList.Add(new[] { "LunchBoxCollectWindow" });
			CheckList.Add(new[] { "DeathclawManager" });
			CheckList.Add(new[] { "PromoCodesWindow" });
			CheckList.Add(new[] { "swrveEventsManager" });
		}

		public static bool IsValidSave(string inputSave)
		{
			JToken saveToken;
			try
			{
				saveToken = JToken.Parse(inputSave);
			}
			catch (Exception)
			{
				return false;
			}
			foreach (var value in CheckList)
			{
				var checkedValue = saveToken[value[0]];
				if (checkedValue == null)
					return false;
				for (var i = 1; i < value.Length; i++)
				{
					checkedValue = checkedValue[value[i]];
					if (checkedValue == null)
						return false;
				}
			}
			return true;
		}
	}
}
