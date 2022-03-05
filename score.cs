using System;

class Score {

    private int nivel;
    private double pontos;
    private DateTime data;

    public void SetNivel(int nivel) {
        this.nivel = nivel;
    }

    public void SetPontos(double pontos) {
        this.pontos = pontos;
    }

    public void SetData(DateTime data) {
        this.data = data;
    }

    public int GetNivel(int nivel) {
        return nivel;
    }

    public double GetPontos() {
        return pontos;
    }

    public DateTime GetData() {
        return data;
    }

    public override string ToString() {
        return $"{nivel} - {pontos} - {data:dd/MM/yyyy}";
    }
}
