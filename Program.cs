using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//IMPLEMENTADO
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "40028922", modelo: "Tijolão", imei: "4002", memoria: 500);
Console.WriteLine($"Seu número é: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("Carteira de Trabalho Digital");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "33333666", modelo: "XPróMaxBlasterMaster", imei: "8922", memoria: 3);
Console.WriteLine($"Seu número é: {iphone.Numero}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("PokemonGO");