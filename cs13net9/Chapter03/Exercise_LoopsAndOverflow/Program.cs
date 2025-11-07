// int max = 500;


// checked
// {
//     for (byte i = 0; i < max; i++)
//     {
//         WriteLine(i);
//     }    
// }

// for (int i = 1; i <= 100; i++)
// {
//     bool fizz = i % 3 == 0;
//     bool buzz = i % 5 == 0;

//     if (fizz && buzz)
//     {
//         WriteLine("FizzBuzz");
//     }
//     else if (fizz)
//     {
//         WriteLine("Fizz");
//     }
//     else if (buzz)
//     {
//         WriteLine("Buzz");
//     }
//     else
//     {
//         WriteLine(i);
//     }
// }

WriteLine("Hola xd");
Write("Enter a number between 0 and 255: ");
string? a = ReadLine();

// WriteLine("Hola xd");
Write("Enter another number between 0 and 255: ");
string? b = ReadLine();

try
{
    int aa = int.Parse(a!);
    int bb = int.Parse(b!);
    WriteLine($"{aa} divided by {bb} is {aa / bb}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
