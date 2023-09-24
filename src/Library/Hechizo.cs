using System;

class Hechizo
{
    // Atributos
    public string Nombre { get; set; }
    public string Efecto { get; set; }
    public int ATK { get; set; }

    // Constructor
    public Hechizo(string nombre, string efecto, int atk)
    {
        Nombre = nombre;
        Efecto = efecto;
        ATK = atk;
    }

    // Método para usar el hechizo en un objetivo
    public void UsarHechizo(int defensa)
    {
        if (ATK >= defensa)
        {
            Console.WriteLine("Has dañado al objetivo.");
        }
        else
        {
            Console.WriteLine("El objetivo es demasiado fuerte. No has causado daño.");
        }
    }
}
