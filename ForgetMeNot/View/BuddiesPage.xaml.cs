using ForgetMeNot.ViewModel;

namespace ForgetMeNot.View;

public partial class BuddiesPage : ContentPage
{
    private BuddiesViewModel vm = new();
    public BuddiesPage()
	{
		BindingContext = vm;
		InitializeComponent();
	}
}