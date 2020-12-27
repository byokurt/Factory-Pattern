using FactoryPattern.Enum;
using FactoryPattern.Models.Factory;
using FactoryPattern.Models.Platform;

namespace FactoryPattern.Models.Creater
{
    public class Creater
    {
        public FactoryExample FactoryMethod(Platforms platform)
        {
            FactoryExample factoryexample = null;

            switch (platform)
            {
                case Platforms.NetCore:
                    factoryexample = new NetCoreExample();
                    break;
                case Platforms.NetFramework:
                    factoryexample = new NetFrameworkExample();
                    break;
            }

            return factoryexample;
        }
    }
}
