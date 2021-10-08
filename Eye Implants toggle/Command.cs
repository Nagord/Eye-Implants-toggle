using PulsarModLoader.Chat.Commands.CommandRouter;

namespace Eye_Implants_toggle
{
    class Command : ChatCommand
    {
        public static bool CurrentSetting = true;
        public override string[] CommandAliases()
        {
            return new string[] { "implants", "eyes" };
        }

        public override string Description()
        {
            return "Toggles Eye Implants on/off";
        }

        public override void Execute(string arguments)
        {
            CurrentSetting = !CurrentSetting;
            string str = CurrentSetting ? "On" : "Off";
            PulsarModLoader.Utilities.Messaging.Notification($"Eye implants now {str}");
        }
    }
}
