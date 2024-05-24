using ForgetMeNot.ViewModel;

namespace ForgetMeNot.View;

public partial class AboutPage : ContentPage
{
    private AboutViewModel vm = new();
    public AboutPage()
	{
		BindingContext = vm;
		InitializeComponent();
	}
}