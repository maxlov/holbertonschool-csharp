using System;

/// <summary>Different modifiers.</summary>
public enum Modifier 
{ 
    /// <summary>Weak multiplier of 0.5</summary>
    Weak, 
    /// <summary>Base multiplier of 1.0</summary>
    Base, 
    /// <summary>Strong multiplier of 1.5</summary>
    Strong
}

/// <summary>Delegate for calculating modifier to values.</summary>
/// <param name="baseValue">Value to be modified.</param>
/// <param name="modifier">Modifier.</param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Delegate for calculating player health methods.</summary>
/// <param>Value to change health.</param>
public delegate void CalculateHealth(float value);