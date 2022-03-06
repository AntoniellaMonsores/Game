using System;

class Program {

    public static void Main(string[] args)
    {
        Game a = new Game("a", "abc", 5);
        Game b = new Game("b", "abc", 7);
        Game c = new Game("c", "abc", 3);
        Game d = new Game("d", "abc", 8);

        Sistema.GameInserir(a);
        Sistema.GameInserir(b);
        Sistema.GameInserir(c);
        Sistema.GameInserir(d);

        Sistema.GameExcluir(2);

        foreach (Game g in Sistema.GameListar())
            Console.WriteLine(g);
    }
}
