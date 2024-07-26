using Examenes.Codigo.PrimerSemestre.ExamenFinal;

namespace Examenes.Prueba.PrimerSemestre;

public class ExamenFinalTest
{
  private static readonly object[] _matrizTriangular =
  {
    new object[] {1, new int[,] {{1}}},
    new object[] {2, new int[,] {{1,0},{1,1}}},
    new object[] {3, new int[,] {{1,0,0},{1,1,0},{1,1,1}}},
    new object[] {4, new int[,] {{1,0,0,0},{1,1,0,0},{1,1,1,0},{1,1,1,1}}},
    new object[] {7, new int[,] {{1,0,0,0,0,0,0},{1,1,0,0,0,0,0},{1,1,1,0,0,0,0},{1,1,1,1,0,0,0},{1,1,1,1,1,0,0},{1,1,1,1,1,1,0},{1,1,1,1,1,1,1}}}
  };
  private ExamenFinal _examenFinal;

  [SetUp]
  public void Setup()
  {
    _examenFinal = new ExamenFinal();
  }

  [TestCase("Mi sol es el sol del verano", "el", new[] { 10, 18 })]
  [TestCase("Los dos niños corren rápido", "os", new[] { 5, 11 })]
  [TestCase("Las gaviotas vuelan cerca del mar", "el", new[] { 15, 27 })]
  [TestCase("La luz es muy luz para ti", "lu", new[] { 3, 14 })]
  [TestCase("Astuto casa hola casa", "sa", new[] { 9, 19 })]
  public void IndexOf5_RetornaLosIndicesEsperados(string cadena, string aparicion, int[] indices)
  {
    // Act
    var resultado = _examenFinal.IndexOf5(cadena, aparicion);

    // Assert
    Assert.That(indices, Is.EqualTo(resultado));
  }

  [TestCaseSource(nameof(_matrizTriangular))]
  public void CrearMatriz_RetornaUnaMatrizTriangular(int longitud, int[,] matriz)
  {
    // Act
    var resultado = _examenFinal.CrearMatriz(longitud);

    // Assert
    Assert.That(matriz, Is.EqualTo(resultado));
  }

  [TestCase("El sol brilla en el cielo azul", 'l', "E so bria en e cieo azu")]
  [TestCase("Mis amigos vienen a la fiesta", 'i', "Ms amgos venen a la festa")]
  [TestCase("Hoy voy al cine con mi hermana", 'i', "Hoy voy al cne con m hermana")]
  [TestCase("El cafe esta caliente y delicioso", 'a', "El cfe est cliente y delicioso")]
  [TestCase("La lluvia cayo durante toda la noche", 'a', "L lluvi cyo durnte tod l noche")]
  public void Eliminar_RetornaCadenaSinCaracter(string cadena, char caracter, string cadenaLimpia)
  {
    // Act
    var resultado = _examenFinal.Eliminar(cadena, caracter);

    // Assert
    Assert.That(cadenaLimpia, Is.EqualTo(resultado));
  }
}