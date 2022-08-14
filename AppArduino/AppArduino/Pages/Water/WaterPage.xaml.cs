namespace AppArduino;

public partial class WaterPage : ContentPage
{
	public WaterPage()
	{
		InitializeComponent();
	}

    

        private void OnTableListPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MiastaPrzyszlosci");
    }

    private void OnLevel1_WaterPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Level_1_WaterPage");
    }

    private void OnLevel2_WaterPage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MiastaPrzyszlosci");
    }

    
}