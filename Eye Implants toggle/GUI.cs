using static UnityEngine.GUILayout;

namespace Eye_Implants_toggle
{
    class GUI : PulsarModLoader.CustomGUI.ModSettingsMenu
    {
        bool cached;
        public override void OnOpen()
        {
            cached = Mod.Enabled;
        }
        public override void Draw()
        {
            cached = Toggle(cached, "Toggle Eye Implants On/Off");

            if (cached != Mod.Enabled)
            {
                Mod.Enabled.Value = cached;
            }
        }

        public override string Name()
        {
            return "Eye Implants Toggle";
        }
    }
}
