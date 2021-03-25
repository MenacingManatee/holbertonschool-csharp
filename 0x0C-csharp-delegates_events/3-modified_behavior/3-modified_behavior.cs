using System;

/// <summary> Player class </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
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
    public void PrintHealth() {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
    public void TakeDamage(float damage) {
        if (damage <= 0f) {
            damage = 0f;
        }
        float newHp = hp - damage;
        ValidateHP(newHp);
        Console.WriteLine("{0} takes {1} damage!", name, damage);
    }
    public void HealDamage(float heal) {
        if (heal <= 0f) {
            heal = 0f;
        }
        float newHp = hp + heal;
        ValidateHP(newHp);
        Console.WriteLine("{0} heals {1} HP!", name, heal);
    }
    public void ValidateHP(float newHp) {
        if (newHp <= 0) {
            hp = 0;
        }
        else if (newHp >= maxHp) {
            hp = maxHp;
        }
        else {
            hp = newHp;
        }
    }
    public float ApplyModifier(float baseValue, Modifier modifier) {
        if (modifier == Modifier.Weak) {
            return (baseValue * 0.5f);
        }
        else if (modifier == Modifier.Base) {
            return (baseValue);
        }
        else {
            return (baseValue * 1.5f);
        }
    }
}

/// <summary> Value modifier enum </summary>
public enum Modifier {
    /// <summary> Weak == half </summary>
    Weak,
    /// <summary> Base == 1:1 </summary>
    Base,
    /// <summary> Strong == 1.5 </summary>
    Strong
}

/// <summary> Calculate modifier delegate </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);