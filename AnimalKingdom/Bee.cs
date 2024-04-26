using System;

namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        int NumberOfWings { get; } = 4;
    }
}