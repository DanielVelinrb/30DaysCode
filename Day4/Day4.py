import re

def obtener_numeros(texto):
    numeros = []
    rangos = texto.split(',')
    for rango in rangos:
        limites = re.findall(r'\d+', rango)
        if len(limites) == 2:
            inicio = int(limites[0])
            fin = int(limites[1])
            numeros.extend(num for num in range(
                            inicio, fin + 1)
                          if num % 2 == 0)
        elif len(limites) == 1:
            numero = int(limites[0])
            if numero % 2 == 0:
                numeros.append(numero)
        print(sum(numeros))
        numeros.clear()

print("*****************Limites*****************")
print("Ingrese el o los rangos del limite ")
texto = input()

print("La suma de los rangos dados da:", obtener_numeros(texto))