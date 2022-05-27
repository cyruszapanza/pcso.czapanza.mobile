using CommunityToolkit.Mvvm.ComponentModel;

namespace pcso.czapanza.ViewModel;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;
}