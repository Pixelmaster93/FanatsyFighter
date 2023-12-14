namespace FanatsyFighter
{
    public abstract class Character //abstarct sta per astratta perchè non andrò mai a lavorare direttamente con Character
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int AttackPoints { get; set; }

        public int DefensePoint { get; set; }

        //public string Role { get; set; } 

      
        public Character(string name, int health, int attackPoints, int defensePoint)
        {
            Name = name;
            Health = health;
            AttackPoints = attackPoints;
            DefensePoint = defensePoint;
        }

        public override string ToString()
        {
            return $"Name: {this.Name} - Healt: {this.Health} - Attack Points: {this.AttackPoints} - Defense Points{this.DefensePoint}"; //this è per dire che si riferisce s qualcosa all'interno della classe, non è necessario ma ordina un po il tutto
            
        }
    }

}

