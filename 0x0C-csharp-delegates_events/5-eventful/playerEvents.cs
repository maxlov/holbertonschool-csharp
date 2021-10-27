using System;

/// <summary>Event for hp status.</summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>The current hp.</summary>
    public float currentHp {get; }

    /// <summary>Constructor for CurrentHPArgs class.</summary>
    /// <param name="newHp">Current hp.</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}