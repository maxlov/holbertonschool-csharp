using System;

/// <summary>Class that holds methods for objects.</summary>
class Obj
{
    /// <summary>Returns true if type is derived from base type.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
