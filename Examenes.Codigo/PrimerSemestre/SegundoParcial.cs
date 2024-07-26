using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Examenes.Codigo.Utilitarios;

namespace Examenes.Codigo.PrimerSemestre;
public class SegundoParcial
{

    public int[,] OrdenarMatriz(int[,] matriz)
    {
        IteradorMatriz<int> iterador = new IteradorMatriz<int>(matriz);
        IDictionary<int, int> diccionarioDeMatriz = new SortedDictionary<int, int>();


        do
        {
            if (diccionarioDeMatriz.ContainsKey(iterador.Current))
            {
                diccionarioDeMatriz[iterador.Current]++;
            }
            else
            {
                diccionarioDeMatriz[iterador.Current] = 1;
            }

        } while (iterador.MoveNext());


        iterador.Reset();

        foreach (var repetido in diccionarioDeMatriz)
        {

            for (int i = 0; i < repetido.Value; i++)
            {
                iterador.Current = repetido.Key;
                iterador.MoveNext();

            }

        }

        return matriz;

    }

}