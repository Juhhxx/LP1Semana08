using System;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        int NumberOfNipples { get; } = 2;
        int NumberOfWings { get; } = 4;
    }
}