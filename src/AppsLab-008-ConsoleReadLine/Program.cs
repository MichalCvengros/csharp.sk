Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno);

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");

Console.WriteLine("Ahoj");
string? prveCislo = Console.ReadLine();
string? druheCislo = Console.ReadLine();
int sucet =  int.Parse(prveCislo) + int.Parse(druheCislo);
Console.WriteLine($"Sucet: {sucet}");