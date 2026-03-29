Algoritmo Act2_Lecc7_Inc3
	Escribir "Meses del Año"
	Definir M Como Real
	Escribir "Escriba el numero que corresponda al mes"
	Escribir "1 = Enero"
	Escribir "2 = Febrero"
	Escribir "3 = Marzo"
	Escribir "4 = Abril"
	Escribir "5 = Mayo"
	Escribir "6 = Junio"
	Escribir "7 = Julio"
	Escribir "8 = Agosto"
	Escribir "9 = Septiembre"
	Escribir "10 = Octubre"
	Escribir "11 = Noviembre"
	Escribir "12 = Diciembre"
	Leer M
	Si (M = 1) Entonces
		Escribir "Es Enero"
	FinSi
	Si (M = 2) Entonces
		Escribir "Es Febrero"
	FinSi
	Si (M = 3) Entonces
		Escribir "Es Marzo"
	FinSi
	Si (M = 4) Entonces
		Escribir "Es Abril"
	FinSi
	Si (M = 5) Entonces
		Escribir "Es Mayo"
	FinSi
	Si (M = 6) Entonces
		Escribir "Es Junio"
	FinSi
	Si (M = 7) Entonces
		Escribir "Es Julio"
	FinSi
	Si (M = 8) Entonces
		Escribir "Es Agosto"
	FinSi
	Si (M = 9) Entonces
		Escribir "Es Septiembre"
	FinSi
	Si (M = 10) Entonces
		Escribir "Es Octubre"
	FinSi
	Si (M = 11) Entonces
		Escribir "Es Noviembre"
	FinSi
	Si (M = 12) Entonces
		Escribir "Es Diciembre"
	FinSi
	Si ( M<> 1 y  M<> 2 y M<> 3 y M<> 4 y M<> 5 y M<> 6 y M<> 7 y M<> 8 y M<> 9 y M<> 10 y M<> 11 y M<> 12) Entonces
		Escribir "No existe ese mes"
	FinSi
FinAlgoritmo
