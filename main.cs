using System;

class Program {

    public static void Main(string[] args)
    {
        Game a = new Game("a", "ação", 3);
        Game b = new Game("b", "ação", 2);
        Game c = new Game("c", "ação", 1);
        Game d = new Game("d", "ação", 2);
        Game e = new Game("e", "ação", 5);
        Game f = new Game("f", "ação", 2);
        Game g = new Game("g", "ação", 2);
        
        Sistema.GameInserir(a);
        Sistema.GameInserir(b);
        Sistema.GameInserir(c);
        Sistema.GameInserir(d);
        Sistema.GameInserir(e);
        Sistema.GameInserir(f);
        Sistema.GameInserir(g);
            
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
    }
}
