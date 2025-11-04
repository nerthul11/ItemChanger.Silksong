using ItemChanger.Containers;

namespace ItemChanger.Silksong.Containers
{
    public class ShinyContainer : Container
    {
        public static ShinyContainer Instance { get; } = new();

        public override string Name => ContainerNames.Shiny;

        public override uint SupportedCapabilities => ContainerCapabilities.PAY_COSTS;

        public override bool SupportsInstantiate => true;

        public override bool SupportsModifyInPlace => true;

        public override GameObject GetNewContainer(ContainerInfo info)
        {
            throw new NotImplementedException();
        }

        public override void ModifyContainerInPlace(GameObject obj, ContainerInfo info)
        {
            throw new NotImplementedException();
        }

        protected override void Load()
        {
        }

        protected override void Unload()
        {
        }
    }

}
