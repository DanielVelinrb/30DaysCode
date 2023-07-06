import re
def validar_numero_romano(numero):
    # Expresión regular para validar un número romano válido
    patron = r'^(M{0,3})(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$'

    if re.match(patron, numero):
        return True
    else:
        return False
print(validar_numero_romano('CDXXI'))  # True