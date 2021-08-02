using System;


/// <summary>Basic shape class.</summary>
class Shape
{
    /// <summary>Finds area of shape.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Rectangle class.</summary>
class Rectangle : Shape
{
    /// rect width
    private int width;
    /// rect height
    private int height;

    /// <summary>Width getter and setter.</summary>
    public int Width 
    {
        get { return width; }
        set 
        { 
            if (value < 0 )
                throw new ArgumentException("Width must be greater than or equal to 0.");
            else
                width = value;
        }
    }

    /// <summary>Height getter and setter.</summary>
    public int Height
    {
        get { return height; }
        set 
        {
            if (value < 0 )
                throw new ArgumentException("Height must be greater than or equal to 0.");
            else
                height = value; 
        }
    }

    /// <summary>Finds area of rectangle.</summary>
    public new int Area()
    {
        return this.Width * this.Height;
    }

    /// <summary>Return string representation of rectangle.</summary>
    public override string ToString()
    {
        return $"[{this.GetType().Name}] {this.Width} / {this.Height}";
    }
}

/// <summary>Square class.</summary>
class Square : Rectangle
{
    /// square size
    private int size;

    /// <summary>Size getter and setter.</summary>
    public int Size 
    {
        get { return size; }
        set 
        { 
            if (value < 0 )
                throw new ArgumentException("Size must be greater than or equal to 0.");
            else
                size = Height = Width = value;
        }
    }
}