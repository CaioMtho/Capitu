using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class ListBlock : BlockElement
{
    public bool Ordered { get; init; } = false;
    public List<ListItem> Items { get; } = [];
    public void AddItems (params IEnumerable<ListItem> elements) => Items.AddRange(elements);
}