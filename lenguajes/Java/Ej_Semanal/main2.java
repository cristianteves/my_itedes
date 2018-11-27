import java.util.Scanner;

public class main2{
	public static void main(String args[]){
		Scanner input = new Scanner(System.in);

		System.out.print("Ingrese un numero de dia: ");

		Integer dia = Integer.parseInt(input.nextLine());

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
				respuesta = "Numero invalido";
				break;
		}
	System.out.println(respuesta);
	}
}
