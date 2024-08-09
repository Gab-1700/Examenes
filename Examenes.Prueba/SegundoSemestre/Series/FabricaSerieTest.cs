using Examenes.Codigo.SegundoSemestre.Series;

namespace Examenes.Prueba.SegundoSemestre.Series;

public class FabricaSerieTest
{
  [Test]
  public void SerieFibonacci_Test()
  {
    // Act
    var fabrica = CargarFabrica("SerieFibonacci");
    var serie = fabrica.GenerarSerie();

    // Assert
    Assert.That(serie[0], Is.EqualTo(0));
    Assert.That(serie[1], Is.EqualTo(1));
    Assert.That(serie[2], Is.EqualTo(1));
    Assert.That(serie[3], Is.EqualTo(2));
    Assert.That(serie[4], Is.EqualTo(3));
    Assert.That(serie[5], Is.EqualTo(5));
  }

  [Test]
  public void SeriePrimo_Test()
  {
    // Act
    var fabrica = CargarFabrica("SeriePrimo");
    var serie = fabrica.GenerarSerie();

    // Assert
    Assert.That(serie[0], Is.EqualTo(2));
    Assert.That(serie[1], Is.EqualTo(3));
    Assert.That(serie[2], Is.EqualTo(5));
    Assert.That(serie[3], Is.EqualTo(7));
    Assert.That(serie[4], Is.EqualTo(11));
    Assert.That(serie[5], Is.EqualTo(13));
  }

  [Test]
  public void SerieTriangular_Test()
  {
    // Act
    var fabrica = CargarFabrica("SerieTriangular");
    var serie = fabrica.GenerarSerie();

    // Assert
    Assert.That(serie[0], Is.EqualTo(1));
    Assert.That(serie[1], Is.EqualTo(3));
    Assert.That(serie[2], Is.EqualTo(6));
    Assert.That(serie[3], Is.EqualTo(10));
    Assert.That(serie[4], Is.EqualTo(15));
  }

  [Test]
  public void SerieFactorial_Test()
  {
    // Act
    var fabrica = CargarFabrica("SerieFactorial");
    var serie = fabrica.GenerarSerie();

    // Assert
    Assert.That(serie[0], Is.EqualTo(1));
    Assert.That(serie[1], Is.EqualTo(1));
    Assert.That(serie[2], Is.EqualTo(2));
    Assert.That(serie[3], Is.EqualTo(6));
    Assert.That(serie[4], Is.EqualTo(24));
    Assert.That(serie[5], Is.EqualTo(120));
  }

  [Test]
  public void SerieCuadrado_Test()
  {
    // Act
    var fabrica = CargarFabrica("SerieCuadrado");
    var serie = fabrica.GenerarSerie();

    // Assert
    Assert.That(serie[0], Is.EqualTo(0));
    Assert.That(serie[1], Is.EqualTo(1));
    Assert.That(serie[2], Is.EqualTo(4));
    Assert.That(serie[3], Is.EqualTo(9));
    Assert.That(serie[4], Is.EqualTo(16));
    Assert.That(serie[5], Is.EqualTo(25));
  }

  private static IFabricaSerie CargarFabrica(string nombreFabrica)
  {
    var rutaFabrica = string.Format($"Examenes.Codigo.SegundoSemestre.Series.{nombreFabrica}, Examenes.Codigo");
    var tipoFabrica = Type.GetType(rutaFabrica) ?? throw new Exception($"Error, la clase '{rutaFabrica}' no existe");
    if (!tipoFabrica.IsAssignableTo(typeof(IFabricaSerie)))
    {
      throw new Exception($"Error, '{nombreFabrica}' debe implementar de IFabricaSerie");
    }

    var fabrica = Activator.CreateInstance(tipoFabrica) ?? throw new Exception($"Error al cargar '{nombreFabrica}'");
    return (IFabricaSerie)fabrica;
  }
}
