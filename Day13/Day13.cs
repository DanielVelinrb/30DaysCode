using static System.Console;
using System.Text.RegularExpressions;

namespace Day13{
    class Day13{    
        static void Main(string [] args){

            string entrada = "(0,0)";
            long [] values = new long[2]{0,0};
            long [] tempValues = new long[2]{0,0};

            do{
                WriteLine("Ingrese la coordenada con el formato (n,n)");
                entrada = ReadLine();
                if(Regex.IsMatch(entrada, @"^(\(-?\d+,-?\d+\))$")){
                    entrada = Regex.Replace(entrada , @"\(|\)" , "");
                    tempValues = entrada.Split(",").Select(number => long.Parse(number)).ToArray();
                    values[0] += tempValues[0];
                    values[1] += tempValues[1];
                }
                else
                    break;
            }while(true);

            WriteLine("Lectura de datos finalizada");
            WriteLine($"Posición final: ({values[0]} , {values[1]})");
        }
    }

}
