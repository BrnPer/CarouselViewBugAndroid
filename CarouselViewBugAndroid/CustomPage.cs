namespace CarouselViewBugAndroid;

public class CustomPage
{
    public int Id { get; set; }
    public string PageName { get; set; } = "";
    public string PageContent { get; set; } = "";

    public List<CustomCategory> Categories { get; set; } = [];

    public int WordsLength => PageContent.Length;
}