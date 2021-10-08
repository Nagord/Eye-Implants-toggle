﻿using PulsarModLoader;

namespace Eye_Implants_toggle
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.1.1";

        public override string Author => "Dragon";

        public override string LongDescription => "Toggles Eye implants on/off";

        public override string Name => "Eye Implants toggle";

        public override string HarmonyIdentifier()
        {
            return "Dragon.Eye Implants toggle";
        }
    }
}