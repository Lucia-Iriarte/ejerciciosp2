
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
        double PI = Math.PI;
        return 2 * PI * radio;
    }

    public double GetArea(double radio)
    {
        double PI = Math.PI;
        return (radio*radio) * PI;
    }
}