using static System.Console;

namespace Day6{
    class Program{
        static void Main(string [] args){

            int num = int.Parse(ReadLine().ToString());
            int [,] espiral = new int[num, num];
            int contador = num * num;
            int i = 0, j = num;
            int direccion = 0;
            int extension = num;
            
            while(contador > 0){                    
                if(extension == num && j == 0){
                    direccion++;
                    extension--;
                }
                else if((j == num - extension && direccion == 0)){
                    extension--;
                    direccion++;
                }
                else if((i == extension && direccion == 1) || (j == extension && direccion == 2)){
                    direccion++;
                }
                else if(i == num - extension && direccion == 3){
                    direccion = 0;
                }

                switch(direccion){
                    case 0:
                        espiral[i, --j] = contador--; break;           
                    case 1:
                        espiral[++i, j] = contador--; break;
                    case 2:
                        espiral[i, ++j] = contador--; break;
                    case 3:
                        espiral[--i, j] = contador--; break;
                }
            }

            for(i = 0; i < num; i++){
                for(j = 0; j < num; j++){
                    Write($"{espiral[i, j]} ");       
                }
                WriteLine("");
            }
        }
    }
}
