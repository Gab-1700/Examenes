using System.Collections;

namespace Examenes.Codigo.Utilitarios;

public class IteradorMatriz<T> : IEnumerator
{
    private T[,] _matriz;
    private int _fila;
    private int _columna;

    public T Current
    {
        //get { return _matriz[_fila, _columna]; }
        get => _matriz[_fila,_columna];
        set => _matriz[_fila, _columna] = value; 
    }
    //object IEnumerator.Current {get{return Current;}}   int gasd{ get ; set; }
    object IEnumerator.Current => Current;

    public IteradorMatriz(T[,] matriz)
    {
        _matriz = matriz;
    }

    public bool MoveNext()
    {
        int filas = _matriz.GetLength(0);
        filas = filas-1;

        if (_fila < filas)
        {
            _fila++;
            return true;
        }

        int columnas = _matriz.GetLength(1);
        columnas = columnas-1;
        if (_columna < columnas)
        {
            _columna++;
            _fila = 0;
            return true;
        }

        return false;

            /*int filas = _matriz.GetLength(0);
        int columnas = _matriz.GetLength(1);

        _columna++; // Primero intenta avanzar a la siguiente columna 

        if (_columna >= columnas)
        {
            _columna = 0;
            _fila++; // Si se alcanza el final de las columnas, avanza a la siguiente fila
        }

        // Devuelve true si estamos dentro de los límites de la matriz
        return _fila < filas && _columna < columnas; */

        
    }

    public void Reset()
    {
        _fila = 0;
        _columna = 0;
    }

}