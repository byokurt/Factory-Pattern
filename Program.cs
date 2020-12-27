using FactoryPattern.Models.Creater;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            var value = creater.FactoryMethod(Enum.Platforms.NetCore);
            var response = value.Platform();
        }
    }
}
