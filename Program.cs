String frasesDigitada, fraseComDislalia;

Console.Write("Digite uma flase: ");
frasesDigitada = Console.ReadLine()!;

fraseComDislalia = frasesDigitada
.Replace("r", "l")
.Replace("R", "L");
Console.WriteLine(fraseComDislalia);

