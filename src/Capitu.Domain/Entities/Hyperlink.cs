using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class Hyperlink : InlineElement
{
    public string? Url { get; init; }
    
}