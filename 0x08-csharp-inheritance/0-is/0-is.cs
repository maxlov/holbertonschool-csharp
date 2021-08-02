using System;

/// <summary>Class that holds methods for objects.</summary>
class Obj
{
    /// <summary>Returns true if object is an int.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}
