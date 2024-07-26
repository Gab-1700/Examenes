using Examenes.Codigo.PrimerSemestre;
using Examenes.Codigo.SegundoSemestre;

namespace Examenes.Prueba.PrimerSemestre;
public class FerreteriaTest
{

    private Ferreteria _ferreteria;
    private List<Producto> _productos;

    [SetUp]
    public void Setup()
    {
        // Configuración inicial para las pruebas
        _productos = new List<Producto>
        {
            new Producto { Nombre = "Destornillador", OrigenDeFabricacion = "EEUU", Fecha = DateTime.Parse("2023-02-20"), Precio = 5.75, Cantidad = 30 },
            new Producto { Nombre = "Martillo", OrigenDeFabricacion = "China", Fecha = DateTime.Parse("2023-01-15"), Precio = 10.5, Cantidad = 50 },
            new Producto { Nombre = "Sierra", OrigenDeFabricacion = "Alemania", Fecha = DateTime.Parse("2023-03-10"), Precio = 20.25, Cantidad = 25 }
        };

        _ferreteria = new Ferreteria(_productos);
    }

    [Test]
    public void ListarProductos_DebeRetornarStringJson()
    {
        string actual = _ferreteria.ListarProductos();
        string resultado = "Destornillador :: EEUU :: 20/02/2023 :: 5.75 :: 30\n" +
                           "Martillo :: China :: 15/01/2023 :: 10.5 :: 50\n" +
                           "Sierra :: Alemania :: 10/03/2023 :: 20.25 :: 25";
        Assert.AreEqual(actual, resultado);

    }

    [Test]
    public void AgregarProducto_DebeIncrementarCantidadDeProductos()
    {
        Producto nuevoProducto = new Producto { Nombre = "Llave inglesa", OrigenDeFabricacion = "España", Fecha = DateTime.Parse("2023-04-05"), Precio = 15.0, Cantidad = 20 };

        _ferreteria.AgregarProducto(nuevoProducto);

        //Assert.Equals(4, _productos.Count); // Actualizar según el número esperado de productos
        Assert.AreEqual(4, _productos.Count);
    }

    [Test]
    public void BuscarProducto_ProductoExistente_DebeRetornarProducto()
    {
        string nombreProducto = "Martillo";

        Producto actual = _ferreteria.BuscarProducto(nombreProducto);
        Producto resultado = _productos[1];

        Assert.AreEqual(actual, resultado);
    }

    [Test]
    public void EliminarProducto_ProductoExistente_DebeEliminarProducto()
    {
        string nombreProductoAEliminar = "Martillo";

        _ferreteria.EliminarProducto(nombreProductoAEliminar);

        Assert.AreEqual(_productos.Count, 2);
    }

}



