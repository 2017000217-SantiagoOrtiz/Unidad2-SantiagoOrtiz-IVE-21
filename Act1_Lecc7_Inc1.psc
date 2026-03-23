Algoritmo AprubReprb
	Definir n1,n2,n3,n4,n5,nt Como Real
	Definir Materia Como Caracter
	Escribir "Dijite La Materia:"
	Leer Materia
	Escribir "Digite 5 notas:"
	Leer n1
	Leer n2
	Leer n3
	Leer n4
	Leer n5
	
	nt= (n1+n2+n3+n4+n4)/5
	Escribir "La Materia es:",Materia
	Escribir "El Promedio es de:",nt
	
	si (nt>=70) Entonces
		Escribir "Aprobo la Materia"
	SiNo
	    Escribir "Reprobo la Materia"
	FinSi

FinAlgoritmo
