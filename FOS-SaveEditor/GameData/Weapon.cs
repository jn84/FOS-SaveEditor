using System;
using CsvHelper.Configuration;

namespace FOS_SaveEditor.GameData
{
    public sealed class WeaponMap : CsvClassMap<Weapon>
    {
        public WeaponMap()
        {
            Map(m => m.WeaponID).Name("ID");
            Map(m => m.WeaponName).Name("Name");
            Map(m => m.WeaponType).Name("Type");
            Map(m => m.WeaponMinDamage).Name("MinDamage");
            Map(m => m.WeaponMaxDamage).Name("MaxDamage");
            Map(m => m.WeaponTier).Name("Tier");
            Map(m => m.WeaponRarity).Name("Rarity");
            Map(m => m.WeaponCraftable).Name("Craftable");
            Map(m => m.WeaponRecipe).Name("Recipe available");
        }
    }

    public class Weapon : IComparable<Weapon>
    {
        private bool weaponCraftable = false;
        private bool weaponRecipe = false;

        public Weapon()
        {

        }

        public string WeaponID { get; set; }
        public string WeaponName { get; set; }
        public string WeaponType { get; set; }
        public int WeaponMinDamage { get; set; }
        public int WeaponMaxDamage { get; set; }
        public int WeaponTier { get; set; }
        public string WeaponRarity { get; set; }

        public string WeaponCraftable
        {
            get { return weaponRecipe ? "Yes" : "No"; }
            set { weaponRecipe = (value == "Yes"); }
        }

        public string WeaponRecipe
        {
            get { return weaponCraftable ? "Yes" : "No"; }
            set { weaponCraftable = (value == "Yes"); }
        }

        public void Print()
        {
            Console.WriteLine(
                WeaponID + " " +
                WeaponName + " " +
                WeaponType + " " +
                WeaponMinDamage + " " +
                WeaponMaxDamage + " " +
                WeaponTier + " " +
                WeaponRarity + " " +
                WeaponCraftable + " " +
                WeaponRecipe);
        }

        public int CompareTo(Weapon other)
        {
            return string.CompareOrdinal(this.WeaponID, other.WeaponID);
        }
    }
}

