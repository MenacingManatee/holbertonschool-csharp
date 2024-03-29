﻿using System;

/// <summary> Player class for delegates </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = String.Format("{0} is ready to go!", this.name);
        this.HPCheck += CheckStatus;
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
        float newHp = hp - damage;
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(newHp);
    }

    /// <summary> Removes damage from instance of player class </summary>
    public void HealDamage(float heal) {
        if (heal <= 0f) {
            heal = 0f;
        }
        float newHp = hp + heal;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(newHp);
    }

    /// <summary> Validates HP of player, ensuring it doesn't go below 0 or above the max </summary>
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
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary> Applies a modifier to an input value using enum Modifier </summary>
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

    /// <summary> Prints a string describing the object's current health </summary>
    private void CheckStatus(object sender, CurrentHPArgs e) {
        if (e.currentHp == maxHp) {
            this.status = String.Format("{0} is in perfect health!", name);
        }
        else if (e.currentHp >= maxHp * 0.5f) {
            this.status = String.Format("{0} is doing well!", name);
        }
        else if (e.currentHp >= maxHp * 0.25f) {
            this.status = String.Format("{0} isn't doing too great...", name);
        }
        else if (e.currentHp > 0) {
            this.status = String.Format("{0} needs help!", name);
        }
        else {
            this.status = String.Format("{0} is knocked out!", name);
        }
        Console.WriteLine(this.status);
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

class CurrentHPArgs : EventArgs {
    public float currentHp {get;}

    public CurrentHPArgs(float newHp) {
        currentHp = newHp;
    }
}