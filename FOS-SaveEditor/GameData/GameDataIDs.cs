using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

namespace FOS_SaveEditor.GameData
{
    /// <summary>
    /// Game Data information lookup
    /// </summary>
    public static class GameDataIDs
    {
        public static List<Outfit> outfitList = new List<Outfit>();
        public static List<Pet> petList = new List<Pet>();
        public static List<Weapon> weaponList = new List<Weapon>();
        public static List<Dweller> dwellerList = new List<Dweller>();

        static GameDataIDs()
        {
            CsvParser("//Resources//csv_outfits.csv", outfitList, new OutfitMap());
            CsvParser("//Resources//csv_pets.csv", petList, new PetMap());
            CsvParser("//Resources//csv_weapons.csv", weaponList, new WeaponMap());
            CsvParser("//Resources//csv_dwellers.csv", dwellerList, new DwellerMap());

            foreach (var elem in petList)
                Console.WriteLine(elem.PetBreed);
        }

        public static void DummyMethod()
        {
            
        }

        private static void CsvParser<T, TMap>(
            string file, 
            List<T> dataList, 
            // ReSharper disable once SuggestBaseTypeForParameter
            CsvClassMap<TMap> typeMap)
        {
            try
            {
                using (var fs = new FileStream(Directory.GetCurrentDirectory() + file, FileMode.Open))
                {
                    using (var fileStreamReader = new StreamReader(fs))
                    {
                        using (var fileReader = new CsvReader(fileStreamReader))
                        {
                            fileReader.Configuration.RegisterClassMap(typeMap);
                            dataList.AddRange(fileReader.GetRecords<T>());
                        }
                    }
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine(@"Some exception loading file....");
                Console.WriteLine(e.StackTrace + "\n\n");
                Console.WriteLine(e.Message + "\n\n");
            }
        }
    }
}
