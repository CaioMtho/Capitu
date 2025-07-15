namespace Capitu.Domain.Entities;

public class Document
{
    public required Metadata Metadata { get; init; }
    public List<Chapter> Chapters { get; } = [];
    
    public void AddChapter(Chapter chapter) => Chapters.Add(chapter);
    public void AddChapters(params IEnumerable<Chapter> chapters) => Chapters.AddRange(chapters);
}