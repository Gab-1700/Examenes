using Examenes.Codigo.PrimerSemestre;

namespace Examenes.Prueba.PrimerSemestre;
public class SegundoParciolTest
{
    private SegundoParcial _segundoParcial;
    [SetUp]
    public void Setup()
    {
        _segundoParcial = new SegundoParcial();
    }

    [Test]
    public void OrdenarMatrizTest()
    {
        int[,] matriz = new int[,]{
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int[,] resultado = new int[,]{
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 3, 6, 9 }
        };
        int[,] actual = _segundoParcial.OrdenarMatriz(matriz);
        Assert.That(actual, Is.EqualTo(resultado));
    }

    [Test]
    public void OrdenarMatrizAvanzadaTest()
    {
        int[,] matriz = {
            { 5, 7, 3, 11, 6,  8,  2, 4 },
            { 9, 10, 4,12, 3, 6, 8, 1  },
            { 7, 3, 4, 1, 11, 9, 6, 5 },
            { 8, 2, 5, 9, 10, 3, 1, 6 },
            { 9, 12, 4, 11, 7, 8, 5, 2 },
            { 1, 5, 8, 7, 13, 9, 3, 4 },
            { 2, 10, 4, 12, 5, 8, 6, 1 },
            { 7, 3, 9, 2, 11, 5, 4, 8 },
          };
        int[,] resultado = new int[,]{
            { 1, 2, 4, 5, 6, 8, 9, 11 },
            { 1, 2, 4, 5, 6, 8, 9, 11 },
            { 1, 3, 4, 5, 6, 8, 9, 11 },
            { 1, 3, 4, 5, 7, 8, 9, 11 },
            { 1, 3, 4, 5, 7, 8, 9, 12 },
            { 2, 3, 4, 5, 7, 8, 10,12 },
            { 2, 3, 4, 6, 7, 8, 10,12 },
            { 2, 3, 5, 6, 7, 9, 10,13 },

        };
        int[,] actual = _segundoParcial.OrdenarMatriz(matriz);
        Assert.That(actual, Is.EqualTo(resultado));

    }

 
}