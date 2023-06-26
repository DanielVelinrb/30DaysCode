using static System.Console;
using System.Text.RegularExpressions;

namespace Day7{  
    class Day7{
        static bool validarComponente(string componente, string caracteresAdmitidos, int contadorPuntos = 0){

            for(int i = 1; i < componente.Length; i++){
                if(!Regex.IsMatch(componente[i].ToString(), caracteresAdmitidos)){
                    return false;
                }
                else{
                    if(!componente[i].Equals('.'))
                        contadorPuntos = 0;
                    else if(componente[i].Equals('.') && contadorPuntos == 0)
                        contadorPuntos = 1;
                    else if(componente[i].Equals('.') && contadorPuntos == 1)
                        return false;
                }
            }
            return true;
        }


        static void Main(string [] args){

            string correo = ReadLine();
            string caracteresAdmitidos = @"[A-Za-z\d\.\-_]";

            if(correo.Length == 0 || correo.Count(c => c == '@') != 1){
                WriteLine("Correo no valido");
                return;
            }

            string [] componentesCorreo = correo.Split("@");

            if(componentesCorreo[0].Length == 0 || !Regex.IsMatch(componentesCorreo[0][0].ToString(), @"[A-Za-z\d]") || 
            componentesCorreo[1].Length == 0 || !Regex.IsMatch(componentesCorreo[1][0].ToString(), @"[A-Za-z\d]")){
                WriteLine("Correo no valido");
                return;
            }

            if(validarComponente(componentesCorreo[0], caracteresAdmitidos) && componentesCorreo[1].Count(c => c == '.') >= 1 &&
                componentesCorreo[1][componentesCorreo[1].Length - 1] != '.' && validarComponente(componentesCorreo[0], caracteresAdmitidos))
                WriteLine("Correo VALIDO");
            else
                WriteLine("Correo no valido");
        }
    }
}