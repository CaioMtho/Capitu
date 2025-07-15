using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class ListItem
{
    public List<BlockElement> Content { get; } = [];
    
    public void AddContent (params IEnumerable<BlockElement> elements) => Content.AddRange(elements);
}