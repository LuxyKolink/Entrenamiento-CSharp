#region otey

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Ta mal, 8 carácteres mínimo");
}
else
{
    WriteLine("Melo");
}

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply");
}

#endregion

#region switch

int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");

#endregion

#region animals

var animals = new Animal?[]
{
    new Cat
    {
        Name = "Karen",
        Born = new(year: 2025, month: 10, day: 4),
        Legs = 4,
        IsDomestic = true
    },
    null,
    new Cat
    {
        Name = "Mufasa",
        Born = new(year: 1994, month: 6, day: 12),
    },
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsVenomous = true},
    new Spider { Name = "Captain Furry", Born = DateTime.Today}
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"El gato llamado {fourLeggedCat} tiene cuatro patas";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cat is named {wildCat.Name}.";
            break;
        case Cat cat:
            message = $"El gato se llama {cat.Name}";
            break;
        case Spider spider when spider.IsVenomous:
            message = $"la araña {spider.Name} es venenosa";
            break;
        case null:
            message = "El animal es nulo";
            break;
        default:
            message = $"{animal.Name} is a {animal.GetType().Name}.";
            break;
    }
    WriteLine($"Mensaje del switch: {message}");

    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
            => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false
            => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
            => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsVenomous
            => $"The {spider.Name} spider is venomous. Run!",
        null
            => "The animal is null.",
        _
            => $"{animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine($"Mensaje del switch: {message}");
}


#endregion
