using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Messaging;
using ForgetMeNot.ViewModel;

namespace ForgetMeNot.View;

public partial class ConstructMessage
{

}
public partial class LoginPage : ContentPage
{
    private LoginViewModel vm = new();
    public LoginPage()
    {
        LoginProgressBar = new ProgressBar();
        InitializeComponent();
        LoginStackLayout.Children.Add(LoginProgressBar);
        BindingContext = vm;
        WeakReferenceMessenger.Default.Register<ConstructMessage>(this, async (r, m) =>
        {
            CancellationTokenSource cancellationTokenSource = new();
            var message = "Your account was created";

            var dismissalText = "Click Here to Close the SnackBar";
            TimeSpan duration = TimeSpan.FromSeconds(10);

            Action action = async () =>
                await DisplayAlert(
                  "Snackbar Dismissed!",
                  "The user has dismissed the snackbar",
                  "OK");

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.Yellow,
                ActionButtonTextColor = Colors.Black,
                CornerRadius = new CornerRadius(20),
                Font = Microsoft.Maui.Font.SystemFontOfSize(14),
                ActionButtonFont = Microsoft.Maui.Font
                  .SystemFontOfSize(14)
            };

            var snackbar = Snackbar.Make(
                message,
                action,
                dismissalText,
                duration,
                snackbarOptions);

            await snackbar.Show(cancellationTokenSource.Token);

            vm.ActivityIndicatorIsRunning = false;
        });
    }

    public static ProgressBar? LoginProgressBar;

    //private async void OnSubmit(object sender, EventArgs e)
    //{
    //    for (double i = 0.0; i < 1.0; i += 0.1)
    //        {
    //            await LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
    //        }
    //    await DisplayAlert(
    //        "Submit",
    //        $"You entered {vm.Name} and {vm.Password}",
    //        "OK");
    //}

    //private async void OnForgotPassword(object sender, EventArgs e)
    //{
    //    CreateAccount.Text = (await DisplayActionSheet(
    //      "How can we solve this?",
    //      "Cancel",
    //      null,
    //      "Get new password",
    //      "Show me my hint",
    //      "Delete account"));
    //}
}