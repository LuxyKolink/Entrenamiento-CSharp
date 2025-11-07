#region while

// int x = 0;

// // while (x < 10)
// // {
// //     WriteLine(x);
// //     x++;
// // }

// string? actualPassword = "contrasena";
// string? password;

// do
// {
//     Write("Enter your password: ");
//     password = ReadLine();
//     x++;

//     if (x == 3)
//     {
//         WriteLine("Acceso denegado");
//     }

//     // WriteLine($"Intento {x}");
//     // WriteLine(password == actualPassword ? "Acceso concedido" : "Acceso denegado");
// }
// while (password != actualPassword && x < 3);

// // WriteLine("Eso");

#endregion

#region for

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

#endregion

#region foreach

string[] names = { "Adam", "Barry", "Charlie" };


foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

#endregion

