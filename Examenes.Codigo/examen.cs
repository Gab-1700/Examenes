
using System.Globalization;

public class examen
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

    public int serieFibonacci(int numero)
    {
        int a = 3;
        int b = 0;
        int c = 0;
        int resultado = 0;
        for (int i = 0; i < numero; i++)
        {
            Console.Write(resultado);
            c = b;        //0,3, 
            b = b + a;      //3,8
            a = a + 2;     //5,7
            resultado = b;    //0,3,5
        }

        return resultado;
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

    public void MatrizDiagonal()
    {

        int[,] matriz = {
            {  1,  2,  3,  4,  5,  6,  7,  8,  9, 10 },
            { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
            { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 },
            { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
            { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
            { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
            { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
            { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
          };
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 1; i < filas; i++)
        {
            for (int c= 0; c < columnas; c++){

            }

        }



    }




}