namespace AppArduino;

public partial class MiastaPrzyszlosci : ContentPage
{
	public MiastaPrzyszlosci()
	{
		InitializeComponent();
	}
    private void OnWaterPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//WaterPage");
    }

    private void OnCurrentPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//CurrentPage");
    }

    private void OnWarmthPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//WarmthPage");
    }


    private void OnLightPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//LightPage");
    }

    private void OnTransportPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//TransportPage");
    }

    private void OnMaterialsPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MaterialsPage");
    }
}