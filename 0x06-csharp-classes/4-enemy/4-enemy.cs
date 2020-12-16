using System;

namespace Enemies
{
    /// <summary>
    /// Main class for zombie enemy
    /// </summary>
    public class Zombie
    {
        /// Private stat for zombie health
        private int health;
        /// Private string for zombie name
        private string name = "(No name)";

        /// <summary>
        /// Zombie constructor with no health set
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Zombie constructor that allows for variable health stat
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>
        /// Returns health of zombie
        /// </summary>
        public int GetHealth()
        {
            return this.health;
        }

        /// <summary>
        /// Getter/setter for zombie name
        /// </summary>
        public string Name {
            get => name;
            set {
                name = value;
            }
        }
    }
}
