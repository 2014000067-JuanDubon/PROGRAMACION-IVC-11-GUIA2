Algoritmo Conversor
	Definir opc Como Entero
	Definir m Como Real
	
	Escribir "1 Pies"
	Escribir "2 Centimetros"
	Escribir "3 Pulgadas"
	
	Escribir Sin Saltar "Opcion: "
	Leer opc
	
	Escribir Sin Saltar "Metros: "
	Leer m
	
	Segun opc Hacer
		1: Escribir m * 3.28
		2: Escribir m * 100
		3: Escribir m * 39.37
		De Otro Modo:
			Escribir "Error"
	FinSegun
FinAlgoritmo