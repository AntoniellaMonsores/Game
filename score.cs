using System;

class Score {

    private int nivel;
    private int idGame;
    private int idUser;
    private double pontos;
    private DateTime data;

    public Score(int nivel, int idGame, int idUser, double pontos, DateTime data)
    {
        this.nivel = nivel;
        this.idGame = idGame;
        this.idUser = idUser;
        this.pontos = pontos;
        this.data = data;
    }
    
    public void SetNivel(int nivel) {
        this.nivel = nivel;
    }
    
    public void SetGameId(int idGame) {
        this.idGame = idGame;
    }
    
    public void SetUserId(int idUser) {
        this.idUser = idUser;
    }

    public void SetPontos(double pontos) {
        this.pontos = pontos;
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

    public override string ToString() {
        return $"{nivel} - {pontos:0.0} - {data:dd/MM/yyyy}";
    }
}
