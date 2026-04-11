Algoritmo Estadio
	Definir opc, cant Como Entero
	
	Escribir "1 Palco"
	Escribir "2 Tribuna"
	Escribir "3 Preferencia"
	Escribir "4 General"
	
	Escribir Sin Saltar "Opcion: "
	Leer opc
	
	Escribir Sin Saltar "Cantidad: "
	Leer cant
	
	Segun opc Hacer
		1: Escribir cant * 300
		2: Escribir cant * 100
		3: Escribir cant * 50
		4: Escribir cant * 30
		De Otro Modo:
			Escribir "Error"
	FinSegun
FinAlgoritmo