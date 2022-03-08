using System;
using System.Collections.Generic;

class Program {

    public static void Main(string[] args)
    {
        // Classe Main
        // Determinação dos "serviços" a serem prestados

        int func;
        
        Console.WriteLine("Bem-vindo(a)!");
        
        do 
        {
            func = MenuInicial();
            
            switch (func) {
                case 0 : break;
                case 1 : CadastrarGame(); 
                    break;
                case 2 : CadastrarUser(); 
                    break;
                case 3 : CadastrarScore();
                    break;
                case 4 : AtualizarGame();
                    break;
                case 5 : AtualizarUser();
                    break;
                case 6 : AtualizarScore();
                    break;
                case 7 : ExcluirGame();
                    break;
                case 8 : ExcluirUser();
                    break;
                case 9 : ExcluirScore();
                    break;
                case 10 : ListarGames();
                    break;
                case 11 : ListarUsers();
                    break;
                case 12 : ListarScore();
                    break;
            }
        }

        while (func != 0);
    }

    public static int MenuInicial()
    {
        // Menu inicial
        // Visualização do usuário

        Console.WriteLine();
        Console.WriteLine("O que deseja?");
        Console.WriteLine("01 - Cadastrar jogo");
        Console.WriteLine("02 - Cadastrar jogador");
        Console.WriteLine("03 - Cadastrar pontuação");
        Console.WriteLine("04 - Atualizar jogo");
        Console.WriteLine("05 - Atualizar jogador");
        Console.WriteLine("06 - Atualizar pontuação");
        Console.WriteLine("07 - Excluir jogo");
        Console.WriteLine("08 - Excluir jogador");
        Console.WriteLine("09 - Excluir pontuação");
        Console.WriteLine("10 - Visualizar jogos cadastrados");
        Console.WriteLine("11 - Visualizar jogadores cadastrados");
        Console.WriteLine("12 - Visualizar pontuação");
        Console.WriteLine("00 - Sair do sistema");
        Console.WriteLine();

        return int.Parse(Console.ReadLine());
    }

    public static void MenuScore()
    {
        // Menu secundário
        // Usado em classes referentes ao score
        // Possibilita a checagem de jogos e jogadores cadastrados

        int func;

        do 
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogos cadastrados");
            Console.WriteLine("01 - Lembrar jogadores cadastrados");
            Console.WriteLine("02 - Continuar");
            Console.WriteLine();
            
            func = int.Parse(Console.ReadLine());
            
            switch (func) {
                case 0 : ListarGames(); 
                    break;
                case 1 : ListarUsers(); 
                    break;
            }
        }

