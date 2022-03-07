using System;
using System.Collections.Generic;

class Program {

    public static void Main(string[] args)
    {
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
                case 4 : ListarGames();
                    break;
                case 5 : ListarUsers();
                    break;
                case 6 : ListarScore();
                    break;
                case 7 : ExcluirGame();
                    break;
                case 8 : ExcluirUser();
                    break;
                case 9 : ExcluirScore();
                    break;
            }
        }

        while (func != 0);
    }

    public static int MenuInicial()
    {
        Console.WriteLine();
        Console.WriteLine("O que deseja?");
        Console.WriteLine("01 - Cadastrar jogo");
        Console.WriteLine("02 - Cadastrar jogador");
        Console.WriteLine("03 - Cadastrar pontuação");
        Console.WriteLine("04 - Visualizar jogos cadastrados");
        Console.WriteLine("05 - Visualizar jogadores cadastrados");
        Console.WriteLine("06 - Visualizar pontuação");
        Console.WriteLine("07 - Excluir jogo");
        Console.WriteLine("08 - Excluir jogador");
        Console.WriteLine("09 - Excluir pontuação");
        Console.WriteLine("00 - Sair do sistema");
        Console.WriteLine();

        return int.Parse(Console.ReadLine());
    }

    public static int MenuSecundario()
    {
        Console.WriteLine();
        Console.WriteLine("00 - Lembrar jogos cadastrados");
        Console.WriteLine("01 - Lembrar jogadores cadastrados");
        Console.WriteLine("02 - Continuar");
        
        return int.Parse(Console.ReadLine());
    }
    
    public static void CadastrarGame() 
    {
        Console.WriteLine();
        Console.WriteLine("Informações referentes ao jogo");
        Console.WriteLine();
        
        Console.Write("Numeração: ");
        int id = int.Parse(Console.ReadLine());
        
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Gênero: ");
        string genero = Console.ReadLine();

        Console.Write("Quantidade de níveis: ");
        int niveis = int.Parse(Console.ReadLine());
        
        Game game = new Game(id, nome, genero, niveis);
        Sistema.GameInserir(game);
    }

    public static void CadastrarUser() 
    {   
        Console.WriteLine();
        Console.WriteLine("Informações referentes ao jogador");
        Console.WriteLine();
        
        Console.Write("Numeração: ");
        int id = int.Parse(Console.ReadLine());
        
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Apelido: ");
        string apelido = Console.ReadLine();
        
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Player user = new Player(id, idade, apelido, nome, email);
        Sistema.PlayerInserir(user);
    }

    public static void CadastrarScore() 
    {
        int func;
        
        do 
        {
            func = MenuSecundario();
            
            switch (func) {
                case 0 : ListarGames(); 
                    break;
                case 1 : ListarUsers(); 
                    break;
            }
        }

        while (func != 2);
        
        Console.WriteLine();
        Console.WriteLine("Informações referentes à pontuação");
        Console.WriteLine();
        
        Console.Write("Numeração do jogo: ");
        int idGame = int.Parse(Console.ReadLine());

        Console.Write("Numeração do jogador: ");
        int idUser = int.Parse(Console.ReadLine());

        Console.Write("Nivel: ");
        int nivel = int.Parse(Console.ReadLine());

        Console.Write("Pontuação: ");
        double pontos = int.Parse(Console.ReadLine());

        Console.Write("Data: ");
        DateTime data = DateTime.Parse(Console.ReadLine());

        Score score = new Score(nivel, idGame, idUser, pontos, data);
        Sistema.ScoreInserir(score);
    }

    public static void ListarGames()
    {
        Game[] games = Sistema.GameListar();
        
        Console.WriteLine();
        
        for (int i = 0; i < games.Length; i++)
            Console.WriteLine($"{games[i]}");
    }
    
    public static void ListarUsers()
    {
        List<Player> users = Sistema.PlayerListar();
        
        Console.WriteLine();
        
        for (int i = 0; i < users.Count; i++)
            Console.WriteLine($"{users[i]}");
    }
    
    public static void ListarScore()
    {
        int func;
        
        Console.WriteLine();
        Console.WriteLine("A pontuação será dada de acordo com o jogo e jogador informado");
        
        do 
        {
            func = MenuSecundario();
            
            switch (func) {
                case 0 : ListarGames(); 
                    break;
                case 1 : ListarUsers(); 
                    break;
            }
        }

        while (func != 2);
        
        Console.WriteLine();
        
        Console.Write("Id do jogo: ");
        int idGame = int.Parse(Console.ReadLine());

        Console.Write("Id do usuário: ");
        int idUser = int.Parse(Console.ReadLine());
        
        List<Score> score = Sistema.ScoreListar(idGame, idUser);
        
        Console.WriteLine();
        
        for (int i = 0; i < score.Count; i++)
            Console.WriteLine($"{score[i]}");
    }

}
