using UnityEngine;
using Verse;
using HarmonyLib;

namespace BedRestForFoodPoisoning
{
    public class BedRestForFoodPoisoningMod : Mod
    {
        public const string PACKAGE_ID = "bedrestforfoodpoisoning.1trickPonyta";
        public const string PACKAGE_NAME = "Bed Rest For Food Poisoning";

        public BedRestForFoodPoisoningMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
