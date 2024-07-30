using System.Reflection.Metadata.Ecma335;

namespace Examenes.Codigo;

public class Class1
{   
                            // 78913
    public static void Resoluciones(int numero)
    {
        string numerocasteado= numero.ToString();
        int numerototal=numerocasteado.Length;
        int[]arreglo= new int[numerototal];
    
        for(int i= 0; i <numerocasteado.Length; i++){
            arreglo[i] = int.Parse(numerocasteado[i].ToString());
           // arreglo[i] = numerocasteado[i] - '0'; ese -'0' es unca casteada del caracter al numero deseado

        }
        //78912
        int mayor=0;
        int menor=arreglo[0];
        for(int c=0; c<arreglo.Length;c++){
            if(arreglo[c] >= mayor){
                  mayor = arreglo[c];  
            }else{
                if(arreglo[c] <= menor)
                menor=arreglo[c];
            }
           
        }
        int suma=0;
        int contador = 0;
        for(int h=0; h<arreglo.Length; h++){
            suma+= arreglo[h];
            contador++;
        }
        
        int promedio= suma / contador;
        
    }

    public static void Resoluciones(int numero)
    {
       // int ultimo= numero & 10;
        //int copia= numero&10;
        int resultado=0;
        int copia=0;
        for (int i = 0; numero>=0; i++){
             copia = numero %10;
            if(copia <=5){
                resultado +=copia;
            }
            numero= numero /10;
        }
        Console.WriteLine(resultado);
    }

   
    
}
