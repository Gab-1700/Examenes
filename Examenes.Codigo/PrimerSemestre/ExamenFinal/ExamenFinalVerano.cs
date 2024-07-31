
using System.Security.Cryptography;

namespace Examenes.Codigo.PrimerSemestre.ExamenFinal;
public class ExamenFinalVerano
{
  private List<int> arreglo1 = new List<int>();
  private List<int> arreglo2 = new List<int>();
  private List<int> arreglo3 = new List<int>();
  private List<int> arreglo4 = new List<int>();
  private List<int> arreglo5 = new List<int>();
  public void Clasificar(int numero)
  {
    //    3   23   55   //  
    if (numero <= 20)
    {
      arreglo1.Add(numero);
    }
    if (numero > 20 && numero <= 40)
    {
      arreglo2.Add(numero);
    }
    if (numero > 40 && numero <= 60)
    {
      arreglo3.Add(numero);
    }
    if (numero > 60 && numero <= 80)
    {
      arreglo4.Add(numero);
    }
    if (numero > 80 && numero <= 100)
    {
      arreglo5.Add(numero);
    }

  }

  public int GetMayor(Rango rango)
  {
    int may1 = 0;
    int may2 = 0;
    int may3 = 0;
    int may4 = 0;
    int may5 = 0;
    if (rango == Rango.PRIMERO)
    {
      if (arreglo1.Count != 0)
      {
        may1 = EncontrarMayor(arreglo1);
        return may1;
      }
      return 0;

    }
    if (rango == Rango.SEGUNDO)
    {
      if (arreglo2.Count != 0)
      {
        may2 = EncontrarMayor(arreglo2);
        return may2;
      }
      return 0;
    }
    if (rango == Rango.TERCERO)
    {
      if (arreglo3.Count != 0)
      {
        may3 = EncontrarMayor(arreglo3);
        return may3;
      }
      return 0;
    }
    if (rango == Rango.CUARTO)
    {
      if (arreglo4.Count != 0)
      {
        may4 = EncontrarMayor(arreglo4);
        return may4;
      }
      return 0;
    }
    if (rango == Rango.QUINTO)
    {
      if (arreglo5.Count != 0)
      {
        may5 = EncontrarMayor(arreglo5);
        return may5;
      }
      return 0;
    }
    return 0;
  }

  public int GetMenor(Rango rango)
  {
    int men1 = 0;
    int men2 = 0;
    int men3 = 0;
    int men4 = 0;
    int men5 = 0;
    if (rango == Rango.PRIMERO)
    {
      if (arreglo1.Count != 0)
      {
        men1 = EncontrarMenor(arreglo1);
        return men1;
      }
      return 0;
    }
    if (rango == Rango.SEGUNDO)
    {
      if (arreglo2.Count != 0)
      {
        men2 = EncontrarMenor(arreglo2);
        return men2;
      }
      return 0;
    }
    if (rango == Rango.TERCERO)
    {
      if (arreglo3.Count != 0)
      {
        men3 = EncontrarMenor(arreglo3);
        return men3;
      }
      return 0;
    }
    if (rango == Rango.CUARTO)
    {
      if (arreglo4.Count != 0)
      {
        men4 = EncontrarMenor(arreglo4);
        return men4;
      }
      return 0;
    }
    if (rango == Rango.QUINTO)
    {
      if (arreglo5.Count != 0)
      {
        men5 = EncontrarMenor(arreglo5);
        return men5;
      }
      return 0;
    }
    return 0;
  }

  public int GetOcurrencia(Rango rango)
  {
    int ocurrencia1 = 0;
    int ocurrencia2 = 0;
    int ocurrencia3 = 0;
    int ocurrencia4 = 0;
    int ocurrencia5 = 0;
    if (rango == Rango.PRIMERO)
    {
      if (arreglo1.Count != 0)
      {
        ocurrencia1 = NumeroEncontrado(arreglo1);
        return ocurrencia1;
      }
      return 0;
    }
    if (rango == Rango.SEGUNDO)
    {
      if (arreglo1.Count != 0)
      {
        ocurrencia2 = NumeroEncontrado(arreglo2);
        return ocurrencia2;
      }
      return 0;
    }
    if (rango == Rango.TERCERO)
    {
      if (arreglo3.Count != 0)
      {
        ocurrencia3 = NumeroEncontrado(arreglo3);
        return ocurrencia3;
      }
      return 0;
    }
    if (rango == Rango.CUARTO)
    {
      if (arreglo4.Count != 0)
      {
        ocurrencia4 = NumeroEncontrado(arreglo4);
        return ocurrencia4;
      }
      return 0;
    }
    if (rango == Rango.QUINTO)
    {
      if (arreglo5.Count != 0)
      {
        ocurrencia5 = NumeroEncontrado(arreglo5);
        return ocurrencia5;
      }
      return 0;
    }

    return 0;
  }

  public double GetPromedio(Rango rango)
  {
    double promedio1 = 0;
    double promedio2 = 0;
    double promedio3 = 0;
    double promedio4 = 0;
    double promedio5 = 0;
    if (rango == Rango.PRIMERO)
    {
      if (arreglo1.Count != 0)
      {
        promedio1 = EncontrarPromedio(arreglo1);
        return promedio1;
      }
      return 0.0;
    }
    if (rango == Rango.SEGUNDO)
    {
      if (arreglo2.Count != 0)
      {
        promedio2 = EncontrarPromedio(arreglo2);
        return promedio2;
      }
      return 0.0;
    }
    if (rango == Rango.TERCERO)
    {
      if (arreglo3.Count != 0)
      {
        promedio3 = EncontrarPromedio(arreglo3);
        return promedio3;
      }
      return 0.0;
    }
    if (rango == Rango.CUARTO)
    {
      if (arreglo4.Count != 0)
      {
        promedio4 = EncontrarPromedio(arreglo4);
        return promedio4;
      }
      return 0.0;
    }
    if (rango == Rango.QUINTO)
    {
      if (arreglo5.Count != 0)
      {
        promedio5 = EncontrarPromedio(arreglo5);
        return promedio5;
      }
      return 0.0;
    }
    return 0;
  }


  public int EncontrarMayor(List<int> arreglo)
  {
    int copia = arreglo[0];
    int mayor = 0;
    for (int i = 0; i < arreglo.Count; i++)
    {   // 12 14 7 8 1
      if (arreglo[i] >= copia)
      {
        mayor = arreglo[i];
        copia = mayor;
      }
    }
    return mayor;
  }

  public int EncontrarMenor(List<int> arreglo)
  {
    int copia = arreglo[0];           // 12 4 2 1 28
    int menor = 0;
    for (int i = 0; i < arreglo.Count; i++)
    {   // 12 14 7 8 1
      if (arreglo[i] <= copia)
      {
        menor = arreglo[i];
        copia = menor;
      }
    }
    return menor;
  }

  public int NumeroEncontrado(List<int> arreglo)
  {
    int count = 0;
    for (int i = 0; i < arreglo.Count; i++)
    {
      if (arreglo[i] > 0)
      {
        count++;
      }
    }
    return count;
  }

  public double EncontrarPromedio(List<int> arreglo)
  {
    double suma = 0;
    double resultado = 0;
    double copia = arreglo.Count;
    double redondeo;
    for (int i = 0; i < arreglo.Count; i++)
    {
      suma = suma + arreglo[i];
    }
    resultado = suma / copia;
    redondeo = Math.Round(resultado, 2);

    return redondeo;
  }


}