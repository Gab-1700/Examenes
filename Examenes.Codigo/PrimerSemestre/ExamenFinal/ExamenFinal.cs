namespace Examenes.Codigo.PrimerSemestre.ExamenFinal;

public class ExamenFinal
{
    // astuto casa hola casa
    public string Devolver(string cadena, string subcadena)
    {
        string palabra = "";
        string nuevacadena = "";
        int valorCadena = 0;
        string resultado="";
        List<string> palabras = new List<string>();
        for (int i = 0; i < cadena.Length; i++)
        {
                if (cadena[i] == 'a')
                {
                    nuevacadena = nuevacadena + cadena[i];
                }
                else
                {
                    if (cadena[i] == 's')
                    {
                        nuevacadena = nuevacadena + cadena[i];
                        valorCadena = i - 1;
                        palabras.Add(valorCadena.ToString());
                    }
                }   
        }
        int a = palabras.Count-2 ;
             for (int c = 0; c < 2; c++){
                resultado = resultado + palabras[a]+ ",";
                a++;
             }
        return resultado;

    }

    public string Eliminar(string cadena, char caracter){
            //casa campestre        //a
        string cadenanueva="";
         for (int i = 0; i< cadena.Length; i++){
            if(cadena[i] != caracter){
                 cadenanueva+=cadena[i];
            }
         }
        return cadenanueva;
    }

    public int[] IndexOf5(string cadena, string aparicion)
    {
        string nuevacadena = "";
        int valorCadena = 0;
        List<string> palabras = new List<string>();
        //List<string> resultado = new List<string>();
        int[] respuesta = new int[2];
        for (int i = 0; i < cadena.Length; i++)
        {
                if (cadena[i] == aparicion[0])
                {
                    nuevacadena = nuevacadena + cadena[i];   // e
                }
                else
                {
                   if(nuevacadena!="") {
                        if (cadena[i] == aparicion[1])
                        {
                            nuevacadena = nuevacadena + cadena[i];
                            valorCadena = i - 1;
                            palabras.Add(valorCadena.ToString());
                            nuevacadena="";
                        }else{
                            nuevacadena="";
                            }
                    }
                }  
        }

        int a = palabras.Count-2 ;
        for (int c = 0; c < 2; c++){
            respuesta[c] = int.Parse(palabras[a]) ;
            a++;
        }
        return respuesta;

    }

    public int[,] CrearMatriz(int longitud)
    {
        int[,] matriz = new int[longitud,longitud];
        int numero=1;
        int fila = longitud;
        int columna = longitud;
        for(int i = 0; i<longitud;i++){
            for (int c=0; c<=i;c++){
                matriz[i,c] = numero;
            }
        }
        return matriz;
    }
}