string[] names;

names = new string[4];

names[0] = "Duber";
names[1] = "Karo";
names[2] = "Edward";
names[3] = "Andres";

string[] names2 = ["Kate", "Jack", "Rebecca", "Tom"];

for (int i = 0; i < names2.Length; i++)
{
    WriteLine($"{names2[i]} is at position {i}");
}


string[,] grid1 =
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, column {col}: {grid1[row, col]}");
    }
}

// Antes de C# 12
// string[][] jagged = // An array of string arrays.
// {
//     new[] { "Alpha", "Beta", "Gamma" },
//     new[] { "Anne", "Ben", "Charlie", "Doug" },
//     new[] { "Aardvark", "Bear" }
// };

string[][] jagged =
[
    ["Alpha", "Beta", "Gamma"],
    ["Anne", "Ben", "Charlie", "Doug"],
    ["Aardvark", "Bear"]
];

WriteLine("Upper bound of the array is: {0}", jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine("Upper bound of array {0} is: {1}",
        arg0: array,
        arg1: jagged[array].GetUpperBound(0));
        
};

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }
}