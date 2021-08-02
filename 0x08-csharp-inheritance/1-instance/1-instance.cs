using System;

/// <summary>Class that holds methods for objects.</summary>
class Obj
{
    /// <summary>Returns true if object is in inheritance tree of array.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
