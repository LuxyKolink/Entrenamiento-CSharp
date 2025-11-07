using System.Xml;

object height = 1.88;
object name = "Amir";

Console.WriteLine($"{name} is {height} metres tall.");

// int lenght1 = name.Lenght;
int lenght2 = ((string)name).Length;
Console.WriteLine($"{name} has {lenght2} characters.");

dynamic something;

something = new[] { 3, 5, 7 };

// something = 12;

// something = "Ahmed";

Console.WriteLine($"The length of something is {something.Length}");

Console.WriteLine($"something is a {something.GetType()}");


// var poblacion = 67_000_000;
// var peso = 1.88;
// var precio = 4.99M;
// var fruta = "Manzanas";
// var letra = 'Z';
// var feliz = true;

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("Something.txt");
StreamWriter file2 = File.CreateText("something2.txt");


Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");

int number = 13;
Console.WriteLine($"number set to: {number}");

number = default;
Console.WriteLine($"number reset to its default: {number}");