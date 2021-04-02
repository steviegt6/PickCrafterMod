namespace PickCrafterMod.Common.Loaders.LoaderTypes
{
    public abstract class AMPCode : ILoadable
    {
        public virtual void Load() { }

        public abstract bool ProcessCode(string code);

        public void Unload() { }
    }
}
