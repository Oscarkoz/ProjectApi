# ProjectAPI – .NET 9 Web API

Detta är ett .NET 9 Web API som tillhandahåller projektdata till min utvecklarportfölj. API:t används av frontend-appen (React + Tailwind) för att visa tidigare projekt.

## 🌐 Deployment
- API live: https://<ditt-api-namn>.azurewebsites.net/api/projects

## 🔌 Endpoints

| Metod | Route                | Beskrivning           |
|-------|----------------------|------------------------|
| GET   | `/api/projects`      | Hämtar alla projekt    |

## 🔧 Teknik

- ASP.NET Core 9.0
- Entity Framework Core (InMemory)
- Swagger (för test och dokumentation)
- SeedData för testprojekt

## 📦 Används av:
Frontend: [https://oscarkoz.github.io/portfolio-web/](https://oscarkoz.github.io/portfolio-web/)

## 🧑‍💻 Kontakt
Oscar Turell – [oscarkoz.github.io](https://oscarkoz.github.io)
