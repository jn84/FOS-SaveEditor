using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
// ReSharper disable InconsistentNaming

namespace FOS_SaveEditor.GameData
{
    public sealed class OutfitMap : CsvClassMap<Outfit>
    {
        public OutfitMap()
        {
            Map(m => m.OutfitID).Name("ID");
            Map(m => m.OutfitName).Name("Name");
            Map(m => m.OutfitType).Name("Type");
            Map(m => m.OutfitRarity).Name("Rarity");
            Map(m => m.OutfitSpecialS).Name("S");
            Map(m => m.OutfitSpecialP).Name("P");
            Map(m => m.OutfitSpecialE).Name("E");
            Map(m => m.OutfitSpecialC).Name("C");
            Map(m => m.OutfitSpecialI).Name("I");
            Map(m => m.OutfitSpecialA).Name("A");
            Map(m => m.OutfitSpecialL).Name("L");
            Map(m => m.OutfitCraftable).Name("Craftable");
            Map(m => m.OutfitRecipeAvailable).Name("Recipe available");
            Map(m => m.OutfitGender).Name("Gender");
        }
    }

    public class Outfit : IComparable<Outfit>
    {
        public Outfit() {}

        private bool outfitCraftable;
        private bool outfitRecipeAvailable;
        private int outfitGender;

        public string OutfitID { get; set; }
        public string OutfitName { get; set; }
        public string OutfitType { get; set; }
        public string OutfitRarity { get; set; }
        public int OutfitSpecialS { get; set; }
        public int OutfitSpecialP { get; set; }
        public int OutfitSpecialE { get; set; }
        public int OutfitSpecialC { get; set; }
        public int OutfitSpecialI { get; set; }
        public int OutfitSpecialA { get; set; }
        public int OutfitSpecialL { get; set; }

        public string OutfitCraftable
        {
            get { return outfitCraftable ? "Yes" : "No"; }
            set { outfitCraftable = (value == "Yes"); }
        }

        public string OutfitRecipeAvailable
        {
            get { return outfitRecipeAvailable ? "Yes" : "No"; }
            set { outfitRecipeAvailable = (value == "Yes"); }
        }

        public string OutfitGender
        {
            get
            {
                switch (outfitGender)
                {
                    case 1:
                        return "Male";
                    case 2:
                        return "Female";
                    default:
                        return "Both";
                }
            }
            set
            {
                switch (value)
                {
                    case "Male":
                        outfitGender = 1;
                        return;
                    case "Female":
                        outfitGender = 2;
                        return;
                    default:
                        outfitGender = 0;
                        return;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(
                OutfitID + " " + 
                OutfitName + " " + 
                OutfitRarity + " " +
                OutfitSpecialS + " " + 
                OutfitSpecialP + " " + 
                OutfitSpecialE + " " + 
                OutfitSpecialC + " " + 
                OutfitSpecialI + " " + 
                OutfitSpecialA + " " + 
                OutfitSpecialL + " " +
                OutfitCraftable + " " +
                OutfitRecipeAvailable);
        }

        public int CompareTo(Outfit other)
        {
            return string.CompareOrdinal(this.OutfitID, other.OutfitID);
        }
    }
}
