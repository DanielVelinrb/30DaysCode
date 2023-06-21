using static System.Console;

//EL TIM: Sebas Illicachi - Daniel Velin

class Day3 {

    static bool sumaDigitos(char[] number){
        int total = 0;
        for(int i = 0; i < number.Length; i++){
            total += number[i] - 48;
        }
        return total == 7;//C3
    }

    static void Main(string [] args){

        WriteLine("Ingrese el limite inferior del rango");
        ulong min = ulong.Parse(ReadLine());
        WriteLine("Ingrese el limite superior del rango");
        ulong max = ulong.Parse(ReadLine());

        //AL CUMPLIR C1 Y C2 LOS POSIBLES NUMEROS SE ENCONTRARIAN EN SALTOS DE 6: 3, 9, 15..
        min += (min % 3 == 0) ? 0 : 3 - min % 3; //CUMPLIMIENTO PRIMERA CONDICION
        if(min % 2 == 0)        //CUMPLIMIENTO SEGUNDA CONDICION
            min += 3;

        
        WriteLine("Los siguientes son números mágicos dentro del rango: ");

        for(ulong i = min; i <= max; i += 6){ 
            if(sumaDigitos(i.ToString().ToCharArray())){
                WriteLine(i);
            }
        }
    }
}

//EN ESTE CASO C1 Y C3 SON MUTUAMENTE EXCLUYENTES