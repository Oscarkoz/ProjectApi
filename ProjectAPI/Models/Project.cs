namespace ProjectAPI.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string TechStack { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string GithubUrl { get; set; } = string.Empty;
    public string? LiveDemoUrl { get; set; }
}
