// <auto-generated/>
using C4InterFlow.Structures;
using C4InterFlow.Structures.Interfaces;

namespace dotnet.eShop.Architecture.SoftwareSystems
{
    public partial class BasketApi
    {
        public partial class Containers
        {
            public partial class Data
            {
                public partial class Components
                {
                    public partial class RedisBasketRepository : IComponentInstance
                    {
                        private static readonly string ALIAS = "dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.Components.RedisBasketRepository";
                        public static Component Instance => new Component(dotnet.eShop.Architecture.SoftwareSystems.BasketApi.Containers.Data.ALIAS, ALIAS, "Redis Basket Repository")
                        {
                            ComponentType = ComponentType.None,
                            Description = "",
                            Technology = ""
                        };

                        public partial class Interfaces
                        {
                        }
                    }
                }
            }
        }
    }
}