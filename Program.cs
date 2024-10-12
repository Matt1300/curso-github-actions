string userName = Environment.GetEnvironmentVariable("GITHUB_USER") ?? Environment.GetEnvironmentVariable("USERNAME");
string language = Environment.GetEnvironmentVariable("LANGUAGE");

Console.WriteLine($"¡Hola {userName}, este es un codigo en {language}");
