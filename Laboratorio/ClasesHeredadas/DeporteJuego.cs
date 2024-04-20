using System;

public class DeporteJuego : VideoJuego

{
    public string Equipo { get; set; }
    public string Controles { get; set; }
    public string Tiempo { get; set; }
    public string Dificultad { get; set; }
    public string Torneos { get; set; }

    public DeporteJuego()
    {
    }

    public DeporteJuego(string nombre, string genero, int calificacion, string equipo, string controles, string tiempo, string dificultad, string torneos)
        : base(nombre, genero, calificacion)
    {
        Equipo = equipo;
        Controles = controles;
        Tiempo = tiempo;
        Dificultad = dificultad;
        Torneos = torneos;

    }

}