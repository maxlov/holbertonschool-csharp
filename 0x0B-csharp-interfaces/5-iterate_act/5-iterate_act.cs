using System;
using System.Collections.Generic;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string doorName = "Door")
    {
        name = doorName;
    }

    public void Interact() 
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact() 
    {
        if (durability < 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}

class Key : Base, ICollectable
{    
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    public void Collect()
    {
        if (!isCollected)
        {
            Console.WriteLine($"You pick up the {name}.");
            isCollected = true;
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive)
                ((IInteractive)obj).Interact();
            else if (type == typeof(IBreakable) && obj is IBreakable)
                ((IBreakable)obj).Break();
            else if (type == typeof(ICollectable) && obj is ICollectable)
                ((ICollectable)obj).Collect();
        }
    }
}