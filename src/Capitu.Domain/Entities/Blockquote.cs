using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class Blockquote : BlockElement
{
    public List<Paragraph> Paragraphs { get; } = [];
    public void AddParagraphs (params IEnumerable<Paragraph> paragraphs) => Paragraphs.AddRange(paragraphs);
}