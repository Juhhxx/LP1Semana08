using System;

namespace Polimorfismo
{
    public class Dog : Animal, IMammal
    {
        int NumberOfNipples { get; } = 8;
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
