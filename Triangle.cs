using System;

public class Triangle:Shape
{
	public int Side1 { get; set; }
	public int Side2 { get; set; }
	public int Side3 { get; set; }

	public override int Perimeter()
	{
		return Side1 + Side2 + Side3;
	}
}
