using Capitu.Domain.Abstractions;

namespace Capitu.Domain.Entities;

public class TextRun : InlineElement
{
    public bool IsBold { get; init; } = false;
    public bool IsItalic { get; init; } = false;
    public bool IsUnderline { get; init; } = false;
    public bool IsMonospace  { get; init; } = false;
}