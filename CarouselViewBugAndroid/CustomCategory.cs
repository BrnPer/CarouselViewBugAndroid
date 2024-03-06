namespace CarouselViewBugAndroid;

public class CustomCategory(string name)
{
    public string Name { get; set; } = name;

    public override string ToString()
    {
        return Name;
    }
}