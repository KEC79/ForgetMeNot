using CommunityToolkit.Mvvm.ComponentModel;
using ForgetMeNot.Services;
using ForgetMeNotDemo.Model;

namespace ForgetMeNot.ViewModel;

public partial class PreferencesViewModel : ObservableObject
{
    [ObservableProperty]
    private List<Preference>
    preferences;
    private readonly PreferenceService service;
    public PreferencesViewModel()
    {
        service = new();
 }
    public async Task Init()
    {
        Preferences = await service.GetPreferences();
 }
}
