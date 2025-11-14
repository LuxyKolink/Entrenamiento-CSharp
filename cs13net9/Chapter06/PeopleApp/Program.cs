using Packt.Shared;

Person harry = new()
{
    Name = "Harry",
    Born = new(2001, 3, 25, 0, 0, 0, TimeSpan.Zero)
};

harry.WriteToConsole();

#region Funcionalidad 1

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);

Person.Marry(lamech, zillah);

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine("  {0}'s child #{1} is named \"{2}\".", lamech.Name, i, lamech.Children[i].Name);
}

#endregion

#region Colecciones no genéricas

System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;

WriteLine("key {0} has value: {1}", key, lookupObject[key]);
WriteLine("key {0} has value: {1}", harry, lookupObject[harry]);

#endregion

#region Tipos genéricos

Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;

WriteLine("key {0} has value: {1}", key, lookupIntString[key]);

#endregion

#region Delegate

harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

#endregion

#region Interfaces 1

Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

OutputPeopleNames(people, "Initial list of people:");

Array.Sort(people);

OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

Array.Sort(people, new PersonComparer());

OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation");

#endregion

