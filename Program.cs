﻿using DesafioPOO.Models;

using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
