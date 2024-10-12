string userNameGitHub = Environment.GetEnvironmentVariable("GITHUB_USER");
string userName = Environment.GetEnvironmentVariable("USERNAME");
string language = Environment.GetEnvironmentVariable("LANGUAGE");

if (userNameGitHub is not null)
{
    Console.WriteLine($"¡Hola {userNameGitHub} desde GitHub");
}
else
{
    Console.WriteLine($"¡Hola {userName}, este es un codigo en {language}");
}
