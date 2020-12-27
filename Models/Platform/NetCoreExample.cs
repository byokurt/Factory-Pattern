using FactoryPattern.Models.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Models.Platform
{
    public class NetCoreExample : FactoryExample
    {
        public override string Platform()
        {
            return "NetCore Seçildi";
        }
    }
}
