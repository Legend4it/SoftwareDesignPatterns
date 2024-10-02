public class PlainText : IText
{
    private readonly string _content;
    public PlainText(string content)
    {
        _content=content;
    }
    public string GetContent()
    {
        return _content;
    }
}