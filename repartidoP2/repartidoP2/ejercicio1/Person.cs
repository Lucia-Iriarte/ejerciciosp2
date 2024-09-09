using System.Collections;

namespace repartidoP2.ejercicio1;

public class Person
{
    private string name;
    private string role;
    private string firstProgenitor;
    private string secondProgenitor;
    public ArrayList lista = new ArrayList();

    public Person(string name, string role, string firstProgenitor, string secondProgenitor)
    {
        this.name = name;
        this.role = role;
        this.firstProgenitor = firstProgenitor;
        this.secondProgenitor = secondProgenitor;
        
        if (!string.IsNullOrEmpty(firstProgenitor)) lista.Add(new Person(firstProgenitor, "padre", "", ""));
        if (!string.IsNullOrEmpty(secondProgenitor)) lista.Add(new Person(secondProgenitor, "madre", "", ""));
    }

    public string GetName()
    {
        return name;
    }

    public string ShowFamilyTree()
    {
        string arbol = $"{name} es {role}.";
        foreach (Person progenitor in lista)
        {
            arbol += $" {progenitor.GetName()} es {progenitor.role}.";
        }
        return arbol;
    }
}