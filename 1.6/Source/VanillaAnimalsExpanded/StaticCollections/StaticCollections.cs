using Verse;
using System;
using RimWorld;
using System.Collections.Generic;
using System.Linq;


namespace VanillaAnimalsExpanded
{
    [StaticConstructorOnStartup]
    public static class StaticCollections
    {

        public static List<ThingDef> riverAnimals = new List<ThingDef>();

    
        static StaticCollections()
        {

            List<RiverNeedingAnimalDef> riverAnimalsTotal = DefDatabase<RiverNeedingAnimalDef>.AllDefsListForReading;
            foreach (RiverNeedingAnimalDef individualList in riverAnimalsTotal)
            {
                foreach(ThingDef animal in individualList.riverNeedingAnimals)
                {
                    riverAnimals.Add(animal);
                }
               

            }
        
        }




    }
}