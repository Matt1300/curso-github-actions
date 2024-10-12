string userName = Environment.GetEnvironmentVariable("GITHUB_USER") ?? "Usuario desconocido";
Console.WriteLine($"¡Hola {userName} desde GitHub!");