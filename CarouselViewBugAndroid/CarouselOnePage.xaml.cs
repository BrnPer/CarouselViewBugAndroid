using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselViewBugAndroid;

public partial class CarouselOnePage : ContentPage
{
    public CarouselOnePage(CarouselOneViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}