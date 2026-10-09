int PIN = 3254;
// int pinAttempt = ""

do
{
    Console.Write("New 4 digits PIN (between 1000 - 9999)\n> ");
    PIN = int.Parse(Console.ReadLine());
} while (1000 < PIN || PIN < 9999);