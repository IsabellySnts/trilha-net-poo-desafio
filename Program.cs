using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("12345", "1111111", 64, "Modelo 1");
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Wpp");

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone("90876", "1111111", 64, "Modelo 2");
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");