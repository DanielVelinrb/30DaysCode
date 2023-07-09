using static System.Console;

namespace Dia20{
    class Dia20{
        static void Main(string [] args){
            int [] numeros = new int[]{0, 1, 2, 3, 4, 5, 7, 8, 9, 10};
            int n = numeros.Length + 1;
            int sumatoria = n * (numeros[0] + numeros[n - 2])/2;
            WriteLine($"Numero faltante: {sumatoria - numeros.Sum()}");
        }
    }
}