using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class Chapter
{
    public string? Title { get; init; }
    public List<BlockElement> Blocks { get; init; } = [];
    
    public void AddBlocks(params IEnumerable<BlockElement> blocks) => Blocks.AddRange(blocks);
}