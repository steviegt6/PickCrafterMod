using System;
using System.Collections.Generic;
using System.Linq;
using PickCrafterMod.Common.Loading.LoaderClasses;

namespace PickCrafterMod.Common.Utilities
{
    public static class ReflectionLoadingTools
    {
        /*public static bool ValidateForLoading(this Type type, params Type[] validTypes) =>
            !type.IsAbstract && type.GetConstructor(new Type[0]) != null && validTypes.Contains(type);

        public static void FindAndLoadTypes<TType>(List<TType> listToFill, Action<string> onValidTypeFound = null,
            Action<string> preValidTypeLoad = null, Action<string> postValidTypeLoad = null)
        {
            foreach (Type validType in typeof(ReflectionLoadingTools).Assembly.GetTypes()
                .Where(x => x.ValidateForLoading(typeof(TType))))
            {
                if (!(Activator.CreateInstance(validType) is TType loadableType))
                    continue;

                onValidTypeFound?.Invoke(loadableType.GetType().Name);
                listToFill.Add(loadableType);
            }


            foreach (TType type in listToFill)
                if (type is GenericLoadType capableOfLoading)
                {
                    preValidTypeLoad?.Invoke(capableOfLoading.GetType().Name);
                    capableOfLoading.Load();
                    postValidTypeLoad?.Invoke(capableOfLoading.GetType().Name);
                }
        }*/
    }
}
