using System;
using System.Collections.Generic;

class Program
{
    public static string CharRepeat(int n)
    {
        // Inclemento para visualização
        // Uso repetido de um determinado caracter por um número n de vezes

        return new string('-', n);
    }

    public static void CharRepeat()
    {
        // Inclemento para visualização
        // Uso repetido de um determinado caracter

        Console.WriteLine($"\n{new string('-', 46)}");
    }

    public static void Main(string[] args)
    {
        // Classe Main
        // Determinação dos "serviços" a serem prestados

        int func;

        Console.WriteLine($"{CharRepeat(20)} Game {CharRepeat(20)}");

        do
        {
            func = MenuInicial();

            switch (func)
            {
                case 0: break;
                case 1:
                    CadastrarGame();
                    break;
                case 2:
                    CadastrarUser();
                    break;
                case 3:
                    CadastrarScore();
                    break;
                case 4:
                    AtualizarGame();
                    break;
                case 5:
                    AtualizarUser();
                    break;
                case 6:
                    AtualizarScore();
                    break;
                case 7:
                    ExcluirGame();
                    break;
                case 8:
                    ExcluirUser();
                    break;
                case 9:
                    ExcluirScore();
                    break;
                case 10:
                    ListarGames();
                    break;
                case 11:
                    ListarUsers();
                    break;
                case 12:
                    ListarScore();
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
        Console.WriteLine("Escolha de operações");
        Console.WriteLine();
        Console.WriteLine("00 - Sair do sistema");
        Console.WriteLine("01 - Cadastrar jogo");
        Console.WriteLine("02 - Cadastrar jogador");
        Console.WriteLine("03 - Cadastrar pontuação");
        Console.WriteLine("04 - Atualizar jogo");
        Console.WriteLine("05 - Atualizar jogador");
        Console.WriteLine("06 - Atualizar pontuação");
        Console.WriteLine("07 - Excluir jogo");
        Console.WriteLine("08 - Excluir jogador");
        Console.WriteLine("09 - Excluir pontuação");
        Console.WriteLine("10 - Visualizar jogos");
        Console.WriteLine("11 - Visualizar jogadores");
        Console.WriteLine("12 - Visualizar pontuações");
        Console.WriteLine();

        return int.Parse(Console.ReadLine());
    }

    public static void MenuScore()
    {
        // Menu score
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

            switch (func)
            {
                case 0:
                    ListarGames();
                    break;
                case 1:
                    ListarUsers();
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

            switch (func)
            {
                case 0:
                    ListarGames();
                    break;
            }
        }

        while (func != 1);
    }

    public static void MenuUser()
    {
        // Menu user
        // Usado em classes referentes ao jogador
        // Possibilita a visualização dos jogadores cadastrados

        int func;

        do
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogadores cadastrados");
            Console.WriteLine("01 - Continuar");
            Console.WriteLine();

            func = int.Parse(Console.ReadLine());

            switch (func)
            {
                case 0:
                    ListarUsers();
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
        Console.WriteLine($"{CharRepeat(16)} Dados do Jogo {CharRepeat(15)}");
        Console.WriteLine();

        Console.Write("Id: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Gênero: ");
        genero = Console.ReadLine();

        Console.Write("Qtd. de níveis: ");
        niveis = int.Parse(Console.ReadLine());

        Game obj = new Game(id, nome, genero, niveis);
        Sistema.GameInserir(obj);

        CharRepeat();
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
        Console.WriteLine($"{CharRepeat(14)} Dados do Jogador {CharRepeat(14)}");
        Console.WriteLine();

        Console.Write("Id: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Apelido: ");
        apelido = Console.ReadLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Email: ");
        email = Console.ReadLine();

        Player obj = new Player(id, idade, apelido, nome, email);
        Sistema.PlayerInserir(obj);

        CharRepeat();
    }

    public static void CadastrarScore()
    {
        // Cadastrar score
        // Pontuação associada a um jogo e jodador específicos
        // Possibilidade de visualização dos jogos e jogadores já cadastrados
        // O usuário informa as características da pontuação
        // A pontuação é inserida no sistema

        int nivel;
        int idGame;
        int idUser;
        double pontos;
        DateTime data;

        MenuScore();

        Console.WriteLine();
        Console.WriteLine($"{CharRepeat(13)} Dados da pontuação {CharRepeat(13)}");
        Console.WriteLine();

        Console.Write("Data: ");
        data = DateTime.Parse(Console.ReadLine());

        Console.Write("Nivel: ");
        nivel = int.Parse(Console.ReadLine());

        Console.Write("Pontuação: ");
        pontos = double.Parse(Console.ReadLine());

        Console.Write("Id do jogo: ");
        idGame = int.Parse(Console.ReadLine());

        Console.Write("Id do jogador: ");
        idUser = int.Parse(Console.ReadLine());

        Score obj = new Score(nivel, idGame, idUser, pontos, data);
        Sistema.ScoreInserir(obj);

        CharRepeat();
    }

    public static void AtualizarGame()
    {
        // Atualizar game
        // Permite a mudança dos dados referentes a um jogo
        // O id não será alterado

        int id;
        int niveis;
        string nome;
        string genero;

        MenuGame();

        CharRepeat();
        Console.WriteLine();

        Console.Write("Id do jogo: ");
        id = int.Parse(Console.ReadLine());

        if (Sistema.GameIn(id))
        {
            Console.WriteLine();
            Console.WriteLine("Novos dados");
            Console.WriteLine();

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Gênero: ");
            genero = Console.ReadLine();

            Console.Write("Qtd. de níveis: ");
            niveis = int.Parse(Console.ReadLine());

            Game game = new Game(id, nome, genero, niveis);
            Sistema.GameAtualizar(game);
        }

        CharRepeat();
    }

    public static void AtualizarUser()
    {
        // Atualizar user
        // Permite a mudança dos dados referentes a um jogador
        // O id não será alterado

        int id;
        int idade;
        string nome;
        string email;
        string apelido;

        MenuUser();

        Console.WriteLine();
        Console.Write("Id do jogador: ");
        id = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Novos dados");
        Console.WriteLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Apelido: ");
        apelido = Console.ReadLine();

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Email: ");
        email = Console.ReadLine();

        Player obj = new Player(id, idade, apelido, nome, email);
        Sistema.PlayerAtualizar(obj);
    }

    public static void AtualizarScore()
    {
        // Atualizar score
        // Permite a mudança dos dados referentes à pontuação
        // O id não será alterado
        // O jogo e o jogador a ela [pontuação] associados também não serão alterados

        int id;
        int nivel;
        double pontos;
        DateTime data;

        int[] valores = ListarScore();

        CharRepeat();
        Console.WriteLine();

        Console.Write("Id da pontuação: ");
        id = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Novos dados");
        Console.WriteLine();

        Console.Write("Nivel: ");
        nivel = int.Parse(Console.ReadLine());

        Console.Write("Pontuação: ");
        pontos = double.Parse(Console.ReadLine());

        Console.Write("Data: ");
        data = DateTime.Parse(Console.ReadLine());

        Score obj = new Score(nivel, valores[0], valores[1], pontos, data);
        Sistema.ScoreAtualizar(id, obj);

        CharRepeat();
    }

    public static void ExcluirGame()
    {
        // Excluir game
        // Permite a vizualização dos jogos cadastrados
        // Resulta na exclusão do jogo correspondente ao id informado

        MenuGame();

        int id;

        CharRepeat();
        Console.WriteLine();
        Console.Write("Id do jogo: ");

        id = int.Parse(Console.ReadLine());

        if (Sistema.GameIn(id)) 
        {
            Game obj = new Game(id, "", "", 0);
            Sistema.GameExcluir(obj);
        }

        CharRepeat();
    }

    public static void ExcluirUser()
    {
        // Excluir user
        // Permite a vizualização dos jogadores cadastrados
        // Resulta na exclusão do jogador correspondente ao id informado

        int id;

        MenuUser();

        Console.WriteLine();
        Console.Write("Id do jogador: ");

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
        Console.Write("Id da pontuação: ");

        id = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Sistema.ScoreExcluir(Sistema.ScoreListar(id, valores[0], valores[1]));
    }

    public static void ListarGames()
    {
        // Listar games
        // Listagem de todos os jogos atualmente cadastrados no sistema

        Game[] games = Sistema.GameListar();

        CharRepeat();
        Console.WriteLine();

        if (games.Length == 0)
        {
            Console.WriteLine("não há jogos cadastrados");
        }

        else
        {
            for (int i = 0; i < games.Length; i++)
            {
                Console.WriteLine($"{games[i]}");
            }
        }

        CharRepeat();
    }

    public static void ListarUsers()
    {
        // Listar users
        // Listagem de todos os jogadores atualmente cadastrados no sistema

        List<Player> users = Sistema.PlayerListar();

        CharRepeat();
        Console.WriteLine();

        if (users.Count == 0)
        {
            Console.WriteLine("não há jogadores cadastrados");
        }

        else
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{users[i]}");
            }
        }

        CharRepeat();
    }

    public static int[] ListarScore()
    {
        // Listar score
        // Listagem de todos os scores associados a um jogo e jogador específicos
        // Possível visualização dos jogos e jogadores cadastrados no sistema

        int idGame;
        int idUser;

        MenuScore();

        Console.WriteLine();

        Console.Write("Id do jogo: ");
        idGame = int.Parse(Console.ReadLine());

        Console.Write("Id do jogador: ");
        idUser = int.Parse(Console.ReadLine());

        List<Score> score = Sistema.ScoreListar(idGame, idUser);

        CharRepeat();
        Console.WriteLine();

        for (int i = 0; i < score.Count; i++)
        {
            Console.WriteLine($"{i:0000} - {score[i]}");
        }

        CharRepeat();

        int[] valores = { idGame, idUser };

        return valores;
    }
}
