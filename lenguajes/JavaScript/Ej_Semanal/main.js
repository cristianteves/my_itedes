function validarDiaSemanal(){
	var dia = document.getElementById('dia').value;
	var respuesta = '';
	console.log(dia);
	switch(dia){
		case '1':
			respuesta = "Lunes";
			break;
		case '2':
			respuesta = "Martes";
			break;
		case '3':
			respuesta = "Miercoles";
			break;
		case '4':
			respuesta = "Jueves";
			break;
		case '5':
			respuesta = "Viernes";
			break;
		case '6':
			respuesta = "Sabado";
			break;
		case '7':
			respuesta = "Domingo";
			break;
		default:
			respuesta = "Invalido";
			break;
	}
	alert(respuesta);
}
