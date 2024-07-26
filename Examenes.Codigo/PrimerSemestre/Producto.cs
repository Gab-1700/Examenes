namespace Examenes.Codigo.PrimerSemestre;

public class Producto
{

    public string Nombre { get; set; }
    public string OrigenDeFabricacion { get; set; }
    public DateTime Fecha { get; set; }
        public DateTime SoloFecha
    {
        get { return Fecha.Date; }  // Utiliza la propiedad Date para obtener solo la fecha
        set { Fecha = value; }      // Establece la fecha completa
    }
    public double Precio { get; set; }
    public int Cantidad { get; set; }


}