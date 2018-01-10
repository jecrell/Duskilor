using System;
using System.Collections.Generic;
using Harmony;
using ProjectHeron;
using RimWorld;
using UnityEngine;
using Verse;

namespace Duskilor
{
    [StaticConstructorOnStartup]
    static class HarmonyPatches
    {

        static HarmonyPatches()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("rimworld.jecrell.duskilor");
//            harmony.Patch(AccessTools.Method(typeof(Building_Door), "DoorOpen"), new HarmonyMethod(typeof(HarmonyPatches),
//                nameof(InvisDoorOpen)), null);
        }
    }
}

