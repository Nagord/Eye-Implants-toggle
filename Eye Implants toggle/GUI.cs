using static UnityEngine.GUILayout;

namespace Eye_Implants_toggle
{
    class GUI : PulsarModLoader.CustomGUI.ModSettingsMenu
    {
        public override void Draw()
        {
            Command.CurrentSetting = Toggle(Command.CurrentSetting, "Toggle Eye Implants On/Off");
        }

        public override string Name()
        {
            return "Eye Implants Toggle";
        }
    }
}
