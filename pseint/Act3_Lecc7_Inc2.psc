Algoritmo Act3_Lecc7_Inc2
	Definir L1,L2,L3 Como Real
	Escribir "Digame los lados del triangulo"
	Leer L1
	Leer L2
	Leer L3
	Si (L1=L2 Y L1=L3) Entonces
		Escribir "El triangulo es Equilatero"
	SiNo
		Si (L1<>L2 Y L1=L3 O L1=L2 Y L1<>L3 O L2=L3) Entonces
			Escribir "El triangulo es Isosceles"
		SiNo
			Escribir "El triangulo es Escaleno"
		FinSi
	FinSi

	
FinAlgoritmo
