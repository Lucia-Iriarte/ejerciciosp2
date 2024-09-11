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
Person rami = new Person("Rami", "hijo", "Agustin", "Felicia");
Account cuentaRami = new Account(55507, 0.0, rami);
Console.WriteLine(cuentaRami.AddToBalance(99.9));
Console.WriteLine(cuentaRami.RemoveFromBalance(33.333));
Console.WriteLine(cuentaRami.TransferTo(cuentaLu, 80.0));
Console.WriteLine(cuentaRami.TransferTo(cuentaLu, 8.0));
Console.WriteLine(cuentaLu.GetBalance());
Console.WriteLine(cuentaRami.GetBalance());