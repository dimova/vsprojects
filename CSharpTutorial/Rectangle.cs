using System;

public class Rectangle : Shape
{
	public int Height { get; set; }
	public int Width { get; set; }
	public override int Perimeter()
	{
		return (Height + Width) * 2;
	}
}


