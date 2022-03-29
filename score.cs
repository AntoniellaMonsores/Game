using System;
using System.Collections;

public class Score : IComparable {

    private int nivel;
    private int idGame;
    private int idPlayer;
    private double pontos;
    private DateTime data;

    public int Nivel 
    { 
        get => nivel; 
        set => nivel = value; 
    }

    public int IdGame 
    { 
        get => idGame; 
        set => idGame = value; 
    }
    
    public int IdPlayer 
    { 
        get => idPlayer; 
        set => idPlayer = value; 
    }

    public double Pontos 
    { 
        get => pontos; 
        set => pontos = value; 
    }
    
    public DateTime Data 
    { 
        get => data; 
        set => data = value; 
    }
    
    public Score() { }
    
    public Score(int nivel, int idGame, int idPlayer, double pontos, DateTime data)
    {
        this.nivel = nivel;
        this.idGame = idGame;
        this.idPlayer = idPlayer;
        this.pontos = pontos;
        this.data = data;
    }

    public int CompareTo(object obj) 
    {
        return data.CompareTo(((Score)obj).data);
    }

    public override string ToString() 
    {
        return $"Pontuação: {pontos:0.000} - Data: {data:dd/MM/yyyy} - Nível: {nivel:00}";
    }
}
