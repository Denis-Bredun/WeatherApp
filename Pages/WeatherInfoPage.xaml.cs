using WeatherApp.ViewModels;

namespace WeatherApp.Pages;

public partial class WeatherInfoPage : ContentPage
{
	public WeatherInfoPage()
	{
		InitializeComponent();

		BindingContext = new WeatherInfoPageViewModel();
	}
}