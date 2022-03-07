using System;
using System.Collections.Generic;

class Sistema {

    private static Game[] games = new Game[5];
    private static int nGames;
    private static List<Player> players = new List<Player>();
    private static List<Score> score = new List<Score>();

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

    public static void PlayerExcluir(int idUser)
    {
        // Exclusão de um elemento da lista de jogadores
        // Exclusão feita a partir do índice do elemento
        
        players.RemoveAt(idUser);
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

    public static void ScoreInserir(Score obj)
    {
        // Inserção do obj na lista de jogadores
        score.Add(obj);
    }

    public static void ScoreExcluir(int idScore)
    {
        // Exclusão de um elemento da lista de jogadores
        // Exclusão feita a partir do índice do elemento
        
        score.RemoveAt(idScore);
    }

     public static void ScoreAtualizar(Score obj)
    {
        // O ScoreListar recebe dois argumentos: idGame e idUser
        // Score não possui o método GetId
        
        Score aux = ScoreListar(obj.GetGameId(), obj.GetUserId());
        if (aux != null) {
        aux.SetNivel(obj.GetNivel());
        aux.SetGameId(obj.GetGameId());
        aux.SetUserId(obj.GetUserId());
        aux.SetPontos(obj.GetPontos());
        aux.SetData(obj.GetData());
      }
    }

    public static List<Score> ScoreListar(int idGame, int idUser)
    {
        // Retorno dos elementos da lista de jogadores
        // Criação de uma lista auxiliar
        // Retorno apenas da pontuação referente ao jogo e jogador informado

        List<Score> aux = new List<Score>();
        
        foreach (Score s in score)
        {
            if (s.GetGameId() == idGame && s.GetUserId() == idUser)
                aux.Add(s);
        }
        
        return aux;
    }
}
