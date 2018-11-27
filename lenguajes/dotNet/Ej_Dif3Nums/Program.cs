using System;

namespace Ej_Dif3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ingrese los primeros 3 numeros");

	    	int tmp, mayor, medio, menor;

	    	Console.Write("Ingrese nro1: ");
	    	mayor = Int32.Parse(Console.ReadLine());
    	    

	    	Console.Write("Ingrese nro2: ");
	    	tmp = Int32.Parse(Console.ReadLine());

			if(tmp > mayor) {
				medio = mayor;
				mayor = tmp;
			} else {
				medio = tmp;
			}

		
	    	Console.Write("Ingrese nro3: ");
	    	tmp = Int32.Parse(Console.ReadLine());

			if(tmp <= medio) {
				menor = tmp;
			} else if(tmp < mayor && tmp > medio) {
				menor = medio;
				medio = tmp;
			} else {
				menor = medio;
				medio = mayor;
				mayor = tmp;
			}


			Console.WriteLine(menor.ToString());
			Console.WriteLine(medio.ToString());
			Console.WriteLine(mayor.ToString());
        }
    }
}
