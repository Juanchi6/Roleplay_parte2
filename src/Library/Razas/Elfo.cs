using System;

namespace RoleplayGame {
public class Elfo : IRaza
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public Hechizo HechizoInnato { get; set; }

    public Elfo(string nombre, string descripcion)
    {
        Nombre = nombre;
        Descripcion = descripcion;
    }
    public SetHechizo(Hechizo NuevoHechizo)
    {
        HechizoInnato = NuevoHechizo;
    }

    public void UsarMagia(Personaje Objetivo)
    {
        HechizoInnato.UsarHechizo(Objetivo);
    }
}

}