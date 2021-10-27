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
}