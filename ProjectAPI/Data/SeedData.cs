using ProjectAPI.Models;

namespace ProjectAPI.Data;

public static class SeedData
{
    public static void Initialize(ProjectContext context)
    {
        if (context.Projects.Any()) return; // Redan seedad

        var projects = new List<Project>
        {
            new Project
            {
                Name = "BankApp",
                TechStack = "ASP.NET Core, Razor Pages, SQL Server",
                Date = new DateTime(2025, 5, 15),
                Description = "Bankapplikation med konton, transaktioner, och roller (Admin, Kassör).",
                GithubUrl = "https://github.com/dittkonto/BankApp",
                LiveDemoUrl = "https://bankapp.azurewebsites.net"
            },
            new Project
            {
                Name = "AdsAPI",
                TechStack = "ASP.NET Core Web API, Swagger",
                Date = new DateTime(2025, 5, 20),
                Description = "API för att hantera annonser med Entity Framework och swagger-dokumentation.",
                GithubUrl = "https://github.com/dittkonto/AdsAPI"
            }
        };

        context.Projects.AddRange(projects);
        context.SaveChanges();
    }
}
