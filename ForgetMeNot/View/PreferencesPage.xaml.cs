using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ForgetMeNot.ViewModel;

namespace ForgetMeNot.View;

public partial class PreferencesPage : ContentPage
{
    private PreferencesViewModel vm = new();
    public PreferencesPage()
    {
        BindingContext = vm;
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await vm.Init();
    }

    public void SavePreferences(object sender, EventArgs e)
    {
        ShowToast();
    }
    private async Task ShowToast()
    {
        var cancellationTokenSource = new
        CancellationTokenSource();
        var message = "Your preferences were saved";
        ToastDuration duration = ToastDuration.Short;
        var fontSize = 14;
        var toast = Toast.Make(message, duration,
        fontSize);
        await toast.Show(cancellationTokenSource.Token);
    }
}