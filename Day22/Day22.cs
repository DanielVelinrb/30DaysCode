using static System.Console;

namespace Day22{
    class Day22{
        static void Main(string [] args){

            WriteLine("Ingrese su número de cédula: ");
            string cedula = ReadLine();            
            int provincia = validarCedula(cedula);

            if(provincia < 1 || provincia > 24){
                WriteLine("No es una cédula ecuatoriana válida");
            }   
            else{
                String [] provincias = new string[]{"Azuay", "Bolivar","Cañar","Carchi","Cotopaxi","Chimborazo",
                                                    "El Oro","Esmeraldas","Guayas","Imbabura","Loja","Los Ríos",
                                                                    "Manabí",
                                                                    "Morona Santiago",
                                                                    "Napo",
                                                                    "Pastaza",
                                                                    "Pichincha",
                                                                    "Tungurahua",
                                                                    "Zamora Chinchipe",
                                                                    "Galápagos",
                                                                    "Sucumbíos",
                                                                    "Orellana",
                                                                    "Santo Domingo de los Tsáchilas","Santa Elena"
                };
            WriteLine($"Cédula perteneciente a {provincias[provincia - 1]}");
        }
    }
        static int validarCedula(string cedula){
            int resultadoValidacion = 0;
            int temp = 0;

            if(cedula.Length != 10 || int.TryParse(cedula, out int validar) == false){
                return -1;
            }

            int provincia = int.Parse(cedula.Substring(0, 2));
            

            if(provincia < 1 || provincia > 24){
                return -1;
            }
            
            for(int i = 0; i < 9; i++){
                if(i % 2 == 0){
                    temp = 2 * (cedula[i] - 48);
                    resultadoValidacion += (temp > 9) ? temp - 9: temp;
                }
                else{
                    resultadoValidacion += cedula[i] - 48;
                }
            }

            if(resultadoValidacion == 10)
                resultadoValidacion = 1;
            else
                resultadoValidacion %= 10;

            return (resultadoValidacion == int.Parse(cedula.Substring(8, 1))) ? provincia : -1;
        }
    }
}
