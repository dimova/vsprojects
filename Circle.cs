using System;

public class Circle
{
	public Circle(decimal radius){
		radius = radius;//using Radius before it's declared
	}
	public decimal Radius { get; private set; }
	public decimal Perimeter()
	{
		return 2 * _pi * this.Radius;//using _pi before it's declared
	}
	private const decimal _pi = 3.14159m;
}
