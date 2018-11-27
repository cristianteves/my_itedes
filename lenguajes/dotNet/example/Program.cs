using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los primeros 3 numeros");

			int a, b, c;
			int mayor = 0, medio = 0, menor = 0;

			a = Int32.Parse(Console.ReadLine());
			b = Int32.Parse(Console.ReadLine());
			c = Int32.Parse(Console.ReadLine());

      if(a > b && a > c) {
    mayor = a;
    if(b > c) {
        medio = b;
        menor = c;
    }else {
        medio = c;
        menor = b;
    }
}
else if(b > a && b > c) {
    mayor = b;
    if(a > c) {
        medio = a;
        menor = c;
    }else {
        medio = c;
        menor = a;
    }
}
else {
    mayor = c;
    if(b > a) {
        medio = b;
        menor = a;
    }else {
        medio = a;
        menor = b;
    }
}

			Console.Write("Orden: " + mayor + " - " + medio + " - " + menor);
    }
	}
}
