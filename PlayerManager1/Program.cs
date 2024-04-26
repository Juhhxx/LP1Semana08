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
        private Program()
        {
            _playerList = new List<Player>() {
                new Player("Best player ever", 100),
                new Player("An even better player", 500)
            };
        }
        private void Start()
        {
            string _userOption;

            do
            {
                _userOption = Console.ReadLine();

                switch(_userOption)
                {
                    case "1":
                        InsertPlayer();
                        break;
                    case "2":
                        ListPlayers(_playerList);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan();
                        break;
                    case "4":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
                        break;
                }
            } while (_userOption != "4");
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
            Console.Write("Insert the minimum score:\n> ");
            int _minScore = int.Parse(Console.ReadLine());

            IEnumerable<Player> _newList = GetPlayersWithScoreGreaterThan(_minScore);

            ListPlayers(_newList);
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
