using ForgetMeNot.ViewModel;

namespace ForgetMeNot.View;

public partial class MainPage : ContentPage
{
    private MainViewModel vm = new();
    public MainPage()
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.FullName = "Kim Crowe";
        vm.FavoriteFlower = "flower.png";
    }
}
