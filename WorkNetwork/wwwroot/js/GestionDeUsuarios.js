﻿function loginEmpresa(){	
			event.preventDefault();
			let correoEmpresa =	$('#correoEmpresa').val();
			let passEmpresa = $('#passwordEmpresa').val();
			let url = '../../GestionDeUsuarios/Ingresar';
			let data = { email: correoEmpresa, password:passEmpresa };
	$.post(url, data).done(resultado => {
		resultado ? window.location.href='/' : alert('usuario o contraseña incorrecta')
			}).fail(e => console.log(e))
		}
function register() {
	event.preventDefault();
	let correo = $('#Email').val();
	let pass = $('#Password').val();
	let passConfirm = $('#ConfirmPassword').val();
	let url = '../../GestionDeUsuarios/Registrar';
	let data = { email: correo, password: pass }
	if (pass === passConfirm) {
		$.post(url, data).done(resultado => resultado ? window.location.href='/' : alert('usuario o contraseña incorrecta')).fail(e => console.log(e))
	} else {
		alert('las contraseñas no coinciden')
    }
	
}