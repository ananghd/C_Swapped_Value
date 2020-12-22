using System;
					
public class Program
{
	public static void Main()
	{
		int a = 10;
		int b = 7;
    		Console.WriteLine("Before Values");
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
		a = a + b;
		b = a - b;
		a = a - b;
		Console.WriteLine("After Swapped Values");
		Console.WriteLine("a = " + a);
		Console.WriteLine("b = " + b);
	}
}
