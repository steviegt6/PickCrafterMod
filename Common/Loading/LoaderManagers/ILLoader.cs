using System;
using System.Collections.Generic;
using MelonLoader;
using PickCrafterMod.Common.Loading.LoaderClasses;
using PickCrafterMod.Common.Utilities;

namespace PickCrafterMod.Common.Loading.LoaderManagers
{
    public static class ILLoader
    {
        public static List<ILEdit> ILEdits { get; private set; }

        internal static void Load()
        {
            ILEdits = new List<ILEdit>();

            //ReflectionLoadingTools.FindAndLoadTypes(ILEdits, LogValidType, LogLoadingType, LogLoadedType);
        }

        private static void LogValidType(string typeName) =>
            MelonLogger.Msg(ConsoleColor.DarkGray, $"Valid IL edit found: {typeName}");

        private static void LogLoadingType(string typeName) =>
            MelonLogger.Msg(ConsoleColor.DarkGray, $"Loading IL edit: {typeName}");

        private static void LogLoadedType(string typeName) =>
            MelonLogger.Msg(ConsoleColor.DarkGray, $"Loaded IL edit: {typeName}");
    }
}
