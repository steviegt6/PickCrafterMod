using System;
using MelonLoader;
using PickCrafterMod.Common.Loading.LoaderManagers;

namespace PickCrafterMod
{
    public class Entrypoint : MelonMod
    {
        public static Entrypoint Instance { get; private set; }

        public Entrypoint() => Instance = this;

        public override void OnApplicationStart()
        {
            MelonLogger.Msg(ConsoleColor.DarkGray, "Detected application start!");
            MelonLogger.Msg(ConsoleColor.DarkGray, "Initializing...");

            ILLoader.Load();
        }

        public override void OnApplicationQuit()
        {
            MelonLogger.Msg(ConsoleColor.DarkGray, "Detected application quit!");
            MelonLogger.Msg(ConsoleColor.DarkGray, "Unloading...");
        }
    }
}
