using System;

public class AventuraJuego : VideoJuego

{
    public string Personaje { get; set; }
    public string Controles { get; set; }
    public string Habilidades { get; set; }
    public string Vidas { get; set; }

    public AventuraJuego()
    {
    }

    public AventuraJuego(string nombre, string genero, int calificacion, string personaje, string controles, string habilidades, string vidas)
        : base(nombre, genero, calificacion)
    {
        Personaje = personaje;
        Controles = controles;
        Habilidades = habilidades;
        Vidas = vidas;
    }

}
