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

    /// <summary>Prints current health.</summary>
    public void PrintHealth() => Console.WriteLine($"{name} has {hp} / {maxHp} health");

    /// <summary>Damages player.</summary>
    /// <param name="damage">Value to damage player by.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        float newHp = hp;
        newHp -= damage;
        ValidateHP(newHp);
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>Heals player.</summary>
    /// <param name="heal">Value to heal player by.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        float newHp = hp;
        newHp += heal;
        ValidateHP(newHp);
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// <summary>Validates new hp value before setting it.</summary>
    /// <param name="newHp">Value of newHp.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            newHp = 0;
        else if (newHp > maxHp)
            newHp = maxHp;
        hp = newHp;
    }

    /// <summary>Applies modifier to value.</summary>
    /// <param name="baseValue">Value to be modified.</param>
    /// <param name="modifier">Modifier.</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

}