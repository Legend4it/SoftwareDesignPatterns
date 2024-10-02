public class ItalicDecorator : TextDecorator
{
    public ItalicDecorator(IText text) : base(text)
    {
    }

    public override string GetContent()
    {
        return $"<i>{base.GetContent()}</i>"; // Add italic tags
    }
}