using System;

/// <summary>Class implementing a queue.</summary>
class Queue<T>
{
    /// <summary>Returns this queue's type.</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
