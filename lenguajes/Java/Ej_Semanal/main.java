import java.util.Scanner;

public class main {
	public static void main(String args[]){
		Scanner input = new Scanner(System.in);

		System.out.println("Ingrese un numero de dia: ");
		
		Integer dia = Integer.parseInt(input.nextLine());

		String respuesta;

		if (dia == 1){
			respuesta = "Lunes";	
		}else if(dia == 2){
			respuesta = "Martes";
		}else if(dia == 3){
			respuesta = "Miercoles";
		}else if(dia == 4){
			respuesta = "Jueves";
		}else if(dia == 5){
			respuesta = "Viernes";
		}else if(dia == 6){
			respuesta = "Sabado";
		}else if(dia == 7){
			respuesta = "Domingo";
		}else{
			respuesta = "Numero invalido";
		}
		System.out.println(respuesta);
	}
}
