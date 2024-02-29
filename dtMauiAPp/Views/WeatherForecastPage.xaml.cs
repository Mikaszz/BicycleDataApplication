using dtMauiAPp.ViewModels;

namespace dtMauiAPp.Views;

public partial class WeatherForecastPage : ContentPage
{
    public WeatherForecastPage(WeatherForecastViewModel weatherForecastViewModel)
    {
        InitializeComponent();
        BindingContext = weatherForecastViewModel;
    }
}