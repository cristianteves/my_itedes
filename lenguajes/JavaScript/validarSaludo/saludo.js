function validar(){

	const valueUser = document.getElementById("user").value;
	const user = valueUser.toUpperCase();
	const message = document.getElementById("message");

	if (user == 'pedro'){
		message.innerHTML = `Hola '${valueUser}'`;
	}else{
		message.innerHTML = `Usted no es pedro, usted es '${valueUser}'`;
	}
}
