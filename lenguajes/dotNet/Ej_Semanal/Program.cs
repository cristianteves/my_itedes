using System;

namespace Ej_Semanal
{
    class Program
    {
        static void Main(string[] args)
        {
            
		Console.WriteLine("Ingrese numero de dia: ");
	    	
		int dia = int.Parse(Console.ReadLine());
	    	String respuesta;

	    	switch(dia){
		    case 1:
			    respuesta = "Lunes";
			    break;
		    case 2:
			    respuesta = "Martes";
			    break;
		    case 3:
			    respuesta = "Miercoles";
			    break;
		    case 4:
			    respuesta = "Jueves";
			    break;
		    case 5:
			    respuesta = "Viernes";
			    break;
		    case 6:
			    respuesta = "Sabado";
			    break;
		    case 7:
			    respuesta = "Domingo";
			    break;
		    default:
			    respuesta = "Invalido";
			    break;
		}
		Console.WriteLine(respuesta);
        }
    }
}
