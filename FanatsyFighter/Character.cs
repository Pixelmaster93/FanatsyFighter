namespace FanatsyFighter
{
    public abstract class Character //abstarct st aper astratta
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int AttackPoints { get; set; }

        public int DefensePoint { get; set; }

        public string Role { get; set; }  //Role sta per la calasse

        public Character(string name, int health, int attackPoints, int defensePoint)
        {
            Name = name;
            Health = health;
            AttackPoints = attackPoints;
            DefensePoint = defensePoint;
        }

        public override string ToString()
        {
            return $"Name: {this.Name} - Healt: {this.Health} - Attack Points: {this.AttackPoints} - Defense Points{this.DefensePoint}"; //this è per dire che si riferisce a questo file
        }
    }

}

