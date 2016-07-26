using System;
using System.Collections.Generic;
using CsvHelper.Configuration;

namespace FOS_SaveEditor.GameData
{
    public sealed class PetMap : CsvClassMap<Pet>
    {
        public PetMap()
        {
            Map(m => m.PetID).Name("ID");
            Map(m => m.PetName).Name("BaseName");
            Map(m => m.PetBreed).Name("Breed");
            Map(m => m.PetType).Name("Type");
            Map(m => m.PetRarity).Name("Rarity");
            Map(m => m.PetBonus).Name("Bonus");
            Map(m => m.PetMinValue).Name("Min bonus value");
            Map(m => m.PetMaxValue).Name("Max bonus value");
        }
    }

    public class Pet : IComparable<Pet>
    {
        public Pet() {}

        public string PetID        { get; set; }
        public string PetName      { get; set; }
        public string PetBreed     { get; set; }
        public string PetType      { get; set; }
        public string PetRarity    { get; set; }
        public string PetBonus     { get; set; }
        public int    PetMinValue  { get; set; }
        public int    PetMaxValue  { get; set; }

        public void Print()
        {
            Console.WriteLine(
                PetID + " " +
                PetName + " " +
                PetBreed + " " +
                PetType + " " +
                PetRarity + " " +
                PetBonus + " " +
                PetMinValue + " " +
                PetMaxValue);
        }

        public int CompareTo(Pet other)
        {
            return string.CompareOrdinal(this.PetID, other.PetID);
        }
    }
}
