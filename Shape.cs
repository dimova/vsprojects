using System;

public class Shape
{
	public virtual int Perimeter()
	{
		return 0;
	}

	public void DisplayShape(Shape shape)
	{
		Console.WriteLine($"Shape Perimeter: {shape.Perimeter()}");
	}
}
