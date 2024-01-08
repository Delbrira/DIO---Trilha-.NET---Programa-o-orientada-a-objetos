using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia n1 = new Nokia("00 0000-0000", "Modelo X", "001970-01-010000-0", 256);
n1.Ligar();
n1.InstalarAplicativo("Aplicativo X");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone i1 = new Iphone("00 0000-0000", "Modelo Y", "001970-01-010000-0", 128);
i1.ReceberLigacao();
i1.InstalarAplicativo("Aplicativo Y");