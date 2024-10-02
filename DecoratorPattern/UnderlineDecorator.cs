public class UnderlineDecorator : TextDecorator
{
    public UnderlineDecorator(IText text) : base(text)
    {
    }

    public override string GetContent()
    {
        return $"<u>{base.GetContent()}</u>"; // Add underline tags
    }
}