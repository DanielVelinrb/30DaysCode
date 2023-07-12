import random

def seleccionar_palabra():
    palabras = ["python", "programacion", "panteras", "ahorcado", "jexdev", "pizza", "animal", "compiladores", "azure"]
    return random.choice(palabras)

def mostrar_tablero(palabra, letras_adivinadas, intentos):
    ahorcado = [
        "     +---+",
        "     |   |",
        "     {}   |".format("O" if intentos <= 5 else " "),
        "    {}{}{}  |".format("/" if intentos <= 4 else " ", "|" if intentos <= 3 else " ", "\\" if intentos <= 2 else " "),
        "    {}{}   |".format("/" if intentos <= 1 else " ", "\\" if intentos <= 0 else " "),
        "         |",
        "========="
    ]

    for linea in ahorcado:
        print(linea)

    print()

    for letra in palabra:
        if letra in letras_adivinadas:
            print(letra, end=" ")
        else:
            print("_", end=" ")
    print("\n")

def pedir_letra():
    letra = input("Ingresa una letra: ")
    return letra.lower()

def jugar_ahorcado():
    palabra = seleccionar_palabra()
    letras_adivinadas = []
    intentos = 6

    print("¡Bienvenido al juego del ahorcado!")
    mostrar_tablero(palabra, letras_adivinadas, intentos)

    while True:
        letra = pedir_letra()

        if letra in letras_adivinadas:
            print("Ya has ingresado esa letra. Intenta con otra.")
            continue

        letras_adivinadas.append(letra)

        if letra == palabra:
            print("¡Ganaste! Adivinaste la palabra correctamente.")
            break

        if letra in palabra:
            print("¡Correcto! La letra está en la palabra.")
        else:
            intentos -= 1
            print("Incorrecto. La letra no está en la palabra.")
            print("Te quedan {} intentos.".format(intentos))

        mostrar_tablero(palabra, letras_adivinadas, intentos)

        if intentos == 0:
            print("¡Perdiste! La palabra correcta era '{}'.".format(palabra))
            break

        if all(letra in letras_adivinadas for letra in palabra):
            print("¡Ganaste! Adivinaste la palabra correctamente.")
            break

jugar_ahorcado()