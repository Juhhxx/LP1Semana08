﻿using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        private List<Player> _playerList;
        static void Main(string[] args)
        {
        }
        private void InsertPlayer()
        {
            Console.Write("Insert player name:\n> ");
            string _name = Console.ReadLine();

            Console.Write("\nInsert player score:\n> ");
            int _score = int.Parse(Console.ReadLine());
            
            Player newPlayer = new Player(_name,_score);
            _playerList.Add(newPlayer);
        }
    }
}
