using System;

namespace Enemies
{
    
    ///<summary>Represents an enemy of type Zombie.</summary>
    public class Zombie
    {
        ///<summary>Represents remaining health of a Zombie.</summary>
        public int health;

        ///<summary>Constructs a Zombie instance</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>Constructs a Zombie instance with a value</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
