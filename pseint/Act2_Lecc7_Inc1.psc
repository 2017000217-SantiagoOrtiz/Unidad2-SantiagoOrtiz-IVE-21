Algoritmo Act2_Lecc7_Inc1
	Escribir "Mensajed de voz"
	Definir opc Como Real
	Escribir "Coloque un numero"
	Escribir "Coloque 1 para llamar a Provedores"
	Escribir "Coloque 2 para llamar a Atencion al Cliente"
	Escribir "Coloque 3 para llamar a Gerencia"
	Escribir "Coloque 4 para llamar a Servicio e Marketing"
	Escribir "Coloque cualquier numero para Salir"
	Leer  opc
	Si (opc == 1) Entonces
		Escribir "Llamando a Provedores"
	FinSi
	si (opc == 2) Entonces
		Escribir "Llamando a Atencion al cliente"
	FinSi
	si (opc == 3) Entonces
		Escribir "Llamando a Gerencia"
	FinSi
	si (opc == 4) Entonces
		Escribir "Llamando Servicio al cliente"
	FinSi
	si (opc <> 1 y opc <> 2 y opc <> 3 y opc <> 4) Entonces
		Escribir "Saliendo del Mensaje"
	FinSi
	
FinAlgoritmo
