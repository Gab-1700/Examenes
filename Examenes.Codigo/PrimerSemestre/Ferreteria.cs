using System.Collections;
using System.Globalization;
using System.Text;
using Examenes.Codigo.PrimerSemestre;

namespace Examenes.Codigo.SegundoSemestre;
public class Ferreteria
{

    private List<Producto> productos = new List<Producto>();

    public Ferreteria(List<Producto> productosLlegados)
    {

        if (productosLlegados.Count > 200)
        {
            throw new Exception("ocurrio un error inesperado");
        }
        productos = productosLlegados;
    }

    public string ListarProductos()
    {
        return ListarProductosV1();
    }
    public string ListarProductosV1()
    {
        string respuesta = "";
        for (int i = 0; i < productos.Count; i++)
        {
            Producto mostrar = productos[i];
            if (mostrar != null)
            {
                string fechaFormateada = mostrar.Fecha.ToString("dd/MM/yyyy");
                respuesta = respuesta + mostrar.Nombre + " :: " + mostrar.OrigenDeFabricacion + " :: " + fechaFormateada + " :: " + mostrar.Precio.ToString(CultureInfo.InvariantCulture) + " :: " + mostrar.Cantidad + "\n";
            }

        } //8
        return respuesta.Substring(0, respuesta.Length-1);//respuesta.Length - 1);
    }
    public string ListarProductosV2()
    {
        // no necesitamos el indici pa buscar elementos de la lista
        // solo declaramos un objeto del tipo de lista para con ese objeto buscar 
        string respuesta = "";
        foreach (Producto producto in productos)
        {
            if (producto != null)
            {
                string fechaFormateada = producto.Fecha.ToString("dd/MM/yyyy");
                respuesta = respuesta + producto.Nombre + " :: " + producto.OrigenDeFabricacion + " :: " + fechaFormateada + " :: " + producto.Precio.ToString(CultureInfo.InvariantCulture) + " :: " + producto.Cantidad + "\n";
            }
        }
        return respuesta.Substring(0, respuesta.Length - 1);

    }
    public string ListarProductosV3()
    {

        StringBuilder respuesta = new StringBuilder();
        foreach (Producto producto in productos)
        {
            if (producto != null)
            {
                string fechaFormateada = producto.Fecha.ToString("dd/MM/yyyy");
                respuesta.Append(producto.Nombre);
                respuesta.Append(" :: ");
                respuesta.Append(producto.OrigenDeFabricacion);
                respuesta.Append(" :: ");
                respuesta.Append(fechaFormateada);
                respuesta.Append(" :: ");
                respuesta.Append(producto.Precio.ToString(CultureInfo.InvariantCulture));
                respuesta.Append(" :: ");
                respuesta.Append(producto.Cantidad);
                respuesta.Append("\n");

            }
        }
        return respuesta.ToString().Substring(0, respuesta.Length - 1);

    }

    public string ListarProductosV4()
    {

        StringBuilder respuesta = new StringBuilder();
        foreach (Producto producto in productos)
        {
            if (producto != null)
            {
                string fechaFormateada = producto.Fecha.ToString("dd/MM/yyyy");
                respuesta.AppendFormat("{0} :: {1} :: {2} :: {3} :: {4}\n",
                    producto.Nombre,
                    producto.OrigenDeFabricacion,
                    fechaFormateada,
                    producto.Precio.ToString(CultureInfo.InvariantCulture),
                    producto.Cantidad
                );

            }
        }
        return respuesta.ToString().Substring(0, respuesta.Length - 1);

    }

    public void AgregarProducto(Producto productoNuevo)
    {

        if (productos.Count > 200)
        {
            throw new Exception("hemos llegado al limite");
        }
        //producto = new Producto() { Nombre = "jorge", OrigenDeFabricacion = "China", Fecha = DateTime.Now, Precio = 22, Cantidad = 2 };
        //Producto productoNuevo = new Producto(nombre,origenFabricacion,fechaFabricacion,precio)
        //Producto productoNuevo = new Producto{ Nombre = nombre, Cantidad = 1, Precio = 21, OrigenDeFabricacion = "China", Fecha = DateTime.Now };
        productos.Add(productoNuevo);
    }

    public Producto BuscarProducto(string productoBuscado)
    {

        for (int i = 0; i < productos.Count; i++)
        {
            Producto producto = productos[i];
            if (producto.Nombre == productoBuscado)
            {
                return producto;
                //Console.WriteLine("encontramos el producto");
                //Console.WriteLine("esta en la posicion" + ""+ productos[i]);
            }

        }
        return null;

    }
    public void EliminarProducto(string nombre)
    {

        for (int i = 0; i < productos.Count; i++)
        {
            Producto producto = productos[i];
            if (producto.Nombre == nombre)
            {
                productos.Remove(producto);
                i--;
            }

        }
    }

}