using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace AppArduino.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
    
}

