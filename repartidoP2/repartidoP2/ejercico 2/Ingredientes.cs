namespace repartidoP2.ejercico_2;

public class Ingrediente
{
    private string nombre;
    private double precio;

    public string Nombre
    {
        get { return this.nombre; }
        set
        {
            this.nombre = value;
        }
    }

    public Ingrediente(string nombre, double precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }
}