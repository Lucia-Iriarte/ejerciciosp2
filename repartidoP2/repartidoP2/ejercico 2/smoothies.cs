namespace repartidoP2.ejercico_2;
using System;
using System.Collections.Generic;

public class OriginalIngrediente
{
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public OriginalIngrediente(string nombre, double precio)
    {
        this.Nombre = nombre;
        this.Precio = precio;
    }
}

public class Smoothies
{
    private string nombre;
    private double precioBase;
    private List<Ingrediente> ingredientes;

    public Smoothies(string nombre, double precioBase, List<Ingrediente> ingredientes)
    {
        this.nombre = nombre;
        this.precioBase = precioBase;
        this.ingredientes = ingredientes;
    }

    public void AddIngrediente(Ingrediente ingrediente)
    {
        ingredientes.Add(ingrediente);
    }

    public double GetCost()
    {
        double totalCost = precioBase;
        foreach (var ingrediente in ingredientes)
        {
            totalCost += ingrediente.Precio;
        }

        return totalCost;
    }

    public double GetPrice()
    {
        return GetCost() * 1.5;
    }

    public string GetName()
    {
        foreach (var ingre in ingredientes)
        {
            List<string> nombres = new List<string>();
            foreach (Ingrediente ingrediente in ingredientes)
            {
                string modificado = ingrediente.Nombre.Replace("berries", "berry");
                if (ingrediente.Nombre == "berries")
                {
                    ingrediente.Nombre = "berry";
                }
                
                nombres.Add(modificado);
            }

            nombres.Sort();
            if (nombres.Count > 1)
                return $"A fusion of {string.Join(", ", nombres)}.";
            else
            {
                return $"{nombres[0]} Smoothie.";
            }
        }
    }
}