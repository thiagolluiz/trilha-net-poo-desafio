using DesafioPOO.Models;

    //TODO: Realizar os testes com as classes Nokia e Iphone

    Console.WriteLine("Smartphone Nokia: "); 
    //Criar instâncias de Nokia
    Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
    nokia.Ligar();
    nokia.ReceberLigacao();
    // Chamada do método InstalarAplicativo de forma polimórfica
    nokia.InstalarAplicativo("Duolingo");

    Console.WriteLine("\n");

    Console.WriteLine("Smartphone Iphone: ");
    // Criar instâncias de Iphone
    Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "2222222", memoria: 128);
    iphone.Ligar();
    iphone.ReceberLigacao();
    // Chamada do método InstalarAplicativo de forma polimórfica
    iphone.InstalarAplicativo("PrimoRico");

