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

    public static void GameExcluir(Game obj)
    {
        // Exclusão de um elemento do array "games" por seu índice
        // Deslocamento dos elementos do array
        // Redefinição do tamanho do array

        int id = games.IndexOf(obj);
        
        for (int i = id; i < nGames - 1; i++) 
        {
            games[i] = games[i + 1];
        }

        nGames--;
    }

    public static void GameAtualizar(Game obj)
    {
        Game aux = GameListar(obj.GetId());
        
        if (aux != null)
        {
            aux.SetNome(obj.GetNome());
            aux.SetGenero(obj.GetGenero());
            aux.SetNiveis(obj.GetNiveis());
        }
    }
    
    public static Game[] GameListar()
    {
        // Retorno de todos os elementos presentes no array "games"
        // Criação de um array auxiliar e passagem dos elementos
        // Apenas o array auxiliar deve ser retornado
        
        Game[] aux = new Game[nGames];
        Array.Copy(games, aux, nGames);

        return aux;
    }

    public static Game GameListar(int id)
    {
        // Retorno de um elemento específico da lista de jogos
        
        return games[id];
    }

    public static void PlayerInserir(Player obj)
    {
        // Inserção do obj na lista de jogadores
        
        players.Add(obj);
    }

    public static void PlayerExcluir(Player obj)
    {
        // Exclusão de um elemento da lista de jogadores
        // Exclusão feita a partir do índice do elemento
        
        int id = players.IndexOf(obj);
        players.RemoveAt(id);
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

    public static void ScoreExcluir(Score obj)
    {
        // Exclusão de um elemento da lista de jogadores
        // Exclusão feita a partir do índice do elemento
        
        int id = score.IndexOf(obj);
        score.RemoveAt(id);
    }

    public static void ScoreAtualizar(int id, Score obj)
    {
        // Atualização de informações referentes à pontuação
        // O método recebe o id (índice) do score e o objeto em si
 
        Score aux = ScoreListar(obj.GetGameId(), obj.GetUserId())[id];
        
        if (aux != null) 
        {
            aux.SetNivel(obj.GetNivel());
            aux.SetGameId(obj.GetGameId());
            aux.SetUserId(obj.GetUserId());
            aux.SetPontos(obj.GetPontos());
            aux.SetData(obj.GetData());
        }
    }

    public static List<Score> ScoreListar(int idGame, int idUser)
    {
        // Retorno dos elementos da lista de pontos
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

    public static Score ScoreListar(int id, int idGame, int idUser)
    {
        // Retorno de um elemento específico da lista de pontos
        // Cada pontuação está associada a um jogo e jogador específicos
        
        Score obj = ScoreListar(idGame, idUser)[id];

        if (obj != null) return obj;

        return null;
    }
}
