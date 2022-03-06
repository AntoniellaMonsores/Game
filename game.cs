using System;

class Game {

    private string nome;
    private string genero;
    private int niveis;

    public Game(string nome, string genero, int niveis)
    {
        this.nome = nome;
        this.genero = genero;
        this.niveis = niveis;
    }

    public void SetNome(string nome) {
        this.nome = nome;
    }

    public void SetGenero(string genero) {
        this.genero = genero;
    }
    
    public void SetNiveis(int niveis) {
        this.niveis = niveis;
    }
    
    public string GetNome() { 
        return nome; 
    }

    public string GetGenero() { 
        return genero; 
    }
    
    public int GetNiveis() { 
        return niveis; 
    }
    
    public override string ToString() {
        return $"{nome} - {genero}";
    }
}
