Console.WriteLine("Polyalphabetic Cipher Encryption / Decryption");

Console.WriteLine("Enter Number of Key Rules :");
int steps = int.Parse(Console.ReadLine());
int[] rules = new int[steps];
for (int i = 0; i < steps; i++)
{
    Console.WriteLine($"Enter Rule{i + 1}");
    rules[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter Message:");
var message = Console.ReadLine();
char[] cypher = new char[message.Length];
int n = 0;
int n1 = 0;

//Encyption
foreach (var c in message.ToUpper())
{
    int num = c;
    int numn = num + rules[n1];
    if (numn >= 91)
        numn -= 26;
    cypher[n] = (char)numn;
    n++;
    n1++;
    if (n1 == steps)
        n1 = 0;
}
Console.WriteLine("Encyption:");
Console.WriteLine(cypher);

//Decryption
rules.Reverse();
char[] Plain = new char[message.Length];
n = 0;
n1 = 0;
foreach (var c in cypher)
{
    int num = c;
    int numn = num - rules[n1];
    if (numn < 65)
        numn += 26;
    Plain[n] = (char)numn;
    n++;
    n1++;
    if (n1 == steps)
        n1 = 0;
}
Console.WriteLine("Decryption :");
Console.WriteLine(Plain);