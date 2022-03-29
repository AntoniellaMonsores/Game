using System;
using System.Collections;

public class Player : IComparable {

    private int id;
    private int idade;
    private string apelido;
    private string nome;
    private string email;

    public int Id 
    { 
        get => id; 
        set => id = value; 
    }

    public int Idade 
    { 
        get => idade; 
        set => idade = value; 
    }

    public string Apelido 
    { 
        get => apelido; 
        set => apelido = value; 
    }
    
    public string Nome 
    { 
        get => nome; 
        set => nome = value; 
    }
    
    public string Email 
    { 
        get => email; 
        set => email = value; 
    }
    
    public Player() { }
    
    public Player(int id, int idade, string apelido, string nome, string email)
    {
        this.id = id;
        this.nome = nome;
        this.email = email;
        this.idade = idade;
        this.apelido = apelido;
    }
    
    public int CompareTo(object obj) 
    {
        return apelido.CompareTo(((Player)obj).apelido);
    }

    public override string ToString() 
    {
        return $"Id: {id, -5:00000} - Apelido: {apelido, -6} - Email: {email, -20} - Nome: {nome, -11} - Idade: {idade}";
    }
}
