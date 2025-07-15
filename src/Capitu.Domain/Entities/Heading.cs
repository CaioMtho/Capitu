using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class Heading : BlockElement
{
    public int Level { get; set; } = 1;
    public List<InlineElement> Elements { get; } = [];
    
    public void AddElements (params IEnumerable<InlineElement> elements) => Elements.AddRange(elements);
}