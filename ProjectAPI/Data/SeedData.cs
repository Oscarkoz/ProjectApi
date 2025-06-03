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
                GithubUrl = "https://github.com/Oscarkoz/BankApp-G-Del",
                LiveDemoUrl = "https://bankapp.azurewebsites.net"
            },
            new Project
            {
                Name = "AdsAPI",
                TechStack = "ASP.NET Core Web API, Swagger",
                Date = new DateTime(2025, 5, 20),
                Description = "API för att hantera annonser med Entity Framework och swagger-dokumentation.",
                GithubUrl = "https://github.com/Oscarkoz/WebApi-AdsApi",
                LiveDemoUrl = null
            },
            new Project
            {
                Name = "Portfolio",
                TechStack = "React, TailwindCSS",
                Date = new DateTime(2025, 6, 3),
                Description = "Min personliga utvecklarportfölj byggd i React och TailwindCSS.",
                GithubUrl = "https://github.com/Oscarkoz/portfolio-web",
                LiveDemoUrl = "https://oscarkoz.github.io/portfolio-web/"
            }
        };

        context.Projects.AddRange(projects);
        context.SaveChanges();
    }
}
