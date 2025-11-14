using Packt.Shared;

using Fruit = (string Name, int Number);

ConfigureConsole();

#region Personas

Person bob = new();
WriteLine(bob);

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.

WriteLine(format: "{0} was born on {1:D}", // Long Date <> d (shrt date)
    arg0: bob.Name, arg1: bob.Born);

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.", // Short date.
arg0: alice.Name, arg1: alice.Born);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
// bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia | WondersOfTheAncientWorld.GreatPyramidOfGiza;
// bob.FavoriteAncientWonder = (WondersOfTheAncientWorld)128;

WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList =
    WondersOfTheAncientWorld.HangingGardenOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

// Para todas las versiones de C#
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// C# 3 y posterior
bob.Children.Add(new Person { Name = "Bella" });

// C#9 y posterior
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

#endregion

#region Banco

BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

#endregion

WriteLine($"{bob.Name} is a {Person.Species}.");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

/*
// Instanciar un libro utilizando usando sintaxis de inicialización de objetos 
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
*/

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author, book.PageCount);

Person blankPerson = new();

WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    blankPerson.Name, blankPerson.HomePlanet, blankPerson.Instantiated);

Person gunny = new("Gunny", "Mars");

WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    gunny.Name, gunny.HomePlanet, gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters(4, "Jump!", 98.5));

int a = 10;
int b = 20;
int c = 30;
int d = 40;

WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");

bob.PassingParameters(a, b, ref c, out d);

WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;

WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");

// Simplified C# 7 or later syntax for the out parameter.

bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

bob.ParamsParameters("Sum using commas", 3, 6, 1, 2);
bob.ParamsParameters("Sum using collection expression", [3, 6, 1, 2]);
bob.ParamsParameters("Sum using explicit array", new int[] { 3, 6, 1, 2 });
bob.ParamsParameters("Sum (empty)");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

// Sin el alias de una tupla
// var fruitNamed = bob.GetNamedFruit();

// Se usa var para simplificar:
// (string Name, int Number) fruitNamed = bob.GetNamedFruit();

// WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children");

// Con el alias de una tupla
Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");


var (name1, dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

int number = 5; // -1 -> exception

try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
}

Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fugde";
WriteLine($"Sam's favorite icre-cream flavor is {sam.FavoriteIceCream}.");

string color = "black";

try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

sam.Children.Add(new() { Name = "Charlie", Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero) });
sam.Children.Add(new() { Name = "Ella", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero) });

// Get using Children list.
WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");

// Get using the int indexer.
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");

// Get using the string indexer.
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

Passenger[] passengers = [
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" }
];

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        // C# 8
        // FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
        // FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
        // FirstClassPassenger _ => 2_000M,

        // C# 9
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M,
        },

        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };

    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};

// jeff.FirstName = "Geoff";

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car
    with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };

WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };

WriteLine($"ar1 == ar2: {ar1 == ar2}");


int number1 = 3;
int number2 = 3;

WriteLine($"number1: {number1}, number2: {number2}");
WriteLine($"number1 == number2: {number1 == number2}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };

WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1 == p2: {p1 == p2}");

Person p3 = p1;
WriteLine($"p3: {p3}");
WriteLine($"p3.Name: {p3.Name}");
WriteLine($"p1 == p3: {p1 == p3}");

WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar;

WriteLine($"{who} is a {what}.");


Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}.");


Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}.");
Headset mq = new() { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}.");
