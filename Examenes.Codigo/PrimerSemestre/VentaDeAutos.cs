namespace Examenes.Codigo.PrimerSemestre;

public class VentaDeAutos{


    private List<Automoviles> autoLista = new List<Automoviles>();
    public VentaDeAutos(List<Automoviles> listaDeAutos){
        if(listaDeAutos.Count > 40){
            throw new Exception("hay un error");
        }
        autoLista = listaDeAutos;
    }

    public void VisualizarAutoElementos(){
        
        for (int i=0; i<autoLista.Count; i++){
              Console.WriteLine(autoLista[i]);  
        }
        
    }

    public void AñadirAutomovil(Automoviles auto){
        if(autoLista.Count > 40){
            throw new Exception ("no podemos añadir el auto");
        }

        autoLista.Add(auto);

    }
    public void BuscarAutoMovil(string placa){
        for (int i=1; i<autoLista.Count; i++){
            Automoviles autobuscado= autoLista[i];
            if(autobuscado.Placa == placa){
                    Console.WriteLine("encontramos el auto" + "" + "esta en la posicion"+ autoLista[i]);
            }

        }
    }
    

}