using System;
using System.Collections.Generic;
using System.Linq;
using PickCrafterMod.Common.Loaders.LoaderTypes;

namespace PickCrafterMod.Common.Loaders
{
    public static class AMPLoader
    {
        public static List<AMPCode> AMPCodes { get; private set; }

        public static TCode GetEdit<TCode>() where TCode : AMPCode => (TCode)AMPCodes.First(x => x.GetType() == typeof(TCode));

        internal static void Load()
        {
            PluginEntrypoint.Logging.LogInfo("Loading AMP codes...");

            AMPCodes = new List<AMPCode>();

            foreach (Type type in typeof(AMPLoader).Assembly.GetTypes().Where(x => !x.IsAbstract && x.GetConstructor(new Type[0]) != null && x.IsSubclassOf(typeof(AMPCode))))
                if (Activator.CreateInstance(type) is AMPCode ampCode)
                {
                    PluginEntrypoint.Logging.LogInfo($"Found AMP code: {type.Name}");
                    AMPCodes.Add(ampCode);
                }

            foreach (AMPCode code in AMPCodes)
            {
                PluginEntrypoint.Logging.LogInfo($"Loading AMP code: {code.GetType().Name}");
                code.Load();
                PluginEntrypoint.Logging.LogInfo($"Loaded AMP code: {code.GetType().Name}");
            }

            PluginEntrypoint.Logging.LogInfo("Loaded AMP codes!");
        }
    }
}
