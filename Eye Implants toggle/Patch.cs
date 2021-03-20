using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using static PulsarPluginLoader.Patches.HarmonyHelpers;

namespace Eye_Implants_toggle
{
    [HarmonyPatch(typeof(PLUIOutsideWorldUI), "UpdateKeenUIElements")]
    class Patch
    {
        
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator generator)
        {
            List<CodeInstruction> findsequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Brfalse),
                new CodeInstruction(OpCodes.Ldsfld, AccessTools.Field(typeof(PLEncounterManager), "Instance")),
                new CodeInstruction(OpCodes.Ldfld, AccessTools.Field(typeof(PLLevelSync), "PlayerShip")),
                new CodeInstruction(OpCodes.Ldfld, AccessTools.Field(typeof(PLShipInfoBase), "InWarp")),
                new CodeInstruction(OpCodes.Brtrue),
            };

            int LabelIndex = FindSequence(instructions, findsequence, CheckMode.NONNULL) - 1;
            Label thing = (Label)instructions.ToList()[LabelIndex].operand;

            List <CodeInstruction> targetSequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Ldsfld, AccessTools.Field(typeof(PLEncounterManager), "Instance")),
                new CodeInstruction(OpCodes.Ldfld, AccessTools.Field(typeof(PLLevelSync), "PlayerShip")),
                new CodeInstruction(OpCodes.Ldfld, AccessTools.Field(typeof(PLShipInfoBase), "InWarp")),
                new CodeInstruction(OpCodes.Brtrue, thing),
            };

            List<CodeInstruction> injectedSequence = new List<CodeInstruction>()
            {
                new CodeInstruction(OpCodes.Ldsfld, AccessTools.Field(typeof(Command), "CurrentSetting")),
                new CodeInstruction(OpCodes.Brfalse, thing)
            };
            return PatchBySequence(instructions, targetSequence, injectedSequence, patchMode: PatchMode.AFTER);
        }
    }
}
