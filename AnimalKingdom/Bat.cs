using System;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples { get; } = 2;
        public int NumberOfWings { get; } = 4;
    }
}