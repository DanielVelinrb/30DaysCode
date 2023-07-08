using static System.Console;

namespace Day19{
    class Day19{
        static void Main(string [] args){
            int [] numeros = new int[]{1, 1, 2, 3, 4, 5, 5, 5, 6, 7, 8, 9, 0};

            Dictionary<int, int> repeticiones = new Dictionary<int, int>();

            foreach (int numero in numeros)
            {
                if (repeticiones.ContainsKey(numero))
                    repeticiones[numero]++;
                else
                    repeticiones[numero] = 1;
            }

            foreach (var numero in repeticiones)
            {
                Console.WriteLine($"Se tiene {numero.Value} veces el número: {numero.Key}");
            }
        }
    }
}
