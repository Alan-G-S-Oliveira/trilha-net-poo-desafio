using DesafioPOO.Models;

Iphone i = new Iphone("+55 (88) 9 1827-6817", "Ruim", "10388478922356", 128);
Nokia n = new Nokia("+55 (88) 9 3946-1872", "Inquebrável", "39847747459950", 64);

Console.WriteLine("Testando no Iphone:");
i.Ligar();
i.InstalarAplicativo("Minecraft");
i.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("Testando no Nokia:");
i.Ligar();
i.InstalarAplicativo("Minecraft");
i.ReceberLigacao();
