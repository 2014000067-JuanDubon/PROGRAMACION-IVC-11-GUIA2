Algoritmo Impresoras
	Definir opc, cant Como Entero
	
	Escribir Sin Saltar "Cantidad: "
	Leer cant
	
	Escribir "1 Efectivo"
	Escribir "2 Tarjeta"
	Escribir "3 Vale"
	
	Escribir Sin Saltar "Opcion: "
	Leer opc
	
	Segun opc Hacer
		1: Escribir cant * 650 * 1.12 * 0.90
		2: Escribir cant * 650 * 1.12 * 0.95
		3: Escribir cant * 650 * 1.12 * 0.85
		De Otro Modo:
			Escribir "Error"
	FinSegun
FinAlgoritmo