using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using EIJ.Models;
using Xamarin.Forms;

namespace EIJ.ViewModels
{
  internal class VoicesViewModel : BaseViewModel
  {
    private string _inputName = string.Empty;

    public ObservableCollection<VoiceModel> Voices { get; }

    public ICommand CommandAddPlayer { get; }
    public ICommand CommandPlayerTapped { get; }

    public string InputName
    {
      get => _inputName;
      set => SetValue(ref _inputName, value);
    }

    public VoicesViewModel()
    {
      Title = "Voices";
      CommandAddPlayer = new Command(AddPlayer);
      CommandPlayerTapped = new Command<string>(PlayerTapped);

      Voices = new ObservableCollection<VoiceModel>
      {
        new VoiceModel {PlayerName = "Phillip"},
        new VoiceModel {PlayerName = "Caitlin"},
        new VoiceModel {PlayerName = "Kyra"}
      };

      OnPropertyChanged(nameof(Voices));
    }

    public VoicesViewModel(ObservableCollection<VoiceModel> voices)
    {
      Voices = voices;

      throw new NotImplementedException();
    }

    private void AddPlayer()
    {
      Voices.Add(new VoiceModel {PlayerName = InputName});
      InputName = string.Empty;
    }

    private void PlayerTapped(string o)
    {
      Application.Current.MainPage.DisplayAlert("Alert", "Tapped " + o, "Ok");
      Debug.Print("Tapped!");
    }
  }
}