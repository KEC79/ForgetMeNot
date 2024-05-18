using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ForgetMeNot.ViewModel;

public partial class MainViewModel : ObservableObject
// : INotifyPropertyChanged
{
    //private string? fullName;
    //public string FullName
    //{
    //    get => fullName;
    //    set
    //    {
    //        fullName = value;
    //        OnPropertyChanged(nameof(FullName));
    //    }
    //}

    //public event PropertyChangedEventHandler? PropertyChanged;

    //protected virtual void OnPropertyChanged(string propertyName)
    //{
    //    var args = new PropertyChangedEventArgs(propertyName);
    //    PropertyChanged?.Invoke(this, args);
    //}

    [ObservableProperty]
    private string? fullName;

    [ObservableProperty]
    private string? favoriteFlower = "flower.png";

    [ObservableProperty]
    private bool flowerIsVisible = true;

    [RelayCommand]
    private void ToggleFlowerVisibility()
    {
        FlowerIsVisible = !FlowerIsVisible;
    }

    [RelayCommand]
    private void ImageTapped()
    {
        FlowerIsVisible = !FlowerIsVisible;
    }
}
