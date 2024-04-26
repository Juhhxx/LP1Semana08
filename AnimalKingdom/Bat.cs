using System;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal
    {
        int NumberOfNipples { get; } = 2;
    }
}