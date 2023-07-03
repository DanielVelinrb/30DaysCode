using static System.Console;

namespace Day14{
    class Day14{
        static void Main(string [] args){
            List<float> tortugas = new List<float>();
            float maxVelocity = 0;
            float velocidadTortuga = 0;

            for(int i = 1; i <= 3; i++){
                Write($"Ingrese la velocidad de la Tortuga {i}: ");
                velocidadTortuga = float.Parse(ReadLine());
                tortugas.Add(velocidadTortuga);
                maxVelocity = (maxVelocity > velocidadTortuga) ? maxVelocity : velocidadTortuga;
            }

            WriteLine("Tortuga(s) con la mayor velocidad: ");
            for(int i = 0; i < tortugas.Count; i++)
            {
                if(tortugas.ElementAt(i) == tortugas.Max()){
                    WriteLine($"Tortuga{ i+1}");
                }
            }

        }
    }
}