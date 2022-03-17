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

    public static bool GameIn(int id)
    {
        // Verificar se um jogo está cadastrado
        
        try 
        {
            Game obj = new Game(id, "", "", 0);
            GameListar(obj.GetId());
            return true;
        }

        catch (NullReferenceException)
        {
            Console.WriteLine();
            Console.WriteLine("Erro: jogo não encontrado.");
            return false;
        }
    }

    public static void GameAtualizar(Game obj)
    {
        // Atualização de dados referentes a um jogo
        // O id permanecerá o mesmo

        Game aux = GameListar(obj.GetId());
            
        if (aux != null)
        {
            aux.SetNome(obj.GetNome());
            aux.SetGenero(obj.GetGenero());
            aux.SetNiveis(obj.GetNiveis());
        }
    }
    
    public static void GameExcluir(Game obj)
    {
        // Exclusão de um elemento do array "games" por seu índice
        // Deslocamento dos elementos do array
        // Redefinição do tamanho do array

        int ind = Array.IndexOf(games, GameListar(obj.GetId()));

        for (int i = ind; i < nGames - 1; i++) 
        {
            games[i] = games[i + 1];
        }

        nGames--;
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
        // FindIndex : retorno do índice do elemento com parâmetro apresentado
        
        int ind = Array.FindIndex(games, obj => obj.GetId() == id);

        if (games[ind] != null) return games[ind];

        return null;
    }

    public static void PlayerInserir(Player obj)
    {
        // Inserção do obj na lista de jogadores
        
        players.Add(obj);
    }

    public static void PlayerAtualizar(Player obj)
    {
        // Atualização de dados referentes a um jogador
        // O id permanecerá o mesmo

        Player aux = PlayerListar(obj.GetId());
        
        if (aux != null)
        {
            aux.SetNome(obj.GetNome());
            aux.SetIdade(obj.GetIdade());
            aux.SetEmail(obj.GetEmail());
            aux.SetApelido(obj.GetApelido());
        }
    }

    public static void PlayerExcluir(Player obj)
    {
        // Exclusão de um elemento da lista de jogadores
        // Exclusão feita a partir do índice do elemento
        
        Player aux = PlayerListar(obj.GetId());
        
        if (aux != null) players.Remove(aux);
    }

    public static List<Player> PlayerListar()
    {
        // Retorno dos elementos da lista de jogadores
        
        return players;
    }

    public static Player PlayerListar(int id) 
    {
        // Retorno de um elemento específico da lista de jogos
        // FindIndex : retorno do índice do elemento com parâmetro apresentado
        
        int ind = players.FindIndex(obj => obj.GetId() == id);

        if (players[ind] != null) { return players[ind]; }

        return null;
    }

    public static void ScoreInserir(Score obj)
    {
        // Inserção do obj na lista de jogadores
        
        score.Add(obj);
    }

    public static void ScoreAtualizar(int id, Score obj)
    {
        // Atualização de informações referentes a uma pontuação
        // O método recebe o id (índice) do score e o objeto em si
 
        Score aux = ScoreListar(obj.GetGameId(), obj.GetUserId())[id];
        
        if (aux != null) 
        {
            aux.SetData(obj.GetData());
            aux.SetNivel(obj.GetNivel());
            aux.SetGameId(obj.GetGameId());
            aux.SetUserId(obj.GetUserId());
            aux.SetPontos(obj.GetPontos());
        }
    }

    public static void ScoreExcluir(Score obj)
    {
        // Exclusão de um elemento da lista de jogadores
        // Exclusão feita a partir do índice do elemento
        
        int ind = score.IndexOf(obj);

        if (score[ind] != null) score.RemoveAt(ind);
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
