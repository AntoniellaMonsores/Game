using System;

class Program {

    public static void Main(string[] args)
    {
        Score a = new Score(1, 1, 2, 145.6, DateTime.Parse("07-12-2022"));
        Score b = new Score(2, 1, 2, 148.2, DateTime.Parse("07-12-2022"));
        Score c = new Score(3, 1, 2, 159.8, DateTime.Parse("07-12-2022"));
        Score d = new Score(4, 3, 2, 137.0, DateTime.Parse("07-12-2022"));
        Score e = new Score(1, 3, 1, 145.6, DateTime.Parse("07-12-2022"));
        Score f = new Score(2, 1, 2, 178.2, DateTime.Parse("07-12-2022"));
        
        Sistema.ScoreInserir(a);
        Sistema.ScoreInserir(b);
        Sistema.ScoreInserir(c);
        Sistema.ScoreInserir(d);
        Sistema.ScoreInserir(e);
        Sistema.ScoreInserir(f);

        Sistema.ScoreAtualizar(obj);
        
        Sistema.ScoreExcluir(2);

        foreach (Score s in Sistema.ScoreListar(1, 2))
            Console.WriteLine(s);
    }
}
