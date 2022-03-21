using System;
using System.Collections.Generic;

class Program
{
    public static string CharRepeat(int n)
    {
        // Inclemento para visualização (menus)
        // Uso repetido de um caracter por um número 'n' de vezes

        string caracter = new string('-', n); 
        return caracter;
    }

    public static void CharRepeat()
    {
        // Chamada do método 'CharRepeat(int n)' com valor fixo de 'n'

        Console.WriteLine($"\n{CharRepeat(46)}");
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
        // Listagem de opções ao usuário
        
        int[] op = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int func;

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

        try 
        {
            func = int.Parse(Console.ReadLine());

            if (Array.IndexOf(op, func) == -1) throw new ArgumentOutOfRangeException(); 
            else return func;
        }

        catch
        {
            CharRepeat();
            Console.WriteLine("\nErro: opção inválida");
            CharRepeat();

            return -1;
        }
    }

    public static void MenuScore()
    {
        // Usado em classes referentes ao score
        // Possibilita a checagem de jogos e jogadores cadastrados

        int func = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogos cadastrados");
            Console.WriteLine("01 - Lembrar jogadores cadastrados");
            Console.WriteLine("02 - Continuar");
            Console.WriteLine();

            try 
            {
                func = int.Parse(Console.ReadLine());

                switch (func)
                {
                    case 0:
                        ListarGames();
                        break;
                    case 1:
                        ListarUsers();
                        break;
                    case 2: break;
                    default: throw new ArgumentOutOfRangeException(); 
                }
            }

            catch
            {
                CharRepeat();
                Console.WriteLine("\nErro: opção inválida");
                CharRepeat();
            }
        }

