using System;

class Program {

    public static void Main(string[] args)
    {
        int func;
        
        Console.WriteLine("Bem-vindo(a)!");
        Console.WriteLine();
        
        Console.WriteLine("O que deseja?");
        Console.WriteLine("00 - Cadastrar jogo");
        Console.WriteLine("01 - Cadastrar jogador");
        Console.WriteLine("02 - Cadastrar pontuação");
        Console.WriteLine("03 - Visualizar jogos cadastrados");
        Console.WriteLine("04 - Visualizar jogadores cadastrados");
        Console.WriteLine("05 - Visualizar pontuação");
        Console.WriteLine();

        func = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (func) 
        {
            case 0 : CadastrarGame(); 
                break;
            case 1 : CadastrarUser(); 
                break;
            case 2 : CadastrarScore();
                break;
        }

    }
    
    public static void CadastrarGame() 
    {
        Console.WriteLine("Informações referentes ao jogo");
        Console.WriteLine();
        
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Gênero: ");
        string genero = Console.ReadLine();

        Console.Write("Quantidade de níveis: ");
        int niveis = int.Parse(Console.ReadLine());
        
        Game game = new Game(nome, genero, niveis);
        Sistema.GameInserir(game);
    }

    public static void CadastrarUser() 
    {        
        Console.WriteLine("Informações referentes ao jogador");
        Console.WriteLine();
        
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Apelido: ");
        string id = Console.ReadLine();
        
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Player user = new Player(idade, id, nome, email);
        Sistema.PlayerInserir(user);
    }

    public static void CadastrarScore() 
    {
        
        
    }
    
}
