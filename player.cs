using System;

class Player {

    private int idade;
    private string id;
    private string nome;
    private string email;

    public Player(int idade, string id, string nome, string email)
    {
        this.idade = idade;
        this.id = id;
        this.nome = nome;
        this.email = email;
    }

    public void SetIdade(int idade) {
        this.idade = idade;
    }

    public void SetId(string id) {
        this.id = id;
    }

    public void SetNome(string nome) {
        this.nome = nome;
    }

    public void SetEmail(string email) {
        this.email = email;
    }

    public int GetIdade() {
        return idade;
    }

    public string GetId() {
        return id;
    }

    public string GetNome() {
        return nome;
    }

    public string GetEmail() {
        return email;
    }

    public override string ToString() {
        return $"{id} - {email}";
    }
}
