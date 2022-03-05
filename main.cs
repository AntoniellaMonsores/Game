using System;

class Program {

    public static void Main(string[] args)
    {
        Player a = new Player(20, "a", "ana", "ana@gmail.com");
        Player b = new Player(17, "b", "bia", "bia@gmail.com");
        Player c = new Player(25, "m", "mia", "mia@gmail.com");
        Player d = new Player(18, "d", "diego", "diego@gmail.com");

        Sistema.PlayerInserir(a);
        Sistema.PlayerInserir(b);
        Sistema.PlayerInserir(c);
        Sistema.PlayerInserir(d);
        
        Sistema.PlayerExcluir(d);

        foreach (Player p in Sistema.PlayerListar())
            Console.WriteLine(p);
    }
}
