using Verse;
using RimWorld;
using HarmonyLib;

namespace BedRestForFoodPoisoning
{
    [HarmonyPatch(typeof(HealthAIUtility))]
    [HarmonyPatch("ShouldSeekMedicalRest")]
    public static class Patch_HealthAIUtility_ShouldSeekMedicalRest
    {
        [MustTranslate]
        private static string initial = "initial";

        [MustTranslate]
        private static string major = "major";

        public static void Postfix(ref Pawn pawn, ref bool __result)
        {
            if (!__result)
            {
                Hediff hediff;
                if ((hediff = pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.FoodPoisoning)) != null)
                {
                    if (hediff.CurStage.label == initial || hediff.CurStage.label == major)
                    {
                        __result = true;
                    }
                }
            }
        }
    }
}
