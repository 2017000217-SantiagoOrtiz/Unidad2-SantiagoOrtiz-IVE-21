Algoritmo MensajedeVoz
	Escribir "Mensaje De Voz"
	Definir opc Como Entero
	
	Escribir "Menu Principal"
	Escribir "1-Recepcion"
	Escribir "2-Vigilacia"
	Escribir "3-Mantenimiento"
	Escribir "4-Salir"
	Escribir Sin Saltar "Digite una opcion:"
	Leer opc
	
	si(opc == 1)Entonces
		Escribir "Bienvenido al Dep. de Recepcion"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si(opc == 2)Entonces
		Escribir "Bienvenido al Dep. de Seguridad"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si(opc == 3)Entonces
		Escribir "Bienvenido al Dep. de Mantenimiento"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	si(opc <> 1 y opc <> 2 y opc <> 3)Entonces
		Escribir "Salir del Sistema"
		Escribir "Presione una tecla para salir"
		Esperar Tecla
		Limpiar Pantalla
		Esperar 3 Segundos
	FinSi
	
	
FinAlgoritmo
