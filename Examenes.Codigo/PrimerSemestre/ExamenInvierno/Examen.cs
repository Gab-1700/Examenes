using System.Diagnostics.Contracts;

namespace Examenes.Codigo.PrimerSemestre.ExamenInvierno;

public class Examen{

    private string _palabra; 


    private string Invertir(string cadena){
        string palabra = new string(cadena.Reverse().ToArray());
        return palabra;
    }
    private string DuplicarCaracteres(string cadena){
        string copia=cadena;        //asac      
        string longitud= cadena + copia;
        string nuevaPalabra="";                                         
        for (int i = 0; i<cadena.Length; i ++){
                nuevaPalabra = nuevaPalabra + cadena[i];    
                nuevaPalabra = nuevaPalabra + cadena[i];    
        }
        return nuevaPalabra;
    }

    public int Digitos(int numero){

        int producto = 1;
        int digito=0;
        for (int i = 0 ;numero >= 0; i++){
            digito = numero % 10 ;
            if(digito <= 3){
                producto = producto * digito;
            }
            numero = numero / 10;
        }
        return numero;
    }



}