using System;
using System.Collections;

class Player : IComparable {

    private int id;
    private int idade;
    private string apelido;
    private string nome;
    private string email;

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
        return id.CompareTo(((Player)obj).id);
    }

    public override string ToString() 
    {
        return $"{id:000000} - {apelido} - {email}";
    }
}
