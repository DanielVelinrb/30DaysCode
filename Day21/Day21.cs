using static System.Console;

namespace Dia21{
    class Day21{

        static void Main(string [] args){

            int [,] numeros = new int[,]{{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}};
            int [,] transpuesta = new int[numeros.GetLength(1) , numeros.GetLength(0)];

            WriteLine("Matriz original: ");
            for(int i = 0; i < numeros.GetLength(0); i++){
                for(int j = 0; j < numeros.GetLength(1); j++){
                    transpuesta[j, i] = numeros[i, j];
                    Write(numeros[i, j] + " ");
                }
                WriteLine();
            }

            WriteLine("\nMatriz transpuesta: ");
            for(int i = 0; i < transpuesta.GetLength(0); i++){
                for(int j = 0; j < transpuesta.GetLength(1); j++){
                    Write(transpuesta[i, j] + " ");
                }
                WriteLine();
            }
        }
    }  
}