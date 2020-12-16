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
        /// Private variable for zombie name
        private string name = "(No name)";

        /// <summary>
        /// Base Zombie constructor
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Zombie constructor with variable health
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>
        /// Returns zombie health
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

        /// <summary>
        /// Override for .ToString method
        /// </summary>
        public override string ToString() {
            return String.Format("Zombie name: {0} / Total Health: {1}", this.name, this.health);
        }
    }
}
