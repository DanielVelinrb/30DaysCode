from itertools import permutations

def generar_palabras(alfabeto):
    permutaciones = permutations(alfabeto, len(alfabeto))
    return [''.join(permutacion) for permutacion in permutaciones]

alfabeto = "ABCDE"

list(map(lambda palabra : print(palabra), generar_palabras(alfabeto)))