﻿using System;

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
        Console.WriteLine("{0} takes {1} damage!", name, damage);
    }
    public void HealDamage(float heal) {
        if (heal <= 0f) {
            heal = 0f;
        }
        Console.WriteLine("{0} heals {1} HP!", name, heal);
    }
}
