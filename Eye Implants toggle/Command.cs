using PulsarPluginLoader.Chat.Commands;

namespace Eye_Implants_toggle
{
    class Command : IChatCommand
    {
        public static bool CurrentSetting = true;
        public string[] CommandAliases()
        {
            return new string[] { "implants", "eyes" };
        }

        public string Description()
        {
            return "Toggles Eye Implants on/off";
        }

        public bool Execute(string arguments, int SenderID)
        {
            CurrentSetting = !CurrentSetting;
            string str = CurrentSetting ? "On" : "Off";
            PulsarPluginLoader.Utilities.Messaging.Notification($"Eye implants now {str}");
            return false;
        }

        public bool PublicCommand()
        {
            return false;
        }

        public string UsageExample()
        {
            return $"/{CommandAliases()[0]}";
        }
    }
}
