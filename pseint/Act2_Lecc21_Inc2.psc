Algoritmo Act2_Lecc21_Inc2
	Definir n Como Real
	Escribir "Escriba un numero"
	Escribir "Escriba 1 para ventas"
	Escribir "Escriba 2 para Recepcion"
	Escribir "Escriba 3 para Direccion"
	Escribir "Escriba 4 para Compras"
	Escribir "Escriba 5 para Gerencia"
	Leer n
	Si (n = 1) Entonces
		Escribir "Bienvenido al Departamento de Ventas"
		Escribir "Acargo de: Joaquin Menocal"
		Escribir "jmenocal@gmail.ventas"
	FinSi
	Si (n = 2) Entonces
		Escribir "Bienvenido al Departamento de Recepcion"
		Escribir "Acargo de: Jose Portillo"
		Escribir "jportillo@gmail.recp"
	FinSi
	Si (n = 3) Entonces
		Escribir "Bienvenido al Departamento de Direccion"
		Escribir "Acargo de: Javier Lobos"
		Escribir "jlobos@gmail.dircc"
	FinSi
	Si (n = 4) Entonces
		Escribir "Bienvenido al Departamento de Compras"
		Escribir "Acargo de: Francisco Gil"
		Escribir "fgil@gmail.compras"
	FinSi
	Si (n = 5) Entonces
		Escribir "Bienvenido al Departamento de Gerencia"
		Escribir "Acargo de: Diego Chocochic"
		Escribir "dchocochic@gmail.gerencia"
	FinSi
	Si ( n<>1 y n<>2 y n<>3 y n<>4 y n<>5) Entonces
		Escribir "Este Departamento no existe intentelo mas tarde"
	FinSi
FinAlgoritmo
