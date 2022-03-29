using System;
using System.Collections;

public class Game : IComparable {

    private int id;
    private int niveis;
    private string nome;
    private string genero;

    public int Id 
    { 
        get => id; 
        set => id = value; 
    }

    public int Niveis 
    { 
        get => niveis; 
        set => niveis = value; 
    }
    
    public string Nome 
    { 
        get => nome; 
        set => nome = value; 
    }
    
    public string Genero 
    { 
        get => genero; 
        set => genero = value; 
    }

    public Game() { }
    
    public Game(int id, string nome, string genero, int niveis)
    {
        this.id = id;
        this.nome = nome;
        this.genero = genero;
        this.niveis = niveis;
    }
 
    public int CompareTo(object obj) 
    {
        return nome.CompareTo(((Game)obj).nome);
    }
    
    public override string ToString() 
    {
        return $"Id: {id, -5:00000} - Nome: {nome, -1} - Gênero: {genero, -8} - Níveis: {niveis:00}";
    }
}
