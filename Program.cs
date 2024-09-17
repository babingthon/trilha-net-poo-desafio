using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123123", modelo: "123123", iMEI: "12321321", memoria: 112);
nokia.Ligar();
nokia.InstalarAplicativo("X");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123123", modelo: "123123", iMEI: "12321321", memoria: 112);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");