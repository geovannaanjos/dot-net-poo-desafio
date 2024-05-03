using DesafioPOO.Models;

Smartphone nok = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Smartphone ip = new Iphone("987654321", "Iphone 15", "987654321", 128);

System.Console.WriteLine("Nokia:");
nok.Ligar();
nok.InstalarAplicativo("Snake");

System.Console.WriteLine("\nIphone:");
ip.ReceberLigacao();
ip.InstalarAplicativo("WhatsApp");