using BepInEx;
using BepInEx.Logging;
using PickCrafterMod.Common.Loaders;
using PickCrafterMod.Properties;

namespace PickCrafterMod
{
    [BepInPlugin("io.github.steviegt6.pickcrafter.pickcraftermod", "PickCrafter Mod", AssemblyInfo.VersionString)]
    public class PluginEntrypoint : BaseUnityPlugin
    {
        public static PluginEntrypoint Instance { get; private set; }

        public static ManualLogSource Logging { get; private set; }
        
        protected void Awake()
        {
            Logger.LogInfo("Plugin entrypoint awoken, loading...");

            Instance = this;
            Logging = Logger;

            ILLoader.Load();
            AMPLoader.Load();

            Logger.LogInfo("Plugin loaded.");
        }
    }
}
