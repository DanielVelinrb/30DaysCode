def formatear_nombre(nombre):
    palabras = nombre.strip().split()
    nombre_formateado = ""

    for palabra in palabras:
        palabra_formateada = palabra.capitalize()
        nombre_formateado += palabra_formateada + " "

    return nombre_formateado