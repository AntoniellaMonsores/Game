using System;
using System.Collections;

class Score : IComparable {

    private int nivel;
    private int idGame;
    private int idUser;
    private double pontos;
    private DateTime data;

    public Score(int nivel, int idGame, int idUser, double pontos, DateTime data)
    {
        // Construtor da classe
        
        this.nivel = nivel;
        this.idGame = idGame;
        this.idUser = idUser;
        this.pontos = pontos;
        this.data = data;
    }
    
    public void SetNivel(int nivel) {
        if (nivel >= 0) this.nivel = nivel;
    }
    
    public void SetGameId(int idGame) {
        if (idGame >= 0) this.idGame = idGame;
    }
    
    public void SetUserId(int idUser) {
        if (idUser >= 0) this.idUser = idUser;
    }

    public void SetPontos(double pontos) {
        if (pontos >= 0) this.pontos = pontos;
    }

    public void SetData(DateTime data) {
        this.data = data;
    }
    
    public int GetNivel() {
        return nivel;
    }
    
    public int GetGameId() {
        return idGame;
    }
    
    public int GetUserId() {
        return idUser;
    }
    
    public double GetPontos() {
        return pontos;
    }

    public DateTime GetData() {
        return data;
    }

    public int CompareTo(object obj) 
    {
        return data.CompareTo(((Score)obj).data);
    }

    public override string ToString() 
    {
        return $"{pontos:0.000} - {data:dd/MM/yyyy} - Nível: {nivel:00}";
    }
}
