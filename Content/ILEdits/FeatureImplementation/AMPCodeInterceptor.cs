using System;
using MelonLoader;
using PickCrafterMod.Common.Loading.LoaderClasses;

namespace PickCrafterMod.Content.ILEdits.FeatureImplementation
{
    public class AMPCodeInterceptor : ILEdit
    {
        //public override void Load() => On.AMPCodes.SpecialCodeCheck += InterceptPreWebCheck;

        //private bool InterceptPreWebCheck(On.AMPCodes.orig_SpecialCodeCheck orig, string userInputCode)
        //{
        //    MelonLogger.Msg(ConsoleColor.DarkGray, $"Detected attempted AMP code: {userInputCode}");
        //
        //    return orig(userInputCode);
        //}
    }
}
