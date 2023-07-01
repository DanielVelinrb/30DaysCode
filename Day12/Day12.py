
def misma_cantidad_caracteres(str1, str2):
    caracteres_str1 = list(str1)
    caracteres_str2 = list(str2)

    if len(caracteres_str1) != len(caracteres_str2):
        return False

    for char in caracteres_str1:
        if char not in caracteres_str2:
            return False

    for char in caracteres_str2:
        if char not in caracteres_str1:
            return False

    for i in range(len(caracteres_str1)):
        if caracteres_str1[i] == caracteres_str2[i]:
            return False

    return True

cadena1 = "hola"
cadena2 = "oahl"
resultado = misma_cantidad_caracteres(cadena1, cadena2)
print(resultado)