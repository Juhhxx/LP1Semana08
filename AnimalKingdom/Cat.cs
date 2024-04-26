using System;

namespace Polimorfismo
{
    public class Cat : Animal, IMammal
    {
        int NumberOfNipples { get; } = 6;
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
