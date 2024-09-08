using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using repartidoP2.ejercicio1;

namespace repartidoP2.Tests.ejercicio1;

[TestClass]
[TestSubject(typeof(Circulo))]
public class CirculoTest
{

    [TestMethod]
    public void testPerimetro1()
    {
        Circulo c1 = new Circulo(1);
        Assert.AreEqual(c1.GetPerimeter(),6,283185307179586);
    }
    
    
    [TestMethod]
    public void testPerimetro0()
    {
        Circulo c1 = new Circulo(0);
        Assert.AreEqual(c1.GetPerimeter(),0);
    }
    
    [TestMethod]
    public void testPerimetroNegativo()
    {
        Circulo c1 = new Circulo(-1);
        Assert.AreEqual(c1.GetPerimeter(),6,283185307179586);
    }
}