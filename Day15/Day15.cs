using static System.Console;

namespace Day15{
    class Day15{
        static void Main(string [] args){
            int intentos = 5;
            int min = 1;
            int max = 100;
            int respuesta = 0;
            int num = new Random().Next(min, max);

            while(intentos > 0){
                WriteLine($"Adivina el numero en el que estoy pensando? entre el rango ({min} , {max})");
                respuesta = validarValor(min, max);

                if(respuesta == num){
                    WriteLine($"FELICIDADES HAS GANADO EN EL INTENTO {5 - intentos + 1}");
                    return;
                }
                else if(respuesta > num){
                    max = respuesta;
                    intentos--;
                }
                else if(respuesta < num){
                    min = respuesta;
                    intentos--;
                }
            }

            WriteLine($"HA PERDIDO, SE HA QUEDADO SIN INTENTOS. MI NÚMERO ERA: {num}");
        }

        static int validarValor(int min, int max, int value = 0){        
            while(value < min ||  value > max){
                value = int.Parse(ReadLine());
            }
            return value;
        }
    }
}