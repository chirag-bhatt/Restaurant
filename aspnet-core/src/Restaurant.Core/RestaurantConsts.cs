using Restaurant.Debugging;

namespace Restaurant
{
    public class RestaurantConsts
    {
        public const string LocalizationSourceName = "Restaurant";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "94f03f5e75014b8fbb308b5e3916a9de";
    }
}
