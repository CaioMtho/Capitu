using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class Paragraph : BlockElement
{
    public List<InlineElement> Elements { get; } = [];
    
    public void AddElements (params IEnumerable<InlineElement> elements) => Elements.AddRange(elements);


}