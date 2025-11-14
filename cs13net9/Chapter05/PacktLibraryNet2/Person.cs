namespace Packt.Shared;

public partial class Person
{
    #region Campos: Datos o estados de Persona

    public string? Name;
    public DateTimeOffset Born;

    // Se traslada a PersonAutoGen.cs como propiedad
    // public WondersOfTheAncientWorld FavoriteAncientW onder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public const string Species = "Homo Sapiens";

    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    #endregion

    #region Constructores: Cuando se necesita instanciar un nuevo tipo

    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion

    #region Métodos: Acciones que el tipo puede realizar

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(int count, string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
    }

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // Parámetros out no pueden tener un valor por defecto
        // y deben inicializarse dentro del método

        z = 100;

        // Incrementa cada parámetro a excepción de x read-only
        w++;
        // x++; // Arroja error de compilación
        y++;
        z++;

        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    #endregion

    public void ParamsParameters(
        string text, params int[] numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        WriteLine($"{text}: {total}");
    }

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);

        int localFactorial(int localNumber) // Local function
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

}
