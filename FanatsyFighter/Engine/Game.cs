using System.Runtime.CompilerServices;

namespace FanatsyFighter
{
    internal class Game
    {
        private List<Character> _enemies;//lista di nemici da affrontare

        private Hero? _player; //? sta per null

        public bool IsGameRunning { get; private set; }

        public Game() //costruttore senza paarmetri
        {
            this._enemies = new List<Character>()
            {
                new Dragon("Red Dregon"),
                new Dragon("Golden Dregon"),
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

        private string GetPlayerNAme() 
        {
            Console.WriteLine("Please choose your name");
            var name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                Console.WriteLine("The name cannot be empty spaces");

            //TODO:   richiedere il nome al giocatore

            return name!;                                               //Con il punto esclamativo gli dico che sono sicuro che non sarà null
        }

        private void DisplayWekcimeMessage()
        {
            Console.WriteLine("Messaggio di benvenuto....");
        }

    }
}
