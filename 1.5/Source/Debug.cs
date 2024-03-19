namespace BedRestForFoodPoisoning
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{BedRestForFoodPoisoningMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
