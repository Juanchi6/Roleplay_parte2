using System;
using System.Collections.Generic;

// Clase Hechizo 
public class Hechizo
{
    public string Nombre { get; set; }
    public int Nivel { get; set; }

    public Hechizo(string nombre, int nivel)
    {
        Nombre = nombre;
        Nivel = nivel;
    }
}

// Clase ItemMagico
public class ItemMagico
{
   
}

// Clase Grimorio
public class Grimorio
{
    // Atributo para almacenar los hechizos
    private List<Hechizo> Hechizos { get; set; }

    // Constructor
    public Grimorio()
    {
        Hechizos = new List<Hechizo>();
    }

    // Método para añadir un hechizo al grimorio
    public void AñadirHechizo(Hechizo hechizo, bool esMago)
    {
        // Verifica si el personaje es un mago
        if (personaje.mago)
        {
            Hechizos.Add(hechizo);
            Console.WriteLine($"Se ha añadido el hechizo '{hechizo.Nombre}' al grimorio.");
        }
        else
        {
            Console.WriteLine("Solo los magos pueden usar el grimorio.");
        }
    }
}

