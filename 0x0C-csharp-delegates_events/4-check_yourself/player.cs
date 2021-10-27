using System;

/// <summary>Class that holds data for the player.</summary>
public class Player
{
    string name {get; set;}
    float maxHp {get; set;}
    float hp {get; set;}

    private string status {get; set;}

    /// <summary>HPCheck event.</summary>
    public EventHandler<CurrentHPArgs> HPCheck;

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
        status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>Prints current health.</summary>
    public void PrintHealth() => Console.WriteLine($"{name} has {hp} / {maxHp} health");

    /// <summary>Checks status</summary>
    /// <param name="sender">What sent the event</param>
    /// <param name="e">HP event</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= maxHp / 2)
            status = $"{name} is doing well!";
        else if (e.currentHp >= maxHp / 4)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0)
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";
        Console.WriteLine(status);
    }

    /// <summary>Damages player.</summary>
    /// <param name="damage">Value to damage player by.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        float newHp = hp;
        newHp -= damage;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(newHp);
    }

    /// <summary>Heals player.</summary>
    /// <param name="heal">Value to heal player by.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        float newHp = hp;
        newHp += heal;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(newHp);
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
        HPCheck?.Invoke(this, new CurrentHPArgs(this.hp));
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