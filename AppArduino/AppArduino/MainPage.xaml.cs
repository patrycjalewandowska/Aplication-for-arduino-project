using Microsoft.Maui.Graphics;
using System.Drawing;

namespace AppArduino;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void OnMiastaPrzyszlosci(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("//MiastaPrzyszlosci");
	}

    private void OnSettings(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//SettingsPage");
    }

    

}

