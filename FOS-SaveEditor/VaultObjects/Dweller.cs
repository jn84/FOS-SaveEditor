using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS_SaveEditor.VaultObjects
{
	class Dweller
	{
		public int ID { get; set; }

		public string firstName { get; set; }

		public string lastName { get; set; }

		public Happiness happiness { get; set; } = new Happiness();

		public Health health { get; set; } = new Health();

		public Dweller() { }

		public struct Happiness
		{
			public double happinessValue { get; set; }
		}

		public struct Health
		{
			public double healthValue { get; set; }

			public double radiationValue { get; set; }

			public bool permaDeath { get; set; }

			public int lastLevelUpdated { get; set; }

			public double maxHealth { get; set; }
		}

		public struct Experience
		{
			public double experienceValue { get; set; }

			public int currentLevel { get; set; }

		}
	}
}
