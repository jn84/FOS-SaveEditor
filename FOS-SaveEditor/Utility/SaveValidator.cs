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
		private static List<string[]> checkList = new List<string[]>();

		static SaveValidator()
		{
			checkList.Add(new[] { "timeMgr" });
			checkList.Add(new[] { "localNotificationMgr" });
			checkList.Add(new[] { "taskMgr" });
			checkList.Add(new[] { "ratingMgr" });
			checkList.Add(new[] { "dwellers" });
			checkList.Add(new[] { "constructMgr" });
			checkList.Add(new[] { "vault" });
			checkList.Add(new[] { "dwellerSpawner" });
			checkList.Add(new[] { "deviceName" });
			checkList.Add(new[] { "tutorialManager" });
			checkList.Add(new[] { "objectiveMgr" });
			checkList.Add(new[] { "unlockableMgr" });
			checkList.Add(new[] { "survivalW" });
			checkList.Add(new[] { "happinessManager" });
			checkList.Add(new[] { "refugeeSpawner" });
			checkList.Add(new[] { "LunchBoxCollectWindow" });
			checkList.Add(new[] { "DeathclawManager" });
			checkList.Add(new[] { "PromoCodesWindow" });
			checkList.Add(new[] { "swrveEventsManager" });
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
			foreach (var value in checkList)
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
