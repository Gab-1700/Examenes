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
            if(cadena[i] == caracter){
                 cadenanueva=cadena.Remove(i,1);
            }
            
         }
         
        return cadenanueva;
    }

    
}