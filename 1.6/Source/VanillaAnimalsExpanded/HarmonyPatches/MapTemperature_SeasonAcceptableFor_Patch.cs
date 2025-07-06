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
using RimWorld.Planet;

namespace VanillaAnimalsExpanded
{

    [HarmonyPatch(typeof(MapTemperature))]
    [HarmonyPatch("SeasonAcceptableFor")]
    public static class VanillaAnimalsExpanded_MapTemperature_SeasonAcceptableFor_Patch
    {
        [HarmonyPostfix]
        public static void AllowAnimalSpawns(ThingDef animalRace, ref bool __result, Map ___map)

        {
           

            if (animalRace != null && StaticCollections.riverAnimals.Contains(animalRace))
            {
                SurfaceTile surfaceTile = ___map.Tile.Tile as SurfaceTile;
                if (surfaceTile.Rivers==null)
                {
                    __result = false;
                }

            }




        }
    }





}
