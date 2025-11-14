namespace Packt.Shared;

public partial class Person
{
    #region Properties: Métodos getters y setters

    public string Origin
    {
        get
        {
            return string.Format("{0} was bor on {1}", Name, HomePlanet);
        }
    }

    #endregion

    // Dos propiedades readonly definidos usando C# 6 o posterior
    // lambdas

    public string Greeting => $"{Name} says 'Hello!'";

    public int Age => DateTime.Today.Year - Born.Year;

    public string? FavoriteIceCream { get; set; }

    private string? _favoritePrimaryColor;

    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
            }
        }
    }

    private WondersOfTheAncientWorld _favoriteAncientWonder;

    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get { return _favoriteAncientWonder; }
        set
        {
            string wonderName = value.ToString();

            if (wonderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only have a single enum value.",
                    paramName: nameof(FavoriteAncientWonder));

            }

            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                $"{value} is not a member of the WondersOfTheAncientWorld enum.", paramName: nameof(FavoriteAncientWonder));
            }

            _favoriteAncientWonder = value;
        }
    }

    #region Indices: Propiedades que usan sintaxis de arreglo para acceder a ellas

    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
    }

    #endregion

}