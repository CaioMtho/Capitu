namespace Capitu.Domain.Entities;

public record Metadata(DateTime? PublicationDate, string Title = "Sem título", string Author = "Sem autor", string Publisher = "Sem editora") {}