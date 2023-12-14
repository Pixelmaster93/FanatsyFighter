using System.Runtime.CompilerServices;

namespace FanatsyFighter
{
    internal class Game
    {
        private List<Character> _enemies;//lista di nemici da affrontare

        private Hero? _player; //? sta per null

        public bool IsGameRunning { get; private set; }

        public Game() //costruttore senza paarmetri, il costruttore ha lo stesso nome della classe
        {
            this._enemies = new List<Character>()
            {
                new Dragon("Red Dragon"),
                new Dragon("Golden Dragon"),
                new Goblin("Goblin #1"),
                new Goblin("Goblin #2"),
                new Troll("Paolo"),
                new Slime("Slime #1"),
                new Slime("Slime #2"),
            };

        }

        public void StartNewGame()
        {
            if(this.IsGameRunning)
            {
                Console.WriteLine("The game is alredy running");
                return;
            }

            this.IsGameRunning = true;

            // messaggio di benvenuto al giocatore

            // chiedere al giocatore di scegliere il nome

            // chiedere al giocatore di scegliere un ruolo

            // costruire il nostro hero

            //iniziamo i turni
        }


        /*
        private bool IsPlayerNAmeValid(string name, out string result)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                result = "The name cannot be empty or white sapces";
                return false;
            }
               

            string[] prohibitedWords = new string[]
            {
                ".",
                ",",
                ";",
                ":",
            };

            foreach (string prohibitedWord in prohibitedWords)
            {
                if (name.Contains(prohibitedWord))
                {
                    result = $"The name cannot include {prohibitedWord}";
                    return false;
                }
            }
            result = "Name is ok";
            return true;
        }

        private string GetPlayerNAme() 
        {
            Console.WriteLine("Please choose your name");
            var name = Console.ReadLine();

            if (!IsPlayerNAmeValid(name, result: out string erroeMessage))
            {
                Console.WriteLine(erroeMessage);
            }
        */


        private bool IsPlayerNAmeValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                result = "The name cannot be empty or white sapces";
                return false;
            }


            string[] prohibitedWords = new string[]
            {
                ".",
                ",",
                ";",
                ":",
            };

            foreach (string prohibitedWord in prohibitedWords)
            {
                if (name.Contains(prohibitedWord))
                {
                    result = $"The name cannot include {prohibitedWord}";
                    return false;
                }
            }
            result = "Name is ok";
            return true;
        }

        private string GetPlayerNAme()
        {
            Console.WriteLine("Please choose your name");
            var name = Console.ReadLine();

            if (!IsPlayerNAmeValid(name, result: out string erroeMessage))
            {
                Console.WriteLine(erroeMessage);
            }

            //TODO:   richiedere il nome al giocatore

            return name!;                                               //Con il punto esclamativo gli dico che sono sicuro che non sarà null
        }

        private void DisplayWekcimeMessage()
        {
            Console.WriteLine("Messaggio di benvenuto....");
        }

    }
}
