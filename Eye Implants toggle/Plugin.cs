using PulsarPluginLoader;

namespace Eye_Implants_toggle
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "0.1.0";

        public override string Author => "Dragon";

        public override string LongDescription => "Toggles Eye implants on/off";

        public override string Name => "Eye Implants toggle";

        public override string HarmonyIdentifier()
        {
            return "Dragon.Eye Implants toggle";
        }
    }
}
