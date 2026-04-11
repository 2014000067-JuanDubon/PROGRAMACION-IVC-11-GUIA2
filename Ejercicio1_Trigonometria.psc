Algoritmo Trigonometria
	Definir opc Como Entero
	Definir ang Como Real
	
	Escribir "1 Seno"
	Escribir "2 Coseno"
	Escribir "3 Tangente"
	
	Escribir Sin Saltar "Opcion: "
	Leer opc
	
	Escribir Sin Saltar "Angulo: "
	Leer ang
	
	Segun opc Hacer
		1: Escribir Sen(ang * PI / 180)
		2: Escribir Cos(ang * PI / 180)
		3: Escribir Tan(ang * PI / 180)
		De Otro Modo:
			Escribir "Error"
	FinSegun
FinAlgoritmo