equivalencias = {
    '1': 1000,     #kilo
    '2': 1,           #m
    '3': 0.01,    #centi
    '4': 0.001,    #mili
    '5': 1609.34,  #milla
    '6': 0.9144,  #yarda
    '7': 0.3048,    #pie
    '8': 0.0254,#pulgada
    }

def conversor_Unidades(valor, origen, destino):
    metros = valor * equivalencias[origen]
    resultado = metros / equivalencias[destino]
    return resultado

print("*****************Conversor de Unidades*****************")
print("Escoja la unidad de medida de origen")
print("1.Kilometro")
print("2.Metro")
print("3.Centimetro")
print("4.Milimetro")
print("5.Milla")
print("6.Yarda")
print("7.Pie")
print("8.Pulgada")
origen = input()

print("*****************Conversor de Unidades*****************")
print("Escoja la unidad de medida de destino")
print("1.Kilometro")
print("2.Metro")
print("3.Centimetro")
print("4.Milimetro")
print("5.Milla")
print("6.Yarda")
print("7.Pie")
print("8.Pulgada")
destino = input()

print("*****************Conversor de Unidades*****************")
print("Ingrese el numero a convertir")
valor = float(input())

resultado = conversor_Unidades(valor, origen, destino)
print(resultado)