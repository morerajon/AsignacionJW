#Resolver el siguiente ejercicio de programación
# El empleado llamado Juan cobró 300 dólares por mes desde enero a junio, 500 dólares de julio a octubre, 
# y 700 dólares por mes en noviembre y en diciembre. 
# En base al escenario propuesto, se le solicita a los estudiantes que creen un pequeño
# programa que calcule el sueldo promedio del empleado Juan. Además, se debe indicar sí Juan 
# se encuentra cobrando un sueldo bajo, normal o mejor de lo normal, considerando las siguientes pautas:

# a. Sueldo bajo: por debajo de 300 dólares.

# b. Sueldo normal:  entre 300 a 900.

# c. Sueldo mejor de lo normal: más de 900 dólares.

#Tip: se debe utilizar estructuras condicionales.

sueldos = [300, 300, 300, 300, 300, 300, 500, 500, 500, 500, 700, 700]

sueldoProm =sum(sueldos)/len(sueldos)

print("El sueldo promedio de Juan es "+ str(sueldoProm)+ " dólares.")



if (sueldoProm<300):
  print("Juan se encuentra cobrando un sueldo bajo")
elif(300<sueldoProm<900):
  print("Juan se encuentra cobrando un sueldo normal")
else:
  print("Juan se encuentra cobrando un sueldo mejor de lo normal")


