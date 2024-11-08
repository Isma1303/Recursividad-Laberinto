using System;

public class Laberinto
{
    public static bool EncontrarCamino(int[][] laberinto, int filaInicial, int columnaInicial, int filaFinal, int columnaFinal)
    {
        if (filaInicial == filaFinal && columnaInicial == columnaFinal)
            return true;

        if (filaInicial < 0 || filaInicial >= laberinto.Length ||
            columnaInicial < 0 || columnaInicial >= laberinto[0].Length ||
            laberinto[filaInicial][columnaInicial] != 0)
            return false;

        laberinto[filaInicial][columnaInicial] = -1;

        if (EncontrarCamino(laberinto, filaInicial + 1, columnaInicial, filaFinal, columnaFinal) ||
            EncontrarCamino(laberinto, filaInicial - 1, columnaInicial, filaFinal, columnaFinal) ||
            EncontrarCamino(laberinto, filaInicial, columnaInicial + 1, filaFinal, columnaFinal) ||
            EncontrarCamino(laberinto, filaInicial, columnaInicial - 1, filaFinal, columnaFinal))
        {
            return true;
        }

        laberinto[filaInicial][columnaInicial] = 0;
        return false;
    }

    public static void Main()
    {
        int[][] laberinto1 = {
            new int[] { 0, 1, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 0, 1, 1 },
            new int[] { 0, 0, 0, 0, 0 }
        };

        int[][] laberinto2 = {
            new int[] { 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 1, 0, 1, 0, 0, 0, 1, 1 },
            new int[] { 1, 0, 0, 0, 1, 1, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 0, 0, 0, 0, 1, 0 },
            new int[] { 0, 1, 1, 1, 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 0 }
        };

        int[][] laberinto3 = {
            new int[] { 0, 1, 0, 0, 0, 1, 0, 0, 0, 1 },
            new int[] { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 },
            new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 },
            new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 0 },
            new int[] { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
            new int[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0, 1, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        //Console.WriteLine(EncontrarCamino(laberinto1, 0, 0, 4, 4));
        //Console.WriteLine(EncontrarCamino(laberinto2, 0, 0, 7, 4));
        Console.WriteLine(EncontrarCamino(laberinto3, 0, 0, 9, 9));
    }
}
