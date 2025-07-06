using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using HarmonyLib;

namespace VanillaAnimalsExpanded
{

    public class VanillaAnimalsExpanded : Mod
    {
        public VanillaAnimalsExpanded(ModContentPack content) : base(content)
        {
            HarmonyInstance = new Harmony("OskarPotocki.VanillaAnimalsExpanded");
        }

        public static Harmony HarmonyInstance;

    }

}
