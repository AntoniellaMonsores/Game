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

    public static void GameExcluir(int idGame)
    {
        // Exclusão de um elemento do array "games" por seu índice
        // Deslocamento dos elementos do array
        // Redefinição do tamanho do array

        for (int i = idGame; i < games.Length - 1; i++) 
        {
            games[i] = games[i + 1];
        }

        Array.Resize(ref games, nGames--);
    }

    /*public _ GameAtualizar()
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
        // Inserção do obj na lista de jogadores
        players.Add(obj);
    }

    public static void PlayerExcluir(Player obj)
    {
        // Exclusão de um obj da lista de jogadores
        players.Remove(obj);
    }

    /*
    public _ PlayerAtualizar()
    {
        
    }*/

    public static List<Player> PlayerListar()
    {
        // Retorno dos elementos da lista de jogadores
        return players;
    }
}
