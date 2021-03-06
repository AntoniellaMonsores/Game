using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

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
        Console.WriteLine($"\n{CharRepeat(54)}");
    }

    public static void Main()
    {
        // Classe Main
        // Determinação dos "serviços" a serem prestados

        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

        // Leitura de arquivos
        try 
        { 
            Sistema.ArquivosAbrir(); 
        }
        
        catch (Exception erro) 
        {
            Console.WriteLine($"\nErro: {erro.Message}");
        }
        
        int func;

        Console.WriteLine($"{CharRepeat(24)} Game {CharRepeat(24)}");

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
                    CadastrarPlayer();
                    break;
                case 3:
                    CadastrarScore();
                    break;
                case 4:
                    AtualizarGame();
                    break;
                case 5:
                    AtualizarPlayer();
                    break;
                case 6:
                    AtualizarScore();
                    break;
                case 7:
                    ExcluirGame();
                    break;
                case 8:
                    ExcluirPlayer();
                    break;
                case 9:
                    ExcluirScore();
                    break;
                case 10:
                    ListarGame();
                    break;
                case 11:
                    ListarPlayer();
                    break;
                case 12:
                    ListarScore();
                    break;
                case 13:
                    PesquisarGame();
                    break;
                case 14:
                    PesquisarPlayer();
                    break;
            }
        }

        while (func != 0);

        // Fechamento de arquivos
        try 
        {
            Sistema.ArquivosSalvar();
        }
    
        catch (Exception erro) 
        {
            Console.WriteLine(erro.Message);
        }
    }

    public static int MenuInicial()
    {
        // Listagem de opções ao usuário
        
        int[] op = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
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
        Console.WriteLine("13 - Pesquisar jogo");
        Console.WriteLine("14 - Pesquisar jogador");
        Console.WriteLine();

        try 
        {
            func = int.Parse(Console.ReadLine());

            if (Array.IndexOf(op, func) == -1) throw new ArgumentOutOfRangeException(); 
            else return func;
        }
        
        catch
        {
            Console.WriteLine($"\nErro: opção inválida");
            CharRepeat();
            return -1;
        }
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
            Console.WriteLine("01 - Pesquisar jogo");
            Console.WriteLine("02 - Continuar");
            Console.WriteLine();

            try
            {
                func = int.Parse(Console.ReadLine());

                switch (func)
                {
                    case 0:
                        ListarGame();
                        break;
                    case 1: 
                        PesquisarGame();
                        break;
                    case 2: break;
                    default: throw new ArgumentOutOfRangeException(); 
                }
            }

            catch
            {
                Console.WriteLine($"\nErro: opção inválida");
                CharRepeat();
            }
        }

        while (func != 2);
    }

    public static void MenuPlayer()
    {
        // Usado em classes referentes ao jogador
        // Possibilita a visualização dos jogadores cadastrados

        int func = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("00 - Lembrar jogadores cadastrados");
            Console.WriteLine("01 - Pesquisar jogador");
            Console.WriteLine("02 - Continuar");
            Console.WriteLine();

            try 
            {
                func = int.Parse(Console.ReadLine());

                switch (func)
                {
                    case 0:
                        ListarPlayer();
                        break;
                    case 1: 
                        PesquisarPlayer();
                        break;
                    case 2: break;
                    default: throw new ArgumentOutOfRangeException();
                }
            }

            catch
            {
                Console.WriteLine($"\nErro: opção inválida");
                CharRepeat();
            }
        }

        while (func != 2);
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
                        ListarGame();
                        break;
                    case 1:
                        ListarPlayer();
                        break;
                    case 2: break;
                    default: throw new ArgumentOutOfRangeException(); 
                }
            }

            catch
            {
                Console.WriteLine($"\nErro: opção inválida");
                CharRepeat();
            }
        }

        while (func != 2);
    }

    public static void CadastrarGame()
    {
        // Cadastro de jogos
        // Erros: erros de digitação, id ou nome informado já possui cadastro

        int id;
        int niveis;
        string nome;
        string genero;

        Console.WriteLine();
        Console.WriteLine($"{CharRepeat(20)} Dados do Jogo {CharRepeat(19)}");
        Console.WriteLine();

        try 
        {
            Game[] games = Sistema.GameListar();

            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());

            // Procurar id no sistema
            if (Sistema.GameIn(id)) throw new Exception("id já cadastrado");

            Console.Write("Nome: ");
            nome = Console.ReadLine().Trim();

            // Procurar nome no sistema
            // Considera-se "B" igual a "b"
            // Comparação com valores em "lower case" - apenas letras minúsculas
            int checarNome = Array.FindIndex(games, x => x.Nome.ToLower() == nome.ToLower());
            if (checarNome != -1) throw new Exception("jogo já cadastrado");

            Console.Write("Gênero: ");
            genero = Console.ReadLine().Trim();

            Console.Write("Qtd. de níveis: ");
            niveis = int.Parse(Console.ReadLine());

            Game obj = new Game(id, nome, genero, niveis);
            Sistema.GameInserir(obj);

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            // Considera-se que o usuário reconhecerá o erro sem maiores informações
            // O usuário retorna ao menu de cadastro

            Console.WriteLine("\nErro: valor inválido");
            CadastrarGame();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        }
    }

    public static void CadastrarPlayer()
    {
        // Cadastro de jogadores (ou usuários)

        int id;
        int idade;
        string nome;
        string email;
        string apelido;

        Console.WriteLine();
        Console.WriteLine($"{CharRepeat(18)} Dados do Jogador {CharRepeat(18)}");
        Console.WriteLine();

        try 
        {
            List<Player> players = Sistema.PlayerListar();
            
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());

            // Procurar id no sistema
            if (Sistema.PlayerIn(id)) throw new Exception("id já cadastrado");

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Apelido: ");
            apelido = Console.ReadLine().Replace(" ", "");

            // Procurar apelido no sistema
            int checarUser = players.FindIndex(x => x.Apelido == apelido);
            if (checarUser != -1) throw new Exception("este apelido já está em uso");
            
            // O apelido não deve conter espaços em branco
            if (apelido.Contains(" ")) throw new Exception("o apelido não deve conter espaços em branco");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine().ToLower().Trim();
            if (email.Contains(" ")) throw new Exception("o email não deve conter espaços em branco");

            Player obj = new Player(id, idade, apelido, nome, email);
            Sistema.PlayerInserir(obj);

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CadastrarGame();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        }
    }

    public static void CadastrarScore()
    {
        // Cadastro de pontuações
        // Se associa a um jogo e jodador específicos

        int nivel;
        int idGame;
        int idPlayer;
        double pontos;
        DateTime data;
        Game[] games = Sistema.GameListar();

        MenuScore();
        Console.WriteLine();
        Console.WriteLine($"{CharRepeat(17)} Dados da pontuação {CharRepeat(17)}");
        Console.WriteLine();

        try 
        {
            Console.Write("Id do jogo: ");
            idGame = int.Parse(Console.ReadLine());

            // Procurar jogo no sistema
            if (!Sistema.GameIn(idGame)) throw new Exception("jogo não encontrado");

            Console.Write("Id do jogador: ");
            idPlayer = int.Parse(Console.ReadLine());

            // Procurar jogador no sistema
            if (!Sistema.PlayerIn(idPlayer)) throw new Exception("jogador não encontrado");

            Console.Write("Data: ");
            data = DateTime.Parse(Console.ReadLine());

            Console.Write("Nivel: ");
            nivel = int.Parse(Console.ReadLine());

            // Verificar nível
            int i = Array.FindIndex(games, x => x.Id == idGame);
            
            if (nivel < 0 || nivel > games[i].Niveis) 
                throw new Exception($"o jogo informado não possui o nível {nivel}");

            Console.Write("Pontuação: ");
            pontos = double.Parse(Console.ReadLine());

            Score obj = new Score(nivel, idGame, idPlayer, pontos, data);
            Sistema.ScoreInserir(obj);

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
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
        
        try 
        {
            Game[] games = Sistema.GameListar();
            
            Console.Write("Id do jogo: ");
            id = int.Parse(Console.ReadLine());

            // Procurar id no sistema
            if (!Sistema.GameIn(id)) throw new Exception("jogo não encontrado");
            
            Console.WriteLine();
            Console.WriteLine("Novos dados");
            Console.WriteLine();

            Console.Write("Nome: ");
            nome = Console.ReadLine().Trim();

            // É permitido a atribuição do mesmo nome
            // Não é permitido a atribuição de um nome cadastrado em outro id
            int checarNome = Array.FindIndex(games, x => x.Nome.ToLower() == nome.ToLower());
            if (checarNome != -1 && games[checarNome].Id != id) throw new Exception("jogo já cadastrado");

            Console.Write("Gênero: ");
            genero = Console.ReadLine().Trim();

            Console.Write("Qtd. de níveis: ");
            niveis = int.Parse(Console.ReadLine());

            Game game = new Game(id, nome, genero, niveis);
            Sistema.GameAtualizar(game);

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        } 
    }

    public static void AtualizarPlayer()
    {
        // Permite a mudança dos dados referentes a um jogador
        // O id não será alterado

        int id;
        int idade;
        string nome;
        string email;
        string apelido;

        MenuPlayer();

        try 
        {
            List<Player> players = Sistema.PlayerListar();
            
            Console.WriteLine();

            Console.Write("Id do jogador: ");
            id = int.Parse(Console.ReadLine());

            // Procurar id no sistema
            if (!Sistema.PlayerIn(id)) throw new Exception("jogador não encontrado");

            Console.WriteLine();
            Console.WriteLine("Novos dados");
            Console.WriteLine();

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Apelido: ");
            apelido = Console.ReadLine().Trim();

            // O usuário pode usar o mesmo apelido
            // O usuário não deve utilizar um apelido já usado por outro usuário
            int checarUser = players.FindIndex(x => x.Apelido == apelido);
            if (checarUser != -1 && players[checarUser].Id != id) throw new Exception("este apelido já está em uso");
            
            // O apelido não deve conter espaços em branco
            if (apelido.Contains(" ")) throw new Exception("o apelido não deve conter espaços em branco");

            Console.Write("Nome: ");
            nome = Console.ReadLine().Trim();

            Console.Write("Email: ");
            email = Console.ReadLine().ToLower().Trim();
            if (email.Contains(" ")) throw new Exception("o email não deve conter espaços em branco");

            Player obj = new Player(id, idade, apelido, nome, email);
            Sistema.PlayerAtualizar(obj);

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        } 
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

        try 
        {
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
    
            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        }
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
    
            // Procurar id no sistema
            if (!Sistema.GameIn(id)) throw new Exception("jogo não encontrado");
            
            Game obj = new Game(id, "", "", 0);
            Sistema.GameExcluir(obj);
            Console.WriteLine("\noperação concluída");
    
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        } 
    }

    public static void ExcluirPlayer()
    {
        // Resulta na exclusão do jogador
        // O id deve ser informado

        int id;

        MenuPlayer();

        try 
        {
            Console.WriteLine();

            Console.Write("Id do jogador: ");
            id = int.Parse(Console.ReadLine());

            // Procurar id no sistema
            if (!Sistema.PlayerIn(id)) throw new Exception("jogador não encontrado");

            Player obj = new Player(id, 0, "", "", "");
            Sistema.PlayerExcluir(obj);

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        } 
    }

    public static void ExcluirScore()
    {
        // Resulta na exclusão do score informado

        int id;
        int[] v = ListarScore();

        try 
        {
            Console.WriteLine();
            Console.Write("Id da pontuação: ");
            id = int.Parse(Console.ReadLine());
            
            // Procurar pontuação no sistema
            if (!Sistema.ScoreIn(id, v[0], v[1])) throw new Exception("pontuação não encontrada");
            
            Sistema.ScoreExcluir(Sistema.ScoreListar(id, v[0], v[1]));

            Console.WriteLine("\noperação concluída");
            CharRepeat();
        }

        catch (FormatException)
        {
            CharRepeat();
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            ExcluirScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        }
    }

    public static void ListarGame()
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

    public static void ListarPlayer()
    {
        // Listagem de todos os jogadores cadastrados

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
        // Listagem de todas as pontuações associados a um jogo e jogador informados

        int idGame;
        int idPlayer;

        MenuScore();
        Console.WriteLine();

        try
        {
            Console.Write("Id do jogo: ");
            idGame = int.Parse(Console.ReadLine());
            
            // Procurar jogo no sistema
            if (!Sistema.GameIn(idGame)) throw new Exception("jogo não encontrado");
               
            Console.Write("Id do jogador: ");
            idPlayer = int.Parse(Console.ReadLine());
    
            // Procurar jogador no sistema
            if (!Sistema.PlayerIn(idPlayer)) throw new Exception("jogador não encontrado");
            
            List<Score> score = Sistema.ScoreListar(idGame, idPlayer);
    
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
                    Console.WriteLine($"Id: {i:000} - {score[i]}");
                }
            }
    
            CharRepeat(); 
    
            int[] valores = { idGame, idPlayer };
            return valores;
        }

        catch (FormatException)
        {
            CharRepeat();
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            ListarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        }

        return null;
    }

    public static void PesquisarGame()
    {
        // Procura de um jogo específico a partir de seu id ou nome

        int func;

        Console.WriteLine();
        Console.WriteLine("00 - Pesquisar pelo id");
        Console.WriteLine("01 - Pesquisar pelo nome");
        Console.WriteLine();

        try 
        {
            Game[] games = Sistema.GameListar();

            func = int.Parse(Console.ReadLine());

            if (func == 0)
            {
                int id;

                CharRepeat();
                Console.WriteLine();
                Console.Write("Id do jogo: ");
                id = int.Parse(Console.ReadLine());

                int checarId = Array.FindIndex(games, x => x.Id == id);

                if (checarId == -1)
                {
                    Console.WriteLine("\nid não cadastrado");
                    CharRepeat();
                }

                else 
                {
                    Console.WriteLine();
                    Console.WriteLine(games[checarId]);
                    CharRepeat();
                }
            }

            else if (func == 1)
            {
                string nome;

                CharRepeat();
                Console.WriteLine();
                Console.Write("Nome do jogo: ");
                nome = Console.ReadLine().ToLower().Replace(" ", "");

                int checarNome = Array.FindIndex(games, x => x.Nome.ToLower().Replace(" ", "") == nome);

                if (checarNome == -1) 
                {
                    Console.WriteLine("\nnome não cadastrado");
                    CharRepeat();
                }

                else 
                {
                    Console.WriteLine();
                    Console.WriteLine(games[checarNome]);
                    CharRepeat();
                }
            }

            else throw new Exception("opção inválida");
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        } 
    }

    public static void PesquisarPlayer()
    {
        // Pesquisa de um jogador específico a partir de seu id ou apelido

        int func;

        Console.WriteLine();
        Console.WriteLine("00 - Pesquisar pelo id");
        Console.WriteLine("01 - Pesquisar pelo apelido");
        Console.WriteLine();

        try 
        {
            List<Player> players = Sistema.PlayerListar();

            func = int.Parse(Console.ReadLine());

            if (func == 0)
            {
                int id;

                CharRepeat();
                Console.WriteLine();
                
                Console.Write("Id do jogador: ");
                id = int.Parse(Console.ReadLine());

                int checarId = players.FindIndex(x => x.Id == id);

                if (checarId == -1)
                {
                    Console.WriteLine("\nid não cadastrado");
                    CharRepeat();
                }

                else 
                {
                    Console.WriteLine();
                    Console.WriteLine(players[checarId]);
                    CharRepeat();
                }
            }

            else if (func == 1)
            {
                string apelido;

                CharRepeat();
                Console.WriteLine();

                Console.Write("Apelido do jogador: ");
                apelido = Console.ReadLine().ToLower().Replace(" ", "");

                int checarApelido = players.FindIndex(x => x.Apelido.ToLower() == apelido);

                if (checarApelido == -1) 
                {
                    Console.WriteLine("\napelido não cadastrado");
                    CharRepeat();
                }

                else 
                {
                    Console.WriteLine();
                    Console.WriteLine(players[checarApelido]);
                    CharRepeat();
                }
            }

            else throw new Exception("opção inválida");
        }

        catch (FormatException)
        {
            Console.WriteLine("\nErro: valor inválido");
            CharRepeat();
            CadastrarScore();
        }

        catch (Exception erro)
        {
            Console.WriteLine($"\nErro: {erro.Message}");
            CharRepeat();
        } 
    }
}
