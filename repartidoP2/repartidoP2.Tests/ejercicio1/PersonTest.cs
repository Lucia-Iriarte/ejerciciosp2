using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using repartidoP2.ejercicio1;

namespace repartidoP2.Tests.ejercicio1;

[TestClass]
[TestSubject(typeof(Person))]
public class PersonTest
{

    [TestMethod]
    public void testNombreNull()
    {
        Person juan = new Person("Juan", "hijo", "Pedro", "Clara");
        Console.WriteLine(juan.ShowFamilyTree()); 
    }
}