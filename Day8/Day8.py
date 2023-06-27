def contar_palabras(cadena):

    cadena = cadena.strip()
    if(len(cadena) == 0):
        return 0

    cantidad_palabras = 1
    validador = 0
    for caracter in cadena:
        if caracter == ' ' and validador == 0:
            cantidad_palabras += 1
            validador = 1
        elif caracter != ' ':
            validador = 0
    return cantidad_palabras
