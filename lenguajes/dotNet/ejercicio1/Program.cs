using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
	    int edad = int.Parse(Console.ReadLine());

	    if (edad >= 18){
		Console.WriteLine("Es mayor");
	    }else{
		Console.WriteLine("Es menor");
	    }
        }
    }
}
