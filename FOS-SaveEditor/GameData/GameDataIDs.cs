using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BindingFiltering;
using CsvHelper;
using CsvHelper.Configuration;

namespace FOS_SaveEditor.GameData
{
    /// <summary>
    /// Game Data information lookup
    /// </summary>
    public static class GameDataIDs
    {
        private static List<Outfit> outfitList = new List<Outfit>();
        private static List<Pet> petList = new List<Pet>();
        private static List<Weapon> weaponList = new List<Weapon>();
        //private static List<Dweller> dwellerList = new List<Dweller>();

        public static FilteredBindingList<Outfit> outfitBindingList;
        public static FilteredBindingList<Pet> petBindingList;
        public static FilteredBindingList<Weapon> weaponBindingList;

        public static BindingSource outfitListBindingSource;
        public static BindingSource petListBindingSource;
        public static BindingSource weaponListBindingSource;
        //private static BindingSource outfitListBindingSource;


        static GameDataIDs()
        {
            CsvParser("//Resources//csv_outfits.csv", outfitList, new OutfitMap());
            CsvParser("//Resources//csv_pets.csv", petList, new PetMap());
            CsvParser("//Resources//csv_weapons.csv", weaponList, new WeaponMap());
            //CsvParser("//Resources//csv_dwellers.csv", dwellerList, new DwellerMap());

            outfitList.Sort(Comparer<Outfit>.Create((x, y) => 
                string.Compare(x.OutfitName, y.OutfitName, StringComparison.Ordinal)));


            outfitBindingList = new FilteredBindingList<Outfit>(outfitList);
            petBindingList = new FilteredBindingList<Pet>(petList);
            weaponBindingList = new FilteredBindingList<Weapon>(weaponList);

            // DataSources for equipment editing
            outfitListBindingSource = new BindingSource(new BindingList<Outfit>(outfitList), null);
            petListBindingSource = new BindingSource(new BindingList<Pet>(petList), null);
            weaponListBindingSource = new BindingSource(new BindingList<Weapon>(weaponList), null);


            foreach (var elem in outfitList)
            {
                //Console.WriteLine(elem.);
            }
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
                            fileReader.Configuration.AllowComments = true;
                            fileReader.Configuration.Comment = '#';
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
