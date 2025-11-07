WriteLine($"There are {args.Length} arguments");

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("debes especificar dos colores y tamaño de cursor, e.j.");
    WriteLine("dotnet run red yellow 50");
    return; // Stop running.
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true);

if (OperatingSystem.IsWindows())
{
    try
    {
        CursorSize = int.Parse(args[2]);
    }
    catch (FormatException)
    {
        WriteLine("Tamaño de cursor no es un número válido.");
    }
    catch (PlatformNotSupportedException)
    {
        WriteLine("La plataforma actual no posee soporte para el tamaño del cursor.");
    }
}
else
{
    WriteLine("El tamaño del cursor solo se puede ajustar en Windows.");
}

