public abstract class TextDecorator : IText
{
    protected IText _text;

    protected TextDecorator(IText text)
    {
        _text = text;
    }

    public virtual string GetContent()
    {
        return _text.GetContent();
    }
}