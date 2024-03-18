using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;
using System.Reflection.Emit;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Verse.AI;

namespace VanillaAnimalsExpanded
{

    [HarmonyPatch(typeof(MapTemperature))]
    [HarmonyPatch("SeasonAcceptableFor")]
    public static class VanillaAnimalsExpanded_MapTemperature_SeasonAcceptableFor_Patch
    {
        [HarmonyPostfix]
        public static void AllowAnimalSpawns(ThingDef animalRace, ref bool __result, Map ___map)

        {
            RiverNeedingAnimalDef riverAnimals = DefDatabase<RiverNeedingAnimalDef>.GetNamed("AEXP_RiverNeedingAnimals");


            if (animalRace != null && riverAnimals.riverNeedingAnimals.Contains(animalRace))
            {
                if (___map.TileInfo.Rivers==null)
                {
                    __result = false;
                }

            }




        }
    }





}
