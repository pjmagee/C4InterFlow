// <auto-generated/>
using C4InterFlow;
using C4InterFlow.Structures;
using C4InterFlow.Structures.Interfaces;

namespace DotNetEShop.SoftwareSystems
{
    public partial class BasketApi
    {
        public partial class Containers
        {
            public partial class Data
            {
                public partial class Components
                {
                    public partial class RedisDatabase : IComponentInstance
                    {
                        public static Component Instance => new Component(typeof(RedisDatabase), "Redis Database")
                        {
                            ComponentType = ComponentType.Database,
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