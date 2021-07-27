using System;

namespace Enemies
{
    
    ///<summary>Represents an enemy of type Zombie.</summary>
    public class Zombie
    {
        ///<summary>Represents remaining health of a Zombie.</summary>
        private int health;
        private string name = "(No name)";

        ///<summary>Private field name getter and setter.</summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        ///<summary>Constructs a Zombie instance.</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>Constructs a Zombie instance with a value.</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        ///<summary>Gets health of zombie instance.</summary>
        public int GetHealth()
        {
            return this.health;
        }

        ///<summary>Overides default ToString.</summary>
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}
