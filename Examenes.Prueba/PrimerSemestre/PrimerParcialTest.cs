using Examenes.Codigo.PrimerSemestre;

namespace Examenes.Prueba.PrimerSemestre;
public class PrimerParcialTest
{
    private PrimerParcial _primerParcial;
    [SetUp]
    public void Setup()
    {
        _primerParcial = new PrimerParcial();
    }


    [TestCase(new int[] { 0, 3, 8, 15, 24, 35, 48 }, 7)]
    [TestCase(new int[] { 0, 3, 8 }, 3)]
    [TestCase(new int[] { 0, 3, 8, 15, 24 }, 5)]
    public void SerieFibonacci(int[] resultado, int numero)
    {
        var actual = _primerParcial.serieFibonacci(numero);
        Assert.That(actual, Is.EqualTo(resultado));
    }
}