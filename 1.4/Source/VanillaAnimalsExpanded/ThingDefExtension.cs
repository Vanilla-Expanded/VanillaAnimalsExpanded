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

    public class AnimalSpawningExtension : DefModExtension
    {

        public static readonly AnimalSpawningExtension defaultValues = new AnimalSpawningExtension();

        public bool requiresRiver;

    } 

}
