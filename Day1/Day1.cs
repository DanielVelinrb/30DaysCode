using static System.Console;
using System;

class Day1 {
    static void Main(string [] args){

        string? number = ReadLine();
        if(number.Length == 0){
            WriteLine("Recuerde que solo se aceptan valores no nullos enteros positivos.");
            return;
        }

        int resultado = 0;
        int type = 0;
        int aux = 0;

        try{
            //int numeroInt = int.Parse(number.ToString());
            for(int i = number.Length - 1; i >= 0; i--){
                
                if(type == 0){
                    resultado += int.Parse(number[i].ToString());
                    type++;
                }
                else if(type == 1){
                    aux = int.Parse(number[i].ToString()) * 2;
                    resultado += (aux > 9) ? aux - 9 : aux;
                    type--; 
                }
            }
            string mensajeRespuesta = (resultado % 10 == 0) ? 
            $"Tarjeta con #{number} valida" : "Tarjeta incorrecta";
            WriteLine(mensajeRespuesta);
        }
        catch(Exception ex){
            WriteLine("Recuerde que solo se aceptan valores no nullos enteros positivos.");
        }

    }
}