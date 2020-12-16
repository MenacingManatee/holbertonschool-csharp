using System;

namespace Enemies
{
    /// <summary>
    /// Main class for zombie enemy
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie health stat
        /// </summary>
        public int health;

        /// <summary>
        /// Zombie constructor
        /// Allows variable health stat with validator
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}
