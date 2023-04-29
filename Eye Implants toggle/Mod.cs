using PulsarModLoader;
using PulsarModLoader.Keybinds;

namespace Eye_Implants_toggle
{
    public class Mod : PulsarMod, IKeybind
    {
        public override string Version => "1.0.0";

        public override string Author => "Dragon";

        public override string LongDescription => "Toggles Eye implants on/off";

        public override string Name => "Eye Implants toggle";


        public static SaveValue<bool> Enabled = new SaveValue<bool>("Enabled", true);

        public override bool CanBeDisabled()
        {
            return true;
        }

        public override void Disable()
        {
            Enabled.Value = false;
        }

        public override void Enable()
        {
            Enabled.Value = true;
        }

        public override string HarmonyIdentifier()
        {
            return $"{Author}.{Name}";
        }

        public override bool IsEnabled()
        {
            return Enabled.Value;
        }

        public void RegisterBinds(KeybindManager manager)
        {
            manager.NewBind("Toggle Eye Implants", "EyeImplantsToggle", "Basics", "i");
        }
    }
}
