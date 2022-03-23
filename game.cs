using System;
using System.Collections;

class Game {

    private int id;
    private int niveis;
    private string nome;
    private string genero;
    
    public Game(int id, string nome, string genero, int niveis)
    {
        // Construtor da classe

        this.id = id;
        this.nome = nome;
        this.genero = genero;
        this.niveis = niveis;
    }
    
    public void SetId(int id) {
        this.id = id;
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
    
    public int GetId() { 
        return id; 
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
    
    public override string ToString() 
    {
        return $"{id:000000} - {nome} - {genero} - Níveis: {niveis:00}";
    }
}
