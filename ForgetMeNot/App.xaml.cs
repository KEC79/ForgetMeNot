using ForgetMeNot.ViewModel;

namespace ForgetMeNot
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
