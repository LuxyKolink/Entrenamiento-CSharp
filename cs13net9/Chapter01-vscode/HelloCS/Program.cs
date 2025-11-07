// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");

string name = typeof(Program).Namespace ?? "<null>";
Console.WriteLine($"Namespace: {name}");
// throw new Exception();

Console.WriteLine(format: "Value is {0}.", arg0: 19.8);