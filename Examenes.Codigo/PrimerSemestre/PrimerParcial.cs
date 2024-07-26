using Microsoft.VisualBasic;

namespace Examenes.Codigo.PrimerSemestre;
public class PrimerParcial
{
    public int misteriosoRedondo(int n)
    {
        int rest = 0;
        while (n > 0)
        {
            rest = rest + redondos(n / 10);
            n = n / 10;

        }
        return rest;
    }
    private int redondos(int dig)
    {
        int rest = 0;
        if (dig == 0)
        {
            rest = 1;
        }
        if (dig == 6)
        {
            rest = 1;
        }
        return rest;
    }              // 0 1 2 3 4 
                   //n 2 3 4  5 9 
    public int numeroDivisible(int n)
    {

        string numero = n.ToString();
        int i = 0;
        int sumImpares = 0;
        int sumPares = 0;
        bool bandera = true;
        while (i < numero.Length)
        {
            int numeroConvertido = int.Parse(numero[i].ToString());
            if (bandera)
            {
                sumPares = sumPares + numeroConvertido;
                bandera = false;
            }
            else
            {
                sumImpares = sumImpares + numeroConvertido;
                bandera = true;
            }
            i++;
        }
        int resultado = sumPares - sumImpares;
        if (resultado == 0 || resultado % 11 == 0)
        {
            return resultado;
        }
        else
        {
            return -1;
        }

    }


    public int DevolverProducto(int numero)
    {
        int dig;
        int copiaDig = numero;
        dig = numero & 10;
        int digMayor = 0;
        int digMenor = 0;
        int resultado;
        for (int i = 0; numero >= 0; i++)
        {
            copiaDig = numero % 10;

            if (dig >= copiaDig)
            {
                digMenor = copiaDig;
            }
            else
            {
                digMayor = copiaDig;
            }
            numero = numero / 10;

        }
        resultado = digMayor * digMenor;
        return resultado;
    }

    public int[] serieFibonacci(int numero)
    {
        int a = 3;
        int b = 0;
        int c = 0;
        int resultado = 0;
        List <int> fibonacci = new List<int> ();
        for (int i = 0; i < numero; i++)
        {
            fibonacci.Add(resultado);
            //Console.Write(resultado);
            c = b;        //0,3, 
            b = b + a;      //3,8
            a = a + 2;     //5,7
            resultado = b;    //0,3,5
        }

        return fibonacci.ToArray();
    }

    public int InvertirNumero(int numero)
    {
        string palabra = numero.ToString(); // 23459
        int totalNumero = int.Parse(palabra);
        string nuevoNumero = "";
        for (int i = 0; numero >= 0; i++)
        {
            nuevoNumero = nuevoNumero + palabra[totalNumero];
            numero = numero / 10;
            totalNumero--;
        }

        return int.Parse(nuevoNumero);
    }

 




}