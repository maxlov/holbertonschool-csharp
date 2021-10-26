﻿using System;

abstract class Base
{
    public string name { get; set; }

    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}
