using PulsarModLoader.Chat.Commands.CommandRouter;

namespace Eye_Implants_toggle
{
    class Command : ChatCommand
    {
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
            Mod.Enabled.Value = !Mod.Enabled.Value;
            string str = Mod.Enabled.Value ? "On" : "Off";
            PulsarModLoader.Utilities.Messaging.Notification($"Eye implants now {str}");
        }
    }
}
