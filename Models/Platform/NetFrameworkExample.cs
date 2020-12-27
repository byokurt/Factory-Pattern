using FactoryPattern.Models.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Models.Platform
{
    public class NetFrameworkExample : FactoryExample
    {
        public override string Platform()
        {
            return "NetFramework Seçildi";
        }
    }
}
