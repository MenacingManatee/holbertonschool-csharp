using System;

/// <summary> Player class for delegates </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary> Constructor for player. Required: string name, float max HP </summary>
    public Player(string name="Player", float maxHp=100f) {
        if (maxHp <= 0f) {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    /// <summary> Prints player health as formatted string </summary>
    public void PrintHealth() {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// <summary> Assigns damage to instance of player class </summary>
    public void TakeDamage(float damage) {
        if (damage <= 0f) {
            damage = 0f;
        }
        Console.WriteLine("{0} takes {1} damage!", name, damage);
    }

    /// <summary> Removes damage from instance of player class </summary>
    public void HealDamage(float heal) {
        if (heal <= 0f) {
            heal = 0f;
        }
        Console.WriteLine("{0} heals {1} HP!", name, heal);
    }
}
