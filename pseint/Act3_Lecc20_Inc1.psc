Algoritmo Act3_Lecc20_Inc1
	Definir d Como Real
	Escribir "Digite un numero e la semana"
	Escribir "1 = Lunes"
	Escribir "2 = Martes"
	Escribir "3 = Miercoles"
	Escribir "4 = Jueves"
	Escribir "5 = Viernes"
	Escribir "6 = Sabado"
	Escribir "7 = Domingo"
	Leer d
	Si (d == 1 o d == 2 o d == 3 o d == 4 o d == 5) Entonces
		Escribir "Ese dia es entre semana"
	FinSi
	Si (d == 6 o d == 7) 
		Escribir "Ese dia es fin de semana"
	FinSi
	Si ( d <> 1 y d<> 2 y d<> 3 y d<> 4 y d<>5 y d<> 6 y d<> 7)
		Escribir "Ese dia no existe"
	FinSi
FinAlgoritmo
