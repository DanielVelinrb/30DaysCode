using static System.Console;
using System.Text.RegularExpressions;

namespace Day5{
    class Program{
        static void Main(string [] args){

            WriteLine("Ingrese la contraseña");
            String password = ReadLine();
            
            //CON REGEX
            String regex = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).+$";

            if(password.Length >= 8 && !password.Contains(" ") && Regex.IsMatch(password, regex))
                WriteLine($"{password} es una contraseña válida");
            else
                WriteLine("CONTRASEÑA INVÁLIDA");

            //SIN REGEX
            /*int minusculas = 0, mayusculas = 0, numeros = 0;
            String respuesta = "CONTRASEÑA INVÁLIDA";
             if(password.Length >= 8 && !password.Contains(" ")){
                for(int i = 0; i < password.Length; i++){
                    if(password[i] <= 57 && password[i] >= 48){
                        numeros++;
                    }
                    else if((password[i] <= 90 && password[i] >= 65) || password[i] == 165){
                        mayusculas++;
                    }
                    else if((password[i] <= 122 && password[i] >= 97) || password[i] == 164){
                        minusculas++;
                    }
                }
                respuesta = (minusculas > 0 && mayusculas > 0 && numeros > 0) ? $"{password} es una contraseña válida" : respuesta;
             }
             WriteLine(respuesta);*/
        }
    }
}