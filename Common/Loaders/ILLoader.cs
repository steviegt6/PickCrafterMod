using System;
using System.Collections.Generic;
using System.Linq;
using PickCrafterMod.Common.Loaders.LoaderTypes;

namespace PickCrafterMod.Common.Loaders
{
    public static class ILLoader
    {
        public static List<ILEdit> ILEdits { get; private set; }

        public static TEdit GetEdit<TEdit>() where TEdit : ILEdit => (TEdit) ILEdits.First(x => x.GetType() == typeof(TEdit));

        internal static void Load()
        {
            PluginEntrypoint.Logging.LogInfo("Loading IL edits...");

            ILEdits = new List<ILEdit>();

            foreach (Type type in typeof(ILLoader).Assembly.GetTypes().Where(x => !x.IsAbstract && x.GetConstructor(new Type[0]) != null && x.IsSubclassOf(typeof(ILEdit))))
                if (Activator.CreateInstance(type) is ILEdit ilEdit)
                {
                    PluginEntrypoint.Logging.LogInfo($"Found IL edit: {type.Name}");
                    ILEdits.Add(ilEdit);
                }

            foreach (ILEdit edit in ILEdits)
            {
                PluginEntrypoint.Logging.LogInfo($"Loading IL edit: {edit.GetType().Name}");
                edit.Load();
                PluginEntrypoint.Logging.LogInfo($"Loaded IL edit: {edit.GetType().Name}");
            }

            PluginEntrypoint.Logging.LogInfo("Loaded IL edits!");
        }
    }
}
