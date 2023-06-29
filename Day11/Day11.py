clave = {
    '0': 'm',
    '1': 'u',
    '2': 'r',
    '3': 'c',
    '4': 'i',
    '5': 'e',
    '6': 'l',
    '7': 'a',
    '8': 'g',
    '9': 'o'
    }

def dividir_string(string):
    arreglo = list(string)
    return arreglo

def reemplazar_numeros(arreglo):
    resultado = []
    for caracter in arreglo:
        if caracter.isdigit() and (caracter in clave):
            resultado.append(clave[caracter])
        else:
            resultado.append(caracter)
    return resultado

arreglo = dividir_string("T24st5z7 S9y y9 d5 n15v9 H735 t450p9 q15 n9s v509s N9 p92q15 q14527 p529 b15n9 1st5d s450p25 05 q14s9 0as")
resultado = reemplazar_numeros(arreglo)
print(''.join(resultado))