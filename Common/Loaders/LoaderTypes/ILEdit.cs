namespace PickCrafterMod.Common.Loaders.LoaderTypes
{
    public abstract class ILEdit : ILoadable
    {
        public abstract void Load();

        public void Unload() { }
    }
}
