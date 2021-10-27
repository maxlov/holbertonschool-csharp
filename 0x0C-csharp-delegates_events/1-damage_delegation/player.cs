using System;

/// <summary>Class that holds data for the player.</summary>
public class Player
{
    string name {get; set;}
    float maxHp {get; set;}
    float hp {get; set;}

    /// <summary>Player constructor.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>Calculates player health.</summary>
    /// <param>Value to change health.</param>
    public delegate void CalculateHealth(float value);

    /// <summary>Damages player.</summary>
    /// <param>Value to damage player by.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        hp -= damage;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>Heals player.</summary>
    /// <param>Value to heal player by.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        hp += heal;
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// <summary>Prints current health.</summary>
    public void PrintHealth() => Console.WriteLine($"{name} has {hp} / {maxHp} health");
}