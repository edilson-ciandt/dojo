using System;

class Hello {

	public static void Main() {
		Console.WriteLine("Hello World");
		
		Calculadora calc=new Calculadora();
		Console.WriteLine("3+4={0}", calc.add(3,4));
		
	}
}