using System;

namespace dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
	    string name;	    
            Console.Write("Ingrese su nombre: ");
	    name = Console.ReadLine();
	
	    string lower = name.ToLower();

	    if (name == "Pedro"){
		    Console.WriteLine("Su nombre es pedro!");
	    }else{
		    Console.WriteLine("Su NO es pedro");
	    }
        }
    }
}
