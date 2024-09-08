
namespace repartidoP2.ejercicio1;

public class Circulo
{
    public double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double GetPerimeter()
    {
        if (radio < 0)
        {
            Console.WriteLine("Valor invalido.");
            return -1.0;
        }
        else
        {
            double PI = Math.PI;
            return 2 * PI * radio; 
        }
    }

    public double GetArea()
    {if (radio < 0)
        {
            Console.WriteLine("Valor invalido.");
            return -1.0;
        }
        else
        {
            double PI = Math.PI;
            return (radio*radio) * PI;
        }
    }
}