        while (func != 2);
    }
    

    public static void MenuGame()
    {
        // Menu game
        // Usado em classes referentes ao jogo
        // Possibilita a visualização dos jogos cadastrados

        int func; 
  
        do 
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogos cadastrados");
            Console.WriteLine("01 - Continuar");
            Console.WriteLine();
            
            func = int.Parse(Console.ReadLine());
            
            switch (func) {
                case 0 : ListarGames(); 
                    break;
            }
        }

        while (func != 1);
    }

    public static void CadastrarGame() 
    {
        // Cadastrar game
        // O usuário informa as características do jogo
        // O jogo é inserido no sistema

        int id;
        int niveis;
        string nome;
        string genero;

        Console.WriteLine();
        Console.WriteLine("Dados referentes ao jogo");
        Console.WriteLine();
        
        Console.Write("Numeração: ");
        id = int.Parse(Console.ReadLine());
        
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Gênero: ");
        genero = Console.ReadLine();

        Console.Write("Quantidade de níveis: ");
        niveis = int.Parse(Console.ReadLine());
        
        Game game = new Game(id, nome, genero, niveis);
        Sistema.GameInserir(game);
    }

    public static void CadastrarUser() 
    {   
        // Cadastrar user
        // O usuário informa as características do jogador
        // O jogador é inserido no sistema

        int id;
        int idade;
        string nome;
        string email;
        string apelido;

        Console.WriteLine();
        Console.WriteLine("Dados referentes ao jogador");
        Console.WriteLine();
        
        Console.Write("Numeração: ");
        id = int.Parse(Console.ReadLine());
        
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Apelido: ");
        apelido = Console.ReadLine();
        
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        
        Console.Write("Email: ");
        email = Console.ReadLine();

        Player user = new Player(id, idade, apelido, nome, email);
        Sistema.PlayerInserir(user);
    }

    public static void CadastrarScore() 
    {
        // Cadastrar score
        // Pontuação associada a um jogo e jodador específicos
        // Possibilidade de visualização dos jogos e jogadores já cadastrados
        // O usuário informa as características da pontuação
        // A pontuação é inserida no sistema

        int idGame;
        int idUser;
        int nivel;
        double pontos;
        DateTime data;

        MenuScore();

        Console.WriteLine();
        Console.WriteLine("Dados referentes à pontuação");
        Console.WriteLine();
        
        Console.Write("Numeração do jogo: ");
        idGame = int.Parse(Console.ReadLine());

        Console.Write("Numeração do jogador: ");
        idUser = int.Parse(Console.ReadLine());

        Console.Write("Nivel: ");
        nivel = int.Parse(Console.ReadLine());

        Console.Write("Pontuação: ");
        pontos = double.Parse(Console.ReadLine());

        Console.Write("Data: ");
        data = DateTime.Parse(Console.ReadLine());

        Score score = new Score(nivel, idGame, idUser, pontos, data);
        Sistema.ScoreInserir(score);
    }

    public static void AtualizarGame()
    {
        // Atualizar game
        // Permite a mudança dos dados referentes a um jogo
        // O id não será alterado

        MenuGame();

        Console.Write("Id do jogo a ser atualizado: ");
        id = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Novos dados");
        Console.WriteLine();
        
        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Gênero: ");
        genero = Console.ReadLine();

        Console.Write("Quantidade de níveis: ");
        niveis = int.Parse(Console.ReadLine());
        
        Game game = new Game(id, nome, genero, niveis);
        Sistema.GameAtualizar(game);
    }

    public static void AtualizarUser()
    {
 
    }

    public static void AtualizarScore()
    {
 
    }

    public static void ExcluirGame()
    {
        // Excluir game
        // Permite a vizualização dos jogos cadastrados
        // Resulta na exclusão do jogo correspondente ao id informado

        MenuGame();
        
        int id;
     
        Console.WriteLine();
        Console.Write("Id do jogo: ");
        
        id = int.Parse(Console.ReadLine());

        Game obj = new Game(id, "", "", 0);
        Sistema.GameExcluir(obj);
    }

    public static void ExcluirUser()
    {
        // Excluir user
        // Permite a vizualização dos jogadores cadastrados
        // Resulta na exclusão do jogador correspondente ao id informado

        int func; 
        int id;
        
        do 
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogadores cadastrados");
            Console.WriteLine("01 - Continuar");
            Console.WriteLine();
            
            func = int.Parse(Console.ReadLine());
            
            switch (func) {
                case 0 : ListarUsers(); 
                    break;
            }
        }

        while (func != 1);
        
        Console.WriteLine();
        Console.Write("Numeração do jogador: ");
        
        id = int.Parse(Console.ReadLine());

        Player obj = new Player(id, 0, "", "", "");
        Sistema.PlayerExcluir(obj);
    }

    public static void ExcluirScore()
    {
        // Excluir user
        // Faz uso da classe ListarScore()
        // Resulta na exclusão do score informado

        int id;
        int[] valores = ListarScore();

        Console.WriteLine();
        Console.Write("Numeração do score: ");

        id = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Sistema.ScoreExcluir(Sistema.ScoreListar(id, valores[0], valores[1]));
    }

    public static void ListarGames()
    {
        // Listar games
        // Listagem de todos os jogos atualmente cadastrados no sistema

        Game[] games = Sistema.GameListar();
        
        Console.WriteLine();
        
        for (int i = 0; i < games.Length; i++)
        {
            Console.WriteLine($"{games[i]}");
        }
    }
    
    public static void ListarUsers()
    {
        // Listar users
        // Listagem de todos os jogadores atualmente cadastrados no sistema

        List<Player> users = Sistema.PlayerListar();
        
        Console.WriteLine();
        
        for (int i = 0; i < users.Count; i++)
        {
            Console.WriteLine($"{users[i]}");
        }
    }
    
    public static int[] ListarScore()
    {
        // Listar score
        // Listagem de todos os scores associados a um jogo e jogador específicos
        // Possível visualização dos jogos e jogadores cadastrados no sistema

        int idGame;
        int idUser;
       
        MenuScore();
    
        Console.Write("Numeração do jogo: ");
        idGame = int.Parse(Console.ReadLine());

        Console.Write("Numeração do usuário: ");
        idUser = int.Parse(Console.ReadLine());
        
        List<Score> score = Sistema.ScoreListar(idGame, idUser);
        
        Console.WriteLine();
        
        for (int i = 0; i < score.Count; i++)
            Console.WriteLine($"{i:0000} - {score[i]}");

        int[] valores = {idGame, idUser};

        return valores;
    }
}
