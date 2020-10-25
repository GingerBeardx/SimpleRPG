namespace Engine
{
    public class Player
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Charm { get; set; }
        public bool IsDead { get; set; } = false;

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
