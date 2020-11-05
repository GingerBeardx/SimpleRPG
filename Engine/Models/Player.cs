namespace Engine
{
    public class Player
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public int Health { get; private set; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }
        public int Charm { get; private set; }
        public bool IsDead { get; private set; } = false;

        public Player(string name, string gender, int health,
            int strength, int stamina, int charm)
        {
            Name = name;
            Gender = gender;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            Charm = charm;
        }

        public string GetPlayer()
        {
            return $"{Name} is a {Gender} player with {Health} points of health.";
        }
    }
}
