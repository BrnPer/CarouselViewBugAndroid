using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Primitives;

namespace CarouselViewBugAndroid;

public class CarouselOneViewModel : ObservableObject
{
    public ObservableCollection<CustomPage> Pages { get; private set; } = [];

    public virtual IAsyncRelayCommand PageAppearingCommand { get; }

    public CarouselOneViewModel()
    {
        PageAppearingCommand = new AsyncRelayCommand(OnLoad);
    }

    private async Task OnLoad()
    {
        Pages.Clear();
        var random = new Random(2);

        for (var i = 0; i < 30; i++)
        {
            Pages.Add(new CustomPage
            {
                Id = 1,
                PageName = $"Page Number {i}",
                PageContent = $"Random content generated {i}. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam vestibulum imperdiet blandit. Ut pulvinar ut magna interdum porta. Fusce non augue nec ex lacinia lobortis. Donec non nibh ac neque mattis finibus vitae dignissim augue. Interdum et malesuada fames ac ante ipsum primis in faucibus. Praesent at neque finibus, condimentum enim in, ultrices metus. Nam sed iaculis mauris. Phasellus aliquet lacinia ipsum vitae mollis. Suspendisse potenti. Aenean eget velit tellus. Quisque eget molestie velit. Fusce sed gravida massa.",
                Categories = Enumerable.Range(0, random.Next(5)).Select(r=> new CustomCategory($"Category {r}")).ToList()
            });
        }
    }
}