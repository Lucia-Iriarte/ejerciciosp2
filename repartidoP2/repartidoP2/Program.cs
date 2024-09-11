// See https://aka.ms/new-console-template for more information

using repartidoP2.ejercicio1;

Circulo c1 = new Circulo(1);
Console.WriteLine("Perimetro: " + c1.GetPerimeter());
Console.WriteLine("Area: " + c1.GetArea());

Person juan = new Person("Juan", "hijo", "Pedro", "Clara");
Console.WriteLine(juan.ShowFamilyTree());

Person lu = new Person("Lucia Iriartte", "hija", "Carlos", "Isabel");
Account cuentaLu = new Account(56342, 100.00, lu);
Console.WriteLine(cuentaLu.AddToBalance(50.0));
Console.WriteLine(cuentaLu.GetBalance());
Console.WriteLine(cuentaLu.RemoveFromBalance(76.44));
Console.WriteLine(cuentaLu.GetBalance());