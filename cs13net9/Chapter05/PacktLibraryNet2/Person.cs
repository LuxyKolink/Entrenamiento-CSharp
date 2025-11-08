namespace Packt.Shared;

public class Person
{
    #region Campos: Datos o estados de Persona

    public string? Name;
    public DateTimeOffset Born;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new();

    public const string Species = "Homo Sapiens";

    public readonly string HomePlanet = "Earth";

    #endregion
}
