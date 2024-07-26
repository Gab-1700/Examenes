namespace Examenes.Codigo.PrimerSemestre.ExamenFinal;

public class Matriz{

                                    // 6 * 6
    public int[,] RecorridoMatriz(int[,] matriz){

        int fila =matriz.GetLength(0);
        int columna =matriz.GetLength(1);
        int [,] matrizRetorno = new int [6,6];
        for(int i = 1; i<fila/2;i++){

            for (int c=i; c<=i;c++){
                matrizRetorno[i,c]= matriz[i,c];
            }

        }
        return matriz;
    }
    
}