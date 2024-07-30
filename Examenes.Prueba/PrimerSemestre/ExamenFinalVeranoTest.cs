using Examenes.Codigo.PrimerSemestre.ExamenFinal;

namespace Examenes.Prueba.PrimerSemestre;

public class ExamenFinalVeranoTest
{
  private ExamenFinalVerano _examenFinal;

  [SetUp]
  public void Setup()
  {
    _examenFinal = new ExamenFinalVerano();
  }

  [TestCase(new[] { 15, 22, 37, 45, 62, 78, 91 }, new[] { 1, 2, 1, 2, 1 }, new[] { 15.0, 29.5, 45.0, 70.0, 91.0 }, new[] { 15, 37, 45, 78, 91 }, new[] { 15, 22, 45, 62, 91 })]
  [TestCase(new[] { 8, 15, 23, 29, 34, 48, 52, 67, 75, 85, 92 }, new[] { 2, 3, 2, 2, 2 }, new[] { 11.5, 28.67, 50.0, 71.0, 88.5 }, new[] { 15, 34, 52, 75, 92 }, new[] { 8, 23, 48, 67, 85 })]
  [TestCase(new[] { 7, 25, 83 }, new[] { 1, 1, 0, 0, 1 }, new[] { 7.0, 25.0, 0.0, 0.0, 83.0 }, new[] { 7, 25, 0, 0, 83 }, new[] { 7, 25, 0, 0, 83 })]
  [TestCase(new int[0], new[] { 0, 0, 0, 0, 0 }, new[] { 0.0, 0.0, 0.0, 0.0, 0.0 }, new[] { 0, 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, 0 })]
  public void Clasificar_ActualizaOcurrenciasPromediosMayoresMenores(int[] numeros, int[] ocurrencias, double[] promedios, int[] mayores, int[] menores)
  {
    // Act
    foreach (int numero in numeros)
    {
      _examenFinal.Clasificar(numero);
    }

    // Assert
    foreach (Rango rango in Enum.GetValues(typeof(Rango)))
    {
      Assert.That(_examenFinal.GetOcurrencia(rango), Is.EqualTo(ocurrencias[(int)rango]));
      Assert.That(_examenFinal.GetPromedio(rango), Is.EqualTo(promedios[(int)rango]));
      Assert.That(_examenFinal.GetMayor(rango), Is.EqualTo(mayores[(int)rango]));
      Assert.That(_examenFinal.GetMenor(rango), Is.EqualTo(menores[(int)rango]));
    }
  }
}