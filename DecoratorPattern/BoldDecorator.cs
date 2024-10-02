public class BoldDecorator : TextDecorator
{
    public BoldDecorator(IText text) : base(text)
    {
    }
    public override string GetContent()
    {
        return $"<b>{base.GetContent()}</b>"; // Add bold tags
    }
}