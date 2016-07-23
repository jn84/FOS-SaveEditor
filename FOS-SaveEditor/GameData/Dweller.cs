using System;
using CsvHelper.Configuration;

namespace FOS_SaveEditor.GameData
{
    public sealed class DwellerMap : CsvClassMap<Dweller>
    {
        public DwellerMap()
        {
            Map(m => m.DwellerCode).Name("Code");
            Map(m => m.DwellerName).Name("Name");
            Map(m => m.DwellerGender).Name("Gender");
            Map(m => m.DwellerHairType).Name("Hair");
            Map(m => m.DwellerHairColor).Name("HairColor");
            Map(m => m.DwellerSkinColor).Name("SkinColor");
            Map(m => m.DwellerRarity).Name("Rarity");
            Map(m => m.DwellerOutfit).Name("Outfit");
            Map(m => m.DwellerWeapon).Name("Weapon");
            Map(m => m.DwellerStatS).Name("S");
            Map(m => m.DwellerStatP).Name("P");
            Map(m => m.DwellerStatE).Name("E");
            Map(m => m.DwellerStatC).Name("C");
            Map(m => m.DwellerStatI).Name("I");
            Map(m => m.DwellerStatA).Name("A");
            Map(m => m.DwellerStatL).Name("L");
        }
    }

    public class Dweller
    {
        public Dweller()
        {

        }
        public string DwellerCode        { get; set; }
        public string DwellerName        { get; set; }
        public string DwellerGender      { get; set; }
        public string DwellerHairType    { get; set; }
        public string DwellerHairColor { get; set; }
        public string DwellerSkinColor { get; set; }
        public string DwellerRarity     { get; set; }
        public string DwellerOutfit     { get; set; }
        public string DwellerWeapon     { get; set; }
        public int    DwellerStatS      { get; set; }
        public int    DwellerStatP      { get; set; }
        public int    DwellerStatE      { get; set; }
        public int    DwellerStatC      { get; set; }
        public int    DwellerStatI      { get; set; }
        public int    DwellerStatA      { get; set; }
        public int    DwellerStatL      { get; set; }

        public void Print()
        {
            Console.WriteLine(
                DwellerCode + " " +
                DwellerName + " " +
                DwellerGender + " " +
                DwellerHairType + " " +
                DwellerHairColor + " " +
                DwellerSkinColor + " " +
                DwellerRarity + " " +
                DwellerOutfit + " " +
                DwellerWeapon + " " +
                DwellerStatS + " " +
                DwellerStatP + " " +
                DwellerStatE + " " +
                DwellerStatC + " " +
                DwellerStatI + " " +
                DwellerStatA + " " +
                DwellerStatL);
        }
    }
}