using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string newName, float newAge, string newOwner, Rating newRating)
    {
        name = newName;
        age = newAge;
        owner = newOwner;
        rating = newRating;
    }

    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}
