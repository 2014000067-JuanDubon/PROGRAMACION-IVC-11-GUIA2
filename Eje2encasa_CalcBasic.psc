Algoritmo CalcBasic
	Definir opc Como Entero
	Definir num1, num2 Como Entero
	
	Escribir "****************************"
	Escribir "*     MENU DE OPCIONES     *"
	Escribir "****************************"
	Escribir "1-Suma."
	Escribir "2-Resta."
	Escribir "3-Multiplicacion."
	Escribir "4-Division."
	
	Escribir Sin Saltar"Digite la opcion:"
	Leer opc 
	Escribir"Digite dos valores numericos"
	Leer num1
	Leer num2
	
	Segun opc Hacer
		1:
			Escribir "La suma es",(num1+num2)
		2:
			Escribir "La resta es",(num1-num2)
		3:
			Escribir "La multiplicación es",(num1*num2)
		4:
			Escribir "La division es",(num1/num2)
		De Otro Modo:
			Escribir "Error  al operar los numeros"
	Fin Segun
FinAlgoritmo
