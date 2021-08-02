using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Globalization;

/// <summary>Class that holds methods for objects.</summary>
class Obj
{
    /// <summary>Prints properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        IEnumerable<MethodInfo> mList = t.GetMethods();

        StringBuilder sb = new StringBuilder();
        
        sb.Append($"{t.Name} Properties:");
        foreach (PropertyInfo p in pList)
        {

            sb.Append("\n" + p.Name);
        }
        sb.Append($"\n{t.Name} Methods:");
        foreach (MethodInfo m in mList)
        {
            sb.Append("\n" + m.Name);
        }
        
        Console.WriteLine(sb.ToString());
    }
}