        while (func != 2);
    }

    public static void MenuGame()
    {
        // Usado em classes referentes ao jogo
        // Possibilita a visualização dos jogos cadastrados

        int func = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogos cadastrados");
            Console.WriteLine("01 - Continuar");
            Console.WriteLine();

            try
            {
                func = int.Parse(Console.ReadLine());

                switch (func)
                {
                    case 0:
                        ListarGames();
                        break;
                    case 1: break;
                    default: throw new ArgumentOutOfRangeException(); 
                }
            }

            catch
            {
                CharRepeat();
                Console.WriteLine("\nErro: opção inválida");
                CharRepeat();
            }
        }

        while (func != 1);
    }

    public static void MenuUser()
    {
        // Usado em classes referentes ao jogador
        // Possibilita a visualização dos jogadores cadastrados

        int func = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogadores cadastrados");
            Console.WriteLine("01 - Continuar");
            Console.WriteLine();

            try 
            {
                func = int.Parse(Console.ReadLine());

                switch (func)
                {
                    case 0:
                        ListarUsers();
                        break;
                    case 1: break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }

            catch
            {
                CharRepeat();
                Console.WriteLine("\nErro: opção inválida");
                CharRepeat();
            }
        }

        while (func != 1);
    }

    public static void CadastrarGame()
    {
        // Cadastro de jogos

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

        Console.WriteLine("\nprocesso finalizado");
        CharRepeat();
    }

    public static void CadastrarUser()
    {
        // Cadastro de jogadores (ou usuários)

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

        Console.WriteLine("\nprocesso finalizado");
        CharRepeat();
    }

    public static void CadastrarScore()
    {
        // Cadastro de pontuações
        // Se associa a um jogo e jodador específicos

        int nivel;
        int idGame;
        int idUser;
        double pontos;
        DateTime data;

        MenuScore();

        Console.WriteLine();
        Console.WriteLine($"{CharRepeat(13)} Dados da pontuação {CharRepeat(13)}");
        Console.WriteLine();

        try 
        {
            Console.Write("Id do jogo: ");
            idGame = int.Parse(Console.ReadLine());
            
            // Verificar se o jogo está cadastrado no Sistema
            if (!Sistema.GameIn(idGame)) throw new Exception("\nErro: jogo não encontrado");

            Console.Write("Id do jogador: ");
            idUser = int.Parse(Console.ReadLine());
            
            // Verificar se o jogador está cadastrado no Sistema
            if (!Sistema.PlayerIn(idUser)) throw new Exception("\nErro: jogador não encontrado");

            Console.Write("Data: ");
            data = DateTime.Parse(Console.ReadLine());

            Console.Write("Nivel: ");
            nivel = int.Parse(Console.ReadLine());

            Console.Write("Pontuação: ");
            pontos = double.Parse(Console.ReadLine());

            Score obj = new Score(nivel, idGame, idUser, pontos, data);
            Sistema.ScoreInserir(obj);

            Console.WriteLine("\nprocesso finalizado");
            CharRepeat();
        }

        catch (FormatException)
        {
            CharRepeat();
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            CharRepeat();
        }
    }

    public static void AtualizarGame()
    {
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

            Console.WriteLine("\nprocesso finalizado");
        }

        else Console.WriteLine("\nErro: jogo não encontrado");

        CharRepeat();
    }

    public static void AtualizarUser()
    {
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

        Console.WriteLine("\nprocesso finalizado");
        CharRepeat();
    }

    public static void AtualizarScore()
    {
        // Mudança dos dados referentes à pontuação
        // O id não será alterado
        // O jogo e jogador associados a ela não serão alterados

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

        Console.WriteLine("\nprocesso finalizado");
        CharRepeat();
    }

    public static void ExcluirGame()
    {
        // Resulta na exclusão de um jogo
        // O id deve ser informado

        MenuGame();

        int id;

        CharRepeat();
        Console.WriteLine();

        try 
        {
            Console.Write("Id do jogo: ");
    
            id = int.Parse(Console.ReadLine());
    
            if (Sistema.GameIn(id)) 
            {
                Game obj = new Game(id, "", "", 0);
                Sistema.GameExcluir(obj);
                Console.WriteLine("\nprocesso finalizado");
            }
    
            else Console.WriteLine("\nErro: jogo não encontrado");

            CharRepeat();
        }

        catch 
        { 
            CharRepeat();
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            ExcluirGame();
        }
    }

    public static void ExcluirUser()
    {
        // Resulta na exclusão do jogador
        // O id deve ser informado

        int id;

        MenuUser();

        Console.WriteLine();
        Console.Write("Id do jogador: ");

        id = int.Parse(Console.ReadLine());

        Player obj = new Player(id, 0, "", "", "");
        Sistema.PlayerExcluir(obj);

        Console.WriteLine("\nprocesso finalizado");
        CharRepeat();
    }

    public static void ExcluirScore()
    {
        // Faz uso da classe ListarScore()
        // Resulta na exclusão do score informado

        int id;
        int[] valores = ListarScore();

        try 
        {
            Console.WriteLine();
            Console.Write("Id da pontuação: ");
            id = int.Parse(Console.ReadLine());
            
            if (!Sistema.ScoreIn(id, valores[0], valores[1])) throw new Exception("\nErro: pontuação não encontrada");
            Sistema.ScoreExcluir(Sistema.ScoreListar(id, valores[0], valores[1]));

            Console.WriteLine("\nprocesso finalizado");
            CharRepeat();
        }

        catch (FormatException)
        {
            CharRepeat();
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            ExcluirScore();
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            CharRepeat();
        }
    }

    public static void ListarGames()
    {
        // Listagem de todos os jogos cadastrados

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
        // Listagem de todos os jogadores (ou usuários) cadastrados

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
        // Listagem de todos os scores associados a um jogo e jogador específicos

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

        if (score.Count == 0)
        {
            Console.WriteLine("não há pontuações cadastradas");
        }

        else 
        {
            for (int i = 0; i < score.Count; i++)
            {
                Console.WriteLine($"{i:000} - {score[i]}");
            }
        }

        CharRepeat(); 

        int[] valores = { idGame, idUser };

        return valores;
    }
}
