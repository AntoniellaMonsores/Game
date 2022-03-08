using System;

class Player {

    private int id;
    private int idade;
    private string apelido;
    private string nome;
    private string email;

    public Player(int id, int idade, string apelido, string nome, string email)
    {
        // Construtor da classe

        this.id = id;
        this.idade = idade;
        this.apelido = apelido;
        this.nome = nome;
        this.email = email;
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

    public override string ToString() 
    {
        return $"{id:0000} - {apelido} - {email}";
    }
}
