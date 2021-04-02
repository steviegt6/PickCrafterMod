using System.Linq;
using System.Reflection;
using MonoMod.RuntimeDetour.HookGen;
using PickCrafterMod.Common.Loaders;
using PickCrafterMod.Common.Loaders.LoaderTypes;

namespace PickCrafterMod.Content.ILEdits
{
    public class RedemptionCodeHandlerEdit : ILEdit
    {
        private static readonly MethodInfo Info = typeof(AMPCodes).GetMethod("SpecialCodeCheck", BindingFlags.Public | BindingFlags.Static);

        private delegate bool RedeemCodeOrig(string userInputCode);

        private delegate bool RedeemCodeHook(RedeemCodeOrig orig, string userInputCode);

        private static event RedeemCodeHook RedeemCodeOn
        {
            add => HookEndpointManager.Add(Info, value);

            remove => HookEndpointManager.Remove(Info, value);
        }

        public override void Load() => RedeemCodeOn += HandleCustomAMPCodes;

        private static bool HandleCustomAMPCodes(RedeemCodeOrig orig, string userInputCode) => AMPLoader.AMPCodes.Any(code => code.ProcessCode(userInputCode)) || orig(userInputCode);
    }
}
