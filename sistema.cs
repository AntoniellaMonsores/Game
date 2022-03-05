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
        // Inserção do obj no array

        if (nGames == games.Length) 
        {
            Array.Resize(ref games, games.Length + 1);
        }

        games[nGames++] = obj;
    }

    /*public _ GameExcluir()
    {
        
    }
    
    public _ GameAtualizar()
    {
        
    }*/

    public static Game[] GameListar()
    {
        // Retorno de todos os elementos presentes no array "games"
        // Criação de um array auxiliar e passagem dos elementos
        // Apenas o array auxiliar deve ser retornado
        
        Game[] aux = new Game[nGames];
        Array.Copy(games, aux, nGames);

        return aux;
    }

    public static void PlayerInserir(Player obj)
    {
        // Inserção do obj na lista
        players.Add(obj);
    }

    public static void PlayerExcluir(Player obj)
    {
        // Exclusão de um obj da lista "players"
        players.Remove(obj);
    }

    /*
    public _ PlayerAtualizar()
    {
        
    }*/

    public static List<Player> PlayerListar()
    {
        // Retorno dos objetos da lista "players"
        return players;
    }
}
