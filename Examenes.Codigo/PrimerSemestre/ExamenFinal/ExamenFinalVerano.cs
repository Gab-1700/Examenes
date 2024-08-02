
using System.Security.Cryptography;

namespace Examenes.Codigo.PrimerSemestre.ExamenFinal;
public class ExamenFinalVerano
{
  private Dictionary<Rango, List<int>> diccionario = new Dictionary<Rango, List<int>>();

  public ExamenFinalVerano()
  {
    var rangos = Enum.GetValues<Rango>();
    foreach (Rango rango in rangos)
    {
      diccionario.Add(rango, new List<int>());
    }
  }
  public void Clasificar(int numero)
  {
    var rango = GetRango(numero);
    diccionario[rango].Add(numero);
  }

  public int GetMayor(Rango rango)
  {
    if (diccionario.ContainsKey(rango))     // validar q el diccionario tenga una clave  
    {
      List<int> lista = diccionario[rango];  // rango = PRIMERO;   [42  5 3 1 4]
      if (lista.Count > 0)                    //verificar q la lista no este vacia
      {
        return lista.Max();
      }
    }
    return 0;
  }

  public int GetMenor(Rango rango)
  {
    if (diccionario.ContainsKey(rango))     // validar q el diccionario tenga una clave  
    {
      List<int> lista = diccionario[rango];  // rango = PRIMERO;   [42  5 3 1 4]
      if (lista.Count > 0)                    //verificar q la lista no este vacia
      {
        return lista.Min();
      }
    }
    return 0;
  }

  public int GetOcurrencia(Rango rango)
  {
      if(diccionario.ContainsKey(rango)){
          List<int > lista = diccionario[rango];
          return lista.Count;
      }
    return 0;
  }

  public double GetPromedio(Rango rango)
  {
    if(diccionario.ContainsKey(rango)){
          List<int > lista = diccionario[rango];
          if(lista.Count>0){
               double promedio = lista.Average();
               double promedio2 = Math.Round(promedio, 2);
               return promedio2;
          }
      }
    return 0.0;
  }

  private Rango GetRango(int numero)
  {
    int indice = numero / 20;
    return (Rango)indice;
  }


}