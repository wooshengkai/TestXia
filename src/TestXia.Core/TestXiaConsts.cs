using TestXia.Debugging;

namespace TestXia
{
    public class TestXiaConsts
    {
        public const string LocalizationSourceName = "TestXia";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "866f54f8fbfb4f898003f88001ca06f2";
    }
}
