double massa, altura, imc;

Console.Write("Insira sua massa, em quilogramas: ");
massa = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira sua altura, em metros: ");
altura = Convert.ToDouble(Console.ReadLine()!);

imc = massa / Math.Pow(altura, 2);

Console.WriteLine($"\nSeu IMC é {imc} kg/m²");