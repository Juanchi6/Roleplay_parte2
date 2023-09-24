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
    public void UsarHechizo(Personaje personaje)
    {
        if (ATK >= personaje.DEF)
        {
            Console.WriteLine("Has dañado al objetivo.");
            int daño = ATK - personaje.DEF;
            personaje.HP -= daño;
            Console.WriteLine($"Has causado {dano} puntos de daño a {personaje.Nombre}.");
        }
        else
        {
            Console.WriteLine("El objetivo es demasiado fuerte. No has causado daño.");
        }
    }
}
