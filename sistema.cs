using System;
using System.Collections.Generic;

class Sistema {

    private static Game[] games = new Game[5];
    private static int nGames;
    private static List<Player> players = new List<Player>();

    public static void GameInserir(Game obj)
    {
        // Checagem do tamanho do array
        // Possível reconfiguração do tamanho
        if (nGames == games.Length) 
        {
            Array.Resize(ref games, games.Length + 1);
        }

        games[nGames++] = obj;
    }
}
