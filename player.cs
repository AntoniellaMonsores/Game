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
        // Construtor da classe

        this.id = id;
        this.nome = nome;
        this.email = email;
        this.idade = idade;
        this.apelido = apelido;
    }
    
    public void SetId(int id) {
        this.id = id;
    }
    
    public void SetIdade(int idade) {
        this.idade = idade;
    }

    public void SetApelido(string apelido) {
        this.apelido = apelido;
    }

    public void SetNome(string nome) {
        this.nome = nome;
    }

    public void SetEmail(string email) {
        this.email = email;
    }
    
    public int GetId() {
        return id;
    }
    
    public int GetIdade() {
        return idade;
    }

    public string GetApelido() {
        return apelido;
    }

    public string GetNome() {
        return nome;
    }

    public string GetEmail() {
        return email;
    }

    public int CompareTo(object obj) 
    {
        return apelido.CompareTo(((Player)obj).apelido);
    }

    public override string ToString() 
    {
        return $"Id: {id:000000} - User: {apelido} - Email: {email}";
    }
}
