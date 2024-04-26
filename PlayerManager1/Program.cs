using System;
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
        private static void ListPlayers(IEnumerable<Player> _playerToList)
        {
            Console.WriteLine("\nList of all players:");

            foreach (Player p in _playerToList)
            {
                Console.WriteLine($"Name={p.Name} Score={p.Score}");
            }
        }
        private void ListPlayersWithScoreGreaterThan()
        {

        }
        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(int _minScore)
        {
            List<Player> _greaterThan = new List<Player>();

            foreach (Player p in _playerList)
            {
                if (p.Score > _minScore)
                {
                    _greaterThan.Add(p);
                }
            }

            return _greaterThan;
        }
    }
}
