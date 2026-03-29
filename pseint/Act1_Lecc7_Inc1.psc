Algoritmo Act1_Lecc7_Inc1
	Definir Mat Como Caracter
	Definir n1,n2,n3,n4,n5,nt Como Real
	Escribir "Digame una Materia"
	Leer Mat
	Escribir "Digame sus notas"
	Leer n1
	Leer n2
	Leer n3
	leer n4
	Leer n5
	nt = (n1+n2+n3+n4+n5)/5
	Escribir "La materia es:",Mat
	Escribir "La nota es:",nt
	si (nt >= 70) Entonces
		Escribir "El estudiante aprobo"
	SiNo
		Escribir "El estudiante reprobo"
	FinSi
	
FinAlgoritmo
