internal class VideoJuego
{
    private string titulo;
    private string desarrolladora;
    private double calificacion;
    private int anioLanzamiento;
    private bool jugando;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Desarrolladora
    {
        get { return desarrolladora; }
        set { desarrolladora = value; }
    }

    public double Calificacion
    {
        get { return calificacion; }
        set
        {
            // La calificación debe estar entre 0 y 10
            if (value >= 0 && value <= 10)
            {
                calificacion = value;
            }
            else
            {
                Console.WriteLine("Error: La calificación debe estar entre 0 y 10");
            }
        }
    }

    public int AnioLanzamiento
    {
        get { return anioLanzamiento; }
        set
        {
            // Asignar un valor válido para el año de lanzamiento
            if (value >= 0)
            {
                anioLanzamiento = value;
            }
            else
            {
                Console.WriteLine("Error: Año de lanzamiento no válido");
            }
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Desarrolladora: " + Desarrolladora);
        Console.WriteLine("Calificación: " + Calificacion);
        Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
    }

    public static void Saludo()
    {
        Console.WriteLine("¡Hola, Jugador!");
    }

    public void IniciarPartida()
    {
        jugando = true;
        Console.WriteLine("¡Partida iniciada!");
    }

    public void DetenerPartida()
    {
      
        Console.WriteLine("Partida detenida: " + (jugando ? "en curso" : "no hay partida en curso"));
    }

    public void TerminarJuego()
    {
        if (jugando)
        {
            jugando = false;
            Console.WriteLine("Juego terminado.");
        }
        else
        {
            Console.WriteLine("Error: No hay partida en curso para terminar.");
        }
    }

    public static void Main(string[] args)
        {
            
            AccionJuego juegoAccion = new AccionJuego("Mi Juego de Acción es Fortnite", "Desarrollador Epic Games", 9.5, 2016, "Jhons", "Control", "Sniper");

           
            juegoAccion.MostrarInformacion(); 
            juegoAccion.IniciarPartida(); 
            juegoAccion.DetenerPartida(); 
            juegoAccion.TerminarJuego(); 
            VideoJuego.saludo(); 
        }
    }



}
}
